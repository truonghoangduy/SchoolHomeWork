using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup;
namespace TestWorldCup
{
    [TestClass]
    public class TestStage
    {

        Stage stage = new Stage();


        [TestMethod]
        public void Test_Method_InitTeem()
        {
            bool IsTeemBeenSussesfullyCreate = stage.InitTeemForBattle();
            Assert.IsTrue(IsTeemBeenSussesfullyCreate);
        }

        [TestMethod]
        public void Test_Teem_Been_Init_And_HasData()
        {
            Assert.IsNotNull(stage.InitTeem);
        }

        [TestMethod]
        public void Test_ClassContructor()
        {
            Assert.IsNotNull(stage);
        }

        [TestMethod]
        public void Test_TeemWorldCup()
        {
            stage.InitTeemForBattle();
            //stage.Start_Frist_RoundBattle();
            Assert.AreEqual(34, stage.InitTeem.Count);
        }

        [TestMethod]
        public void Test_Frist_Playoff()
        {
            //One teem left the game after play the frist play off
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            //stage.Start_Frist_RoundBattle();
            Assert.AreEqual(33, stage.InitTeem.Count);
        }

        [TestMethod]
        public void Test_Sec_Playoff()
        {
            //One teem left the game after play the frist play off
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            //stage.Start_Frist_RoundBattle();
            Assert.AreEqual(32, stage.InitTeem.Count);
        }

        [TestMethod]
        public void Test_Total_Teem_Enter_After_Playoff()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            Assert.AreEqual(32, stage.InitTeem.Count);
        }

        [TestMethod]
        public void Test_Frist_Ground__Match_IS_Run()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            bool isRun = stage.Start_Frist_RoundBattle();
            if (isRun)
            {
                Assert.IsTrue(isRun);
            }
        }

        [TestMethod]
        public void Test_Frist_Ground_Match_TeemEnter()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            Assert.AreEqual(32, stage.InitTeem.Count);

        }

        [TestMethod]
        public void Test_Frist_Ground_Match_Teemleft()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            bool isRun = stage.Start_Frist_RoundBattle();
            if (isRun)
            {
                Assert.AreEqual(16, stage.InitTeem.Count);
            }
        }

        [TestMethod]
        public void Test_Sec_Ground_Isrun()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            bool isRun1 = stage.Start_Frist_RoundBattle();
            bool isRun2 = stage.Start_Frist_RoundBattle();
            if (isRun1==true && isRun2==true)
            {
                Assert.IsTrue(isRun2);
            }
        }

        [TestMethod]
        public void Test_Sec_Ground_CheckTeemEnter()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            bool isRun1 = stage.Start_Frist_RoundBattle();
            //bool isRun2 = stage.Start_Frist_RoundBattle();
            if (isRun1 == true)
            {
                Assert.AreEqual(16,stage.InitTeem.Count);
            }
        }

        [TestMethod]
        public void Test_Sec_Ground_Teemleft()
        {
            stage.InitTeemForBattle();
            stage.Start_Frist_PlayOff();
            stage.Start_Sec_PlayOff();
            bool isRun1 = stage.Start_Frist_RoundBattle();
            bool isRun2 = stage.Start_Frist_RoundBattle();
            if (isRun1 == true && isRun2 == true)
            {
                Assert.AreEqual(8, stage.InitTeem.Count);
            }
        }
    }
}
