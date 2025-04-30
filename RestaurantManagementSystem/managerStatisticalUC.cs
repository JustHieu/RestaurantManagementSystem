
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



namespace RestaurantManagementSystem
{
    public partial class managerStatisticalUC : UserControl
    {
        Database db = new Database();
        public managerStatisticalUC()
        {
            InitializeComponent();
            LoadData();
            LoadRevenueChart();
        }

        private void LoadRevenueChart()
        {
            // 1. Truy vấn dữ liệu theo ngày
            string query = @"
        SELECT 
            CAST(time AS DATE) AS Ngay,
            SUM(totalAmount) AS DoanhThu,
            SUM(ingredientCost) AS ChiPhi,
            SUM(totalAmount) - SUM(ingredientCost) AS LoiNhuan
        FROM PaymentHistory
        GROUP BY CAST(time AS DATE)
        ORDER BY Ngay
    ";

            DataTable dt = new DataTable();
            string connectionString = db.Connectstring(); // Sửa thành chuỗi kết nối của bạn nếu cần

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(dt);
            }

            // 2. Dọn sạch chart
            statisticalChart.Series.Clear();
            statisticalChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM"; // Định dạng ngày
            statisticalChart.ChartAreas[0].AxisX.Title = "Ngày";
            statisticalChart.ChartAreas[0].AxisY.Title = "$";

            // 3. Tạo series cho từng loại
            Series sDoanhThu = new Series("Doanh Thu") { ChartType = SeriesChartType.Column };
            Series sChiPhi = new Series("Chi Phí") { ChartType = SeriesChartType.Column };
            Series sLoiNhuan = new Series("Lợi Nhuận") { ChartType = SeriesChartType.Column };

            foreach (DataRow row in dt.Rows)
            {
                DateTime ngay = Convert.ToDateTime(row["Ngay"]);
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);
                double chiPhi = Convert.ToDouble(row["ChiPhi"]);
                double loiNhuan = Convert.ToDouble(row["LoiNhuan"]);

                sDoanhThu.Points.AddXY(ngay, doanhThu);
                sChiPhi.Points.AddXY(ngay, chiPhi);
                sLoiNhuan.Points.AddXY(ngay, loiNhuan);
            }

            // 4. Thêm series vào chart
            statisticalChart.Series.Add(sDoanhThu);
            statisticalChart.Series.Add(sChiPhi);
            statisticalChart.Series.Add(sLoiNhuan);

            // 5. Đặt tiêu đề, legend
            statisticalChart.Titles.Clear();
            statisticalChart.Titles.Add("Thống kê doanh thu, chi phí, lợi nhuận theo ngày");
            statisticalChart.Legends[0].Docking = Docking.Top;
        }
        private void LoadBestSeller()
        {
            Database db = new Database();
            string connectionString = db.Connectstring();

            string query = @"SELECT TOP 3 D.Name, D.Price, DS.TotalQuantity AS TotalSold
                            FROM DishSold DS
                            JOIN Dish D ON DS.DishID = D.Id
                            ORDER BY DS.TotalQuantity DESC;
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
                        string name = reader.GetString(0);
                        decimal price = reader.GetDecimal(1);

                        bestSellerUC item = new bestSellerUC();
                        item.DishName = name;
                        item.DishPrice = $"{price}$";

                        item.Dock = DockStyle.Top;
                        showTopFlowPanel.Controls.Add(item);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải món bán chạy: " + ex.Message);
            }
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
            string query = @"SELECT SUM(Quantity * Price) FROM UsedIngredient";

            decimal totalCost = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalCost = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total cost: " + ex.Message);
            }

            return totalCost/1000;
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

        private void managerStatisticalUC_Load(object sender, EventArgs e)
        {
            LoadBestSeller();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
