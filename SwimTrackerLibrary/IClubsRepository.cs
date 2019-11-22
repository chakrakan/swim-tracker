using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    public interface IClubsRepository
    {
        int Number { set; get; }
        void Add(Club aClub);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
        Club GetByRegNum(int clubNumber);
    }
}
