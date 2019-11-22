using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    [Serializable]
    public class Swim
    {
        //fields
        private int heatNum;
        private int laneNum;
        private TimeSpan finalTime;
        private Event anEvent;

        //constructors
        public Swim(int heat, int lane)
        {
            Heat = heat;
            Lane = lane;
        }
        public Swim() { }

        //Properties
        public int Heat
        {
            set { heatNum = value; }
            get { return heatNum; }
        }
        public int Lane
        {
            set { laneNum = value; }
            get { return laneNum; }
        }
        public TimeSpan TimeSwam
        {
            set { finalTime = value; }
            get { return finalTime; }
        }
        public Event Event
        {
            get { return anEvent; }
            set { anEvent = value; }
        }
        public override string ToString()
        {
            string result;
            string time = TimeSwam.ToString(@"mm\:ss\.ff");
            result = ($"Heat: {Heat} | Lane: {Lane} \n" +
                $"Time Swam: {time}");
            return result;
        }
    }
}
