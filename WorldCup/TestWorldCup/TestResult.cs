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
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.A)));
        }

        [TestMethod]
        public void TestGoundB()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.B)));

        }

        [TestMethod]
        public void TestGoundC()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.C)));

        }

        [TestMethod]
        public void TestGoundD()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.D)));

        }

        [TestMethod]
        public void TestGoundE()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.E)));

        }

        [TestMethod]
        public void TestGoundF()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.F)));

        }

        [TestMethod]
        public void TestGoundG()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.G)));

        }

        [TestMethod]
        public void TestGoundH()
        {
            Stage stage = new Stage();
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Frist_RoundBattle();
            Assert.IsTrue(stage.RoundHasPlay.Contains(stage.getRoundPerRound(RoundPerRound.H)));

        }

    }
}
