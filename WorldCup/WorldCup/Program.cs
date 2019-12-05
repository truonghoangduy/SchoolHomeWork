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
            Teem teemEnter = new Teem();
            //Player Induvitual = new Player("duy");
            //Console.WriteLine(Induvitual.playerName + Induvitual._Pesonalsroce.ToString());
            //Console.ReadLine();
            DatabaseConnector database = new DatabaseConnector();
            //String Querydata = @'SELECT * FROM player';
            database.makeQueryByTeem("Select name From player", area.GetContinentCode(Continent.Asia));

            //Match match = new Match();
            teemEnter.printallPlayer();




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
