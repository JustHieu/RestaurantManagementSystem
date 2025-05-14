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
    public partial class managerUsedIngredient : UserControl
    {
        Database db = new Database();
        public managerUsedIngredient()
        {
            InitializeComponent();
            LoadUsedIngredientsToPanel();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadUsedIngredientsToPanel()
        {
            string connectionString = db.Connectstring();
            string query = @"
                            SELECT Name AS IngredientName, SUM(Quantity) AS TotalQuantity, MAX(UsedTime) AS UsedTime
                            FROM UsedIngredient
                            GROUP BY Name";

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
                        string name = reader["IngredientName"].ToString();
                        decimal totalQuantity = Convert.ToDecimal(reader["TotalQuantity"]);
                        DateTime usedTime = Convert.ToDateTime(reader["UsedTime"]);

                        usedIngredientUC uc = new usedIngredientUC();
                        uc.SetData(name, totalQuantity, usedTime);  
                        showPanel.Controls.Add(uc);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading used ingredients: " + ex.Message);
            }
        }

    }
}
