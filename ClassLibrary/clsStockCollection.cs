using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        List<clsStock> mStockList = new List<clsStock>();

        clsStock mThisStock = new clsStock();

        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }

        public clsStock ThisStock
        {
            get
            {
                return mThisStock;
            }
            set
            {
                mThisStock = value;
            }
        }

        public clsStockCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("AgeRating", mThisStock.AgeRating);
            DB.AddParameter("GameDescription", mThisStock.GameDescription);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("DateAdded", mThisStock.DateAdded);
            DB.AddParameter("Available", mThisStock.Available);

            return DB.Execute("sproc_tblStock_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("AgeRating", mThisStock.AgeRating);
            DB.AddParameter("GameDescription", mThisStock.GameDescription);
            DB.AddParameter("Price", mThisStock.Price);
            DB.AddParameter("DateAdded", mThisStock.DateAdded);
            DB.AddParameter("Available", mThisStock.Available);
            DB.AddParameter("GameNumber", mThisStock.GameNumber);

            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameNumber", mThisStock.GameNumber);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void ReportByGameNumber(string GameDescription)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@GameDescription", GameDescription);
            DB.Execute("sproc_tblStock_FilterByGameNumber");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            Int32 Count;

            Count = DB.Count;

            mStockList = new List<clsStock>();

            while (Index < Count)
            {
                clsStock AnStock = new clsStock();

                AnStock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                AnStock.GameNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["GameNumber"]);
                AnStock.AgeRating = Convert.ToInt32(DB.DataTable.Rows[Index]["AgeRating"]);
                AnStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                AnStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStock.GameDescription = Convert.ToString(DB.DataTable.Rows[Index]["GameDescription"]);

                mStockList.Add(AnStock);

                Index++;
            }
        }


    }
}