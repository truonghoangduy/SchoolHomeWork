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
        
        public DatabaseConnector()
        {
            connection.ConnectionString = path_connection;
        }
        public SqlConnection makeConnection(String flag) { // Done


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
        public List<Teem> makeTeam_QueryBy_Continnent(int ContinnentArea) { // Done
            List<Teem> teems = new List<Teem>();
            //SqlCommand command = new SqlCommand(Query + " where team = " + ContinnentArea.ToString(), makeConnection("open"));
            String GivenCommand = "select * from [team] where region in " +
                $"(select id_region from region where region.id_region = {ContinnentArea})";
            SqlCommand command = new SqlCommand(GivenCommand, makeConnection("open"));
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("Did come to here");
            
            while (reader.Read())
            {
                Teem teemObject = new Teem();
                //teemObject.AddplayerToTeem(reader["playername"].ToString());
                teemObject.teemindexing = (int)reader["id_team"];
                teemObject.Coach = reader["coach"].ToString();
                teemObject.CountryName = reader["name"].ToString();
                teemObject.ContinentCode = ContinnentArea;
                teems.Add(teemObject);
                //Console.WriteLine(teem.ContinentCode.ToString());
            }           
            closeConnection(makeConnection("close"));
            foreach (var item in teems)
            {
                item.listOfPlayer = GetPlayerByTeem(item.teemindexing);
            }
            return teems;
        }

        public List<Player> GetPlayerByTeem(int TeamID)
        {
            List<Player> playerName = new List<Player>();
            String GivenCommand = "select name from [player] " +
                    $"where team={TeamID}";
            SqlCommand command = new SqlCommand(GivenCommand, makeConnection("open"));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Player player = new Player(reader["name"].ToString());
                playerName.Add(player);
            }
            makeConnection("close");
            return playerName;
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
        public void WriteMatchToDB()
        {
        //    String GivenCommand = "select name from [player] " +
        //$"where team={TeamID}";
            //SqlCommand command = new SqlCommand(GivenCommand, makeConnection("open"));
        }

    }
}
