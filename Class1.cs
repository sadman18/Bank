using Microsoft.VisualBasic.ApplicationServices;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Bank
{
    internal class Class1
    {
        Database database = new Database();
        public int Verify(string email,string password)
        {
            string query = $"SELECT * FROM `users` WHERE email = '{email}' and password = '{password}';";
            MySqlDataReader output = database.SelectQuery(query);

            while (output.Read())
            {
                if (output[3]==email && output[4]==password)
                {
                    return 200;
                }
            }
            return 0;
        }
    }
}
