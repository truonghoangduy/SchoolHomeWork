using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player Induvitual = new Player("duy");
            //Console.WriteLine(Induvitual.playerName + Induvitual._Pesonalsroce.ToString());
            //Console.ReadLine();
            DatabaseConnector database = new DatabaseConnector();
            //String Querydata = @'SELECT * FROM player';
            database.makeQuery("Select name From player");

            Teem teemEnter = new Teem();

            Match match = new Match();

            match.TeemA = teemEnter.listOfPlayer.Where<>

            //Console.ReadLine();

            Area test = new Area();
            test.radomArea(Continent.Asia);
            test.printall();
            Console.WriteLine("---");
            test.radomArea(Continent.Australia);
            test.printall();
            Console.ReadLine();

            




        }
    }
}
