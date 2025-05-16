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
    public partial class staffItemReservationUC : UserControl
    {
        Database db = new Database();
        private int _idTable; 

        public event EventHandler ReservationCancelled;

        public staffItemReservationUC()
        {
            InitializeComponent();
        }
        public void SetData(int idTable, string name, string phone, int personNumber, DateTime usedTime)
        {
            _idTable = idTable;

            idTableLabel.Text = idTable.ToString();
            nameLabel.Text = name;
            phoneLabel.Text = phone;
            personNumberLabel.Text = personNumber.ToString();
            timeLabel.Text = usedTime.ToString("dd/MM/yyyy");
        }

        private void cancelReservationButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this reservation?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string connectionString = db.Connectstring();
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                string getBookingIdQuery = "SELECT TOP 1 idBooking FROM BookingKey WHERE idTable = @id";
                                SqlCommand getBookingIdCmd = new SqlCommand(getBookingIdQuery, conn, transaction);
                                getBookingIdCmd.Parameters.AddWithValue("@id", _idTable);
                                object bookingIdObj = getBookingIdCmd.ExecuteScalar();
                                int idBooking = (bookingIdObj != null) ? Convert.ToInt32(bookingIdObj) : -1;

                                if (idBooking != -1)
                                {
                                    string deleteDetailQuery = "DELETE FROM TableDetail WHERE idBooking = @idBooking";
                                    SqlCommand deleteDetailCmd = new SqlCommand(deleteDetailQuery, conn, transaction);
                                    deleteDetailCmd.Parameters.AddWithValue("@idBooking", idBooking);
                                    deleteDetailCmd.ExecuteNonQuery();

                                    string deleteBookingQuery = "DELETE FROM BookingKey WHERE idBooking = @idBooking";
                                    SqlCommand deleteBookingCmd = new SqlCommand(deleteBookingQuery, conn, transaction);
                                    deleteBookingCmd.Parameters.AddWithValue("@idBooking", idBooking);
                                    deleteBookingCmd.ExecuteNonQuery();
                                }

                                string updateQuery = @"
                                                    UPDATE Tables
                                                    SET name = NULL,
                                                        phone = NULL,
                                                        time = NULL,
                                                        personNumber = NULL,
                                                        price = 0,
                                                        status = 'Empty'
                                                    WHERE idTable = @id";
                                SqlCommand updateCmd = new SqlCommand(updateQuery, conn, transaction);
                                updateCmd.Parameters.AddWithValue("@id", _idTable);
                                int rowsAffected = updateCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Reservation cancelled.");
                                    ReservationCancelled?.Invoke(this, EventArgs.Empty); 
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Failed to cancel reservation.");
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show("Error during cancellation: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
