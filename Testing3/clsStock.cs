using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private date member for the stock no property
        private Int32 mGameNumnber;
        public bool Available { get; set; }
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
        public string GameDescription { get; set; }
        public int Price { get; set; }
        public int AgeRating { get; set; }
        public Int32 GameNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mGameNumnber;
            }
            set
            {
                //this line of code allows data into your property
                mGameNumnber = value;
            }
        }
        public bool Find(int GameNumber)
        {
            mGameNumnber = 21;
            mDateAdded = Convert.ToDateTime("16/09/2015");
            return true;
        }
    }
}
