using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace Test
{
    class Modify
    {
        public Modify()
        {
        }
        
        SqlDataAdapter dataAdapter;

        public SqlCommand SqlCommand { get; private set; }

        public DataTable getAllDatHang()
        {
            DataTable dataTable = new DataTable();
            string query = "select * from DatHang";
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                SqlCommand = new SqlCommand(query, sqlConnection);
                SqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }
    }
}
