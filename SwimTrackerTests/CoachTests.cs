using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class CoachTests
    {
        [TestMethod]
        public void Test_Coach_ClubProperty()
        {
            Club aClub = new Club();
            Coach aCoach = new Coach();
            aClub.AddCoach(aCoach);
            Assert.AreEqual(aCoach, aClub.Coaches[0]);
        }

        [TestMethod]
        public void Test_Coach_CredentialsProperty()
        {
            string expectedResult = "NNCA Level 1";
            Coach aCoach = new Coach();
            aCoach.Credentials = "NNCA Level 1";
            Assert.AreEqual(expectedResult, aCoach.Credentials);
        }

        [TestMethod]
        public void Test_Coach_Constructor()
        {
            string expectedResult = "Micael Phelps";
            Coach aCoach = new Coach("Micael Phelps", new DateTime(1945, 6, 30), new Address("5 Queen St", "Toronto", "ON", "M1L 6Y7"), 3123123333);
            Assert.AreEqual(expectedResult, aCoach.Name);
        }

        [TestMethod]
        public void Test_Coach_ConstructorEmpty()
        {
            string expectedResult = "0001-01-01 12:00:00 AM";
            Coach aCoach = new Coach();
            Assert.AreEqual(expectedResult, aCoach.DateOfBirth.ToString());
        }

        [TestMethod]
        public void Test_Coach_AddSwimmerMethods()
        {
            Coach aCoach = new Coach("Micael Phelps", new DateTime(1975, 6, 30), new Address("5 Queen St", "Boston", "ON", "M1L 6Y7"), 3123123333);
            Club aClub = new Club();
            aClub.Name = "Cool new club";
            aClub.AddCoach(aCoach);
            Swimmer aSwimmer = new Swimmer();
            aSwimmer.Name = "Randalph";
            aClub.AddSwimmer(aSwimmer);
            aCoach.AddSwimmer(aSwimmer);
            Assert.AreEqual(aSwimmer.Name, aCoach.Swimmers[0].Name);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Coach is not assigned to a club")]
        public void Test_Coach_AddSwimmerCoachIsNotAssignedException()
        {
            Coach aCoach = new Coach("Micael Phelps", new DateTime(1975, 6, 30), new Address("5 Queen St", "Boston", "ON", "M1L 6Y7"), 3123123333);
            Club aClub = new Club();
            aClub.Name = "Cool new club2";
            Swimmer aSwimmer = new Swimmer();
            aClub.AddSwimmer(aSwimmer);
            aCoach.AddSwimmer(aSwimmer);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Coach and swimmer are not in the same club")]
        public void Test_Coach_AddSwimmerDifferentClubException()
        {
            Coach aCoach = new Coach("Micael Phelps", new DateTime(1975, 6, 30), new Address("5 Queen St", "Boston", "ON", "M1L 6Y7"), 3123123333);//6
            Club aClub = new Club();
            aClub.Name = "Cool new club3";
            aClub.AddCoach(aCoach);
            Club bClub = new Club();
            Swimmer aSwimmer = new Swimmer();
            bClub.AddSwimmer(aSwimmer);
            aCoach.AddSwimmer(aSwimmer);
        }
    }
}
