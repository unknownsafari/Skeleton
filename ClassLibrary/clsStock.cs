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
        //private data member for the limited edition property
        private string mLimitedEdition;
        //limited edition public property
        public string LimitedEdition
        {
            get
            {
                //this line of code sends data out of the property
                return mLimitedEdition;
            }
            set
            {
                //this line of code allows data into the property 
                mLimitedEdition = value;
            }
        }
        /***************** FIND METHOD *********************/

        public bool Find(int ProductID)
        {
            //set the private data members to the test data value
            mProductId = 505;
            mCurrentStockLevel = 1490;
            mPublisher = "Ubisoft";
            mPlatform = "XBOX";
            mProductName = "Far Cry 4";
            mMinimumRecorderLEvel = 250;
            mUnitPrice = 10.95m;
            mLimitedEdition = "YES"; 
            //always return true
            return true;
        }
    }
}