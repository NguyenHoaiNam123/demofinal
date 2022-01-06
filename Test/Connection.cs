using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Test
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-S9FKVPS\SQLEXPRESS;Initial Catalog=User;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
