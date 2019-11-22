using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class SwimMeetTests
    {
        [TestMethod]
        public void Test_SwimMeet_PoolTypeProperty()
        {
            string expectedType = "SCM";
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.SCM, 2);

            Assert.AreEqual(expectedType, aMeet.PoolType.ToString());
        }

        [TestMethod]
        public void Test_SwimMeet_NameProperty()
        {
            string expectedName = "Spring Splash";
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.SCM, 2);

            Assert.AreEqual(expectedName, aMeet.Name);
        }

        [TestMethod]
        public void Test_SwimMeet_SeedMethod()
        {
            Event anEvent = new Event();
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.SCM, 2);
            Registrant aRegistrant = new Registrant();
            aMeet.AddEvent(anEvent);

            anEvent.AddSwimmer(aRegistrant);
            aMeet.Seed();
            Assert.AreEqual("1" + "1", aMeet.Events[0].Swims[0].Heat.ToString() + aMeet.Events[0].Swims[0].Lane.ToString());
        }

        [TestMethod]
        public void Test_SwimMeet_SeedMethodNewHeat()
        {
            Event anEvent = new Event();
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.SCM, 2);
            Registrant swimmer1 = new Registrant();
            Registrant swimmer2 = new Registrant();
            Registrant swimmer3 = new Registrant();
            aMeet.AddEvent(anEvent);

            anEvent.AddSwimmer(swimmer1);
            anEvent.AddSwimmer(swimmer2);
            anEvent.AddSwimmer(swimmer3);
            aMeet.Seed();
            Assert.AreEqual("11" + "12" + "21", aMeet.Events[0].Swims[0].Heat.ToString() + aMeet.Events[0].Swims[0].Lane.ToString() + 
                aMeet.Events[0].Swims[1].Heat.ToString() + aMeet.Events[0].Swims[1].Lane.ToString() + aMeet.Events[0].Swims[2].Heat.ToString()
                + aMeet.Events[0].Swims[2].Lane.ToString());
        }

        [TestMethod]
        public void Test_SwimMeet_AddEventMethod()
        {
            string expectedResult = "Spring Splash";
            SwimMeet aMeet = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.SCM, 2);

            Event anEvent = new Event(EventDistance._200, Stroke.Butterfly);
            aMeet.AddEvent(anEvent);

            try
            {
                Assert.AreEqual(expectedResult, aMeet.Name);
                Assert.AreEqual("_200", aMeet.Events[0].Distance.ToString());
                Assert.AreEqual("Butterfly", aMeet.Events[0].Stroke.ToString());
            }
            catch
            {
                throw new Exception($"Event: {aMeet.Events[0].Distance.ToString()} {aMeet.Events[0].Stroke.ToString()}");
            }
        }
    }
}
