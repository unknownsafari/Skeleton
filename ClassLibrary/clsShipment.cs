using System;
using System.Threading;


namespace ClassLibrary
{
    public class clsShipment
    {
        private Int32 mShipmentId;
        public Int32 ShipmentId
        {
            get
            {
                return mShipmentId;
            }
            set
            {
                mShipmentId = value;
            }
        }
        private Int32 mOrderId;
        public Int32 OrderId
        {

            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }

        }
        private string mCarrier;
        public string Carrier
        {
            get
            {
                return mCarrier;
            }
            set
            {
                mCarrier = value;
            }
        }
        private string mTrackingNumber;
        public string TrackingNumber
        {
            get
            {
                return mTrackingNumber;
            }
            


            set
            {
                mTrackingNumber = value;
            }
        }
        private DateTime mShippingDate;
        public DateTime ShippingDate
        {
            get
            {
                return mShippingDate;
            }
            set
            {
                mShippingDate = value;
            }


        }
        private DateTime mActualDeliveryDate;
        public DateTime ActualDeliveryDate

        {
            get
            {
                return mActualDeliveryDate;
            }
            set
            {
                mActualDeliveryDate = value;
            }

        }
        private bool mDelivered;
        public bool Delivered
        {
            get
            {
                return mDelivered;
            }
            set
            {
                mDelivered = value;
            }
        }
        //private data member for the data added property
        private DateTime mDateAdded;
        //dataAdded public property
        public DateTime DateAdded

        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        public Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }



        public bool Find(int ShipmentId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ShipmentId", ShipmentId);
            DB.Execute("sproc_tblShipment_FilterByShipmentId");
            if (DB.Count == 1)
            {

                mShipmentId = Convert.ToInt32(DB.DataTable.Rows[0]["ShipmentId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCarrier = Convert.ToString(DB.DataTable.Rows[0]["Carrier"]);
                mTrackingNumber = Convert.ToString(DB.DataTable.Rows[0]["TrackingNumber"]);
                mShippingDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ShippingDate"]);
                mActualDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ActualDeliverydate"]);
                mDelivered = Convert.ToBoolean(DB.DataTable.Rows[0]["Delivered"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["ActualDeliverydate"]);

                return true;


            }
            else
            {
                return false;
            }

        }
        public string Valid(string OrderID, string Carrier, string TrackingNumber, string ShippingDate, string ActualDeliveryDate)
        {
            String Error = "";

            // OrderID validation
            if (string.IsNullOrEmpty(OrderID))
            {
                Error += "The OrderID may not be blank: ";
            }
            else if (OrderID.Length > 50)
            {
                Error += "The OrderID must be less than 50 characters: ";
            }

            // Carrier validation
            if (string.IsNullOrEmpty(Carrier))
            {
                Error += "The Carrier may not be blank: ";
            }
            else if (Carrier.Length > 50)
            {
                Error += "The Carrier must be less than 50 characters: ";
            }

            // TrackingNumber validation
            if (string.IsNullOrEmpty(TrackingNumber))
            {
                Error += "The TrackingNumber may not be null or empty: ";
            }
            else if (TrackingNumber.Length > 50)
            {
                Error += "The TrackingNumber must be less than 50 characters: ";
            }

            // Date validation
            DateTime DateTemp;
            DateTime extremeMinDate = DateTime.Now.Date.AddYears(-100);
            DateTime extremeMaxDate = DateTime.Now.Date.AddYears(100);

            // Shipping Date Validation
            if (string.IsNullOrEmpty(ShippingDate))
            {
                Error += "The shipping date may not be blank: ";
            }
            else if (!DateTime.TryParse(ShippingDate, out DateTemp))
            {
                Error += "The shipping date is not a valid date: ";
            }
            else
            {
                if (DateTemp < extremeMinDate || DateTemp > extremeMaxDate)
                {
                    Error += "The shipping date is out of valid range: ";
                }
                else if (DateTemp < DateTime.Now.Date)
                {
                    Error += "The shipping date cannot be in the past: ";
                }
                else if (DateTemp > DateTime.Now)
                {
                    Error += "The shipping date cannot be in the future: ";
                }
            }

            // Actual Delivery Date Validation
            if (!string.IsNullOrEmpty(ActualDeliveryDate))
            {
                if (!DateTime.TryParse(ActualDeliveryDate, out DateTemp))
                {
                    Error += "The actual delivery date is not a valid date: ";
                }
                else if (DateTemp < extremeMinDate || DateTemp > extremeMaxDate)
                {
                    Error += "The actual delivery date is out of valid range: ";
                }
            }

            return Error;
        }
    }
}
    





    

