using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net.Mail;

namespace Testing4
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass the method
        String FirstName = "Nikhil";
        String LastName = "Kumar";
        String EmailAddress = "NikhilKumar@gmail.com";
        String DateOfBirth = new DateTime(1999, 03, 05).ToShortDateString();
        String PhoneNumber = "62626262";

      
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
            TheCustomer.NewsletterSubscription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(TheCustomer.NewsletterSubscription, TestData);
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
            if (TheCustomer.NewsletterSubscription != false)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void FirstNameMinLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string FirstName = ""; // This should trigger an error
                                   // Invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            // Test to see that the result is not an empty string (i.e., an error message is expected)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "a"; //this should be ok
                                    //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aa"; //this should be ok
                                    //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                     //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                                     //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                                  //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void FirstNameMaxPlusOne()

        { 
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string FirstName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; 
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]

        public void FirstNameExtremeMax()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string LastName = ""; // This should trigger an error
                                   // Invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            // Test to see that the result is not an empty string (i.e., an error message is expected)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "a"; //this should be ok
                                    //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aa"; //this should be ok
                                     //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                                 //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                              //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                            //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void LastNameMaxPlusOne()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]

        public void LastNameExtremeMax()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string FirstName = "";
            FirstName = LastName.PadRight(500, 'a');
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void EmailAddressMinLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string EmailAddress = ""; // This should trigger an error
                                  // Invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            // Test to see that the result is not an empty string (i.e., an error message is expected)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMin()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "a"; //this should be ok
                                   //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aa"; //this should be ok
                                    //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                                //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMax()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                                             //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailAddressMid()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
                                                           //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void EmailAddressMaxPlusOne()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string EmailAddress = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]

        public void EmailAddressExtremeMax()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string EmailAddress = "";
            FirstName = LastName.PadRight(500, 'a');
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }



        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            // Create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            // String variable to store any error message
            String Error = "";
            // Create some test data to pass to the method
            string PhoneNumber = ""; // This should trigger an error
                                      // Invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            // Test to see that the result is not an empty string (i.e., an error message is expected)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "11111111"; //this should be ok
                                       //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "11"; //this should be ok
                                        //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "1111111"; //this should be ok
                                                                                    //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "11111111"; //this should be ok
                                                                                 //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PhoneNumber = "1111"; //this should be ok
                                                               //invoke the method
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void PhoneNumberMaxPlusOne()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string PhoneNumber = "111111111";
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]

        public void PhoneNumberExtremeMax()

        {
            //create an instance of the class we want to create
            clsCustomer TheCustomer = new clsCustomer();
            //String variable to store any error message 
            String Error = "";
            //create some test to pass to the method 
            string PhoneNumber = "";
            FirstName = LastName.PadRight(500, '1');
            //invoke the method 
            Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, DateOfBirth, PhoneNumber);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }


       
    }






}
