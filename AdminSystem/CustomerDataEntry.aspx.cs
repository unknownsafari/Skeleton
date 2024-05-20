using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer TheCustomer = new clsCustomer();
        //capture the Data entered by the customer 
        TheCustomer.FirstName = txtFirstName.Text;
        TheCustomer.LastName = txtLastName.Text;
        TheCustomer.EmailAddress = txtEmailAddress.Text;
        
        
        //Store the customer in the session object
        Session["TheCustomer"] = TheCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }
}