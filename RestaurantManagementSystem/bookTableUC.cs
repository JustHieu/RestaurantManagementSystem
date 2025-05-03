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
            bool isValid = true;

            // Kiểm tra Name
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "The field is required.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }

            // Kiểm tra Phone
            if (string.IsNullOrWhiteSpace(txtPhone.Text) || !phoneRegex.IsMatch(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "The telephone number is invalid.");
                isValid = false;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }

            if (!isValid)
            {
                finalyLabel.Text = "Please fill in all required fields correctly.";
                finalyLabel.ForeColor = Color.Red;
                finalyLabel.Visible = true;
                return;
            }

            string name = txtName.Text;
            string phone = txtPhone.Text;
            int personNumber = int.Parse(comboBoxPersonNumber.SelectedItem.ToString());

            DateTime selectedDate = datePicker.Value.Date;
            DateTime selectedTime = timePicker.Value;
            DateTime reservationTime = selectedDate.Add(selectedTime.TimeOfDay);
            if (reservationTime < DateTime.Now)
            {
                MessageBox.Show("You cannot book a table in the past. Please select a valid date and time.",
                                "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int tableId = GetRandomAvailableTable();
            if (tableId == -1)
            {
                MessageBox.Show("Sorry, no available tables at the moment.");
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

                    // Cập nhật trạng thái bàn và thông tin người đặt
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
                        string insertKey = @"
                        INSERT INTO BookingKey (idTable, accessKey, time, phone) 
                        VALUES (@TableID, @AccessKey, @Time, @Phone)";
                        SqlCommand insertCmd = new SqlCommand(insertKey, conn);
                        insertCmd.Parameters.AddWithValue("@TableID", tableId);
                        insertCmd.Parameters.AddWithValue("@AccessKey", key);
                        insertCmd.Parameters.AddWithValue("@Time", reservationTime);
                        insertCmd.Parameters.AddWithValue("@Phone", phone);
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show($"Your Access Key: {key}",
                                        "Reservation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        keyAccessFrom keyFrm = new keyAccessFrom();
                        keyFrm.keyLabel.Text = key;
                        keyFrm.IsVisible(false);
                        keyFrm.Show();
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
