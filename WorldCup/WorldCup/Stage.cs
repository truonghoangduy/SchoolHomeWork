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
    }
}
