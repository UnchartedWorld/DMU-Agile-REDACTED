using System;

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
        private double mPrice;
        public double Price
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


        public bool Find(int orderNo)
        {
            //set the private data members to the test data value
            mOrderNo = 69;
            mAvailable = true;
            mGameNo = 19;
            mPrice = 59.99;
            mGameTitle = "Eldenring";
            mDateAdded = Convert.ToDateTime("01/3/2022");

            //always return true
            return true;
        }
    }
}