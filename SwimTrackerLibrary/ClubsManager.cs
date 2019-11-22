using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SwimTrackerLibrary
{
    [Serializable]
    public class ClubsManager : IClubsRepository
    {
        private List<Club> clubs;
        private int numberOfClubs = 0;
        //private const int MAX_NO_CLUBS = 100;
        private SwimmersManager swimmerManager;
        //private const string DELIM = ",";

        //properties
        public List<Club> Clubs
        {
            get { return clubs; }
            set { clubs = value; }
        }
        public int Number
        {
            get { return numberOfClubs; }
            set { numberOfClubs = value; }
        }
        public SwimmersManager SwimmerManager
        {
            get { return swimmerManager; }
            set { swimmerManager = value; }
        }

        //constructor
        public ClubsManager()
        {
            //Clubs = new List<Club>(MAX_NO_CLUBS);
            Clubs = new List<Club>();
            SwimmerManager = new SwimmersManager(this);
        }

        //methods
        public void Add(Club aClub)
        {
            try
            {
                for (int i = 0; i < Number; i++)
                {
                    if (Clubs[i] == aClub)
                    {
                        throw new Exception($"Error: Club {aClub.Name} already exists in clubs-list");
                    }
                }
                Clubs.Add(aClub);
                Number++;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: Clubs list is full!");
            }
        }
        public Club GetByRegNum(int clubNumber)
        {
            Club aClub = null;
            
            for (int i = 0; i < Number; i++ )
            {
                if (Clubs[i].RegistrationNum == clubNumber)
                {
                    aClub = Clubs[i];
                }
            }
            return aClub;
        }
        public void Load(string fileName, string delimiter)
        {
            FileStream inFile = null;
            StreamReader reader = null;
            char DELIM = Convert.ToChar(delimiter);
            int clubID;
            long phoneNum;
            string clubName;
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
                                throw new Exception("Invalid club record. Club number is not valid: ");
                            }

                            if (fields[1] == "")
                            {
                                throw new Exception("Invalid club record. Club name not provided: ");
                            }

                            if (fields[6].Length != 10 || (!(long.TryParse(fields[6], out long testNum))))
                            {
                                throw new Exception("Invalid club record. Phone number wrong format: ");
                            }
                        }
                        catch
                        {
                            throw;
                        }

                        if (int.TryParse(fields[0], out int testID))
                        {
                            for (int i = 0; i < Number; i++)
                            {
                                if (testID == Clubs[i].RegistrationNum)
                                {
                                    throw new Exception("Invalid club record. Club with the registration number already exists: ");
                                }
                            }
                        }
                        //set params for new club
                        clubID = int.Parse(fields[0]);
                        clubName = fields[1];
                        phoneNum = long.Parse(fields[6]);
                        address = new Address(fields[2], fields[3], fields[4], fields[5]);

                        //create new club and add
                        Club aClub = new Club(clubID, clubName, address, phoneNum);
                        Add(aClub);
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
                foreach (var club in Clubs)
                {
                    writer.WriteLine(club.RegistrationNum + delimiter + club.Name + delimiter + club.Address.Street + delimiter + 
                        club.Address.City + delimiter + club.Address.Province + delimiter + club.Address.PostalCode + delimiter + club.PhoneNumber);
                }

            }
            catch
            {
                throw new Exception("Error: Unable to Create ClubsOut file");
            }
            finally
            {
                if (writer != null) writer.Close();
                if (outFile != null) outFile.Close();
            }            
        }

    }
}
