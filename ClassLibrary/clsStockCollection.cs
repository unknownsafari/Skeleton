using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //private data member for the list 
        List<clsStock> mStockList = new List<clsStock>();
        //private member data for Thisstock
        clsStock mThisStock = new clsStock();
        //public property for the stock list 
        public List<clsStock> StockList
        {
            get
            {
                //return the private data 
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        }
        //public  property for count 
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about it later
            }
        }
        //public property to ThisStock
        public clsStock ThisStock
        {
            get
            {
                //return the private data 
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }
        }

        //constructor for the class 
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the daa connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records to process 
            while (Index < RecordCount)
            {
                //create a blank stock 
                clsStock AStock =new clsStock();
                //read in the fields for the current record
                AStock.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                AStock.ProductId = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductId"]);
                AStock.Publisher = Convert.ToString(DB.DataTable.Rows[Index]["Publisher"]);
                AStock.Platform = Convert.ToString(DB.DataTable.Rows[Index]["Platform"]);
                AStock.UnitPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["UnitPrice"]);
                AStock.CurrentStockLevel = Convert.ToInt32(DB.DataTable.Rows[Index]["CurrentStockLevel"]);
                AStock.MinimumRecorderLEvel = Convert.ToInt32(DB.DataTable.Rows[Index]["MinimumRecorderLEvel"]);
                AStock.LimitedEdition = Convert.ToString(DB.DataTable.Rows[Index]["LimitedEdition"]);
                //add the record to the privare data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisSstock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductName", mThisStock.ProductName);
            DB.AddParameter("@CurrentStockLevel", mThisStock.CurrentStockLevel);
            DB.AddParameter("@UnitPrice", mThisStock.UnitPrice);
            DB.AddParameter("@MinimumRecorderLEvel", mThisStock.MinimumRecorderLEvel);
            DB.AddParameter("@Platform", mThisStock.Platform);
            DB.AddParameter("@Publisher", mThisStock.Publisher);

            //execute the query returning the primary key value 
            return DB.Execute("sproc_tblStock_Insert");
        }
    }
}