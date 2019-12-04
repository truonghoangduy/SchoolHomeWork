using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using WorldCup;

namespace TestWorldCup
{
    [TestClass]
    public class TestDatabaseConnector
    {
        DatabaseConnector database = new DatabaseConnector();
        // Test Get Teem
        public void getAsianTeem()
        {
            List<Player> players = new List<Player>;
        }



        // Test the _ClearTable Method
        [TestMethod]
        public void testFlashDBForNoPremission()
        {
            String[] templet = new String[] { "player", "region" };
            for (int i = 0; i < templet.Length; i++)
            {
                Console.WriteLine(i);
                String _callback = database._ClearTable(templet[i]);
                Assert.AreEqual("No premission", _callback);
            }

        }
        [TestMethod]
        public void testFlashDBFor_InvalidCollum()
        {
          Assert.AreEqual("Table not found", database._ClearTable("aaA"));
        }
    }
}
