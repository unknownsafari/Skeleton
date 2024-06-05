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
    }
    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        lstStaffList.DataSource = Staff.StaffList;
        lstStaffList.DataValueField = "StaffNo";
        lstStaffList.DataTextField = "Postcode";
        lstStaffList.DataBind();

    }

    protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}