using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class SwimmerTests
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "Coach and swimmer are not in a same club")]
        public void Test_Swimmer_CoachProperty()
        {
            Coach aCoach = new Coach("Micael Phelps", new DateTime(1975, 6, 30), new Address("5 Queen St", "Boston", "ON", "M1L 6Y7"), 3123123333);//6
            Club aClub = new Club();
            aClub.Name = "another club";
            aClub.AddCoach(aCoach);
            Club bClub = new Club();
            Swimmer aSwimmer = new Swimmer();
            bClub.AddSwimmer(aSwimmer);
            aSwimmer.Coach = aCoach;
        }
    }
}
