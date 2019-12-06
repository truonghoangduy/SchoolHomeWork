using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public class FinalRound
    {
        Random rand = new Random();
        Match match = new Match();
        public Teem startFinal(Teem teemA,Teem teemB)
        {
            
            match.TeemA = teemA;
            match.TeemB = teemB;
            match.who_Is_Winning();

            return match.Winner;
        }
    }
}

