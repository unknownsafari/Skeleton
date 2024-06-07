using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;


namespace ClassLibrary

{
    public class clsShippingCollection
    {

        //private data member for the list
        List<clsShipment> mShippingList = new List<clsShipment>();
        clsShipment mThisShipping = new clsShipment();

        public List<clsShipment> ShippingList
        {
            get
            {
                //return the private data
                return mShippingList;
            }
            set
            {
                //set the private data
                mShippingList = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mShippingList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsShipment ThisShipping
        {
            get
            {
                return mThisShipping;
            }
            set
            {
                mThisShipping = value;
            }
        }

        public clsShippingCollection()

        {
            //variable for the index 
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //onject for the data connect
            clsDataConnection DB = new clsDataConnection();
            //excute the stored procedure
            DB.Execute("sproc_tblShipping_SelectALL");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank shipment 
                clsShipment AnShipping = new clsShipment();
                //read in the fields for the current record
                AnShipping.ShipmentId = Convert.ToInt32(DB.DataTable.Rows[Index]["ShipmentId"]);
                AnShipping.Delivered = Convert.ToBoolean(DB.DataTable.Rows[Index]["Delivered"]);
                AnShipping.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnShipping.Carrier = Convert.ToString(DB.DataTable.Rows[Index]["Carrier"]);
                AnShipping.TrackingNumber = Convert.ToString(DB.DataTable.Rows[Index]["TrackingNumber"]);
                AnShipping.ActualDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ActualDeliveryDate"]);
                AnShipping.ShippingDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ShippingDate"]);
                //add the record to the private data member
                mShippingList.Add(AnShipping);
                Index++;
            }

           

        }

        public int Add()
        {
            // Create an instance of the data connection
            clsShippingCollection DB = new clsShippingCollection();

            try
            {
                // Add parameters based on the ThisShipping property
                DB.AddParameter("@ShipmentId", ThisShipping.ShipmentId);
                DB.AddParameter("@OrderId", ThisShipping.OrderId);
                DB.AddParameter("@Carrier", ThisShipping.Carrier);
                DB.AddParameter("@TrackingNumber", ThisShipping.TrackingNumber);
                DB.AddParameter("@ShippingDate", ThisShipping.ShippingDate);
                DB.AddParameter("@ActualDeliveryDate", ThisShipping.ActualDeliveryDate);
                DB.AddParameter("@Delivered", ThisShipping.Delivered);

                // Execute the stored procedure to insert the new record
                DB.Execute("sproc_tblShipping_Insert");

                // Assuming the execution is successful, return 1
                return 1;
            }
            catch
            {
                // If there is an error, return 0 or handle the exception as needed
                return 0;
               
            }
        }


        public void Update()
        {
            // Update an existing record based on the values of ThisShipping
            clsShippingCollection DB = new clsShippingCollection();

            // Set the parameter for the new stored procedure
            DB.AddParameter("@ShipmentId", mThisShipping.ShipmentId);
            DB.AddParameter("@OrderId", mThisShipping.OrderId);
            DB.AddParameter("@Carrier", mThisShipping.Carrier);
            DB.AddParameter("@TrackingNumber", mThisShipping.TrackingNumber);
            DB.AddParameter("@ShippingDate", mThisShipping.ShippingDate);
            DB.AddParameter("@ActualDeliveryDate", mThisShipping.ActualDeliveryDate);
            DB.AddParameter("@Delivered", mThisShipping.Delivered);

            // Execute the stored procedure
            DB.Execute("sproc_tblShipping_Update");
            
        }

        public void Execute(string v)
        {
            throw new NotImplementedException();
        }

        public void AddParameter(string v, object shipmentId)
        {
            
        }

        public void Delete()
        {
           //deletes the record pointed to by thisshipping
           //connect to the database
           clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ShipmentId",mThisShipping.ShipmentId);
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_Delete");
        }

        public void ReportbyOrderId(string v)
        {
           
        }
    }
}
            