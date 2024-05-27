using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create sine test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductName = "Minecraft";
            TestItem.UnitPrice = 8.99m;
            TestItem.CurrentStockLevel = 2500;
            TestItem.Publisher = "Mojang Studios";
            TestItem.Platform = "PC";
            TestItem.MinimumRecorderLEvel = 1500;
            TestItem.LimitedEdition = "Yes";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.ProductName = "Minecraft";
            TestStock.UnitPrice = 8.99m;
            TestStock.CurrentStockLevel = 2500;
            TestStock.Publisher = "Mojang Studios";
            TestStock.Platform = "PC";
            TestStock.MinimumRecorderLEvel = 1500;
            TestStock.LimitedEdition = "Yes";
            //assign the data to the property 
            AllStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create sine test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.ProductName = "Minecraft";
            TestItem.UnitPrice = 8.99m;
            TestItem.CurrentStockLevel = 2500;
            TestItem.Publisher = "Mojang Studios";
            TestItem.Platform = "PC";
            TestItem.MinimumRecorderLEvel = 1500;
            TestItem.LimitedEdition = "Yes";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the dsame
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set the properties 
            TestItem.ProductName = "Minecraft";
            TestItem.UnitPrice = 8.99m;
            TestItem.CurrentStockLevel = 2500;
            TestItem.Publisher = "Mojang Studios";
            TestItem.Platform = "PC";
            TestItem.MinimumRecorderLEvel = 1500;
            TestItem.LimitedEdition = "Yes";
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
    }
}
