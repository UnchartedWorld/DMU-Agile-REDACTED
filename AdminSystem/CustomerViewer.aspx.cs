using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the clsCustomer class.
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the session data for this entry
        Response.Write(ACustomer.CustomerName + "<br />" + ACustomer.CustomerEmail + "<br />" + ACustomer.CustomerPassword + "<br />" + ACustomer.DateAdded + "<br />" + ACustomer.UsernameAvailable);
    }
}