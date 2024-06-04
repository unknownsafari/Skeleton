using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tststaff
    {
        private bool OK;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to creat
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //test to see that is exists
            Assert.IsNotNull(AnStaff);
        }
        [TestMethod]
        public void ActiveProretyOK()
        { //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }
        [TestMethod]
        public void StaffIDPropertyOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }
        [TestMethod]
        public void CountyCodePropertyOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.CountyCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.CountyCode, TestData);
        }
        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnStaff.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.HouseNo, TestData);
        }
        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnStaff.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.PostCode, TestData);
        }
        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            AnStaff.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Town, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //test to see if the result is true
            if(AnStaff.DateAdded !=Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the Staff id property
            if (AnStaff.StaffId != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHouseNoFound()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the house no property
            if (AnStaff.HouseNo != "123")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the street property
            if (AnStaff.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the town property
            if (AnStaff.Town != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the post code property
            if (AnStaff.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCountyCodeFound()
        {
            //create an instance of the class we want to create
            ClassLibrary.clsStaff AnStaff = new ClassLibrary.clsStaff();
            //create a boolean variable to store the result of the search
            Boolean Found = false;
            //create a boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StaffId = 21;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the county code property
            if (AnStaff.CountyCode != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }




    }
}
