using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member for the product id property
        private int mProductId;

        //productid public property
        public int ProductId
        {
            get
            {
                //this line of code sends data out of the property
                return mProductId;
            }
            set
            {
                //this line of code allows data into the property
                mProductId = value;
            }
        }

        //private data member for the current stock level property
        private int mCurrentStockLevel;

        //current stock level public property
        public int CurrentStockLevel
        {
            get
            {
                //this line of code sends data out of the property
                return mCurrentStockLevel;
            }
            set
            {
                //this line of code allows data into the property
                mCurrentStockLevel = value;
            }
        }

        //private data member for the publisher property
        private string mPublisher;

        //publisher public property
        public string Publisher
        {
            get
            {
                //this line of code sends data out of the property
                return mPublisher;
            }
            set
            {
                //this line of code allows data into the property 
                mPublisher = value;
            }
        }
        //private data member for the platform property
        private string mPlatform;
        //platform public property
        public string Platform
        {
            get
            {
                //this line of code sends data out of the property
                return mPlatform;
            }
            set
            {
                //this line of code allows data into the property 
                mPlatform = value;
            }
        }
        //private data member for the product name property
        private string mProductName;
        //product name public property
        public string ProductName
        {
            get
            {
                //this line of code sends data out of the property
                return mProductName;
            }
            set
            {
                //this line of code allows data into the property 
                mProductName = value;
            }
        }
        //private data member for the minimum recorder level property
        private int mMinimumRecorderLEvel;
        //minimum recorder level public property
        public int MinimumRecorderLEvel
        {
            get
            {
                //this line of code sends data out of the property
                return mMinimumRecorderLEvel;
            }
            set
            {
                //this line of code allows data into the property 
                mMinimumRecorderLEvel = value;
            }
        }
        //private data member for the unit price property
        private decimal mUnitPrice;
        //unit price public property
        public decimal UnitPrice
        {
            get
            {
                //this line of code sends data out of the property
                return mUnitPrice;
            }
            set
            {
                //this line of code allows data into the property 
                mUnitPrice = value;
            }
        }
        //private data member for the download only property
        private bool mDownloadOnly;
        //download only public property
        public bool DownloadOnly
        {
            get
            {
                //this line of code sends data out of the property
                return mDownloadOnly;
            }
            set
            {
                //this line of code allows data into the property 
                mDownloadOnly = value;
            }
        }

        /***************** FIND METHOD *********************/

        public bool Find(int ProductID)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            // add the parameter for the product id to search for
            DB.AddParameter("@ProductId", ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductId");
            //if one record is found (ther should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mProductId = Convert.ToInt32(DB.DataTable.Rows[0]["ProductId"]);
                mCurrentStockLevel = Convert.ToInt32(DB.DataTable.Rows[0]["CurrentStockLevel"]);
                mPublisher = Convert.ToString(DB.DataTable.Rows[0]["Publisher"]);
                mPlatform = Convert.ToString(DB.DataTable.Rows[0]["Platform"]);
                mProductName = Convert.ToString(DB.DataTable.Rows[0]["ProductName"]);
                mMinimumRecorderLEvel = Convert.ToInt32(DB.DataTable.Rows[0]["MinimumRecorderLEvel"]);
                mUnitPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["UnitPrice"]);
                mDownloadOnly = Convert.ToBoolean(DB.DataTable.Rows[0]["DownloadOnly"]);
                //always return true;
                return true;
            }
            // if no record was found 
            else
            {

                //return false indicating there is a problem 
                return false;
            }
        }

        public string Valid(string productName, string minimumRecorderLevel, string unitPrice, string currentStockLevel, string platform, string publisher)
        {
            //creating a datatype for parse
            int currentStockLevelInt;
            int minimumRecorderLevelInt;
            decimal unitPriceDecimal;
            //create a string variable to store the error
            String Error = "";
            //if the ProductName is blank 
            if (productName.Length == 0)
            {
                //record the error 
                Error = Error + "The product name may not be blank : ";
            }
            //if the product name is greater than 50 characters
            if (productName.Length > 50)
            {
                //record the error 
                Error = Error + "The product name must be less than 50 characters : ";
            }
            //if the platform is blank
            if (platform.Length == 0)
            {
                //record the error 
                Error = Error + "The platform may not be blank :";
            }
            //if the platform is greater than 20 characters
            if (platform.Length > 20)
            {
                //record the error 
                Error = Error + "The platform must be less than 20 characters :";
            }
            //if the publisher is blank
            if (publisher.Length == 0)
            {
                //record the error 
                Error = Error + "The publisher may not be blank :";
            }
            //if the publisher is greater than 20 characters
            if (publisher.Length > 30)
            {
                //record the error 
                Error = Error + "The publisher must be less than 20 characters :";
            }
            //if the current stock level is not int, less than zero and greater than 1000000
            if (!int.TryParse(currentStockLevel, out currentStockLevelInt))
            {
                //record the error
                Error = Error + "Current Stock Level must be a number : ";
            }
            else
            {
                //add your existing validation for currentStockLevel here
                if (currentStockLevelInt < 0)
                {
                    // record the error
                    Error = Error + "Current Stock Level may not be blank : ";
                }

                if (currentStockLevelInt > 1000000)
                {
                    // record the error
                    Error = Error + "Current stock level must be less than 1000000";
                }
            }
            //if the minimum recorder level is not int, less than 40 and greater than 8000000
            if (!int.TryParse(minimumRecorderLevel, out minimumRecorderLevelInt))
            {
                //record the error
                Error = Error + "Minimum recorder Level must be a number : ";
            }
            else
            {
                //add your existing validation for currentStockLevel here
                if (minimumRecorderLevelInt < 40)
                {
                    // record the error
                    Error = Error + "Minimum recorder Level must not be less than 40 : ";
                }

                if (minimumRecorderLevelInt > 1000000)
                {
                    // record the error
                    Error = Error + "Minimum recorder level must be less than 1000000";
                }
            }
            //if the unit price is not decimal, less than 0 and greater than 100
            if (decimal.TryParse(unitPrice, out unitPriceDecimal))
            {
                if (unitPriceDecimal <= 0)
                {
                    // record the error
                    Error = Error + "Unit Price must be greater than zero : ";
                }

                // Assuming 100.00 is the maximum unit price
                if (unitPriceDecimal > 100.00m)
                {
                    // record the error
                    Error = Error + "Unit Price must be less than or equal to 100.00";
                }
            }
            else
            {
                // record the error
                Error = Error + "Unit Price must be a decimal number";
            }
            //return any error messages
            return Error;
        }
    }
}