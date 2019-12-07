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


            FinalRound final = new FinalRound();
            Teem teem = new Teem();
            var teemList = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var whowin = final.startFinal(teemList[0], teemList[1]);
            Console.WriteLine("Teem Enter");
            for (int i = 0; i < teemList.Count; i++)
            {
                Console.WriteLine(teemList[i].CountryName);
            }
            Console.WriteLine("---------------------");
            Console.WriteLine("The winner is : "+whowin.CountryName +"  which the total of "+whowin.SrocePerRound);
            foreach (var item in whowin.listOfPlayer)
            {
                Console.WriteLine(item.playerName+" "+item._Pesonalsroce.ToString());
            }



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
