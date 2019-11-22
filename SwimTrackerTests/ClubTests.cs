using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class ClubTests
    {
        //Testing Registration Num property + valid num generation
        [TestMethod]
        public void Test_Clubs_ValidRegistrationNumGeneration()
        {
            Club testclub1 = new Club();
            Club testclub2 = new Club();
            int expectedNum1 = testclub1.RegistrationNum;
            int expectedNum2 = testclub2.RegistrationNum;
            int expectedResult = 1;

            try
            {
                Assert.AreEqual(expectedResult, expectedNum2 - expectedNum1);
            }
            catch
            {
                throw new Exception($"Club1 = {testclub1.RegistrationNum}\nClub2 = {testclub2.RegistrationNum}");
            }
        }

        //Testing only important class properties. If AddressTests passes then Clubs Address property works.
        [TestMethod]
        public void Test_Club_ConstructorAndProperties()
        {
            Club aClub = new Club(2000, "CCACA", new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3"), 4164588700);
            long expectedPhone = 4164588700;
            int expectedReg = 2000;
            string expectedName = "CCACA";
            Address expectedAddress = new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3");


            Assert.AreEqual(expectedPhone, aClub.PhoneNumber);
            Assert.AreEqual(expectedReg, aClub.RegistrationNum);
            Assert.AreEqual(expectedName, aClub.Name);
            Assert.AreEqual(expectedAddress, aClub.Address);
        }

        //Test 
        [TestMethod]
        public void Test_Club_AddSwimmerMethod_NumRegistrantsProperty()
        {
            int expectedResult = 2;
            Club aClub = new Club("Club 1", new Address("7 Caley", "Toronto", "ON", "M1C 1E3"), 4164588700);
            Registrant aSwimmer = new Registrant("Rick Sanchez", new DateTime(1980, 10, 5), new Address("8 Caley", "Toronto", "ON", "M1E 1E3"), 4164588888);
            Registrant aNewSwimmer = new Registrant();
            aClub.AddSwimmer(aSwimmer);
            aClub.AddSwimmer(aNewSwimmer);
            Assert.AreEqual(expectedResult, aClub.NumRegistrants);            
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Club_AddSwimmerMethod_UserToMultipleClubs()
        {
            Club aClub = new Club("Club 1", new Address("7 Caley", "Toronto", "ON", "M1C 1E3"), 4164588700);
            Registrant aSwimmer = new Registrant("Rick Sanchez", new DateTime(1980, 10, 5), new Address("8 Caley", "Toronto", "ON", "M1E 1E3"), 4164588888);
            Club aClub2 = new Club();

            aClub.AddSwimmer(aSwimmer);
            aClub2.AddSwimmer(aSwimmer);
        }
    }
}
