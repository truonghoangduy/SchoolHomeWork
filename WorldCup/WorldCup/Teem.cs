﻿using System;
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

        public String CountryName { set; get; }
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
            Console.WriteLine("-------------------------------------------------------------------");
            // Player name and their personalGoal
            foreach (var item in listOfPlayer)
            {
                //Console.WriteLine(item.playerName +"  "+item._Pesonalsroce +"  ",ContinentCode.ToString());
                Console.WriteLine($"Player Name {item.playerName} Sorce {item._Pesonalsroce} From {CountryName} AreaCode {ContinentCode}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
        }

    }
}
