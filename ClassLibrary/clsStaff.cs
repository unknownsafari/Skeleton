using System;
namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the Staff id property
        private Int32 mStaffId;
        //StaffId public property
        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }
        //private data member for the house no property
        private string mHouseNo;
        //house no public property
        public string HouseNo
        {
            get
            {
                //this line of code sends data out of the property
                return mHouseNo;
            }
            set
            {
                //this line of code allows data into the property
                mHouseNo = value;
            }
        }
        //private data member for the street property
        private string mStreet;
        //street public property
        public string Street
        {
            get
            {
                //this line of code sends data out of the property
                return mStreet;
            }
            set
            {
                //this line of code allows data into the property
                mStreet = value;
            }
        }
        //private data member for the town property
        private string mTown;
        //town public property
        public string Town
        {
            get
            {
                //this line of code sends data out of the property
                return mTown;
            }
            set
            {
                //this line of code allows data into the property
                mTown = value;
            }
        }
        //private data member for the post code property
        private string mPostCode;
        //post code public property
        public string PostCode
        {
            get
            {
                //this line of code sends data out of the property
                return mPostCode;
            }
            set
            {
                //this line of code allows data into the property
                mPostCode = value;
            }
        }//private data member for the county no property
        private Int32 mCountyCode;
        //county no public property
        public int CountyCode
        {
            get
            {
                //this line of code sends data out of the property
                return mCountyCode;
            }
            set
            {
                //this line of code allows data into the property
                mCountyCode = value;
            }
        }
        //private data member for the date added property
        private DateTime mDateAdded;
        //date added public property
        public DateTime DateAdded
        {
            get
            {
                //this line of code sends data out of the property
                return mDateAdded;
            }
            set
            {
                //this line of code allows data into the property
                mDateAdded = value;
            }
        }
        //private data member for the active property
        private Boolean mActive;
        //active public property
        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }
        /****** FIND METHOD ******/
        public bool Find(int StaffId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mHouseNo = Convert.ToString(DB.DataTable.Rows[0]["GouseNo"]); ;
                mStreet = Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown = Convert.ToString(DB.DataTable.Rows[0]["StaffId"]);
                mPostCode = Convert.ToString (DB.DataTable.Rows[0]["Postcode"]);
                mCountyCode = Convert.ToInt32 (DB.DataTable.Rows[0]["CountryCode"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
