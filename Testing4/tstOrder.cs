using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {

        string GameTitle = "Elden Ring";
        string TotalPrice = "69";
        string GameNo = "02";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void TestMethod1()
        {  //create an instance of the class we want to create
            clsOrder anOrder = new clsOrder();
            //test to see that it exists 
            Assert.IsNotNull(anOrder);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Available, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.OrderNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }
        public void GameTitlePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            string TestData = "Eldenring";
            //assign the data to the property
            AnOrder.GameTitle = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.GameTitle, TestData);
        }
        [TestMethod]
        public void GameNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnOrder.GameNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.GameNo, TestData);
        }
        [TestMethod]
        public void TotalPricePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            double TestData = 59.99;

            //assign the data to the property
            AnOrder.TotalPrice = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the address no
            if (AnOrder.OrderNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.Available != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.DateAdded != Convert.ToDateTime("25/03/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameNoFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the address no
            if (AnOrder.GameNo != 56)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGameTitleFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderNo = 1;
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.GameTitle != "Yonuweewee")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //create some test data to use with the method
            Int32 GameNo = 1;
            //invoke the method
            Found = AnOrder.Find(GameNo);
            //check the address no
            if (AnOrder.TotalPrice != 135)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        public void ValidMethodOk()
        {
            clsOrder anOrder = new clsOrder();

            String Error = "";
            Error = anOrder.Valid(GameTitle, TotalPrice, GameNo, DateAdded);
            Assert.AreEqual(Error, "");


        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string TotalPrice = "";
            Error = AnOrder.Valid(GameTitle, TotalPrice, DateAdded, GameNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "2"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "999999998"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TotalPrice = "999999999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string TotalPrice = "1000000000"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string TotalPrice = "this is not a price!";
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string GameNo = "0";
            Error = AnOrder.Valid(GameTitle, TotalPrice, DateAdded, GameNo);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "1";
            //create some test data to pass to the method
            string GameNo = "1"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string OrderNo = "2"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, OrderNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameNo = "999999998"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameNo = "999999999"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string GameNo = "1000000000"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameNoInvalidData()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string GameNo = "this is not an Order Number!";
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameTitleMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string Error = "";
            string GameTitle = "";
            Error = AnOrder.Valid(GameNo, TotalPrice, DateAdded, GameTitle);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "01234567890123456789012"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "0123456789012345678901234"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameTitle = "0123456789012"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string GameTitle = "01234567890123456789012345"; //this should fail
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void GameTitleExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string GameTitle = ""; //this should fail
            GameTitle = GameTitle.PadRight(200, 'a');
            //invoke the method
            Error = AnOrder.Valid(TotalPrice, GameNo, GameTitle, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}
