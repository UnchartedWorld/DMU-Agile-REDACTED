using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to score the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.UsernameAvailable = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsAvailable"]);
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                ACustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPassword"]);
                ACustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;

            }
        }


        public List<clsCustomer> CustomerList {
            get 
            {
                //return the private data
                return mCustomerList;
            }
            set 
            {
                //set the private data 
                mCustomerList = value;
            }
        }
        public int Count 
        {
            get 
            {
                //return the count of the list
                return mCustomerList.Count;

            }
            set 
            { 
            //later
            } 
        }
        public clsCustomer ThisCustomer 
        {
            get 
            {
                //return the private data
                return mThisCustomer;
            }
            set 
            {
                //set the private data
                mThisCustomer = value;
            } 
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@DateCreated", mThisCustomer.DateAdded);
            DB.AddParameter("@IsAvailable", mThisCustomer.UsernameAvailable);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");


        }

        public void Update()
        {
            //update an existing record based on the values of ThisCustomer
            //connect to the database 
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerID);
            DB.AddParameter("@CustomerName", mThisCustomer.CustomerName);
            DB.AddParameter("@CustomerEmail", mThisCustomer.CustomerEmail);
            DB.AddParameter("@CustomerPassword", mThisCustomer.CustomerPassword);
            DB.AddParameter("@DateCreated", mThisCustomer.DateAdded);
            DB.AddParameter("@IsAvailable", mThisCustomer.UsernameAvailable);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");

        }

        public void Delete()
        {
            //deleted the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }
    }
}