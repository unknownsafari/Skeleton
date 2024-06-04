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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the customer class
        clsCustomer TheCustomer = new clsCustomer();
        // Create a variable to store the primary key 
        Int32 CustomerId;
        // Create a variable to store the result of the find operation 
        Boolean Found = false;

        // Validate the primary key entered by the user
        if (Int32.TryParse(txtCustomerId.Text, out CustomerId))
        {
            // Find the record
            Found = TheCustomer.Find(CustomerId);
            // If found
            if (Found)
            {
                // Display the value of the properties in the form
                txtFirstName.Text = TheCustomer.FirstName;
                txtLastName.Text = TheCustomer.LastName;
                txtEmailAddress.Text = TheCustomer.EmailAddress;
                txtDateOfBirth.Text = TheCustomer.DateOfBirth.ToString();
                txtPhoneNumber.Text = TheCustomer.PhoneNumber.ToString();
                chkNewsletter.Checked = TheCustomer.Newsletter;
            }
            else
            {
                // Display an error message if the primary key is not found
                lblError.Text = "Customer with ID: " + CustomerId + " not found.";
                lblError.Visible = true;
            }
        }
        else
        {
            // Display an error message if the input is not a valid integer
            lblError.Text = "Invalid Customer ID. Please enter a valid integer.";
            lblError.Visible = true;
        }
    }
}

