using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WorldCup
{
    class DatabaseConnector
    {
        private String path_connection
        {
            get
            {
                return @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    @"AttachDbFilename =" + System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WorldCup.mdf;") +
                    "Integrated Security = True; Connect Timeout = 30";

                //return "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\user\\Desktop\\WorldCup\\WorldCup\\WorldCup.mdf; Integrated Security = True; Connect Timeout = 30";
            }
        }
        SqlConnection connection = new SqlConnection();
        Teem teem = new Teem();
        public DatabaseConnector()
        {
            connection.ConnectionString = path_connection;
        }
        public SqlConnection makeConnection(String flag) {
            

            if (flag == "open")
            {
                connection.Open();
                return connection;
            }
            else
            {
                connection.Close();
                return connection;
            }
        }
        public void closeConnection(SqlConnection connection)
        {
            connection.Close();
        }
        public void makeQuery(String Query) {
            SqlCommand command = new SqlCommand(Query, makeConnection("open"));
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Did come to here");
            while (reader.Read())
            {
                //String data = reader["name"].ToString();
                //Console.WriteLine(reader["name"].ToString() + reader["name"].GetType());
                teem.AddplayerToTeem(reader["name"].ToString());
                //Console.WriteLine(reader["name"].ToString().GetType());
            }
            closeConnection(makeConnection("close"));

        }

        //public List<String> getPlayer(String Query)
        //{
        //    List<String> tempReturn = new List<string>();

        //    SqlConnection connection1 = new SqlConnection();
        //    connection1.ConnectionString = path_connection;
        //    connection1.Open();
        //    SqlCommand command = new SqlCommand(Query,connection1);
        //    return tempReturn;
        //}


    }
}
