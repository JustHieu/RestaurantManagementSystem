using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RestaurantManagementSystem.Class;
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantManagementSystem
{
    public partial class managerStatisticalUC : UserControl
    {
        Database db = new Database();
        public managerStatisticalUC()
        {
            InitializeComponent();
            LoadData();
        }

        private string GetTotalOrder()
        {
            string connectionString = db.Connectstring();
            string query = "SELECT COUNT(*) FROM PaymentHistory"; // Câu lệnh SQL để đếm số bản ghi

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalOrders = (int)cmd.ExecuteScalar();  
                    return totalOrders.ToString();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total orders: " + ex.Message);
                return "0";  
            }

        }
        private decimal GetCost()
        {
            string connectionString = db.Connectstring();
            string query = @"
                SELECT SUM(Amount * Price) 
                FROM UsedIngredient
                GROUP BY Name";  // Nhóm theo Name

            decimal totalCost = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Thực thi câu lệnh SQL để tính tổng chi phí theo Name
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Lặp qua các kết quả và tính tổng chi phí
                    while (reader.Read())
                    {
                        totalCost += reader.IsDBNull(0) ? 0 : reader.GetDecimal(0); // Cộng dồn tổng chi phí
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total cost: " + ex.Message);
            }

            return totalCost;  // Trả về tổng chi phí
        }
        private decimal GetProfit()
        {
            string connectionString = db.Connectstring();
            string query = @"
                SELECT SUM(totalAmount) 
                FROM PaymentHistory";

            decimal totalCost = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Thực thi câu lệnh SQL để tính tổng chi phí theo Name
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Lặp qua các kết quả và tính tổng chi phí
                    while (reader.Read())
                    {
                        totalCost += reader.IsDBNull(0) ? 0 : reader.GetDecimal(0); // Cộng dồn tổng chi phí
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total cost: " + ex.Message);
            }

            return totalCost;  
        }
        private string GetTotalEmployee()
        {
            string connectionString = db.Connectstring();
            string query = "SELECT COUNT(*) FROM Employee"; // Câu lệnh SQL để đếm số bản ghi

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    SqlCommand cmd = new SqlCommand(query, conn);
                    int totalEmployee = (int)cmd.ExecuteScalar();
                    return totalEmployee.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting total employee: " + ex.Message);
                return "0";
            }

        }
        private void LoadData()
        {
            totalOderLabel.Text = GetTotalOrder();
            employeeLabel.Text = GetTotalEmployee();
            costLabel.Text ="$ "+ GetCost().ToString();
            profitLabel.Text ="$ "+ GetProfit().ToString();

        }
        private void LoadTop5BestSellingDishes()
        {
            string connectionString = db.Connectstring();
            string query = @"
        SELECT TOP 5 DishName, COUNT(*) AS OrderCount
        FROM UsedIngredient
        GROUP BY DishName
        ORDER BY OrderCount DESC;
    ";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    showTopFlowPanel.Controls.Clear(); 
                    while (reader.Read())
                    {
                        string dishName = reader["DishName"].ToString();

                        managerStatisticalBestSellerUC item = new managerStatisticalBestSellerUC();
                        item.SetDishName(dishName);
                        showTopFlowPanel.Controls.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải món ăn bán chạy nhất: " + ex.Message);
            }
        }

        private void managerStatisticalUC_Load(object sender, EventArgs e)
        {
            LoadTop5BestSellingDishes();
            DrawChart();

        }
        private List<FinancialReport> LoadFinancialReports()
        {
            var reports = new List<FinancialReport>();
            var costDict = new Dictionary<DateTime, decimal>();
            var profitDict = new Dictionary<DateTime, decimal>();

            string connStr = db.Connectstring();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Load Cost (from UsedIngredient)
                string costQuery = @"
                    SELECT CAST(UsedTime AS DATE) AS [Date], SUM(Amount * Price) AS TotalCost
                    FROM UsedIngredient
                    GROUP BY CAST(UsedTime AS DATE)";

                using (SqlCommand cmd = new SqlCommand(costQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        decimal cost = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                        costDict[date] = cost;
                    }
                }

                // Load Profit (from PaymentHistory)
                string profitQuery = @"
                    SELECT CAST(Time AS DATE) AS [Date], SUM(totalAmount) AS TotalProfit
                    FROM PaymentHistory
                    GROUP BY CAST(Time AS DATE)";

                using (SqlCommand cmd = new SqlCommand(profitQuery, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        decimal profit = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                        profitDict[date] = profit;
                    }
                }
            }

            var allDates = costDict.Keys.Union(profitDict.Keys).Distinct().OrderBy(d => d);
            foreach (var date in allDates)
            {
                decimal profit = profitDict.ContainsKey(date) ? profitDict[date] : 0;
                decimal cost = costDict.ContainsKey(date) ? costDict[date] : 0;

                reports.Add(new FinancialReport
                {
                    Date = date,
                    Profit = profit,
                    Capitalization = profit - cost
                });
            }

            return reports;
        }

        private void DrawChart()
        {
            var reports = LoadFinancialReports();

            // Xóa sạch dữ liệu cũ
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.Titles.Clear();

            // Tạo ChartArea
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Ngày";
            chartArea.AxisY.Title = "Giá trị ($)";
            chartArea.AxisX.Interval = 1; // Hiện đầy đủ label

            chart1.ChartAreas.Add(chartArea);

            // Tạo Series cho Vốn hóa
            Series capitalizationSeries = new Series("Vốn hóa");
            capitalizationSeries.ChartType = SeriesChartType.Line;
            capitalizationSeries.BorderWidth = 3;
            capitalizationSeries.Color = Color.Blue;

            // Tạo Series cho Lợi nhuận
            Series profitSeries = new Series("Lợi nhuận");
            profitSeries.ChartType = SeriesChartType.Line;
            profitSeries.BorderWidth = 3;
            profitSeries.Color = Color.Green;

            foreach (var report in reports)
            {
                string dateLabel = report.Date.ToString("dd/MM");
                capitalizationSeries.Points.AddXY(dateLabel, report.Capitalization);
                profitSeries.Points.AddXY(dateLabel, report.Profit);
            }

            // Add vào chart
            chart1.Series.Add(capitalizationSeries);
            chart1.Series.Add(profitSeries);

            // Thêm tiêu đề
            chart1.Titles.Add("Biểu đồ Lợi nhuận và Vốn hóa theo ngày");

            // Hiện chú thích
            chart1.Legends[0].Enabled = true;
        }
    }
}