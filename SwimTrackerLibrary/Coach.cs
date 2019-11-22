using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    public class Coach : Registrant
    {
        private List<Swimmer> swimmers;
        //private const int MAX_NO_SWIMMERS = 20;
        private string credentials;
        public override Club Club { get; set; }
        public string Credentials
        {
            get { return credentials; }
            set { credentials = value; }
        }
        public List<Swimmer> Swimmers
        {
            get { return swimmers; }
            set { swimmers = value; }
        }

        public Coach(string name, DateTime dateOfBirth, Address address, long phoneNo) : base(name, dateOfBirth, address, phoneNo)
        {
            //Swimmers = new List<Swimmer>(MAX_NO_SWIMMERS);
            Swimmers = new List<Swimmer>();
        }
        public Coach()
        {
            Swimmers = new List<Swimmer>();
        }
        public void AddSwimmer(Swimmer aSwimmer)
        {

            if (Club == aSwimmer.Club && !Swimmers.Contains(aSwimmer))
            {
                if (aSwimmer.Coach != this)
                {
                    aSwimmer.Coach = this;
                }
                if (!Swimmers.Contains(aSwimmer))
                {
                    Swimmers.Add(aSwimmer);
                }               
            }
            else if (Club != aSwimmer.Club && Club != null)
            {
                throw new Exception("Coach and swimmer are not in the same club");
            }
            else if (Club == null)
            {
                throw new Exception("Coach is not assigned to a club");
            }
        }

        public override string ToString()
        {
            string res = base.ToString() + $"\n Credentials: {Credentials}\n Swimmers: ";
            for (int i = 0; i < Swimmers.Count; i++)
            {
                res += $"\n\t  {Swimmers[i].Name}";
            }
            return res;
        }


    }
}
