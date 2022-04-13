using System;
using System.Text.RegularExpressions;

namespace ClassLibrary
{
    public class clsOrder
    {
        //private data member for Available
        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                //this line of code sends data out of the property
                return mAvailable;
            }
            set
            {
                //this line of code allows data into the property
                mAvailable = value;
            }
        }
        //private date added data member
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for the Order No
        private Int32 mOrderNo;
        //OrderNo public property
        public Int32 OrderNo
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderNo;
            }
            set
            {
                //this line of code allows data into the property
                mOrderNo = value;
            }
        }
        //private data member for the GameTitle
        private string mGameTitle;
        public string GameTitle
        {
            get
            {
                //return the private data
                return mGameTitle;
            }
            set
            {
                //set the private data
                mGameTitle = value;
            }
        }

        private Int32 mGameNo;
        public int GameNo
        {
            get
            {
                //return the private data
                return mGameNo;
            }
            set
            {
                //set the private data
                mGameNo = value;
            }
        }
        private double mTotalPrice;
        public double TotalPrice
        {
            get
            {
                //return the private data
                return mTotalPrice;
            }
            set
            {
                //set the private data
                mTotalPrice = value;
            }
        }


        public bool Find(int OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //if one record is found (there should be either one or zero!)

            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mGameNo = Convert.ToInt32(DB.DataTable.Rows[0]["GameNo"]);
                mTotalPrice = Convert.ToInt32(DB.DataTable.Rows[0]["TotalPrice"]);
                mGameTitle = Convert.ToString(DB.DataTable.Rows[0]["GameTitle"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(

            string gameTitle,
            string totalPrice,
            string gameNo,
            string dateAdded)


        {
            {
                String Error = "";
                DateTime DateTemp;

                if (gameTitle.Length == 0)
                {
                    Error = Error + "The Game Title may not be blank : ";
                }
                if (gameTitle.Length > 25)
                {
                    Error = Error + "The Game Title must be less than 25 characters : ";
                }

                try
                {
                    DateTemp = Convert.ToDateTime(dateAdded);
                    if (DateTemp < DateTime.Now.Date)
                    {
                        Error = Error + "The date cannot be in the past : ";
                    }
                    if (DateTemp > DateTime.Now.Date)
                    {
                        Error = Error + "The date cannot be in the future : ";
                    }
                }
                catch
                {
                    Error = Error + "the date was not a valid date : ";
                }
                try
                {
                    if (totalPrice.Length == 0)
                    {
                        Error = Error + "price cannot be 0 : ";
                    }
                    if (totalPrice.Length > 9)
                    {
                        Error = Error + "price cannot be more than 999999999 : ";
                    }
                }
                catch
                {
                    Error = Error + "The price was not a valid price : ";
                }

                try
                {
                    if (gameNo.Length == 0)
                    {
                        Error = Error + "Game Number cannot be 0 : ";
                    }
                    if (gameNo.Length > 999)
                    {
                        Error = Error + "Game Number cannot be more than 999999999 : ";
                    }
                }
                catch
                {
                    Error = Error + "The Game Number was not a valid Number : ";
                }

                return Error;
            }
        }
    }
}