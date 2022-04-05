using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private date member for the stock no property

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

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        private String mGameDescription;
        public string GameDescription
        {
            get
            {
                //return the private data
                return mGameDescription;
            }
            set
            {
                //set the private data
                mGameDescription = value;
            }
        }

        private Int32 mPrice;
        public int Price
        {
            get
            {
                //return the private data
                return mPrice;
            }
            set
            {
                //set the private data
                mPrice = value;
            }
        }

        private Int32 mAgeRating;
        public int AgeRating
        {
            get
            {
                //this line of code sends data out of the property
                return mAgeRating;
            }
            set
            {
                //this line of code allows data into your property
                mAgeRating = value;
            }
        }

        private Int32 mGameNumber;
        public Int32 GameNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mGameNumber;
            }
            set
            {
                //this line of code allows data into your property
                mGameNumber = value;
            }
        }

        public bool Find(int GameNumber)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@GameNumber", GameNumber);
            //if one record is found (there should be either one or zero!)

            DB.Execute("sproc_tblOrder_FilterByOrderNo");
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mGameNumber = Convert.ToInt32(DB.DataTable.Rows[0]["GameNumber"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mAgeRating = Convert.ToInt32(DB.DataTable.Rows[0]["AgeRating"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                mGameDescription = Convert.ToString(DB.DataTable.Rows[0]["GameDescription"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                //return that everything worked OK#
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }


        public string Valid(String GameNumber, string GameDescription, string price, string dateAdded)
        {
            String Error = "";
            DateTime DateTemp;

            if (GameDescription.Length == 0)
            {
                Error = Error + "The Game Description may not be blank : ";
            }
            if (GameDescription.Length > 150)
            {
                Error = Error + "The Game Description must be less than 150 characters : ";
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
                if (price.Length == 0)
                {
                    Error = Error + "price cannot be 0 : ";
                }
                if (price.Length > 9)
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
                if (GameNumber.Length == 0)
                {
                    Error = Error + "Game Number cannot be 0 : ";
                }
                if (GameNumber.Length > 99)
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




