using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimTrackerLibrary
{
    [Serializable]
    public struct Address
    {
        public string Street;
        public string City;
        public string Province;
        public string PostalCode;
        public Address(string street, string city, string province, string postalCode)
        {
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.PostalCode = postalCode;
        }
        public override string ToString()
        {
            string result = $"\n\t {Street} \n\t {City} \n\t {Province} \n\t {PostalCode}";
            return result;
        }
    };
}
