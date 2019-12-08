using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup;
namespace TestWorldCup
{
    [TestClass]
    public class TestMatch
    {

        Match match = new Match();
        List<Teem> InitTeem = new List<Teem>();
        DatabaseConnector database = new DatabaseConnector();
        Area area = new Area();

        [TestMethod]
        public void Testclass()
        {
            Assert.IsNotNull(match);
        }

        [TestMethod]
        public void TestMatchBettwenTeem()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNotNull(match.Winner);
        }

        [TestMethod]
        public void TestMatch_GetWinner()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNotNull(match.Winner);
        }

        [TestMethod]
        public void TestMatch_Get_Loser()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNotNull(match.Loser);
        }

        [TestMethod]
        public void TestMatch_Get()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNotNull(match.Loser);
        }

        [TestMethod]
        public void TestMatch_TeemATotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNotNull(match.TeemA.TeemTotalSroce);
        }

        [TestMethod]
        public void TestMatch_TeemB_TotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNotNull(match.TeemB.TeemTotalSroce);
        }

        [TestMethod]
        public void TestMatch_TeemC_TotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            Assert.IsNull(match.TeemB.TeemTotalSroce);
        }

        [TestMethod]
        public void TestMatch_Teem_A_Winner_HasDibtherSorceToPlayer_TotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            int TotalDitrubtedPlayerSorce = 0;
            foreach (var item in match.Winner.listOfPlayer)
            {
                if (item._Pesonalsroce != 0)
                {
                    TotalDitrubtedPlayerSorce += item._Pesonalsroce;
                    //Console.WriteLine(item._Pesonalsroce);
                }
            }
            Assert.IsNotNull(TotalDitrubtedPlayerSorce);
        }

        [TestMethod]
        public void TestMatch_Teem_B_Winner_HasDibtherSorceToPlayer_TotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            int TotalDitrubtedPlayerSorce = 0;
            foreach (var item in match.Winner.listOfPlayer)
            {
                if (item._Pesonalsroce != 0)
                {
                    TotalDitrubtedPlayerSorce += item._Pesonalsroce;
                    //Console.WriteLine(item._Pesonalsroce);
                }
            }
            Assert.IsNotNull(TotalDitrubtedPlayerSorce);
        }

        [TestMethod]
        public void TestMatch_Teem_B_Lose_HasDibtherSorceToPlayer_TotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            int TotalDitrubtedPlayerSorce = 0;
            foreach (var item in match.Winner.listOfPlayer)
            {
                if (item._Pesonalsroce != 0)
                {
                    TotalDitrubtedPlayerSorce += item._Pesonalsroce;
                    //Console.WriteLine(item._Pesonalsroce);
                }
            }
            Assert.IsNotNull(TotalDitrubtedPlayerSorce);
        }


        [TestMethod]
        public void TestMatch_Teem_A_Lose_HasDibtherSorceToPlayer_TotalSroce()
        {
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            match.TeemA = TeemAsia[0];
            match.TeemB = TeemNorthAmericaCentral[3];
            match.who_Is_Winning();
            int TotalDitrubtedPlayerSorce = 0;
            foreach (var item in match.Winner.listOfPlayer)
            {
                if (item._Pesonalsroce != 0)
                {
                    TotalDitrubtedPlayerSorce += item._Pesonalsroce;
                    //Console.WriteLine(item._Pesonalsroce);
                }
            }
            Assert.IsNotNull(TotalDitrubtedPlayerSorce);
        }
    }
}
