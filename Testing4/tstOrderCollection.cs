using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }


        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameTitle = "Elden Ring";
            TestItem.OrderNo = 1;
            TestItem.TotalPrice = 1;
            TestItem.GameNo = 1;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();

            TestOrder.Available = true;
            TestOrder.DateAdded = DateTime.Now.Date;
            TestOrder.GameTitle = "Elden Ring";
            TestOrder.OrderNo = 1;
            TestOrder.TotalPrice = 1;
            TestOrder.GameNo = 1;

            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameTitle = "Elden Ring";
            TestItem.OrderNo = 1;
            TestItem.TotalPrice = 1;
            TestItem.GameNo = 1;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }

        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameTitle = "Elden Ring";
            TestItem.OrderNo = 1;
            TestItem.TotalPrice = 1;
            TestItem.GameNo = 1;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderNo = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameTitle = "Elden Ring";
            TestItem.TotalPrice = 1;
            TestItem.GameNo = 1;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderNo = PrimaryKey;

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.GameTitle = "Elden Ring";
            TestItem.TotalPrice = 1;
            TestItem.GameNo = 1;

            AllOrders.ThisOrder = TestItem;

            AllOrders.Update();

            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();

            clsOrder TestItem = new clsOrder();

            Int32 PrimaryKey = 0;

            TestItem.Available = true;
            TestItem.DateAdded = DateTime.Now;
            TestItem.GameTitle = "Yonuweewee";
            TestItem.OrderNo = 43;
            TestItem.TotalPrice = 135;
            TestItem.GameNo = 56;

            AllOrders.ThisOrder = TestItem;

            PrimaryKey = AllOrders.Add();

            TestItem.OrderNo = PrimaryKey;

            AllOrders.ThisOrder.Find(PrimaryKey);

            AllOrders.Delete();

            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByOrderNoMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByGameTitle("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderNoNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByGameTitle("fffff");
            Assert.AreEqual(0, FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByOrderNoTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByGameTitle("Elden ring");
            if (FilteredOrders.Count > 1)
            {
                if (FilteredOrders.OrderList[0].OrderNo != 2)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderNo != 4)
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
