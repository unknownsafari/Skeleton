using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the product id for this entry 
        Response.Write(AStock.ProductId);
        //display the product name for this entry
        Response.Write(AStock.ProductName);
        //display the current stock level for this entry
        Response.Write(AStock.CurrentStockLevel);
        //display unit price for this entry
        Response.Write(AStock.UnitPrice);
        //display minimum recorder level
        Response.Write(AStock.MinimumRecorderLEvel);
        //display platform for this entry
        Response.Write(AStock.Platform);
        //display publisher for this entry
        Response.Write(AStock.Publisher);
        //yfy
        Response.Write(AStock.LimitedEdition);
    }
}