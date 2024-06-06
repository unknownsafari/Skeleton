using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using static System.Net.Mime.MediaTypeNames;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        //good test data 
        //create some test data to pass the method 
        string ProductName = "Minecraft";
        string Publisher = "Mojang Studios";
        string Platform = "PC";
        string MinimumRecorderLevel = 1500.ToString();
        string CurrentStockLevel = 2500.ToString();
        string UnitPrice = 8.99m.ToString();

        [TestMethod]
        public void DownloadOnlyOK()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //create some test data to assign to the property 
            Boolean TestData = true;
            //assign the data to the property
            AStock.DownloadOnly = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.DownloadOnly, TestData);
        }
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }
        [TestMethod]
        public void PublisherOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Ubisoft";
            //assign the data to the property 
            AStock.Publisher = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.Publisher, TestData);
        }
        [TestMethod]
        public void PlatformOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Xbox";
            //assign the data to the property 
            AStock.Platform = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.Platform, TestData);
        }
        [TestMethod]
        public void ProductNameOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "FarCry4";
            //assign the data to the property 
            AStock.ProductName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AStock.ProductName, TestData);
        }
        [TestMethod]
        public void MinimumRecorderOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStock.MinimumRecorderLEvel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.MinimumRecorderLEvel, TestData);
        }
        [TestMethod]
        public void CurrentStockOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AStock.CurrentStockLevel = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.CurrentStockLevel, TestData);
        }
        [TestMethod]
        public void UnitPriceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            decimal TestData = 10.95M;
            //assign the data to the property
            AStock.UnitPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.UnitPrice, TestData);
        }
        [TestMethod]
        public void ProductIdOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AStock.ProductId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.ProductId, TestData);
        }
        /******************Find MEthod Test*******************/
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 ProductId = 23;
            //involve the method
            Found = AStock.Find(ProductId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestProductIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.ProductId != 23)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestProductNameFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product name
            if (AStock.ProductName != "Minecraft")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCurrentStockLevelFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.CurrentStockLevel != 2500)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestUnitPriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.UnitPrice != 8.99m)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestMinimumRecorderFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.MinimumRecorderLEvel != 1500)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPlatformFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.Platform != "PC")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDownloadOnlyFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.DownloadOnly != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPublisherFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductId = 23;
            //invoke the method
            Found = AStock.Find(ProductId);
            //check the product id
            if (AStock.Publisher != "Mojang Studios")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidationMethodOK()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string avariable to store any error message 
            String Error = "";
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = ""; //this should trigger an error 
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "aaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ProductNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductName = "";
            ProductName = ProductName.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = ""; //this should trigger an error 
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "p"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "pp"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "ppppppppppppppppppp"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "pppppppppppppppppppp"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "pppppppppp"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "pppppppppppppppppppp";
            Platform = Platform.PadRight(21, 'p'); //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PlatformExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Platform = "";
            Platform = Platform.PadRight(500, 'p'); //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = ""; //this should trigger an error 
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "b"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "bb"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "bbbbbbbbbbbbbbb"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "";
            Publisher = Publisher.PadRight(31, 'b'); //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PublisherExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Publisher = "";
            Publisher = Publisher.PadRight(500, 'b'); //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = ""; //this should trigger an error 
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 0; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 1; //this should be ok
            //invoke the method     
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 999999; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 1000000; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 500000; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 1000001;//this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 CurrentStockLevel = 100000000; //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel.ToString(), Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CurrentStockLevelInvalidDataType()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CurrentStockLevel = "Not an Integer";//this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = ""; //this should trigger an error 
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 0; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 40; //this should be ok
            //invoke the method     
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 799999; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 800000; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 400000; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 800001;//this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Int32 MinimumRecorderLevel = 100000000; //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel.ToString(), UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void MinimumRecorderLevelInvalidDataType()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string MinimumRecorderLevel = "Candy";//this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method 
            decimal UnitPrice = 0.99m; //this should be ok
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceExtremeMinLessOne()
        {
            //create an instance of the class we want to create 
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method 
            decimal UnitPrice = 0.01m; //this should be ok
            //invoke the method 
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct 
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            decimal UnitPrice = 1.00m; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            Decimal UnitPrice = 1.01m; //this should be ok
            //invoke the method     
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            decimal UnitPrice = 99.99m; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            decimal UnitPrice = 100.00m; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMid()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            decimal UnitPrice = 50.00m; //this should be ok
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            decimal UnitPrice = 101.00m;//this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            decimal UnitPrice = 999999999999.99m; //this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice.ToString(), CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void UnitPriceInvalidDataType()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string UnitPrice = "not a decimal";//this should fail
            //invoke the method
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel, Platform, Publisher);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

