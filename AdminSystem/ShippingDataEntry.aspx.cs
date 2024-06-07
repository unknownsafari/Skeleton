using System;
using System.Activities.Expressions;
using System.Web.UI;
using ClassLibrary;

public partial class _1_DataEntry : Page
{
    //variable to store the primary key with page level scope
    Int32 ShipmentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the shipmentto be processed
        ShipmentId = Convert.ToInt32(Session["ShipmentId"]);
        if ( IsPostBack == false)
        {
            //if this is the not a new record
            if (ShipmentId != -1)
            {
                //display the current data for the record
                DisplayShipment();
            }
        }
    }

    private void DisplayShipment()
    {
        // Create an instance of the shipping collection
        clsShippingCollection shippingCollection = new clsShippingCollection();

        // Attempt to find the record to update
        bool found = shippingCollection.ThisShipping.Find(ShipmentId);

        // Check if the record was found
        if (found && shippingCollection.ThisShipping != null)
        {
            // Display the data for the record
            txtShipmentId.Text = shippingCollection.ThisShipping.ShipmentId.ToString();
            txtOrderId.Text = shippingCollection.ThisShipping.OrderId.ToString();
            txtTrackingNumberId.Text = shippingCollection.ThisShipping.TrackingNumber.ToString();
            txtShippingDateId.Text = shippingCollection.ThisShipping.ShippingDate.ToString();
            txtActualDeliveryDateId.Text = shippingCollection.ThisShipping.ActualDeliveryDate.ToString();
            chkDelivered.Checked = shippingCollection.ThisShipping.Delivered;
        }
        else
        {
            // Handle the case where the shipping record is not found
            // For example, you can display an error message or clear the fields
            txtShipmentId.Text = string.Empty;
            txtOrderId.Text = string.Empty;
            txtTrackingNumberId.Text = string.Empty;
            txtShippingDateId.Text = string.Empty;
            txtActualDeliveryDateId.Text = string.Empty;
            chkDelivered.Checked = false;

            // Optionally, you can log an error or notify the user
            lblError.Text = "Shipping record not found.";
        }
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsShipment
        clsShipment AnShipment = new clsShipment();
        string Carrier = txtCarrierId.Text;
        string OrderId = txtOrderId.Text;
        string TrackingNumber = txtTrackingNumberId.Text;
        string ShippingDate = txtShippingDateId.Text;
        string ActualDeliveryDate = txtActualDeliveryDateId.Text;
        string Delivered = chkDelivered.Text;
        string Error = "";
        //validate the data
        Error = AnShipment.Valid(OrderId, Carrier, TrackingNumber, ShippingDate, ActualDeliveryDate);
        if (Error == "")
        {
            AnShipment.ShipmentId = ShipmentId;
            AnShipment.Carrier = Carrier;
            AnShipment.OrderId = Convert.ToInt32(OrderId);
            AnShipment.TrackingNumber = TrackingNumber;
            AnShipment.ShippingDate = Convert.ToDateTime(ShippingDate);
            AnShipment.ActualDeliveryDate = Convert.ToDateTime(ActualDeliveryDate);
            AnShipment.Delivered = chkDelivered.Checked;
            //create a new instance of the Shiping collection
            clsShippingCollection ShippingList = new clsShippingCollection();
            //if this is a new record i.e. ShipmentId = -1 then add the data
            if(ShipmentId == -1)
            {
                //set the ThisShipping property
                ShippingList.ThisShipping = AnShipment;
                //add the new record
                ShippingList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                ShippingList.ThisShipping.Find(ShipmentId);
                //set the thisShipping property
                ShippingList.ThisShipping= AnShipment;
                //update the record
                ShippingList.Update();
            }
            
          
            Response.Redirect("ShippingList.aspx");
        }

        else
            {
                //display the error message
                lblError.Text = Error;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void BtnFind_Click(object sender, EventArgs e)
        {
            //create an instance of the address class
            clsShipment AnShipment = new clsShipment();
            //create a variable to store the result of the find operation
            Boolean Found = false;
            //get the primary key entered by the user
            int ShipmentId = Convert.ToInt32(txtShipmentId.Text);
            //find the record
            Found = AnShipment.Find(ShipmentId);
            //if the record is found
            if (Found == true)
            {
                //display the value of the properties in the form
                txtOrderId.Text = AnShipment.OrderId.ToString();
                txtCarrierId.Text = AnShipment.Carrier.ToString();
                txtTrackingNumberId.Text = AnShipment.TrackingNumber.ToString();
                txtShippingDateId.Text = AnShipment.ShippingDate.ToString("yyyy-MM-dd");
                txtActualDeliveryDateId.Text = AnShipment.ActualDeliveryDate.ToString("yyyy-MM-dd");
                chkDelivered.Checked = AnShipment.Active;
            }
        }

        protected void chkDelivered_CheckedChanged(object sender, EventArgs e)
        {

        }
  }




