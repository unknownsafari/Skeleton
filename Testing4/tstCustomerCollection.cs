using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Testing4
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection allCustomers = new clsCustomerCollection();
            //test to see that exists
            Assert.IsNotNull(allCustomers);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this casee the data needs to be a list of object 
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list 
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            // set its properties 
            TestItem.NewsletterSubscription = true;
            TestItem.CustomerId = 1;
            TestItem.PhoneNumber = "222222";
            TestItem.DateOfBirth = new DateTime(1999, 03, 05);
            TestItem.FirstName = "Nirmal";
            TestItem.LastName = "Krishna";
            TestItem.EmailAddress = "NirmalKrishna@gmail.com";
            //add the item to the test list
            TestList.Add(TestItem);
            
            //assign the data to the property 
            AllCustomers.CustomerList = TestList;
            //test to see that the two value are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property 
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.NewsletterSubscription = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.PhoneNumber = "222222";
            TestCustomer.DateOfBirth = new DateTime(1999, 03, 05);
            TestCustomer.FirstName = "Nirmal";
            TestCustomer.LastName = "Krishna";
            TestCustomer.EmailAddress = "NirmalKrishna@gmail.com";
            //assign the data to the property 
            AllCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

       

       

    }
}
