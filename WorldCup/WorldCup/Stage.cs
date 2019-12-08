using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup
{
    public enum GameStage
    {
        ForTestCase,
        playoff,
        group,
        knockout,
        quarterfinal,
        semifinal,
        final
    }
    public enum RoundPerRound
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H

    }


    public class Stage
    {
        List<Teem> teems = new List<Teem>();
        //public bool InitcheckTeem()
        //{
        //    bool checkfag=false;
        //    foreach (var item in teems)
        //    {
        //        if (item.listOfPlayer.Count>7 || item.listOfPlayer.Count <15)
        //        {
        //            checkfag = true;
        //        }
        //        if (true)
        //        {

        //        }
        //    }
        //    return checkfag;
        //}
        public void Add_Teem_To_Stage(List<Teem> teemObject)
        {
            teems.AddRange(teemObject);
        }
        public void printAllTeem_In_Match()
        {
            foreach (var item in teems)
            {
                item.printallPlayer();
            }
        }

        public void PlayoffStage(Teem teemA,Teem teemB,Teem teemC,Teem teemD)
        {
            Match match = new Match();

        }

        public int getGround(Stage_Enum stage_Enum)
        {
            switch (stage_Enum)
            {
                case Stage_Enum.playoff:
                    return 1;
                    break;
                case Stage_Enum.group:
                    return 2;
                    break;
                default:
                    return 0;
            }

        }
        public int getRoundPerRound(RoundPerRound round)
        {
            switch (round)
            {
                case RoundPerRound.A:
                    return 1;
                    break;
                case RoundPerRound.B:
                    return 2;
                    break;
                case RoundPerRound.C:
                    return 3;
                    break;
                case RoundPerRound.D:
                    return 4;
                    break;
                case RoundPerRound.E:
                    return 5;
                    break;
                case RoundPerRound.F:
                    return 6;
                    break;
                case RoundPerRound.G:
                    return 7;
                    break;
                case RoundPerRound.H:
                    return 8;
                    break;
                default:
                    return 0;
                    break;
            }
        }
    }
}
