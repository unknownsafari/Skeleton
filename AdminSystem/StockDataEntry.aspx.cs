using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ProductId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the  number of the stock to be processed
        ProductId = Convert.ToInt32(Session["ProductId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }
    void DisplayStock()
    {
        //create an instance of the stock 
        clsStockCollection Stock = new clsStockCollection();
        //find the record to update
        Stock.ThisStock.Find(ProductId);
        //display the data for the record
        txtProductID.Text = Stock.ThisStock.ProductId.ToString();
        txtCurrentStockLevel.Text = Stock.ThisStock.CurrentStockLevel.ToString();
        txtMinimumRecorder.Text = Stock.ThisStock.MinimumRecorderLEvel.ToString();
        txtPlatform.Text = Stock.ThisStock.Platform.ToString();
        txtPublisher.Text = Stock.ThisStock.Publisher.ToString();
        txtProductName.Text = Stock.ThisStock.ProductName.ToString();
        txtUnitPrice.Text = Stock.ThisStock.UnitPrice.ToString();
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
            //capture the product id
            AStock.ProductId = ProductId; /// DON'T MISS THIS BIT !!!!!!
            //add the product name
            AStock.ProductName = ProductName;
            //show the current stock level
            AStock.CurrentStockLevel = Convert.ToInt32(CurrentStockLevel);
            //add the unit price
            AStock.UnitPrice = Convert.ToDecimal(UnitPrice);
            //add minimum recorder level
            AStock.MinimumRecorderLEvel = Convert.ToInt32(txtMinimumRecorder.Text);
            //add platform of the product
            AStock.Platform = Platform;
            //add publisher of the product
            AStock.Publisher = Publisher;
            //capture Limited edition check box
            AStock.LimitedEdition = chkActive.Checked ? "Yes" : "No";
            //create a new instance of the address collection 
            clsStockCollection StockList = new clsStockCollection();

            //if this is a new record i. e. ProductId = -1 then add the data
            if (ProductId == -1)
            {
                //set the ThisStock Property
                StockList.ThisStock = AStock;
                //add the new record
                StockList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                StockList.ThisStock.Find(ProductId);
                //set the ThisStock property
                StockList.ThisStock = AStock;
                //update the record
                StockList.Update();
            }
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

    protected void txtUnitPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page 
        //Response.Redirect("StockList.aspx");
    }

    protected void btnReturnToMM_Click(object sender, EventArgs e)
    {
        //redirect to the main menu 
        Response.Redirect("TeamMainMenu.aspx");
    }
}
