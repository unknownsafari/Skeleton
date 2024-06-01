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
            //set the private data members to the test data value
            mCustomerId = 1;
            mDateOfBirth = Convert.ToDateTime("2000, 2, 21");
            mFirstName = "Mark";
            mLastName = "Zuckerberg";
            mEmailAddress = "markzuckerberg@gmail.com";
            mPhoneNumber = "88288828282";
            mNewsletter = true;
            return true;
        }
    }
}