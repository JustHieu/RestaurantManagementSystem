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
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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

        private string connectionString = "Data Source=LAPTOP-HCL43H54;Initial Catalog=RestaurantDB;Persist Security Info=True;User ID=sa;Password=quan1772005";

        private void LoadTables()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    String query = "SELECT TableID, State FROM Tables";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    tableFlowLayoutPanel.Controls.Clear();
                    while (reader.Read())
                    {
                        int tableID = Convert.ToInt32(reader["TableID"]);
                        bool state = Convert.ToBoolean(reader["State"]);
                        tableUC item = new tableUC();
                        item.SetData(new Table { IdTable = tableID, StateTable = state });

                        item.OnTableClicked += TableControl_OnTableClicked;

                        tableFlowLayoutPanel.Controls.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void TableControl_OnTableClicked(object sender, int tableID)
        {
            tableLabel.Text = "TABLE " + tableID;
        }
    }
}
