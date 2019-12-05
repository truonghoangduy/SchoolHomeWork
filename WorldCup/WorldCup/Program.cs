using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Area area = new Area();
            Stage stage = new Stage();
            //Player Induvitual = new Player("duy");
            //Console.WriteLine(Induvitual.playerName + Induvitual._Pesonalsroce.ToString());
            //Console.ReadLine();
            DatabaseConnector database = new DatabaseConnector();
            //String Querydata = @'SELECT * FROM player';


            //for (int i = 1; i <= area.GetContinentCode(Continent.Host); i++)
            //{
            //    Teem teemEnter = new Teem();
            //    teemEnter = database.makeQueryByTeem(i);
            //    stage.Add_Teem_To_Stage(teemEnter);
            //}
            //stage.printAllTeem_In_Match();

            List<Teem> AsianTeem = new List<Teem>();
            stage.Add_Teem_To_Stage(database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia)));
            stage.printAllTeem_In_Match();

            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(36);
            foreach (var item in players)
            {
                Console.WriteLine(item.playerName);
            }



            //Match match = new Match();




            Console.ReadLine();

            //Area test = new Area();
            //test.radomArea(Continent.Asia);
            //test.printall();
            //Console.WriteLine("---");
            //test.radomArea(Continent.Australia);
            //test.printall();
            //Console.ReadLine();






        }
    }
}
