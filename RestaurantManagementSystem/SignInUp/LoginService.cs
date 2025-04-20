using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem.SignInUp
{
    internal class LoginService
    {
        
        public static string GetUserRole(string username, string password)
        {
            Database db = new Database();
            string connectionString = db.Connectstring();
            string query = "SELECT Role FROM Account WHERE Username = @Username AND Password = @Password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); 

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();  
                }
                else
                {
                    return null;  
                }
            }
        }
    }
}
