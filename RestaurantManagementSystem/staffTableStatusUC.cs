using Guna.UI2.WinForms.Enums;
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
        
        Database db= new Database();
        public staffTableStatusUC()
        {
            InitializeComponent();
            LoadTables();
           
        }
        private int GetBookingIdByTable(int tableId)
        {
            string connectionString = db.Connectstring();
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
                string status = row["status"].ToString(); // LẤY TRẠNG THÁI
                tableUC tableItem = new tableUC();
                tableItem.SetTableID(id);
                tableItem.SetStatus(status == "Full"); // true = bàn có người

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
            string connectionString = db.Connectstring();
            string query = "SELECT idTable, status FROM Tables";  // THÊM 'status'

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
            string connectionString = db.Connectstring();
            string query = @"
        SELECT 
            d.Id AS dishID,
            d.Name,
            SUM(td.quantity) AS quantity,
            SUM(td.price) AS price
        FROM TableDetail td
        JOIN Dish d ON td.dishID = d.Id
        WHERE td.idBooking = @idBooking
        GROUP BY d.Id, d.Name";

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
            int idBooking = GetBookingIdByTable(tableId);
            if (idBooking == -1) return;

            decimal totalAmount = GetTotalAmount(idBooking);

            totalLabel.Text = totalAmount.ToString("C");
        }
        private decimal GetTotalAmount(int idBooking)
        {
            DataTable orderData = GetOrderList(idBooking);  // Đã gộp theo món ăn
            if (orderData == null) return 0;

            decimal totalAmount = 0;

            foreach (DataRow row in orderData.Rows)
            {
                string name = row["Name"].ToString();
                int quantity = Convert.ToInt32(row["quantity"]);
                decimal totalPrice = Convert.ToDecimal(row["price"]);

                decimal unitPrice = totalPrice / quantity;

                showTableDetailUC detailItem = new showTableDetailUC();
                int dishID = Convert.ToInt32(row["dishID"]);
                detailItem.SetData(name, quantity, unitPrice, dishID); // Gán đơn giá lại để hiển thị đúng
                detailPanel.Controls.Add(detailItem);

                totalAmount += totalPrice;
            }

            return totalAmount;
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
            string connectionString = db.Connectstring();
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
                    string updateTableQuery = "UPDATE Tables SET name = NULL, phone = NULL, time = NULL, personNumber = 0, price = 0, status = 'Empty' WHERE idTable = @idTable";
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
                int idBooking = GetBookingIdByTable(selectedTableId);
                decimal totalAmount = GetTotalAmount(idBooking);
                DateTime? dt = GetBookingTimeByTable(selectedTableId);
                
                AddPaymentToThanhToan(idBooking,selectedTableId, totalAmount, dt);
                AddToUsedIngredient(selectedTableId);
                ClearTableData(selectedTableId);
                LoadTables();  // Tải lại danh sách bàn
                detailPanel.Controls.Clear();  // Xóa hiển thị chi tiết
                totalLabel.Text = "0 VND";  // Đặt lại tổng tiền
            }
        }

        private void AddPaymentToThanhToan(int idBooking, int idTable, decimal totalAmount, DateTime? bookingTime)
        {
            string connectionString = db.Connectstring();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ✅ Tính chi phí nguyên liệu từ bảng UsedIngredient
                    string costQuery = "SELECT SUM(Quantity * Price) FROM UsedIngredient WHERE idTable = @idTable";
                    SqlCommand costCmd = new SqlCommand(costQuery, conn);
                    costCmd.Parameters.AddWithValue("@idTable", idTable);
                    object result = costCmd.ExecuteScalar();
                    decimal ingredientCost = (result != DBNull.Value && result != null) ? Convert.ToDecimal(result) : 0;

                    // ✅ Lưu vào PaymentHistory bao gồm ingredientCost
                    string query = @"INSERT INTO PaymentHistory 
                             (idBooking, idTable, totalAmount, bookingTime, ingredientCost)
                             VALUES (@idBooking, @idTable, @totalAmount, @bookingTime, @ingredientCost)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idBooking", idBooking);
                    cmd.Parameters.AddWithValue("@idTable", idTable);
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@bookingTime", bookingTime);
                    cmd.Parameters.AddWithValue("@ingredientCost", ingredientCost);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu thanh toán: " + ex.Message);
            }
        }



        private DateTime? GetBookingTimeByTable(int idTable)
        {
            string connectionString = db.Connectstring();
            string query = "SELECT time FROM BookingKey WHERE idTable = @idTable";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idTable", idTable);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToDateTime(result);  // Trả về thời gian đặt (DateTime)
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thời gian đặt cho mã bàn này.");
                        return null;  // Nếu không có kết quả, trả về null
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn thời gian đặt: " + ex.Message);
                return null;  // Nếu có lỗi, trả về null
            }
        }

        private void AddToUsedIngredient(int idTable)
        {
            string connectionString = db.Connectstring();
            string selectQuery = @"
        SELECT 
            d.Name AS DishName,
            i.Name AS IngredientName,
            (dia.QuantityRequired * td.quantity) AS TotalQuantityRequired,
            i.Price AS IngredientPrice,
            td.quantity AS TableQuantity -- Số lượng món ăn từ TableDetail
         FROM 
            Tables t
            JOIN BookingKey bk ON t.idTable = bk.idTable
            JOIN TableDetail td ON bk.idBooking = td.idBooking
            JOIN Dish d ON td.dishID = d.Id
            JOIN DishIngredientAssignment dia ON d.Id = dia.DishID
            JOIN Ingredient i ON dia.IngredientID = i.Id
        WHERE 
            t.idTable = @idTable";

                string insertQuery = @"
        INSERT INTO UsedIngredient (idTable, DishName, Name, Quantity, Price, Amount)
        VALUES (@idTable, @DishName, @Name, @Quantity, @Price, @Amount)";  // Thêm Amount vào câu lệnh

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Fetch ingredients used for the table
                    SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                    selectCmd.Parameters.AddWithValue("@idTable", idTable);
                    SqlDataAdapter adapter = new SqlDataAdapter(selectCmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Insert each ingredient into UsedIngredient table
                    foreach (DataRow row in dt.Rows)
                    {
                        string dishName = row["DishName"].ToString();
                        string ingredientName = row["IngredientName"].ToString();
                        decimal quantity = Convert.ToDecimal(row["TotalQuantityRequired"]);
                        decimal price = Convert.ToDecimal(row["IngredientPrice"]);
                        int tableQuantity = Convert.ToInt32(row["TableQuantity"]);  // Lấy số lượng món ăn từ TableDetail

                        // Chỉ sử dụng td.quantity (tableQuantity) cho Amount
                        int amount = tableQuantity;  // Amount chỉ bằng số lượng món ăn (kiểu int)

                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@idTable", idTable);
                            insertCmd.Parameters.AddWithValue("@DishName", dishName);
                            insertCmd.Parameters.AddWithValue("@Name", ingredientName);
                            insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                            insertCmd.Parameters.AddWithValue("@Price", price);
                            insertCmd.Parameters.AddWithValue("@Amount", amount);  
                            insertCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding ingredients to UsedIngredient: " + ex.Message);
            }
        }


    }

}
