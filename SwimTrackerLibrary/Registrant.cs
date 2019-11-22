using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwimTrackerLibrary
{
    [Serializable]
    public class Registrant
    {
        //fields
        private readonly long registrantId;
        private static int registrantCounter = 1;
        private string name;
        private Address address;
        private DateTime dateOfBirth;
        private long regPhoneNum;
        private Club club;
        private Event regEvent;

        //Constructors
        public Registrant(string name, DateTime dateOfBirth, Address address, long phoneNo)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNo;
            this.address = address;
            registrantId = registrantCounter++;
        }

        public Registrant(int regNum, string name, DateTime dateOfBirth, Address address, long phoneNo)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNo;
            this.address = address;
            registrantId = regNum;
        }
        public Registrant()
        {
            registrantId = registrantCounter++;
        }

        //Properties
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public long RegistrantId
        {
            get { return registrantId; }
        }
        public Event RegEvent
        {
            get { return regEvent; }
            set { regEvent = value; }
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
                    regPhoneNum = value;
                }
            }
            get { return regPhoneNum; }
        }
        public DateTime DateOfBirth
        {
            set { dateOfBirth = value; }
            get { return dateOfBirth; }                
        }
        public virtual Club Club
        {
            get { return club; }

            set
            {
                if (club == null)
                {
                    club = value;
                    Club.AddSwimmer(this);
                }
                else
                {
                    throw new Exception(string.Format("Swimmer is registered with a different club"));
                }
            }
        }

        public Address Address
        {
            get { return this.address; }
            set { address = value; }
        }
        public override string ToString()
        {
            string registrantInfo;
            registrantInfo = $"Name: {Name}\nAddress: {Address.ToString()}\n" +
                $"Phone: {PhoneNumber}\nDOB: {DateOfBirth}\nReg number: {RegistrantId}\n" +
                $"Club: {(Club != null ? Club.Name : "not assigned")}";
            return registrantInfo;
        }
    }
}
