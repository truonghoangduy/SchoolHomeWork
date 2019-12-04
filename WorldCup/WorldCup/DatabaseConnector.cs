using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

namespace WorldCup
{
    public class DatabaseConnector
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
        public void makeQueryByTeem(String Query, int ContinnentArea) {
            SqlCommand command = new SqlCommand(Query + " where team = " + ContinnentArea.ToString(), makeConnection("open"));
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Did come to here");
            while (reader.Read())
            {
                //String data = reader["name"].ToString();
                //Console.WriteLine(reader["name"].ToString() + reader["name"].GetType());
                teem.AddplayerToTeem(reader["name"].ToString());
                teem.ContinentCode = ContinnentArea;
                //Console.WriteLine(reader["name"].ToString().GetType());
            }
            closeConnection(makeConnection("close"));

        }

        public string _ClearTable(String TableToFlash)
        {

            // Test for input
            if (TableToFlash == "player" || TableToFlash == "teem" || TableToFlash == "region")
            {
                return "No premission";
            }
            else
            {
                try
                {
                    SqlCommand command = new SqlCommand("Delete from " + TableToFlash, makeConnection("open"));
                    command.ExecuteNonQuery();
                    command.Dispose();
                    closeConnection(makeConnection("close"));
                    return "Sussesfully flash table : " + TableToFlash;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.Message);
                    return e.Message.Contains("Invalid") ? "Somethings wrong check connection":"Table not found"
                        ;
                }
            }


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
