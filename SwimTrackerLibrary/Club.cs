using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwimTrackerLibrary
{
    [Serializable]
    public class Club
    {
        
        //variables
        private string name;
        private readonly int registrationNum;
        private static int clubCounter = 0;
        private long clubPhoneNum;
        private Address address;
        private int numRegistrants = 0;
        private int numCoaches = 0;
        //private const int MAX_NO_REGISTRANTS = 100;
        private List<Registrant> clubMembers;
        private List<Coach> coaches;

        //Default constructor
        public Club(string clubName, Address address, long phoneNum)
        {
            Name = clubName;
            this.address = address;
            PhoneNumber = phoneNum;
            registrationNum = clubCounter++;
            //Registrants = new List<Registrant>(MAX_NO_REGISTRANTS);
            //Coaches = new List<Coach>(MAX_NO_REGISTRANTS);
            Registrants = new List<Registrant>();
            Coaches = new List<Coach>();
        }
        public Club(int regNum, string clubName, Address address, long phoneNum)
        {
            Name = clubName;
            registrationNum = regNum;
            clubCounter++;
            Address = address;
            PhoneNumber = phoneNum;
            Registrants = new List<Registrant>();
            Coaches = new List<Coach>();
        }
        public Club()
        {
            registrationNum = clubCounter++;
            Registrants = new List<Registrant>();
            Coaches = new List<Coach>();
        }

        //Properties
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public int RegistrationNum
        {
            get { return this.registrationNum; }
        }
        public long PhoneNumber
        {
            set
            {
                if ((value.ToString().Length != 10) || (value == 0))
                {
                    WriteLine("Error: Phone Number must be 10 digits. If value is 0 " +
                        "consider providing a phone number for future contact\n");
                }
                else
                {
                    clubPhoneNum = value;
                }
            }
            get { return clubPhoneNum; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
        public int NumRegistrants
        {
            get { return numRegistrants; }
            set { numRegistrants = value; }
        }
        public int NumCoaches
        {
            get { return numCoaches; }
            set { numCoaches = value; }
        }
        public List<Registrant> Registrants
        {
            get { return clubMembers; }
            set { clubMembers = value; }
        }
        public List<Coach> Coaches
        {
            get { return coaches; }
            set { coaches = value; }
        }
        public void AddSwimmer(Registrant aRegistrant)
        {
            if (NumRegistrants == 0 || Registrants[NumRegistrants - 1] != aRegistrant)
            {
                if (aRegistrant.Club == null || aRegistrant.Club == this)
                {
                    Registrants.Add(aRegistrant);
                    NumRegistrants++;
                    if (aRegistrant.Club == null)
                    {
                        aRegistrant.Club = this;
                    }

                }
                else
                {
                    throw new Exception(string.Format("Swimmer already assigned to {0} club", aRegistrant.Club.Name));
                }

            }

        }
        public void AddCoach(Coach aCoach)
        {
            Coaches.Add(aCoach);
            NumCoaches++;
            aCoach.Club = this;
        }

        public override string ToString()
        {
            string clubInfo;
            string swimmers = "";
            string coaches = "";
            if (NumRegistrants != 0)
            {
                for (int i = 0; i < NumRegistrants; i++)
                {
                    swimmers += $"\n\t  {Registrants[i].Name}";
                }
            }
            if (NumCoaches != 0)
            {
                for (int i = 0; i < NumCoaches; i++)
                {
                    coaches += $"\n\t  {Coaches[i].Name}";
                }
            }
            
            clubInfo = $"Name: {Name}\nAddress: {Address.ToString()}\n" +
                $"Phone: {PhoneNumber}\nReg number: {RegistrationNum}" +
                $"\nSwimmers: {swimmers}\nCoaches: {coaches}";

            return clubInfo;
        }
    }
}
