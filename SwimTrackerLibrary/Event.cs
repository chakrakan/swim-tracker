using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    [Serializable]
    public enum EventDistance
    {
        _50 = 50,
        _100 = 100,
        _200 = 200,
        _400 = 400,
        _800 = 800,
        _1500 = 1500
    };
    public enum Stroke
    {
        Butterfly,
        Backstsroke,
        Breaststroke,
        Freestyle,
        Individual_Medley
    };
    public class Event
    {
        //fields
        private EventDistance dist;
        private Stroke stroke;
        private int numOfSwimmers = 0;
        private int numOfSwims = 0;
        //private const int MAX_NO_SWIMMERS = 100;
        //private const int MAX_NO_SWIMS = 20;
        private List<Registrant> registrants;
        private List<Swim> swims;
        private SwimMeet swimMeet;

        //constructors
        public Event(EventDistance dist, Stroke stroke)
        {
            Distance = dist;
            Stroke = stroke;
            //Swimmers = new List<Registrant>(MAX_NO_SWIMMERS);
            //Swims = new List<Swim>(MAX_NO_SWIMS);
            Swimmers = new List<Registrant>();
            Swims = new List<Swim>();
        }
        public Event()
        {
            Swimmers = new List<Registrant>();
            Swims = new List<Swim>();
        }
        //Properties
        public EventDistance Distance
        {
            set { dist = value; }
            get { return dist; }
        }
        public Stroke Stroke
        {
            set { stroke = value; }
            get { return stroke; }
        }
        public List<Registrant> Swimmers
        {
            get { return registrants; }
            set { registrants = value; }
        }
        public int NumOfSwimmers
        {
            get { return numOfSwimmers; }
            private set { numOfSwimmers = value; }
        }
        public int NumOfSwims
        {
            get { return numOfSwims; }
            private set { numOfSwims = value; }
        }
        public List<Swim> Swims
        {
            get { return swims; }
            set { swims = value; }
        }
        public SwimMeet SwimMeet
        {
            get { return swimMeet; }
            set { swimMeet = value; }
        }
        public void AddSwimmer(Registrant aRegistrant)
        {
            try
            {
                for (int i = 0; i < NumOfSwimmers; i++)
                {
                    if (Swimmers[i] == aRegistrant)
                    {
                        throw new Exception($"Error: Swimmer {aRegistrant.Name}, {aRegistrant.RegistrantId} is already entered");
                    }
                }
                Swimmers.Add(aRegistrant);
                NumOfSwimmers++;
                aRegistrant.RegEvent = this;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Error: No more swimmers can be added this event!");
            }
        }
        public void AddSwim()
        {
            Swim aSwim = new Swim();
            Swims.Add(aSwim);
            NumOfSwims++;
            aSwim.Event = this;
        }
        public void Seed(int numOfLanes)
        {
            int heat = 1;
            int lane = 1;
            for (int i = 0; i < NumOfSwimmers;i++)
            {
                AddSwim();

                if (lane <= numOfLanes)
                {
                    Swims[i].Lane = lane++;
                    Swims[i].Heat = heat;
                }
                else
                {
                    lane = 1;
                    heat++;
                    Swims[i].Lane = lane;
                    Swims[i].Heat = heat;
                }                
            }
        }
        public void EnterSwimmersTime(Registrant aRegistrant, string timeSwam)
        {
            try
            {
                int index = 0;
                foreach (Registrant swimmer in Swimmers)
                {
                    if (aRegistrant == swimmer)
                    {
                        break;
                    }
                    index++;
                }
                TimeSpan time = TimeSpan.ParseExact(timeSwam, "mm':'ss'.'ff", null);
                Swims[index].TimeSwam = time;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Error: {timeSwam} has invalid format");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Error: {timeSwam} has invalid range of inputs for TimeSpan");
            }
            catch (Exception)
            {
                throw new Exception("Swimmer has not entered event");
            }

            Swimmer aSwimmer = aRegistrant as Swimmer;
            if (aSwimmer != null)
            {
                bool check = false;
                TimeSpan timeCheck = TimeSpan.ParseExact(timeSwam, "mm':'ss'.'ff", null);
                if (aSwimmer.BestTimesOfEvents.Count == 0)
                {
                    aSwimmer.BestTimesOfEvents.Add(this);
                    aSwimmer.BestTimes.Add(timeCheck);
                }

                for (int i = 0; i < aSwimmer.BestTimesOfEvents.Count; i++)
                {
                    if ((aSwimmer.BestTimesOfEvents[i].Stroke == Stroke) && (aSwimmer.BestTimesOfEvents[i].Distance == Distance)
                        && (aSwimmer.BestTimesOfEvents[i].SwimMeet.PoolType == SwimMeet.PoolType))
                    {
                        if (TimeSpan.Compare(aSwimmer.BestTimes[i], timeCheck) == 1)
                        {
                            aSwimmer.BestTimes[i] = timeCheck;
                        }
                        check = false;
                        break;
                    }
                    else if (!check)
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    aSwimmer.BestTimesOfEvents.Add(this);
                    aSwimmer.BestTimes.Add(timeCheck);
                }
            }
        }
        public override string ToString()
        {
            string result;
            string swimmers = "";
            int i = 0;
            foreach (var swimmer in Swimmers)
            {
                swimmers += $"\n\t{swimmer.Name}";
                if (NumOfSwims > 0)
                {
                    string timeCheck = Swims[i].TimeSwam.ToString(@"mm\:ss\.ff") == "00:00.00" ? "no time" : Swims[i].TimeSwam.ToString(@"mm\:ss\.ff");
                    swimmers += $"\t\tH{Swims[i].Heat}L{Swims[i].Lane}  time: {timeCheck}";
                }
                else
                {
                    swimmers += "\t\n\t\tNot seeded/no swim";
                }
                i++;
            }
        
            result = $"{Distance} {Stroke}\n\tSwimmers: {swimmers}\n";
            return result;
        }
    }
}
