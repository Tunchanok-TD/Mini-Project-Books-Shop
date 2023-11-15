using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Shop1
{
    internal class DB
    {
        static String connectionString = "server=localhost;uid=root;pwd=root;database=book_information_1";



        static public MySqlDataReader getData(String sqlQuery)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        static public void runCmd(String sqlQuery)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
