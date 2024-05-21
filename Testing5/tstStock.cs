using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Policy;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
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
        public void ProductIDOK()
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
    }
}

