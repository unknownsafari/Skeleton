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
        //create a new insstance of clsStaff
        clsStaff aStaff = new clsStaff();
        //capture the staffnum
        aStaff.StaffNum = txtStaffNUM.Text;
        Session["aStaff"] = aStaff;
        Response.Redirect("DingStaffViewer.aspx");
    }
}