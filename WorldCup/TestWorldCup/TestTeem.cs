using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorldCup;

namespace TestWorldCup
{
    [TestClass]
    public class TestTeem
    {
        DatabaseConnector database = new DatabaseConnector();
        List<Teem> teem = new List<Teem>();
        Area area = new Area();

        
        [TestMethod]
        public void InitTeem()
        {
            //DatabaseConnector databaseConnector = new DatabaseConnector();
            ////databaseConnector.makeQueryByTeem("Select name From player",Continent.Asia);
            //Teem teems = new Teem();
            
        }
        [TestMethod]
        public void TestNameIsNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }
        [TestMethod]
        public void TestNameIsNotNull_Afica()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Africa));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }
        [TestMethod]
        public void TestNameIsNotNull_AUS()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Australia));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }

        [TestMethod]
        public void TestNameIsNotNull_EUP()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Europe));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }

        [TestMethod]
        public void TestNameIsNotNull_HOST()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Host));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }

        [TestMethod]
        public void TestNameIsNotNull_NorthCenteal()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }

        [TestMethod]
        public void TestNameIsNotNull_Southerl()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.SouthAmerica));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.CountryName);
            }
        }

        [TestMethod]
        public void Player_In_Teem_Asian_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Teem_Afica_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Africa));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Teem_Aus_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Australia));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Teem_EU_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Europe));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Teem_Host_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Host));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Teem_NorthAmericaCentral_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }
        [TestMethod]
        public void Player_In_Teem_SouthAmerica_isNotNull()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.SouthAmerica));
            foreach (var item in teem)
            {
                Assert.IsNotNull(item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Asia_Teem_Has_MinumumPlayer()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Asia));
            foreach (var item in teem)
            {
                Assert.IsTrue(11 < item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Africa_Teem_Has_MinumumPlayer()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Africa));
            foreach (var item in teem)
            {
                Assert.IsTrue(11 < item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Australia_Teem_Has_MinumumPlayer()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Australia));
            foreach (var item in teem)
            {
                Assert.IsTrue(11 < item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_Europe_Teem_Has_MinumumPlayer()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.Europe));
            foreach (var item in teem)
            {
                Assert.IsTrue(11 < item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_NorthAmericaCentral_Teem_Has_MinumumPlayer()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.NorthAmericaCentral));
            foreach (var item in teem)
            {
                Assert.IsTrue(11 < item.listOfPlayer.Count);
            }
        }

        [TestMethod]
        public void Player_In_SouthAmerica_Teem_Has_MinumumPlayer()
        {
            var teem = database.makeTeam_QueryBy_Continnent(area.GetContinentCode(Continent.SouthAmerica));
            foreach (var item in teem)
            {
                Assert.IsTrue(11 < item.listOfPlayer.Count);
            }
        }
    }
}
