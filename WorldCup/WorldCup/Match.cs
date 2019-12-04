using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class Match
    {
        // Match bettwen 2 teem
        public Teem TeemA { set; get; }
        public Teem TeemB { set; get; }

        public int _winSroce;
        public int _loseSroce;
        Random random = new Random();
        public void randomSroce()
        {
            int winSroce = random.Next(0, 5);
            int loseSroce = random.Next(winSroce, 7);
            _winSroce = winSroce;
            _loseSroce = loseSroce;
        }
        public void RandomplayerGoal(Teem teem, int teemSroce) {

            // Distribute player Sroce by it teem sroce
            //Encapsulation method

            while (teemSroce > 0) {
                int _sroce = random.Next(1, teemSroce);
                int selected_player = random.Next(1, teem.listOfPlayer.Count);
                teem.listOfPlayer[selected_player]._Pesonalsroce = teemSroce;
                teemSroce = teemSroce - _sroce;
            }
        }


    }
}
