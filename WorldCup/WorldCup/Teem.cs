using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    class Teem
    {
        public List<Player> listOfPlayer = new List<Player>();
        public int teemindexing { set; get; }

        public int ContinentCode { set; get; }
        public int TeemTotalSroce { set; get; }
        public void AddplayerToTeem(String Name)
        {
            Console.WriteLine(Name);
            Player player = new Player(Name);
            listOfPlayer.Add(player);
        } 
        public void printall()
        {
            // Player name and their personalGoal
            foreach (var item in listOfPlayer)
            {
                Console.WriteLine(item.playerName +"  "+item._Pesonalsroce +"  ");
            }
        }

    }
}
