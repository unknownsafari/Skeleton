using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffBookLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStaffCollection AnUser = new clsStaffCollection();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(UserName,Password);
        Session["AnUser"] = AnUser;
        if(txtUserName.Text =="")
        {
            lblError.Text = "Enter a username";
        }
        else if(txtUserName.Text =="")
        {
            lblError.Text = "Enter Password";
        }
        else if(Found==true)
        {
            Response.Redirect("DingStaffList.aspx");
        }
        else if(Found ==false) 
        {
            lblError.Text = "Login details are incorrect . Please try again";
        }
    }
}