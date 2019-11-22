using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    //Testing all struct properties & GetAddress method

    [TestClass]
    public class AddressTests
    {
        [TestMethod]
        public void Test_Address_StreetProperty()
        {
            string expectedResult = "7 Caley Terrace";
            Address address = new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3");
            Assert.AreEqual(expectedResult, address.Street);
        }

        [TestMethod]
        public void Test_Address_CityProperty()
        {
            string expectedResult = "Toronto";
            Address address = new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3");
            Assert.AreEqual(expectedResult, address.City);
        }

        [TestMethod]
        public void Test_Address_ProvinceProperty()
        {
            string expectedResult = "ON";
            Address address = new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3");
            Assert.AreEqual(expectedResult, address.Province);
        }

        [TestMethod]
        public void Test_Address_PostalCodeProperty()
        {
            string expectedResult = "M1E 5E3";
            Address address = new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3");
            Assert.AreEqual(expectedResult, address.PostalCode);
        }

        [TestMethod]
        public void Test_Address_ToString()
        {
            Address address = new Address("7 Caley Terrace", "Toronto", "ON", "M1E 5E3");
            string expectedResult = $"\n\t {address.Street} \n\t {address.City} \n\t {address.Province} \n\t {address.PostalCode}";
            Assert.AreEqual(expectedResult, address.ToString());
        }
    }
}
