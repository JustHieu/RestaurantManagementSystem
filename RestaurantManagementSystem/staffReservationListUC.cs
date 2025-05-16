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
    public partial class staffReservationListUC : UserControl
    {
        Database db = new Database();
        public staffReservationListUC()
        {
            InitializeComponent();
            LoadPanel();
        }
        private void LoadPanel()
        {
            string connectionString = db.Connectstring();
            string query = @"
                            SELECT idTable, name, phone, time, personNumber, status
                            FROM Tables
                            WHERE name IS NOT NULL"; 

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    showPanel.Controls.Clear(); 

                    while (reader.Read())
                    {
                        int idTable = Convert.ToInt32(reader["idTable"]);
                        string name = reader["name"].ToString();
                        string phone = reader["phone"].ToString();
                        DateTime time = Convert.ToDateTime(reader["time"]);
                        int personNumber = Convert.ToInt32(reader["personNumber"]);
                        string status = reader["status"].ToString();

                        staffItemReservationUC uc = new staffItemReservationUC();
                        uc.SetData(idTable, name, phone, personNumber, time);

                        uc.ReservationCancelled += (s, e) =>
                        {
                            LoadPanel(); 
                        };

                        showPanel.Controls.Add(uc);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelReservationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
