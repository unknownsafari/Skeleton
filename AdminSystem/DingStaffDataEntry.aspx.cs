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

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff= new clsStaff();
        AnStaff.HouseNo = txtHouseNo.Text;
        Session["Anaddress"] = AnStaff;
        Response.Redirect("StaffBookViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff Anstaff= new clsStaff();

        Int32 StaffId;

        Boolean Found = false;

        StaffId = Convert.ToInt32(txtStaff.Text);

        Found = Anstaff.Find(StaffId);
        if (Found == true)
        {
            txtHouseNo.Text = Anstaff.HouseNo;
            txtStreet.Text = Anstaff.Street;
            txtTown.Text = Anstaff.Town;
            txtPS.Text = Anstaff.PostCode;
            txtCounty.Text = Anstaff.CountyCode.ToString();
            txtDate.Text = Anstaff.DateAdded.ToString();
            chkActive.Checked = Anstaff.Active;
        }
    }

    protected void txtStreet_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtTown_TextChanged(object sender, EventArgs e)
    {

    }
}