using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data member for the customer id propery
        private Int32 mCustomerId;

        public int CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        private DateTime mDateOfBirth;

        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }

        private String mFirstName;

            public string FirstName
        {
            get
            {
                return mFirstName;

            }
            set
            {
                mFirstName = value;
            }
        }

        private String mLastName;

        public string LastName
        {
            get
            {
                return mLastName;

            }
            set
            {
                mLastName = value;
            }
        }

        private String mEmailAddress;

        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }

        private String mPhoneNumber;

        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;

            }
            set
            {
                mPhoneNumber = value;
            }
        }

        private Boolean mNewsletter;

        public bool Newsletter
        {
            get
            {
                return mNewsletter;

            }
            set
            {
                mNewsletter = value;
            }
        }

        
       
        
        
        
        
       

        public bool Find(int customerId)
        {
            //create an instance of the data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@CustomerId", customerId);
            //execute the store procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should either be one or zero)
            if (DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mNewsletter = Convert.ToBoolean(DB.DataTable.Rows[0]["NewsletterSubscription"]);
                //always return true
                return true;
            }
            //if no record was found 
            else

            { 
                return false; 
            
            }
        }

        public string Valid(string firstName, string lastName, string emailAddress, string dateOfBirth, string phoneNumber)
        {
            return "";
        }
    }
}