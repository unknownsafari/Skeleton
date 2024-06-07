using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace Testing1
{
    [TestClass]
    public class tstShippingCollection

    {
        private readonly object mThisShipping;

        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipping = new clsShippingCollection();
            //test to see that is exists
            Assert.IsNotNull(AllShipping);
        }

        [TestMethod]
        public void ShippingListOK()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipping = new clsShippingCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsShipment> TestList = new List<clsShipment>();
            //add an item to the list 
            //create the item of test data
            clsShipment TestItem = new clsShipment();
            //set it properties
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.Carrier = "dpd";
            TestItem.TrackingNumber = "123";
            TestItem.ShippingDate = DateTime.Now;
            TestItem.ActualDeliveryDate = DateTime.Now;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllShipping.ShippingList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllShipping.ShippingList, TestList);
        }

        [TestMethod]
        public void ThisShippingPropertyOk()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipping = new clsShippingCollection();
            //create some test data to assign to the property
            clsShipment TestShipping = new clsShipment();
            //set the properties of the test object
            TestShipping.Delivered = true;
            TestShipping.OrderId = 2;
            TestShipping.Carrier = "dpd";
            TestShipping.TrackingNumber = "123";
            TestShipping.ShippingDate = DateTime.Now;
            TestShipping.ActualDeliveryDate = DateTime.Now;
            //assign the data to the property
            AllShipping.ThisShipping = TestShipping;
            //test to see that two values are the same
            Assert.AreEqual(AllShipping.ThisShipping, TestShipping);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsShippingCollection AllShipping = new clsShippingCollection();
            //create some test data to assign to the property
            //in this case the data need to be a list of objects
            List<clsShipment> TestList = new List<clsShipment>();
            //add an item to the list
            //create the item of test data
            clsShipment TestItem = new clsShipment();
            //set it properties
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.Carrier = "dpd";
            TestItem.TrackingNumber = "123";
            TestItem.ShippingDate = DateTime.Now;
            TestItem.ActualDeliveryDate = DateTime.Now;
            TestList.Add(TestItem);
            //assign the data to the property
            AllShipping.ShippingList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllShipping.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        
        {
            //create an instance of the class we want to create
            clsShippingCollection Allshipping = new clsShippingCollection();
            //create the item of the test data
            clsShipment TestItem = new clsShipment();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.Carrier = "ups";
            TestItem.TrackingNumber = "4232323";
            TestItem.ShippingDate = DateTime.Now;
            TestItem.ActualDeliveryDate = DateTime.Now;
            //set This Shipping to test data
            Allshipping.ThisShipping = TestItem;
            //add the record
            PrimaryKey = Allshipping.Add();
            //set the primary key of the test data
            TestItem.ShipmentId = PrimaryKey;
            //find the record
            Allshipping.ThisShipping.Find(PrimaryKey);
            //test to see that two are the same
            Assert.AreEqual(Allshipping.ThisShipping, TestItem);
        }

        public void UpdateMethodOK()
        {
            //create an instance of the clkass we want to create
            clsShippingCollection Allshipping = new clsShippingCollection();
            //create the item of the test data
            clsShipment TestItem = new clsShipment();
            //variable to store primary key
            Int32 PrimaryKey = 0;
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.Carrier = "ups";
            TestItem.TrackingNumber = "4232323";
            TestItem.ShippingDate = DateTime.Now;
            TestItem.ActualDeliveryDate = DateTime.Now;
            //set This Shipping to test data
            Allshipping.ThisShipping = TestItem;
            //add the record
            PrimaryKey = Allshipping.Add();
            //set the primary key of the test data
            TestItem.ShipmentId = PrimaryKey;
            //modify the test record
            TestItem.Delivered = false;
            TestItem.OrderId = 3;
            TestItem.Carrier = "Royal Mail";
            TestItem.TrackingNumber = "4232fr323";
            TestItem.ShippingDate = DateTime.Now;
            TestItem.ActualDeliveryDate = DateTime.Now;
            //set the record based on the new test data
            Allshipping.ThisShipping = TestItem;
            //update the record 
            Allshipping.Update();
            //find the record
            Allshipping.ThisShipping.Find(PrimaryKey);
            //test to see if ThisAddress matches the test data
            Assert.AreEqual(Allshipping.ThisShipping,TestItem);

        }
       
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsShippingCollection AllShipping = new clsShippingCollection();
            //create the item of test data
            clsShipment TestItem = new clsShipment();
            //variable to store the primary key
            Int32 Primarykey = 0;
            TestItem.Delivered = true;
            TestItem.OrderId = 1;
            TestItem.Carrier = "dpd";
            TestItem.TrackingNumber = "4232fr323";
            TestItem.ShippingDate = DateTime.Now;
            TestItem.ActualDeliveryDate = DateTime.Now;
            //set Thisshipping to the test data
            AllShipping.ThisShipping = TestItem;
            //add the record
            Primarykey = AllShipping.Add();
            //set the primary key of the test data
            TestItem.ShipmentId= Primarykey;
            //find the record
            AllShipping.ThisShipping.Find(Primarykey);
            //delete the record
            AllShipping.Delete();
            //now find the record
            Boolean Found = AllShipping.ThisShipping.Find(Primarykey);
            //test to see that the record was not found
            Assert.IsFalse( Found );

        }
        public void ReportbyOrderIdmethodOK()
        {
            clsShippingCollection  AllShipping = new clsShippingCollection();
            clsShippingCollection Filteredshipment = new clsShippingCollection();
            Filteredshipment.ReportbyOrderId("");
            Assert.AreEqual(AllShipping.Count, Filteredshipment.Count);
        }
        public void ReportbyOrderIdNoneFound() 
        {
            clsShippingCollection Filteredshipment = new clsShippingCollection();
            Filteredshipment.ReportbyOrderId("XXX XXXXXXXX");
            Assert.AreEqual(0, Filteredshipment.Count);

        }

    }


}
