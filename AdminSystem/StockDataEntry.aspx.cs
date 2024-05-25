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
        //capture the product id
        AStock.ProductId = Convert.ToInt32(txtProductID.Text);
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
        //store the name in the session object
        Session["AStock"] = AStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }

}
