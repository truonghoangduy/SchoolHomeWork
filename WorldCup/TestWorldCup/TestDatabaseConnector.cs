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
        //[TestMethod]
        //public void getAsianTeem()
        //{
        //    List<Teem> teem = new List<Teem>();


        //    teem=database.makeQueryByTeem(area.GetContinentCode(Continent.Asia));
        //    foreach (var item in collection)
        //    {

        //    }
        //    //Assert.AreEqual();
        //    ////Assert.AreEqual(1, 1);
        //}
        //[TestMethod]
        //public void getEuporpnTeem()
        //{
        //    Teem teem = new Teem();
        //    String query = "Select name From player";

        //    teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.Europe));
        //    Assert.AreEqual(area.GetContinentCode(Continent.Europe), teem.ContinentCode);
        //    ////Assert.AreEqual(1, 1);
        //}

        //public void getNorthAmericaCentralTeem()
        //{
        //    Teem teem = new Teem();
        //    String query = "Select name From player";

        //    teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.NorthAmericaCentral));
        //    Assert.AreEqual(area.GetContinentCode(Continent.NorthAmericaCentral), teem.ContinentCode);
        //    ////Assert.AreEqual(1, 1);
        //}
        //[TestMethod]
        //public void getSouthAmericaTeem()
        //{
        //    Teem teem = new Teem();
        //    String query = "Select name From player";

        //    teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.SouthAmerica));
        //    Assert.AreEqual(area.GetContinentCode(Continent.SouthAmerica), teem.ContinentCode);
        //    ////Assert.AreEqual(1, 1);
        //}
        //[TestMethod]
        //public void getHostTeem()
        //{
        //    Teem teem = new Teem();
        //    String query = "Select name From player";

        //    teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.Host));
        //    Assert.AreEqual(area.GetContinentCode(Continent.Host), teem.ContinentCode);
        //    ////Assert.AreEqual(1, 1);
        //}
        //[TestMethod]
        //public void getAustraliaaTeem()
        //{
        //    Teem teem = new Teem();
        //    String query = "Select name From player";

        //    teem = database.makeQueryByTeem(query, area.GetContinentCode(Continent.Australia));
        //    Assert.AreEqual(area.GetContinentCode(Continent.Australia), teem.ContinentCode);
        //}
        [TestMethod]
        public void Init_DatabaseConnector_Class()
        {
            DatabaseConnector databaseConnector = new DatabaseConnector();
            Assert.IsNotNull(databaseConnector);
        }

        

        /// <summary>
        /// Test case for Getting player of each teem border method
        /// </summary>
        [TestMethod]
        public void GetPlayers_GetPlayerOfTeamZero()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(0);
            foreach (var item in players)
            {
                Assert.IsNull(item);
            }
        }
        [TestMethod]
        public void GetPlayers_GetPlayerOfTeam1()
        {
            database= new DatabaseConnector();
            Assert.IsNotNull(database.GetPlayerByTeem(1));
        }
        [TestMethod]
        public void GetPlayers_GetPlayerOfTeam33()
        {
            database= new DatabaseConnector();
            Assert.IsNotNull(database.GetPlayerByTeem(33));
        }
        [TestMethod]
        public void GetPlayers_GetPlayerOfTeam34()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(34);
            foreach (var item in players)
            {
                Assert.IsNull(item);
            }
        }
        [TestMethod]
        public void GetPlayers_GetPlayerOfTeam35()
        {
            Assert.IsNotNull(database.GetPlayerByTeem(35));
        }
        [TestMethod]
        public void GetPlayers_GetPlayerOfTeam36()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(36);
            foreach (var item in players)
            {
                Assert.IsNull(item);
            }
           
        }
        /// <summary>
        ///  Check Player Name pre teem using border
        /// </summary>
        [TestMethod]
        public void Check_Name_Players_OfTeam36()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(36);
            foreach (var item in players)
            {
                Assert.IsNull(item.playerName);
            }
        }
        [TestMethod]
        public void Check_Name_Players_OfTeam0()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(0);
            foreach (var item in players)
            {
                Assert.IsNull(item.playerName);
            }
        }
        [TestMethod]
        public void Check_Name_Players_OfTeam1()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(1);
            foreach (var item in players)
            {
                Assert.IsNotNull(item.playerName);
            }
        }
        [TestMethod]
        public void Check_Name_Players_OfTeam23()
        {
            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(23);
            foreach (var item in players)
            {
                Assert.IsNotNull(item.playerName);
            }
        }
        [TestMethod]
        public void Check_Name_Players_OfTeam35()
        {

            List<Player> players = new List<Player>();
            players = database.GetPlayerByTeem(35);
            foreach (var item in players)
            {
                Assert.IsNotNull(item.playerName);
            }
        }

        /// <summary>
        /// Check Basic Player Init Detail within every Contienet -> country name
        /// </summary>
        [TestMethod]
        public void Test_Player_Init_Pont()
        {
            List<Teem> teemObject = new List<Teem>();
            for (int i = 1; i <= 7; i++)
            {
                teemObject = database.makeTeam_QueryBy_Continnent(i);
                foreach (var item in teemObject)
                {
                    foreach (var item0 in item.listOfPlayer)
                    {
                        Assert.AreEqual(0, item0._Pesonalsroce);
                    }
                }
            }
            
        }
        [TestMethod]
        public void Test_Player_Name()
        {
            List<Teem> teemObject = new List<Teem>();
            for (int i = 1; i <= 7; i++)
            {
                teemObject = database.makeTeam_QueryBy_Continnent(i);
                foreach (var item in teemObject)
                {
                    foreach (var item0 in item.listOfPlayer)
                    {
                        Assert.IsNotNull(item0.playerName);
                    }
                }
            }

        }
        [TestMethod]
        public void Test_Total_Teem_In_Asia()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.Asia), teemObject.Count);
        }
        [TestMethod]
        public void Test_Total_Teem_In_Africa()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Africa));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.Africa), teemObject.Count);


        }
        [TestMethod]
        public void Test_Total_Teem_In_Australia()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Australia));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.Australia), teemObject.Count);


        }
        [TestMethod]
        public void Test_Total_Teem_In_Europe()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Europe));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.Europe), teemObject.Count);
        }

        [TestMethod]
        public void Test_Total_Teem_In_Host()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Host));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.Host), teemObject.Count);
        }

        [TestMethod]
        public void Test_Total_Teem_In_NorthAmericaCentral()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.NorthAmericaCentral), teemObject.Count);
        }

        [TestMethod]
        public void Test_Total_Teem_In_SouthAmerica()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.SouthAmerica));
            Assert.AreEqual(area.GetTeemLengtByArea(Continent.SouthAmerica), teemObject.Count);
        }

        [TestMethod]
        public void Test_Total_Teem_In_Fail_For_TestOnly()
        {
            List<Teem> teemObject = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.ForTestCase));
            Assert.IsNull(teemObject.Count);
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
