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
        if(IsPostBack == false)
        {

            DisplayStaff();
        }
        clsStaffUser AnUser = new clsStaffUser();
        AnUser = (clsStaffUser)Session["AnUser"];
        Response.Write("Logged in as:" + AnUser.UserName);
    }
    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffId";
        lstStaffList.DataTextField = "Postcode";
        lstStaffList.DataBind();

    }

    protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffId"] = -1;
        Response.Redirect("DingStaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        { 
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("DingStaffDataEntry.aspx");
        }

        else 
        {
            lblError.Text = "Please select a record from the list eo edit";
        }

    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if(lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("DingStaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("DingStaffTeamMainMenu.aspx");
    }
}