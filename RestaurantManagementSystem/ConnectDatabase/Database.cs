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
            string str = "Data Source=.;Initial Catalog=restaurantData;Persist Security Info=True;User ID=sa;Password=123";
            return str;
        }
    }
}
