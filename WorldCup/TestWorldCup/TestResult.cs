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

            Stage stage = new Stage();
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            stage.math.TeemA = TeemAsia[5];
            stage.math.TeemB = TeemNorthAmericaCentral[3];
            stage.math.who_Is_Winning();
            String matchSroceZ = stage.math._winSroce + ":" + stage.math._loseSroce;
            Assert.AreEqual(1, stage.result.writeResultToDatabase(stage.math.Winner, stage.math.Loser,stage: stage.getGround(Stage_Enum.playoff), ground: 0, sroce: matchSroceZ));
        }

        [TestMethod]
        public void TestPlayoffMatch_For_SouthAremicaVSAus__writeResultToDatabase()
        {

            Stage stage = new Stage();
            var TeemAsia = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            var TeemNorthAmericaCentral = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            stage.math.TeemA = TeemAsia[0];
            stage.math.TeemB = TeemNorthAmericaCentral[3];
            stage.math.who_Is_Winning();
            String matchSroceZ = stage.math._winSroce + ":" + stage.math._loseSroce;
            Assert.AreEqual(1, stage.result.writeResultToDatabase(stage.math.Winner, stage.math.Loser,stage: stage.getGround(Stage_Enum.playoff), ground: 0, sroce: matchSroceZ));
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
