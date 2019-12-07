using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup;

namespace TestWorldCup
{
    [TestClass]
    public class TestFinalRound
    {
        DatabaseConnector database = new DatabaseConnector();
        Area area = new Area();
        [TestMethod]
        public void Test_who_Win()
        {
            FinalRound final = new FinalRound();
            Teem teem = new Teem();
            var teemList = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var whowin = final.startFinal(teemList[0], teemList[1]);
            Assert.AreEqual(teem.GetType(), whowin.GetType());
        }
        [TestMethod]
        public void Test_WinningTeemHasSorce_NotNevgative()
        {
            FinalRound final = new FinalRound();
            Teem teem = new Teem();
            var teemList = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var whowin = final.startFinal(teemList[0], teemList[1]);
            if (whowin.TeemTotalSroce>0)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void Test_WinningTeemHasSorce_ISNevgative()
        {
            FinalRound final = new FinalRound();
            Teem teem = new Teem();
            var teemList = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var whowin = final.startFinal(teemList[0], teemList[1]);
            if (whowin.TeemTotalSroce < 0)
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Test_WinningTeemHasDistrubutedTheirSorcetoPlayer()
        {
            FinalRound final = new FinalRound();
            Teem teem = new Teem();
            var teemList = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var whowin = final.startFinal(teemList[0], teemList[1]);
            int WinnerSorce = whowin.SrocePerRound;
            int TotalDitrubtedPlayerSorce = 0;
            foreach (var item in whowin.listOfPlayer)
            {
                if (item._Pesonalsroce != 0)
                {
                    TotalDitrubtedPlayerSorce += item._Pesonalsroce;
                    //Console.WriteLine(item._Pesonalsroce);
                }
            }
            Console.WriteLine($"Teem Has a Sroce of {whowin.SrocePerRound}  And has Distribute Sroce to Their Goal Player");
            Assert.AreEqual(whowin.SrocePerRound, TotalDitrubtedPlayerSorce);
        }
    }
}
