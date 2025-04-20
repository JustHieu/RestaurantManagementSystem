using LiveCharts.Wpf;
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


    }
}
