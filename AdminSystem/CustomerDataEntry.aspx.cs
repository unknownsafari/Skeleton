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
        TheCustomer.Newsletter = chkNewsletter.Checked;
        long phoneNumber;
        if (long.TryParse(txtPhoneNumber.Text, out phoneNumber))
        {
            TheCustomer.PhoneNumber = txtPhoneNumber.Text;
        }
        else
        {
            lblError.Text = "Invalid phone number. Please enter numbers only.";
            lblError.Visible = true;
            return;
        }
        DateTime dateOfBirth;

        // Attempt to parse the date of birth
        if (DateTime.TryParse(txtDateOfBirth.Text, out dateOfBirth))
        {
            TheCustomer.DateOfBirth = dateOfBirth;

            // Store the customer in the session object
            Session["TheCustomer"] = TheCustomer;

            // Navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            // Display an error message if the date is not valid
            lblError.Text = "Invalid date format. Please enter the date in yyyy-mm-dd format.";
            lblError.Visible = true;
        }
    }
}
