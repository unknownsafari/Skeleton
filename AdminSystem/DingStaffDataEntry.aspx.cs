using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (StaffId == 0)
            StaffId = -1;
        if (IsPostBack == false)
        {
            if (StaffId != -1)
            {
                DisplayStaff();
            }
        }

    }

     void DisplayStaff()
    {
       clsStaffCollection StaffBook = new clsStaffCollection();
        StaffBook.ThisStaff.Find(StaffId);
        /*clsStaff staff = new clsStaff();
        staff.Find(StaffId);
        StaffBook.ThisStaff=staff;*/
        txtStaff.Text = StaffBook.ThisStaff.StaffId.ToString();
        txtHouseNo.Text = StaffBook.ThisStaff.HouseNo.ToString();
        txtStreet.Text = StaffBook.ThisStaff.Street.ToString();
        txtTown.Text = StaffBook.ThisStaff.Town.ToString();
        txtPS.Text = StaffBook.ThisStaff.PostCode.ToString();
        txtDate.Text = StaffBook.ThisStaff.DateAdded.ToString();
        chkActive.Checked = StaffBook.ThisStaff.Active;
        txtCounty.Text = StaffBook.ThisStaff.CountyCode.ToString();
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
            AnStaff.StaffId = StaffId;
            AnStaff.HouseNo = HouseNo;
            AnStaff.Street = Street;
            AnStaff.Town = Town;
            AnStaff.PostCode = PostCode;
            AnStaff.CountyCode = Convert.ToInt32(CountyCode);
            AnStaff.DateAdded = Convert.ToDateTime(DateAdded);
            AnStaff.Active = chkActive.Checked;
            clsStaffCollection Stafflist = new clsStaffCollection();
            if(StaffId == -1)
            {
                Stafflist.ThisStaff = AnStaff;
                Stafflist.Add();

            }
            else
            {
                Stafflist.ThisStaff.Find(StaffId);
                Stafflist.ThisStaff = AnStaff;
                Stafflist.Update();
            }
            Session["Anaddress"] = AnStaff;
            Response.Redirect("DingStaffViewer.aspx");
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

    protected void txtHouseNo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DingStaffTeamMainMenu.aspx");
    }

    protected void btnReturntoMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("DingStaffTeamMainMenu.aspx");
    }
}