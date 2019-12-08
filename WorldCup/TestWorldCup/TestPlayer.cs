using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup;
namespace TestWorldCup
{
    [TestClass]
    public class TestPlayer
    {
        Player player = new Player("aa");
        [TestMethod]
        public void TestPlayerName()
        {
            Player player = new Player("aa");
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestPlayerSroceInitState()
        {
            Player player = new Player("aa");
            Assert.AreEqual(0, player._Pesonalsroce);
        }
    }
}
