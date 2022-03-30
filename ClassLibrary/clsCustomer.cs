using System;
namespace ClassLibrary
{
    public class clsCustomer
    {
        private Boolean mUsernameAvailable;
        public bool UsernameAvailable
        {
            get
            {
                //returns the private data
                return mUsernameAvailable;
            }
            set
            {
                //sets the private data 
                mUsernameAvailable = value;
            }
        }
        //Adds private DateAdded variable
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //Returns the private data
                return mDateAdded;
            }
            set
            {
                // Sets the private data
                mDateAdded = value;
            }
        }
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                //returns the private data
                return mCustomerEmail;
            }
            set
            {
                // Sets the private data
                mCustomerEmail = value;
            }
        }
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                //returns the private data
                return mCustomerName;
            }
            set
            {
                // Sets the private data
                mCustomerName = value;
            }
        }
        private string mCustomerPassword;
        public string CustomerPassword
        {
            get
            {
                //returns the private data
                return mCustomerPassword;
            }
            set
            {
                // Sets the private data
                mCustomerPassword = value;
            }
        }
        //customerid private member variable
        private Int32 mCustomerId;
        public Int32 CustomerID
        {
            get
            { //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {//this line of code allows data out of property
                mCustomerId = value;
            }
        }

    }
}