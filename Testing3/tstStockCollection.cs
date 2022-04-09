using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }


        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameDescription = "shazam";
            TestItem.GameNumber = 1;
            TestItem.Price = 1;
            TestItem.AgeRating = 1;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();

            TestStock.Available = true;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.GameDescription = "Some game";
            TestStock.GameNumber = 1;
            TestStock.Price = 1;
            TestStock.AgeRating = 1;

            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameDescription = "Some game";
            TestItem.GameNumber = 1;
            TestItem.Price = 1;
            TestItem.AgeRating = 1;

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.Count, TestList.Count);

        }

        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.GameNumber = 1;
            TestItem.GameDescription = "Some game";
            TestItem.AgeRating = 1;
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.GameNumber = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.AgeRating = 1;
            TestItem.GameDescription = "Some game";
            TestItem.Price = 1;
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.GameNumber = PrimaryKey;

            TestItem.Available = false;
            TestItem.AgeRating = 2;
            TestItem.GameDescription = "Some game";
            TestItem.Price = 2;
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            AllStock.Update();

            AllStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.GameNumber = 1;
            TestItem.GameDescription = "Some game";
            TestItem.AgeRating = 1;
            TestItem.Price = 10;
            TestItem.DateAdded = DateTime.Now;

            AllStock.ThisStock = TestItem;

            PrimaryKey = AllStock.Add();

            TestItem.GameNumber = PrimaryKey;

            AllStock.ThisStock.Find(PrimaryKey);

            AllStock.Delete();

            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByGameNumberMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByGameNumber("");
            Assert.AreEqual(AllStock.Count, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByGameNumberNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByGameNumber("xxxxx");
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByGameNumberTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByGameNumber("yesyesyes");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].GameNumber != 30)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].GameNumber != 31)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }

}
