using Guna.UI2.WinForms.Suite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml.Linq;


namespace RestaurantManagementSystem
{
    public partial class staffTableStatusUC : UserControl
    {
        

        public staffTableStatusUC()
        {
            InitializeComponent();
            LoadTables();
           
        }
        private int GetBookingIdByTable(int tableId)
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT TOP 1 idBooking FROM BookingKey WHERE idTable = @idTable ORDER BY time DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idTable", tableId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy mã đặt chỗ cho bàn này.");
                        return -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy idBooking từ idTable: " + ex.Message);
                return -1;
            }
        }

        private void LoadTables()
        {
            DataTable tableData = GetTablesData();
            if (tableData == null) return;

            foreach (DataRow row in tableData.Rows)
            {
                int id = Convert.ToInt32(row["idTable"]);
                tableUC tableItem = new tableUC();
                tableItem.SetTableID(id);

                // Sự kiện khi chọn bàn
                tableItem.OnTableSelected += (s, e) =>
                {
                    foreach (tableUC item in tablePanel.Controls)
                    {
                        item.SetSelected(false);  // Hủy chọn tất cả bàn
                    }
                    tableItem.SetSelected(true);  // Đặt bàn hiện tại là đã chọn
                    LoadTableDetails(id);  // Hiển thị chi tiết bàn
                };
                tablePanel.Controls.Add(tableItem);
            }
        }

        // Hàm lấy danh sách bàn từ cơ sở dữ liệu
        private DataTable GetTablesData()
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT idTable FROM Tables";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tables: " + ex.Message);
                return null;
            }
        }
        private DataTable GetOrderList(int idBooking)
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            string query = "SELECT d.Name, td.quantity, td.price " +
                           "FROM TableDetail td " +
                           "JOIN Dish d ON td.dishID = d.Id " +
                           "WHERE td.idBooking = @idBooking";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order list: " + ex.Message);
                return null;
            }
        }


        // Hàm hiển thị chi tiết món ăn trong FlowLayoutPanel
        private void LoadTableDetails(int tableId)
        {
            detailPanel.Controls.Clear();

            // Lấy đúng idBooking từ idTable
            int idBooking = GetBookingIdByTable(tableId);
            if (idBooking == -1) return;

            DataTable orderData = GetOrderList(idBooking);  // Lấy danh sách món ăn theo idBooking
            if (orderData == null) return;

            decimal totalAmount = 0;

            foreach (DataRow row in orderData.Rows)
            {
                string name = row["Name"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                decimal price = Convert.ToDecimal(row["price"]);

                showTableDetailUC detailItem = new showTableDetailUC();
                detailItem.SetData(name, quantity, price);
                detailPanel.Controls.Add(detailItem);

                totalAmount += price * quantity;
            }

            totalLabel.Text = totalAmount.ToString("C");
        }
        private int GetSelectedTableId()
        {
            if (tablePanel.Controls.Count > 0)
            {
                foreach (tableUC tableItem in tablePanel.Controls)
                {
                    if (tableItem.IsSelected)
                    {
                        return tableItem.TableID;
                    }
                }
            }
            return -1;
        }

        private void ClearTableData(int tableId)
        {
            string connectionString = "Data Source=.;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Lấy idBooking từ idTable
                    int idBooking = GetBookingIdByTable(tableId);
                    if (idBooking == -1) return;

                    // Xóa dữ liệu trong bảng TableDetail liên quan đến idBooking
                    string deleteDetailQuery = "DELETE FROM TableDetail WHERE idBooking = @idBooking";
                    using (SqlCommand deleteDetailCmd = new SqlCommand(deleteDetailQuery, conn))
                    {
                        deleteDetailCmd.Parameters.AddWithValue("@idBooking", idBooking);
                        deleteDetailCmd.ExecuteNonQuery();
                    }

                    // Xóa dữ liệu trong bảng BookingKey liên quan đến idBooking
                    string deleteBookingQuery = "DELETE FROM BookingKey WHERE idBooking = @idBooking";
                    using (SqlCommand deleteBookingCmd = new SqlCommand(deleteBookingQuery, conn))
                    {
                        deleteBookingCmd.Parameters.AddWithValue("@idBooking", idBooking);
                        deleteBookingCmd.ExecuteNonQuery();
                    }

                    // Cập nhật trạng thái bàn về "Trống"
                    string updateTableQuery = "UPDATE Tables SET name = NULL, phone = NULL, time = NULL, personNumber = 0, price = 0, status = 'Trống' WHERE idTable = @idTable";
                    using (SqlCommand updateTableCmd = new SqlCommand(updateTableQuery, conn))
                    {
                        updateTableCmd.Parameters.AddWithValue("@idTable", tableId);
                        updateTableCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thanh toán thành công! Bàn đã được dọn dẹp và sẵn sàng phục vụ khách mới.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thanh toán: " + ex.Message);
            }
        }





        private void TableControl_OnTableClicked(object sender, int tableID)
        {
            
        }

        private void staffTableStatusUC_Load(object sender, EventArgs e)
        {

        }

        private void tableUC1_Load(object sender, EventArgs e)
        {

        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // Lấy ID bàn đang chọn
            int selectedTableId = GetSelectedTableId();
            if (selectedTableId == -1)
            {
                MessageBox.Show("Vui lòng chọn bàn để thanh toán.");
                return;
            }

            // Xác nhận thanh toán
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán bàn này?", "Xác nhận thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ClearTableData(selectedTableId);
                LoadTables();  // Tải lại danh sách bàn
                detailPanel.Controls.Clear();  // Xóa hiển thị chi tiết
                totalLabel.Text = "0 VND";  // Đặt lại tổng tiền
            }
        }
    }

}
