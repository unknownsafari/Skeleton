using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            Int32 TestData = 1;
            TheCustomer.CustomerId = TestData;
            Assert.AreEqual(TheCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            DateTime TestData = new DateTime(2000, 2, 21);
            TheCustomer.DateOfBirth = TestData;
            Assert.AreEqual(TheCustomer.DateOfBirth, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "Mark";
            TheCustomer.FirstName = TestData;
            Assert.AreEqual(TheCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "Zuckerberg";
            TheCustomer.LastName = TestData;
            Assert.AreEqual(TheCustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "markzuckerberg@gmail.com";
            TheCustomer.EmailAddress = TestData;
            Assert.AreEqual(TheCustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void PhoneNumberPropertyOK()
        {
            clsCustomer TheCustomer = new clsCustomer();
            string TestData = "88288828282";
            TheCustomer.PhoneNumber = TestData;
            Assert.AreEqual(TheCustomer.PhoneNumber, TestData);
        }

        [TestMethod]    
        public void FindMethod()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsCustomer TheCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.CustomerId != 1)
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
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.DateOfBirth != Convert.ToDateTime("2000, 2, 21"))
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
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.FirstName != "Mark")
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
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.LastName != "Zuckerberg")
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
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.EmailAddress != "markzuckerberg@gmail.com")
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
            Int32 CustomerId = 1;
            Found = TheCustomer.Find(CustomerId);
            if (TheCustomer.PhoneNumber != "88288828282")
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
            Int32 CustomerId = 1;
            Found= TheCustomer.Find(CustomerId);
            if (TheCustomer.Newsletter != true)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }



}
