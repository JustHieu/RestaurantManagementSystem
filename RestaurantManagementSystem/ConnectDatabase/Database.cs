using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    internal class Database
    {
        
        public Database()
        {
        }
        public string Connectstring()
        {
            string str = "Data Source=LAPTOP-HCL43H54;Initial Catalog=RestaurantData;Persist Security Info=True;User ID=sa;Password=123";
            return str;
        }
    }
}
