using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false) 
        {
            //if this is not a new record
            if (CustomerId != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }

    }

    void DisplayCustomer()
    {
        //create an instance of the address book
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        //find the record to update
        CustomerList.ThisCustomer.Find(CustomerId);
        //display the data fro this record
        txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
        txtCustomerName.Text = CustomerList.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = CustomerList.ThisCustomer.CustomerEmail;
        txtCustomerPassword.Text = CustomerList.ThisCustomer.CustomerPassword;
        txtDateAdded.Text = CustomerList.ThisCustomer.DateAdded.ToString();
        chkAvailable.Checked = CustomerList.ThisCustomer.UsernameAvailable;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        //capture the customer name
        string CustomerName = txtCustomerName.Text;
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
            //capture the customerId
            ACustomer.CustomerID = CustomerId;
            //capture the customer name
            ACustomer.CustomerName = CustomerName;
            //capture the customer email
            ACustomer.CustomerEmail = CustomerEmail;
            //capture the customer password
            ACustomer.CustomerPassword = CustomerPassword;
            //capture the date added 
            ACustomer.DateAdded = Convert.ToDateTime(DateAdded);
            //capture active
            ACustomer.UsernameAvailable = chkAvailable.Checked;
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //if this is a new record i.e. CustomerId = -1 then add the data
            if (CustomerId == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else 
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerId);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the listpage
            Response.Redirect("CustomerList.aspx");
            
            

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
            chkAvailable.Checked = ACustomer.UsernameAvailable;

        }

        else
            lblError.Text = "Entry not found in databse, try another number";

    }
}
