using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    public class Swimmer : Registrant
    {
        private Coach coach;
        private List<TimeSpan> bestTimes;
        private List<Event> bestTimesOfEvents;
        //private const int MAX_NO_EVENTS = 100;

        public Coach Coach
        {
            get { return coach; }
            set { coach = value; value.AddSwimmer(this); }
        }
        public List<TimeSpan> BestTimes
        {
            get { return bestTimes; }
            set { bestTimes = value; }
        }
        public List<Event> BestTimesOfEvents
        {
            get { return bestTimesOfEvents; }
            set { bestTimesOfEvents = value; }
        }
        public Swimmer(string name, DateTime dateOfBirth, Address address, long phoneNo) : base(name, dateOfBirth, address, phoneNo)
        {
            //BestTimes = new List<TimeSpan>(MAX_NO_EVENTS);
            //BestTimesOfEvents = new List<Event>(MAX_NO_EVENTS);
            BestTimes = new List<TimeSpan>();
            BestTimesOfEvents = new List<Event>();
        }
        public Swimmer()
        {
            BestTimes = new List<TimeSpan>();
            BestTimesOfEvents = new List<Event>();
        }
        public TimeSpan GetBestTime(PoolType course, Stroke stroke, EventDistance distance)
        {
            TimeSpan time = TimeSpan.Zero;
            for (int i = 0; i < BestTimesOfEvents.Count; i++)
            {
                if (BestTimesOfEvents[i].Stroke == stroke && BestTimesOfEvents[i].Distance == distance && BestTimesOfEvents[i].SwimMeet.PoolType == course)
                {
                    time = BestTimes[i];
                }
            }
            return time;
        }
        public void AddAsBestTime(PoolType course, Stroke stroke, EventDistance distance, TimeSpan time)
        {
            for (int i = 0; i < BestTimesOfEvents.Count; i++)
            {
                if (BestTimesOfEvents[i].Stroke == stroke && BestTimesOfEvents[i].Distance == distance && BestTimesOfEvents[i].SwimMeet.PoolType == course)
                {
                    if (TimeSpan.Compare(BestTimes[i], time) == 1)
                    {
                        BestTimes[i] = time;
                    }
                }
            }
        }
        public override string ToString()
        {
            string res = base.ToString() + $"\nCoach: {(Coach != null ? Coach.Name : "not assigned")}";
            return res;
        }
    }
}
