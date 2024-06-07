using ClassLibrary;
using System;
using System.Web.UI;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsShipment
        clsShipment AnShipment = new clsShipment();
        //get the data from the session object
        AnShipment = (clsShipment)Session["AnShipment"];

        if (AnShipment != null)
        {
            //display the Order Id for this entry
            Response.Write(AnShipment.OrderId);
            //display the carrier for this entry
            Response.Write(AnShipment.Carrier);
            //display the tracking number
            Response.Write(AnShipment.TrackingNumber);
            //display the shipping date
            Response.Write(AnShipment.ShippingDate);
            //display the actual delivery date
            Response.Write(AnShipment.ActualDeliveryDate);
            //display the delivered status
            Response.Write(AnShipment.Delivered);
        }
        else
        {
            Response.Write("No shipment data found.");
        }
    }
}
