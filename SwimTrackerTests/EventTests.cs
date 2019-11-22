using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void Test_Event_DistanceProperty()
        {
            string expectedDistance = "_100";
            Event _100free = new Event(EventDistance._100, Stroke.Freestyle);
            
            Assert.AreEqual(expectedDistance, _100free.Distance.ToString());
        }

        [TestMethod]
        public void Test_Event_StrokeProperty()
        {
            string expectedStroke = "Freestyle";
            Event _100free = new Event(EventDistance._100, Stroke.Freestyle);

            Assert.AreEqual(expectedStroke, _100free.Stroke.ToString());
        }

        [TestMethod]
        public void Test_Event_AddSwimmerMethod()
        {
            string expectedName = "Harry";
            Event _50free1 = new Event(EventDistance._100, Stroke.Freestyle);

            Registrant aSwimmer = new Registrant("Harry", new DateTime(1980, 10, 5), new Address("8 Caley", "Toronto", "ON", "M1E 1E3"), 4164588888);

            _50free1.AddSwimmer(aSwimmer);

            Assert.AreEqual(expectedName, _50free1.Swimmers[0].Name);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Test_Event_AddSwimmerMethod_SwimmerExists()
        {
            Event _50free1 = new Event(EventDistance._100, Stroke.Freestyle);
            Registrant aSwimmer1 = new Registrant("Harry", new DateTime(1980, 10, 5), new Address("8 Caley", "Toronto", "ON", "M1E 1E3"), 4164588888);
           
            _50free1.AddSwimmer(aSwimmer1);
            _50free1.AddSwimmer(aSwimmer1);
        }

        [TestMethod]
        public void Test_Event_AddEventMethod_SeedAndEnterSwimmersTimeMethods()
        {
            SwimMeet meet1 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.LCM, 2);
            Event _200medley = new Event(EventDistance._200, Stroke.Butterfly);
            meet1.AddEvent(_200medley); //Add Event
            TimeSpan expectedTime = TimeSpan.ParseExact("00:30.13", "mm':'ss'.'ff", null);

            Registrant aSwimmer = new Registrant();
            _200medley.AddSwimmer(aSwimmer);
            meet1.Seed(); //Seeding swimmer
            _200medley.EnterSwimmersTime(aSwimmer, "00:30.13"); //Enter time method

            Assert.AreEqual(expectedTime, _200medley.Swims[0].TimeSwam);
        }

        [TestMethod]
        public void Test_Event_AddTimeExceptionHandle()
        {
            SwimMeet meet1 = new SwimMeet("Spring Splash", new DateTime(2017, 5, 21), new DateTime(2017, 5, 21), PoolType.LCM, 2);
            Event _200medley = new Event(EventDistance._200, Stroke.Butterfly);
            
            meet1.AddEvent(_200medley);

            Registrant aSwimmer = new Registrant(); //Swimmer not added
            meet1.Seed();

            try
            {
                _200medley.EnterSwimmersTime(aSwimmer, "00:30.13");
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.Exception);
            }
        }
    }
}
