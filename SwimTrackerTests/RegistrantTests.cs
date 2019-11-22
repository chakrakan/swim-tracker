using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SwimTrackerLibrary;

namespace SwimTrackerTests
{
    [TestClass]
    public class RegistrantTests
    {
        [TestMethod]
        public void Test_Registrant_ChangeClubUsingProperty()
        {
            Club club1 = new Club();
            Registrant swimmer1 = new Registrant();
            Club club2 = new Club();
            try
            {
                swimmer1.Club = club1;
                swimmer1.Club = club2;
                Assert.Fail("None");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is System.Exception);
            }
        }

        [TestMethod]
        public void Test_Registrant_EmptyValues()
        {
            Registrant swimmer1 = new Registrant();
            string expectedResult = $"Name: {swimmer1.Name}\nAddress: {swimmer1.Address.ToString()}\n" +
                $"Phone: {swimmer1.PhoneNumber}\nDOB: {swimmer1.DateOfBirth}\nReg number: {swimmer1.RegistrantId}\n" +
                $"Club: not assigned";

            Assert.AreEqual(expectedResult, swimmer1.ToString());
        }

        [TestMethod]
        public void Test_Registrant_NameProperty()
        {
            Registrant swimmer1 = new Registrant();
            string expectedResult = "Johnny";
            swimmer1.Name = "Johnny";

            Assert.AreEqual(expectedResult, swimmer1.Name);
        }

        [TestMethod]
        public void Test_Registrant_ToString()
        {
            Registrant swimmer1 = new Registrant("Bob Smith", new DateTime(1970, 1, 1),
                                                    new Address("35 Elm St", "Toronto", "ON", "M2M 2M2"), 4164588700);
            string expectedResult = $"Name: {swimmer1.Name}\nAddress: {swimmer1.Address.ToString()}\n" +
                $"Phone: {swimmer1.PhoneNumber}\nDOB: {swimmer1.DateOfBirth}\nReg number: {swimmer1.RegistrantId}\n" +
                $"Club: {(swimmer1.Club != null ? swimmer1.Club.Name : "not assigned")}";

            Assert.AreEqual(expectedResult, swimmer1.ToString());
        }
    }
}
