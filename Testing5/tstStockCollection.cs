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
            //TestItem.DownloadOnly = true;
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
            //TestStock.DownloadOnly = true;
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
            //TestItem.DownloadOnly = true;
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
            TestItem.DownloadOnly = true;
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
        [TestMethod]
        public void UpdateMethodOK()
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
            TestItem.DownloadOnly = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestItem.ProductId = PrimaryKey;
            //modify the test record
            TestItem.ProductName = "Gta 4";
            TestItem.UnitPrice = 5.99m;
            TestItem.CurrentStockLevel = 900;
            TestItem.Publisher = "Rock Studios";
            TestItem.Platform = "XBOX";
            TestItem.MinimumRecorderLEvel = 500;
            TestItem.DownloadOnly = true;
            //set the record based on the new test data
            AllStock.ThisStock = TestItem;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test ti see if ThisStock matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create 
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data 
            clsStock TestItem = new clsStock();
            //variable to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.ProductId = 23;
            TestItem.ProductName = "Minecraft";
            TestItem.UnitPrice = 8.99m;
            TestItem.CurrentStockLevel = 2500;
            TestItem.Publisher = "Mojang Studios";
            TestItem.Platform = "PC";
            TestItem.MinimumRecorderLEvel = 1500;
            TestItem.DownloadOnly = true;
            //set ThisStock to the test data
            AllStock.ThisStock = TestItem;
            //add the record 
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data 
            TestItem.ProductId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record 
            AllStock.Delete();
            //now find the record 
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey); 
            //test to see that the record was not found 
            Assert.IsFalse( Found );
        }
        [TestMethod]
        public void ReportByPublisherMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records);
            FilteredStocks.ReportByPublisher("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count );
        }
        [TestMethod]
        public void ReportByPublisherNoneFound()
        {
            //create an instance of the class we want create
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a post code that doesn't exist
            FilteredStocks.ReportByPublisher("xxxxxxxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredStocks.Count);
        }
        [TestMethod]
        public void ReportByPublisherTestDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStocks = new clsStockCollection();
            //variable to store the outcome 
            Boolean OK = true;
            //apply a publisher that doesn't exist
            FilteredStocks.ReportByPublisher("ROCKSTAR GAMES");
            //check that the correct number of records are found
            if (FilteredStocks.Count == 2)
            {
                //check to set that the first record is 50
                if (FilteredStocks.StockList[0].ProductId != 18)
                {
                    OK = false;
                }
                //check to see that the first record is 51
                if (FilteredStocks.StockList[1].ProductId != 28)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
