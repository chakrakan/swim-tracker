using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    public interface ISwimmersRepository
    {
        int Number { set; get; }
        void Add(Registrant aSwimmer);
        void Load(string fileName, string delimiter);
        void Save(string fileName, string delimiter);
        Registrant GetByRegNum(int regNum);
    }
}
