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
        //create a new instance of clsStock
        clsStock AnStock = new clsStock();
        //capture the Game no
        AnStock.GameNumber = Convert.ToInt32(txtGameNumber.Text);
        //store the address in the session object
        Session["AnStock"] = AnStock;
        //navigate to the viewer page
        Response.Redirect("StockViewer.aspx");
    }
}