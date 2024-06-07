using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page

{
    //variable to store the primary key value of the record to be deleted
    Int32 ShipmentId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ShipmentId = Convert.ToInt32(Session["ShipmentId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsShippingCollection shippingCollection = new clsShippingCollection();
        shippingCollection.ThisShipping.Find(ShipmentId);
        shippingCollection.Delete();
        Response.Redirect("ShippingList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect ("ShippingList.aspx");
    }
}