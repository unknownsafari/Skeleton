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
        //create a new instance of clsstaff
        string HouseNo = txtHouseNo.Text;
        string Street = txtStreet.Text;
        string Town = txtTown.Text;
        string PostCode =txtPS.Text;
        string CountyCode = txtCounty.Text;
        string DateAdded = txtDate.Text;
        string Active = chkActive.Text;
        string Error = "";
        Error = AnStaff.Valid(HouseNo, Street, Town, PostCode, DateAdded);
        if (Error == "")
        {
            AnStaff.HouseNo = HouseNo;
            AnStaff.Street = Street;
            AnStaff.Town = Town;
            AnStaff.PostCode = PostCode;
            AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
            Session["Anaddress"] = AnStaff;
            Response.Redirect("StaffBookViewer.aspx");
        }
        else 
        {
            lblError.Text = Error;
        }
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