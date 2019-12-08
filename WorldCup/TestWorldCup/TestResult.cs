using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup;
namespace TestWorldCup
{
    [TestClass]
    public class TestResult
    {
        DatabaseConnector database = new DatabaseConnector();
        Area area = new Area();
        

        public TestResult() {
            database._ClearTable("game");
        }



        [TestMethod]
        public void TestPlayoffMatch_For_Teem1_writeResultToDatabase()
        {

            Result result = new Result();
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            result.math.TeemA = TeemAsia[5];
            result.math.TeemB = TeemNorthAmericaCentral[3];
            result.math.who_Is_Winning();
            String matchSroce = result.math._winSroce + ":" + result.math._loseSroce;
            Assert.AreEqual(1, result.writeResultToDatabase(stage: 1, sroce: matchSroce));
        }

        [TestMethod]
        public void TestPlayoffMatch_For_SouthAremicaVSAus__writeResultToDatabase()
        {
            Result result = new Result();
            var TeemAustralia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Australia));
            var TeemSouthAmerica = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.SouthAmerica));
            result.math.TeemA = TeemAustralia[0];
            result.math.TeemB = TeemSouthAmerica[3];
            result.math.who_Is_Winning();
            String matchSroce = result.math._winSroce + ":" + result.math._loseSroce;
            Console.WriteLine(matchSroce);
            Assert.AreEqual(1, result.writeResultToDatabase(stage: 1, sroce: matchSroce));
        }

        [TestMethod]
        public void TestGoundA()
        {


        }

        [TestMethod]
        public void TestGoundB()
        {


        }

        [TestMethod]
        public void TestGoundC()
        {


        }

        [TestMethod]
        public void TestGoundD()
        {


        }

        [TestMethod]
        public void TestGoundE()
        {


        }

        [TestMethod]
        public void TestGoundF()
        {


        }

        [TestMethod]
        public void TestGoundG()
        {


        }

        [TestMethod]
        public void TestGoundH()
        {


        }
    }
}
