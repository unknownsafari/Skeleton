using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Mail;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {

      
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Assert.IsNotNull(TheCustomer);
        }

        [TestMethod]
        public void NewsletterPropertyOK()
        {
            //create an insatance of the class we want to create 
            clsCustomer TheCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            TheCustomer.Newsletter = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TheCustomer.Newsletter, TestData);
        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {  
            clsCustomer TheCustomer = new clsCustomer();
            Int32 TestData = 6;
            TheCustomer.CustomerId = TestData;
            Assert.AreEqual(TheCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            DateTime TestData = new DateTime(1999, 03, 05);
            TheCustomer.DateOfBirth = TestData;
            Assert.AreEqual(TheCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "Nirmal";
            TheCustomer.FirstName = TestData;
            Assert.AreEqual(TheCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "Nikhil";
            TheCustomer.LastName = TestData;
            Assert.AreEqual(TheCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "NirmalNikhil@gmail.com";
            TheCustomer.EmailAddress = TestData;
            Assert.AreEqual(TheCustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "66666666";
            TheCustomer.PhoneNumber = TestData;
            Assert.AreEqual(TheCustomer.PhoneNumber, TestData);
        }

        [TestMethod]    
        public void FindMethod()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 6;
            Found = TheCustomer.Find(CustomerId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.CustomerId != 2)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateOfBirthFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.DateOfBirth != Convert.ToDateTime("09/03/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestFirstNameFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.FirstName != "Matthew")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestLastNameFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.LastName != "Jeffery")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestEmailAddressFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.EmailAddress != "MatthewJef1558@gmail.com")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestPhoneNumberFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.PhoneNumber != "66666666")
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNewsletterFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 2;
            Found= TheCustomer.Find(CustomerId);
            if (TheCustomer.Newsletter != false)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

       
    }



}
