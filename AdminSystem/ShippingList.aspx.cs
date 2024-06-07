using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the fisrt time page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayShipping();
        }
    }
    void DisplayShipping()
    {
        //create an instance of the Shipping collection
        clsShippingCollection Shipping = new clsShippingCollection();
        //set the data spource to list of the shippings in collection
        lstShippingList.DataSource = Shipping.ShippingList;
        //set the name of the primary key
        lstShippingList.DataValueField = "OrderId";
        //set the data field to display
        lstShippingList.DataTextField = "OrderId";
        lstShippingList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store-1 into the session object to indicate this is a new record
        Session["ShipmentId"] = -1;
        //redirect to the data entry page
        Response.Redirect("ShippingDataEntry");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 ShipmentId;
        //if a record has been selected from the list
        if (lstShippingList.SelectedIndex != -1) // Use -1 to check if no item is selected
        {
            //get the primary key value of the record to edit
            ShipmentId = Convert.ToInt32(lstShippingList.SelectedValue);
            //store the data in the session object
            Session["ShipmentId"] = ShipmentId;
            //redirect to the edit page
            Response.Redirect("ShippingDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 ShipmentId;
        //if a record has been selected from the list
        if (lstShippingList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            ShipmentId = Convert.ToInt32(lstShippingList.SelectedValue);
            //store the data in the session object
            Session["ShipmentId"] = ShipmentId;
            //redirect to the delete page
            Response.Redirect("ShippingConfirmDelete.aspx");
        }
        else//if no record has been selected
        {
            lblError.Text = "Please select a record from thr list to delete";
        }
    }

    protected void btnApplyFliter_Click(object sender, EventArgs e)
    {
        clsShippingCollection Anshipment = new clsShippingCollection();
        Anshipment.ReportByOrderId(txt)
    }
}
