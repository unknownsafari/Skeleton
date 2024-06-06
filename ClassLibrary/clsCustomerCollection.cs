using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {


        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }


        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {
                //for later
            }
        }
        public clsCustomer ThisCustomer { get; set; }

        public clsCustomerCollection()
        {
            //variable for the index 
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure 
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsCustomer TheCustomer = new clsCustomer();
                //read in the fields for the current record 
                TheCustomer.NewsletterSubscription = Convert.ToBoolean(DB.DataTable.Rows[Index]["NewsletterSubscription"]);
                TheCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                TheCustomer.PhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNumber"]);
                TheCustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfBirth"]);
                TheCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                TheCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                TheCustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                //add the record to the private data member
                mCustomerList.Add(TheCustomer);
                //point at the next record
                Index++;
            }
        }
    }


}


