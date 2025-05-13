/*using LiveCharts.Wpf;*/
using LiveCharts;
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
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts.Wpf.Charts.Base;

namespace RestaurantManagementSystem
{
    public partial class managerStatisticalUC : UserControl
    {
        class DailyStats
        {
            public DateTime Date { get; set; }
            public decimal Revenue { get; set; }
            public decimal Cost { get; set; }
            public decimal Profit => Revenue - Cost;
        }

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
            string query = @"SELECT SUM(Amount * Price) FROM UsedIngredient";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total cost: " + ex.Message);
                return 0;
            }
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
            ShowChart();
            ShowBestSellers();
        }

        private void managerStatisticalUC_Load(object sender, EventArgs e)
        {

        }
        private List<DailyStats> GetDailyStatistics()
        {
            Dictionary<DateTime, DailyStats> statsMap = new Dictionary<DateTime, DailyStats>();
            string connectionString = db.Connectstring();

            // Doanh thu
            string revenueQuery = @"SELECT CAST(time AS DATE), SUM(totalAmount) 
                            FROM PaymentHistory 
                            GROUP BY CAST(time AS DATE)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(revenueQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = reader.GetDateTime(0).Date;
                    decimal revenue = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    statsMap[date] = new DailyStats { Date = date, Revenue = revenue };
                }
                reader.Close();
            }

            // Chi phí
            string costQuery = @"SELECT CAST(UsedTime AS DATE), SUM(Amount * Price)
                         FROM UsedIngredient
                         GROUP BY CAST(UsedTime AS DATE)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(costQuery, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date = reader.GetDateTime(0).Date;
                    decimal cost = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);

                    if (!statsMap.ContainsKey(date))
                        statsMap[date] = new DailyStats { Date = date };

                    statsMap[date].Cost = cost;
                }
                reader.Close();
            }

            return statsMap.Values.OrderBy(d => d.Date).ToList();
        }
        private void ShowChart()
        {
            var data = GetDailyStatistics();

            chart.Series.Clear();
            chart.Titles.Clear();
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.Title = "Ngày";
            chart.ChartAreas[0].AxisY.Title = "$";

            // Set chart title
            chart.Titles.Add("Thống kê doanh thu, chi phí, lợi nhuận theo ngày");

            // Create series
            var revenueSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Doanh Thu")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                Color = Color.RoyalBlue
            };
            var costSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Chi Phí")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                Color = Color.Goldenrod
            };
            var profitSeries = new System.Windows.Forms.DataVisualization.Charting.Series("Lợi Nhuận")
            {
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column,
                Color = Color.Firebrick
            };

            foreach (var d in data)
            {
                string label = d.Date.ToString("dd/MM");
                revenueSeries.Points.AddXY(label, d.Revenue);
                costSeries.Points.AddXY(label, d.Cost);
                profitSeries.Points.AddXY(label, d.Profit);
            }

            chart.Series.Add(revenueSeries);
            chart.Series.Add(costSeries);
            chart.Series.Add(profitSeries);
        }
        private List<(string name, decimal price)> GetTop3BestSellers()
        {
            string connectionString = db.Connectstring();
            string query = @"
        SELECT TOP 3 d.Name, d.Price
        FROM DishSold ds
        JOIN Dish d ON ds.DishID = d.Id
        ORDER BY ds.TotalQuantity DESC";

            List<(string name, decimal price)> result = new List<(string, decimal)>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString(0);
                    decimal price = reader.GetDecimal(1);
                    result.Add((name, price));
                }
            }
            return result;
        }
        private void ShowBestSellers()
        {
            var topDishes = GetTop3BestSellers();
            bestSellerPanel.Controls.Clear();

            foreach (var item in topDishes)
            {
                bestSellerUC dishUC = new bestSellerUC();  // giả sử bạn có UserControl này
                dishUC.SetData(item.name, item.price);     // bạn cần có hàm public void SetData(string name, decimal price)
                bestSellerPanel.Controls.Add(dishUC);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
