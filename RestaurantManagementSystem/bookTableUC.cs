using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace RestaurantManagementSystem
{
    public partial class bookTableUC : UserControl
    {
        public bookTableUC()
        {
            InitializeComponent();
            comboBoxPersonNumber.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPersonNumber.SelectedIndex = 0;
        }
        private int GetRandomAvailableTable()
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            string query = "SELECT idTable FROM Tables WHERE status = 'Empty'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    List<int> availableTables = new List<int>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableTables.Add(reader.GetInt32(0));
                        }
                    }

                    if (availableTables.Count == 0)
                    {
                        return -1;  // Không có bàn trống
                    }

                    Random rand = new Random();
                    int randomIndex = rand.Next(availableTables.Count);
                    return availableTables[randomIndex];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy bàn trống: " + ex.Message);
                return -1;
            }
        }

        //
        private Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);
        private Regex phoneRegex = new Regex(@"^\d+$", RegexOptions.Compiled);
        private string GenerateKey()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();  // Random từ 100000 đến 999999
        }
        private bool IsTableAvailable(int tableId, DateTime selectedTime)
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MAX(time) FROM BookingKey WHERE idTable = @TableID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TableID", tableId);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        DateTime lastBookingTime = (DateTime)result;
                        DateTime nextAvailableTime = lastBookingTime.AddHours(2);

                        if (selectedTime < nextAvailableTime)
                        {
                            MessageBox.Show("Bàn đã được đặt trước đó. Bạn chỉ có thể đặt sau: " + nextAvailableTime.ToString("HH:mm dd/MM/yyyy"));
                            return false;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kiểm tra bàn: " + ex.Message);
                return false;
            }
        }


        private void bookTableButton_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            int personNumber = int.Parse(comboBoxPersonNumber.SelectedItem.ToString());

            DateTime selectedDate = datePicker.Value.Date;
            DateTime selectedTime = timePicker.Value;
            DateTime reservationTime = selectedDate.Add(selectedTime.TimeOfDay);

            bool isValid = true;

            // Kiểm tra Name
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider1.SetError(txtName, "The field is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }

            // Kiểm tra Phone
            if (string.IsNullOrWhiteSpace(phone) || !phoneRegex.IsMatch(phone))
            {
                errorProvider1.SetError(txtPhone, "The telephone number is invalid.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }

            // Kiểm tra nếu ngày chọn nhỏ hơn ngày hôm nay
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("You cannot book a table for a past date. Please select a future date.");
                return;
            }

            if (!isValid)
            {
                finalyLabel.Text = "Please fill in all required fields correctly.";
                finalyLabel.ForeColor = Color.Red;
                finalyLabel.Visible = true;
                return;
            }

            int tableId = GetRandomAvailableTable();
            if (tableId == -1)
            {
                MessageBox.Show("Sorry, no available tables at the moment.");
                return;
            }

            // Kiểm tra nếu bàn đã được đặt trong khung giờ gần đó (tránh đè)
            if (!IsTableAvailable(tableId, reservationTime))
            {
                return;
            }

            string key = GenerateKey();
            Database db = new Database();
            string connectionString = db.Connectstring();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Cập nhật thông tin bàn
                    string updateQuery = "UPDATE Tables SET name = @Name, phone = @Phone, time = @ReservationTime, " +
                                         "personNumber = @PersonNumber, status = 'Full' WHERE idTable = @TableID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Name", name);
                    updateCmd.Parameters.AddWithValue("@Phone", phone);
                    updateCmd.Parameters.AddWithValue("@ReservationTime", reservationTime);
                    updateCmd.Parameters.AddWithValue("@PersonNumber", personNumber);
                    updateCmd.Parameters.AddWithValue("@TableID", tableId);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        string keyQuery = "INSERT INTO BookingKey (idTable, accessKey, time, phone) VALUES (@TableID, @AccessKey, @Time, @Phone)";
                        SqlCommand keyCmd = new SqlCommand(keyQuery, conn);
                        keyCmd.Parameters.AddWithValue("@TableID", tableId);
                        keyCmd.Parameters.AddWithValue("@AccessKey", key);
                        keyCmd.Parameters.AddWithValue("@Time", reservationTime);
                        keyCmd.Parameters.AddWithValue("@Phone", phone);
                        keyCmd.ExecuteNonQuery();

                        MessageBox.Show($"Booking successful!\nTable: {tableId}\nAccess Key: {key}");
                    }
                    else
                    {
                        MessageBox.Show("Booking failed.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during booking: " + ex.Message);
            }
        }

        private void bookTableUC_Load(object sender, EventArgs e)
        {

        }
    }
}
