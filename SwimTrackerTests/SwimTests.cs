using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class SwimTests
    {
        [TestMethod]
        public void Test_Swim_HeatProperty()
        {
            Swim aSwim = new Swim();
            aSwim.Heat = 1;
            Assert.AreEqual(1, aSwim.Heat);
        }

        [TestMethod]
        public void Test_Swim_LaneProperty()
        {
            Swim aSwim = new Swim();
            aSwim.Lane = 1;
            Assert.AreEqual(1, aSwim.Lane);
        }

        [TestMethod]
        public void Test_Swim_TimeSwamProperty()
        {
            string expectedResult = "00:30.13";
            Swim aSwim = new Swim();
            aSwim.TimeSwam = TimeSpan.ParseExact(expectedResult, "mm':'ss'.'ff", null);

            Assert.AreEqual(expectedResult, aSwim.TimeSwam.ToString(@"mm\:ss\.ff"));
        }

        [TestMethod]
        public void Test_Swim_GetInfo()
        {
            Swim aSwim = new Swim(3, 3);
            string expectedResult = ($"Heat: {aSwim.Heat} | Lane: {aSwim.Lane} \n" +
                $"Time Swam: {aSwim.TimeSwam.ToString(@"mm\:ss\.ff")}");
            Assert.AreEqual(expectedResult, aSwim.ToString());
        }
    }
}
