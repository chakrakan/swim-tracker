using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    public enum PoolType
    {
        SCM,
        SCY,
        LCM
    };
    [Serializable]
    public class SwimMeet
    {        
        //fields
        private DateTime startTime;
        private DateTime endTime;
        private string meetName;
        private PoolType poolType;
        private readonly int numOfLanes;
        private int numOfEvents = 0;
        //private const int MAX_NO_EVENTS = 50;
        private List<Event> events;

        //constructors, using current date as deafault Start and End times when unspecified
        public SwimMeet(string name, DateTime startTime, DateTime endTime, PoolType type, int numLanes)
        {
            Name = name;
            StartDate = startTime;
            EndDate = endTime;
            PoolType = type;
            numOfLanes = numLanes;
            //Events = new List<Event>(MAX_NO_EVENTS);
            Events = new List<Event>();
        }
        public SwimMeet()
        {
            numOfLanes = 8;
            Events = new List<Event>();
        }

        //properties
        public string Name
        {
            set { meetName = value; }
            get { return meetName; }
        }
        public PoolType PoolType
        {
            set { poolType = value; }
            get { return poolType; }
        }
        public DateTime StartDate
        {
            set { startTime = value; }
            get { return startTime; }
        }
        public DateTime EndDate
        {
            set { endTime = value; }
            get { return endTime; }
        }
        public List<Event> Events
        {
            get { return events; }
            set { events = value; }
        }
        public int NumLanes
        {
            get { return numOfLanes; }
        }
        public int NumEvents
        {
            get { return numOfEvents; }
            set { numOfEvents = value; }
        }
        public void AddEvent(Event anEvent)
        {
            Events.Add(anEvent);
            NumEvents++;
            anEvent.SwimMeet = this;
        }
        public void Seed()
        {
            for (int i = 0; i < NumEvents; i++)
            {
                Events[i].Seed(NumLanes);
            }
        }
        public override string ToString()
        {
            string result;
            string events = "";
            string startTime = StartDate.ToString(@"yyyy-MM-dd");
            string endTime = EndDate.ToString(@"yyyy-MM-dd");
            if (NumEvents != 0)
            {
                for (int i = 0; i < NumEvents; i++)
                {
                    events += $"\n\t{Events[i].ToString()}";
                }
            }
            result = $"Swim Meet Name: {Name}\n" +
                $"From-to: {startTime} to {endTime}\n" +
                $"Pool Type: {PoolType}\n" +
                $"No lanes: {NumLanes}\nEvents: {events}";
            return result;
        }
    }
}
