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
    { //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //get the data from the session object
        ACustomer = (clsCustomer)Session["ACustomer"];
        //display the customer name for this entry
        Response.Write(ACustomer.CustomerName);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
        //capture the customer ID
        int CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the customer email
        string CustomerEmail = txtCustomerEmail.Text;
        //capture the customer password
        string CustomerPassword = txtCustomerPassword.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;
        //variable to store any error messages 
        string Error = "";
        //validate the data 
        Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
        if (Error == "")
        {
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the customer password
            ACustomer.CustomerPassword = CustomerPassword;
            //capture the date added 
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //store the address in the session object
            Session["Acustomer"] = ACustomer;
            //redirect to the viewer page
            Response.Write("CustomerViewer.aspx");

        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }


    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the Customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable that stores the primary key.
        Int32 CustomerId;
        //variable to store the result of the find operation.
        Boolean Found = false;
        // Get the primary key given by the user.
        CustomerId = Convert.ToInt32(txtCustomerID.Text);
        // Looks for the record.
        Found = ACustomer.Find(CustomerId);
        // If found
        if (Found == true)
        {
            //display the values to the properties in the form
            txtCustomerName.Text = ACustomer.CustomerName;
            txtCustomerEmail.Text = ACustomer.CustomerEmail;
            txtCustomerPassword.Text = ACustomer.CustomerPassword;
            txtDateAdded.Text = ACustomer.DateAdded.ToString();


        }

    }
}
