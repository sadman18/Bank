using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Bank
{
    internal class Database
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=bank;";
        MySqlConnection connection;
        MySqlCommand command;
        public void OpenConnection()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        

        public MySqlDataReader SelectQuery(string query)
        {
            OpenConnection();
            command = new MySqlCommand(query, connection);
            return command.ExecuteReader();
        }

    }
}
