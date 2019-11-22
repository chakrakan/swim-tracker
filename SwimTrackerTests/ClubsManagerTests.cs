using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class ClubsManagerTests
    {
        [TestMethod]
        public void Test_ClubsManager_Constructor()
        {
            ClubsManager clubMg1 = new ClubsManager();
            Assert.AreEqual(true, clubMg1 != null);
        }

        [TestMethod]
        public void Test_ClubsManager_AddMethod()
        {
            ClubsManager clubMg2 = new ClubsManager();
            Club club1 = new Club();
            clubMg2.Add(club1);
            Assert.AreEqual(club1, clubMg2.Clubs[0]);
        }

        [TestMethod]
        public void Test_ClubsManager_GetClubByRegNumMethod()
        {
            ClubsManager clubMg3 = new ClubsManager();
            Club club2 = new Club(2000, "CCAC", new Address("35 River St", "Toronto", "ON", "M2M 5M5"), 4165555555);

            clubMg3.Add(club2);
            Club clubCheck = clubMg3.GetByRegNum(2000);
            Assert.AreEqual(club2, clubCheck);
        }
    }
}
