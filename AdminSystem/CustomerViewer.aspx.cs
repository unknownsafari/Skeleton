using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer TheCustomer = new clsCustomer();
        //get the data from the session object
        TheCustomer = (clsCustomer)Session["TheCustomer"];
        //display the first name for this entry
        Response.Write(TheCustomer.FirstName);
        Response.Write(TheCustomer.LastName);
        Response.Write(TheCustomer.EmailAddress);
        Response.Write(TheCustomer.PhoneNumber);
        Response.Write(TheCustomer.DateOfBirth);
        Response.Write(TheCustomer.Newsletter);
        

    }
     
        
}

