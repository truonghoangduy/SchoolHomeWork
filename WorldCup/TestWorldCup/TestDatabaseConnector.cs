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
        Area area = new Area();
        // Test Get Teem
        [TestMethod]
        public void getAsianTeem()
        {
            Teem teem = new Teem();
            String query = "Select name From player";
            
            teem=database.makeQueryByTeem(query, area.GetContinentCode(Continent.Asia));
            Assert.AreEqual(area.GetContinentCode(Continent.Asia),teem.ContinentCode);
            ////Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void getEuporpnTeem()
        {
            Teem teem = new Teem();
            String query = "Select name From player";

            teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.Europe));
            Assert.AreEqual(area.GetContinentCode(Continent.Europe), teem.ContinentCode);
            ////Assert.AreEqual(1, 1);
        }

        public void getNorthAmericaCentralTeem()
        {
            Teem teem = new Teem();
            String query = "Select name From player";

            teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.NorthAmericaCentral));
            Assert.AreEqual(area.GetContinentCode(Continent.NorthAmericaCentral), teem.ContinentCode);
            ////Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void getSouthAmericaTeem()
        {
            Teem teem = new Teem();
            String query = "Select name From player";

            teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.SouthAmerica));
            Assert.AreEqual(area.GetContinentCode(Continent.SouthAmerica), teem.ContinentCode);
            ////Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void getHostTeem()
        {
            Teem teem = new Teem();
            String query = "Select name From player";

            teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.Host));
            Assert.AreEqual(area.GetContinentCode(Continent.Host), teem.ContinentCode);
            ////Assert.AreEqual(1, 1);
        }
        [TestMethod]
        public void getAustraliaaTeem()
        {
            Teem teem = new Teem();
            String query = "Select name From player";

            teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.Australia));
            Assert.AreEqual(area.GetContinentCode(Continent.Australia), teem.ContinentCode);
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
