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
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string EmailAddress = txtEmailAddress.Text;
        string Newsletter = chkNewsletter.Text;
        string PhoneNumber = txtPhoneNumber.Text;

        

        TheCustomer.PhoneNumber = PhoneNumber;
        DateTime dateOfBirth;

        // Attempt to parse the date of birth
        if (DateTime.TryParse(txtDateOfBirth.Text, out dateOfBirth))
        {
            TheCustomer.DateOfBirth = dateOfBirth;

            // Store the customer in the session object
            Session["TheCustomer"] = TheCustomer;

            // Navigate to the view page
            
        }
        else
        {
            // Display an error message if the date is not valid
            lblError.Text = "Invalid date format. Please enter the date in yyyy-mm-dd format.";
            lblError.Visible = true;
        }
        string Error = "";
        Error = TheCustomer.Valid(FirstName, LastName, EmailAddress, Newsletter, PhoneNumber);
        if (Error == "")
        {
            //capture the first name
            TheCustomer.FirstName = FirstName;
            TheCustomer.LastName = LastName;
            TheCustomer.EmailAddress = EmailAddress;
            TheCustomer.PhoneNumber = PhoneNumber;
            Session["TheCustomer"] = TheCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
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
                chkNewsletter.Checked = TheCustomer.NewsletterSubscription;
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

