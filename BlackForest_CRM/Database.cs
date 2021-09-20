using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace BlackForest_CRM
{
    class Database
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; port=3306; user=root; password=root; database=crm_blackforest");

        public void open_connection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void close_connection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection get_connection()
        {
            return connection;
        }
    }
}
