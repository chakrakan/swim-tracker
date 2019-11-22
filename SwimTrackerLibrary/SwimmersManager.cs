using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SwimTrackerLibrary
{
    public class SwimmersManager : ISwimmersRepository
    {
        private List<Registrant> swimmers;
        private int numberOfSwimmers = 0;
        //private const int MAX_NO_SWIMMERS = 100;
        private ClubsManager clubManager;
        //private const string DELIM = ",";

        //properties
        public List<Registrant> Swimmers
        {
            get { return swimmers; }
            set { swimmers = value; }
        }
        public int Number
        {
            get { return numberOfSwimmers; }
            set { numberOfSwimmers = value; }
        }
        public ClubsManager ClubManager
        {
            get { return clubManager; }
            set { clubManager = value; }
        }

        //constructor
        public SwimmersManager(ClubsManager clubManager)
        {
            //Swimmers = new List<Registrant>(MAX_NO_SWIMMERS);
            Swimmers = new List<Registrant>();
            ClubManager = clubManager;
        }

        //methods
        public void Add(Registrant aRegistrant)
        {
            try
            {
                for (int i = 0; i < Number; i++)
                {
                    if (Swimmers[i] == aRegistrant)
                    {
                        throw new Exception($"Error: Club {aRegistrant.Name} already exists in clubs-list");
                    }
                }
                Swimmers.Add(aRegistrant);
                Number++;

                //checking to see if swimmers club exists in clubmanager clubs
                //if not, create new club without provided id from text file
                bool clubExists = false;

                foreach (Club club in ClubManager.Clubs)
                {
                    if (aRegistrant.Club == club)
                    {
                        clubExists = true;
                    }                        
                }

                if (!clubExists && aRegistrant.Club != null)
                {
                    ClubManager.Add(aRegistrant.Club);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Clubs list is full!");
            }
        }
        public Registrant GetByRegNum(int regNum)
        {
            Registrant aRegistrant = null;

            for (int i = 0; i < Number; i++)
            {
                if (Swimmers[i].RegistrantId == regNum)
                {
                    aRegistrant = Swimmers[i];
                }
            }
            return aRegistrant;
        }
        public void Load(string fileName, string delimiter)
        {
            FileStream inFile = null;
            StreamReader reader = null;
            char DELIM = Convert.ToChar(delimiter);
            int id;
            string name;
            DateTime dob;
            long phoneNum;
            Address address;

            string[] fields;

            try
            {
                inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                string recordIn = reader.ReadLine();
                while (recordIn != null)
                {
                    try
                    {
                        fields = recordIn.Split(DELIM);
                        try
                        {
                            //check for mandatory fields
                            if (fields[0] == "" || (!int.TryParse(fields[0], out int regNum)))
                            {
                                throw new Exception("Invalid swimmer record. Invalid registration number: ");
                            }

                            if (fields[1] == "")
                            {
                                throw new Exception("Invalid swimmer record. Invalid swimmer name: ");
                            }

                            if (fields[2] == "" || (!DateTime.TryParse(fields[2], out DateTime Dob)))
                            {
                                throw new Exception("Invalid swimmer record. Birth date is invalid: ");
                            }

                            if (fields[7].Length != 10 || (!(long.TryParse(fields[7], out long testNum))))
                            {
                                throw new Exception("Invalid swimmer record. Phone number wrong format: ");
                            }
                        }
                        catch
                        {
                            throw;
                        }

                        id = int.Parse(fields[0]);
                        name = fields[1];
                        dob = DateTime.Parse(fields[2]);
                        phoneNum = long.Parse(fields[7]);
                        address = new Address(fields[3], fields[4], fields[5], fields[6]);

                        //create new swimmer
                        Registrant aSwimmer = new Registrant(id, name, dob, address, phoneNum);                     


                        if (int.TryParse(fields[0], out int testID))
                        {
                            for (int i = 0; i < Number; i++)
                            {
                                if (testID == Swimmers[i].RegistrantId)
                                {
                                    throw new Exception("Invalid swimmer record. Swimmer with the registration number already exists: ");
                                }
                            }
                        }
          
                        if (fields[8] != "")
                        {
                            int clubNum = int.Parse(fields[8]);
                            if (clubNum != 0)
                            {
                                for (int i = 0; i < ClubManager.Number; i++)
                                {
                                    if (ClubManager.Clubs[i].RegistrationNum == clubNum)
                                    {
                                        ClubManager.Clubs[i].AddSwimmer(aSwimmer);
                                        break;
                                    }
                                }
                            }
                        }

                        Add(aSwimmer);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"{e.Message} \n\t{recordIn}");
                    }
                    recordIn = reader.ReadLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (inFile != null)
                {
                    inFile.Close();
                }
            }
        }

        public void Save(string fileName, string delimiter)
        {
            FileStream outFile = null;
            StreamWriter writer = null;
            try
            {
                outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);
                foreach (var swimmer in Swimmers)
                {
                    string clubId;
                    if (swimmer.Club == null)
                    {
                        clubId = "";
                    }
                    else
                    {
                        clubId = swimmer.Club.RegistrationNum.ToString();
                    }
                    writer.WriteLine(swimmer.RegistrantId + delimiter + swimmer.Name + delimiter +
                        swimmer.DateOfBirth + delimiter + swimmer.Address.Street + delimiter +
                        swimmer.Address.City + delimiter + swimmer.Address.Province + delimiter +
                        swimmer.Address.PostalCode + delimiter + swimmer.PhoneNumber + delimiter + clubId);

                }
            }
            catch
            {
                throw new Exception("Error: Unable to create SwimmersOut File");
            }
            finally
            {
                if (writer != null) writer.Close();
                if (outFile != null) outFile.Close();
            }
        }
    }
}
