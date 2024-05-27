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


    protected void Unnamed1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtProdName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the product name 
        string ProductName = txtProductName.Text;
        //capture the unit price 
        string UnitPrice = txtUnitPrice.Text;
        //capture the platform
        string Platform = txtPlatform.Text;
        //capture the publisher 
        string Publisher = txtPublisher.Text;
        //capture minimum recorder level
        string MinimumRecorderLevel = txtMinimumRecorder.Text;
        //capture the current stock level
        string CurrentStockLevel = txtCurrentStockLevel.Text;
        //capture limited edition checkbox
        string LimitedEdition = chkActive.Text;
        //variable to store any error message 
        string Error = "";
        //validate the data 
        Error = AStock.Valid(ProductName, MinimumRecorderLevel, UnitPrice, Platform, Publisher, CurrentStockLevel);
        if (Error == "")
        {
            //add the product name
            AStock.ProductName = txtProductName.Text;
            //show the current stock level
            AStock.CurrentStockLevel = Convert.ToInt32(txtCurrentStockLevel.Text);
            //add the unit price
            AStock.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            //add minimum recorder level
            AStock.MinimumRecorderLEvel = Convert.ToInt32(txtMinimumRecorder.Text);
            //add platform of the product
            AStock.Platform = txtPlatform.Text;
            //add publisher of the product
            AStock.Publisher = txtPublisher.Text;
            //capture Limited edition check box
            AStock.LimitedEdition = chkActive.Checked ? "Yes" : "No";
            //create a new instance of the address collection 
            clsStockCollection StockList = new clsStockCollection();
            //set the ThisStock property
            StockList.ThisStock = AStock;
            //add the new record
            StockList.Add();
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
        }
        else
        {
            //display the error messsage 
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the product class
        clsStock AStock = new clsStock();
        //create a variable to store the primary key 
        int ProductId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        // get the primary key entered by the user
        ProductId = Convert.ToInt32(txtProductID.Text);
        //find the record 
        Found = AStock.Find(ProductId);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the  form 
            txtCurrentStockLevel.Text = AStock.CurrentStockLevel.ToString();
            txtMinimumRecorder.Text = AStock.MinimumRecorderLEvel.ToString();
            txtPlatform.Text = AStock.Platform;
            txtPublisher.Text = AStock.Publisher;
            txtProductName.Text = AStock.ProductName;
            txtUnitPrice.Text = AStock.UnitPrice.ToString();
        }
    }
}
