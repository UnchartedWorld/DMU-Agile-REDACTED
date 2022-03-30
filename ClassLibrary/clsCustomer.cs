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

        public bool Find(int CustomerId)
        {
            //create an instance of the data conncection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerID", CustomerId);
            //execute the stored procedure 
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found
            if (DB.Count == 1)

                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
            mUsernameAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["IsAvailable"]);
            mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
            mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
            mCustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["CustomerPassword"]);
            mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
            //always return true
            return true;
        }

        public string Valid(string customerName, string customerEmail, string customerPassword, string dateAdded)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the date values
            DateTime DateTemp;
            //if the HouseNo is blank
            if (customerName.Length == 0)
            {
                //record the error
                Error = Error + "The customer name may not be empty : ";
            }
            if (customerName.Length > 50)
            {
                Error = Error + "The customer name must be less than 50 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past: ";
                }
                //check to see if the data is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }

            //is the customer email blank
            if (customerEmail.Length == 0)
            {
                //record the error
                Error = Error + "The customer email may not be blank : ";
            }
            //if the customer email is too long 
            if (customerEmail.Length > 50)
            {
                //record the error
                Error = Error + "The customer email must be less than 50 characters; ";
            }
            //is the customerAddress blank
            if (customerPassword.Length == 0)
            {
                //record the error
                Error = Error + "The Customer Address may not be blank : ";
            }
            //if the customer address is too long
            if (customerPassword.Length > 50)
            {
                //record the error 
                Error = Error + "The customer address must be less than 50 characters : ";
            }
            //return any error message
            return Error;
        }
    }
}
