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
        bool whowwin;
        public int _winSroce;
        public int _loseSroce;
        Random random = new Random();
        //public void Playoff
        private void randomSroce()
        {
            int winSroce = random.Next(2, 7);
            int loseSroce = random.Next(0, winSroce);
            _winSroce = winSroce;
            _loseSroce = loseSroce;
        }
        private void RandomplayerGoal(Teem teem, int teemSroce) {

            // Distribute player Sroce by it teem sroce
            //Encapsulation method
            while (teemSroce > 0) {
                int _sroce = random.Next(1, teemSroce);
                int selected_player = random.Next(0, teem.listOfPlayer.Count);
                teem.listOfPlayer[selected_player]._Pesonalsroce = _sroce;
                teemSroce = teemSroce - _sroce;
            }
        }
        public void who_Is_Winning()
        {
            bool flag = random_Who_Win();
            whowwin = flag;
            randomSroce();
            if (flag)
            {
                TeemA.TeemTotalSroce +=3;
                TeemA.SrocePerRound = _winSroce;
                RandomplayerGoal(TeemA, _winSroce);
                RandomplayerGoal(TeemB, _loseSroce);
            }
            else
            {
                TeemB.TeemTotalSroce +=3;
                TeemB.SrocePerRound = _winSroce;
                RandomplayerGoal(TeemB, _winSroce);
                RandomplayerGoal(TeemA, _loseSroce);
            }
        }

        public bool random_Who_Win()
        {
            int tempFlag = random.Next(0, 1);
            if (tempFlag==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public Teem Winner
        {
            get
            {
                return whowwin? TeemA : TeemB;
            }
        }


    }
}
