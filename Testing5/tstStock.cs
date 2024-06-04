using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Security.Policy;

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
            Assert.IsTrue( Found );
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
            Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, CurrentStockLevel,Platform,Publisher);
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
    }
}

