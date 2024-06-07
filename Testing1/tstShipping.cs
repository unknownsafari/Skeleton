using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing1
{



    [TestClass]
    public class tstShipment
    {
        //good test data
        //create some test data to pass the method
        string Carrier = "Yodel";
        string TrackingNumber = "123456";
        string ShippingDate = DateTime.Now.ToString();
        string ActualDeliveryDate = DateTime.Now.ToString();
        string OrderId = "1"; // this should be ok


        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //test to see that it exists
            Assert.IsNotNull(AnShipment);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnShipment.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.Active, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnShipment.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.DateAdded, TestData);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnShipment.OrderId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.OrderId, TestData);
        }

        [TestMethod]
        public void CarrierPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            string TestData = "FedEx";
            //assign the data to the property
            AnShipment.Carrier = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.Carrier, TestData);
        }

        [TestMethod]
        public void TrackingNOPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            string TestData = "3tve57892";
            //assign the data to the property
            AnShipment.TrackingNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.TrackingNumber, TestData);
        }

        [TestMethod]
        public void ShippingDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Parse("09/02/2024"); // Convert string to DateTime
            //assign the data to the property
            AnShipment.ShippingDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.ShippingDate, TestData);
        }

        [TestMethod]
        public void ActualDeliveryDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Parse("12/02/2024");
            //assign the data to the property
            AnShipment.ActualDeliveryDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.ActualDeliveryDate, TestData);
        }

        [TestMethod]
        public void DeliveredPropertyOK()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnShipment.Delivered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnShipment.Delivered, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Int32 ShipmentId = 5;
            Found = AnShipment.Find(ShipmentId);
            Assert.IsTrue(Found);


        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 5;
            Found = AnShipment.Find(OrderId);
            if (AnShipment.OrderId != 5)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestCarrierIdFound()
        {
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Boolean OK = true;
            int ShippmentId = 5;
            Found = AnShipment.Find(ShippmentId);
            if (AnShipment.Carrier != "yodel")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestTrackingNoFound()
        {
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Boolean OK = true;
            int ShipmentId = 5;
            Found = AnShipment.Find(ShipmentId);
            if (AnShipment.TrackingNumber != "432433")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestShippingDateFound()
        {
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Boolean OK = true;
            int ShipmentId = 5;
            Found = AnShipment.Find(ShipmentId);
            if (AnShipment.ShippingDate != Convert.ToDateTime("20/08/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActualDeliveryDateFound()
        {
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Boolean OK = true;
            int ShipmentId = 5;
            Found = AnShipment.Find(ShipmentId);
            if (AnShipment.ActualDeliveryDate != Convert.ToDateTime("23/08/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDeliveredIdFound()
        {
            // Arrange
            clsShipment AnShipment = new clsShipment();
            Boolean Found = false;
            Boolean OK = true;
            int ShipmentId = 5;

            // Act
            Found = AnShipment.Find(ShipmentId);

            // Assert
            if (AnShipment.Delivered != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store an error message
            String Error = "";
            //invoke the method
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
  
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CarrierNoMinPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string Carrier = "aa"; // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CarrierNoMaxLessOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string Carrier = new string('a', 49); // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CarrierNoMax()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string Carrier = new string('a', 50); // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CarrierNoMid()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string Carrier = "aaa"; // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void CarrierNoMaxPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string Carrier = new string('a', 51); // This should trigger an error
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void CarrierNoExtremeMax()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string Carrier = new string('a', 500); // This should trigger an error
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ShippingDateExtremeMin()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date.AddYears(-100);
            string ShippingDate = TestDate.ToString("yyyy-MM-dd"); // Ensure consistent date format
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ShippingDateMinLessOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date.AddDays(-1);
            string ShippingDate = TestDate.ToString("yyyy-MM-dd"); // Ensure consistent date format
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ShippingDateMin()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string ShippingDate = TestDate.ToString();
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ShippingDateMinPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date.AddDays(1);
            string ShippingDate = TestDate.ToString();
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ShippingDateExtremeMax()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date.AddYears(100);
            string ShippingDate = TestDate.ToString("yyyy-MM-dd"); // Ensure consistent date format
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }




        [TestMethod]
        public void TrackingNumberMinPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string TrackingNumber = "aa"; // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void TrackingNumberMaxLessOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string TrackingNumber = new string('a', 49); // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void TrackingNumberMax()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string TrackingNumber = new string('a', 50); // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void TrackingNumberMid()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string TrackingNumber = "aaa"; // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate); ;
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void TrackingNumberMaxPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string TrackingNumber = new string('a', 51); // This should trigger an error
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void TrackingNumberExtremeMax()
        {
            clsShipment AnShipment = new clsShipment();
            String Error = "";
            string TrackingNumber = new string('a', 500); // This should trigger an error
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

   
        [TestMethod]
        public void ActualDeliveryDateExtremeMin()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-101);
            //convert the date variable to a string variable
            string ActualDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void ActualDeliveryDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ActualDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ActualDeliveryDateMin()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ActualDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ActualDeliveryDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ActualDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            //test to see that the result is correct
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void ActualDeliveryDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsShipment AnShipment = new clsShipment();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(101);
            //convert the date variable to a string variable
            string ActualDeliveryDate = TestDate.ToString();
            //invoke the method
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            //test to see that the result is correct
            Assert.AreNotEqual("", Error);
        }


        [TestMethod]
        public void OrderIdNoMinPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string OrderId = "a"; // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderIdNoMaxLessOne()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string OrderId = new string('a', 49); // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderIdNoMax()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string OrderId = new string('a', 50); // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate) ;
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderIdNoMid()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string OrderId = "aaa"; // this should be ok
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreEqual("", Error);
        }

        [TestMethod]
        public void OrderIdNoMaxPlusOne()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string OrderId = new string('a', 51); // This should trigger an error
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }

        [TestMethod]
        public void OrderIdNoExtremeMax()
        {
            clsShipment AnShipment = new clsShipment();
            string Error = "";
            string OrderId = new string('a', 500); // This should trigger an error
            Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
            Assert.AreNotEqual("", Error);
        }
    }
}










