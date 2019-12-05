using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class Teem
    {
        public List<Player> listOfPlayer = new List<Player>();
        public int teemindexing { set; get; }
        public String Coach { get; set; }
        public int ContinentCode { set; get; }
        public int TeemTotalSroce { set; get; }
        public void AddplayerToTeem(String Name)
        {
            ////Console.WriteLine(Name);
            Player player = new Player(Name);
            listOfPlayer.Add(player);
        } 
        public void printallPlayer()
        {
            // Player name and their personalGoal
            foreach (var item in listOfPlayer)
            {
                //Console.WriteLine(ContinentCode.ToString());
                Console.WriteLine(item.playerName +"  "+item._Pesonalsroce +"  " );
            }
        }

    }
}
