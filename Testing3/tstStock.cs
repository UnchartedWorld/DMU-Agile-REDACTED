using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        string Price = "13";
        string GameDescription = "This game is good!";
        string DateAdded = DateTime.Now.Date.ToString();
        string AgeRating = "18";

        [TestMethod]
        public void InstanceOK()
        {
            clsStock AnStock = new clsStock();
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void AvailableStockOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the stock
            Boolean TestData = true;
            //assign the data to the property
            AnStock.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Available, TestData);
        }

        [TestMethod]
        public void DataAddedStockOk()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the stock
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the stock
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }
        [TestMethod]
        public void GameDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the game
            string TestData = "DRAGON BALL FighterZ is born from what makes the DRAGON BALL series so loved and famous: endless spectacular fights with its all-powerful fighters. Partnering with Arc System Works, DRAGON BALL FighterZ maximizes high end Anime graphics and brings easy to learn but difficult to master fighting gameplay.";
            //assign the data to the game
            AnStock.GameDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.GameDescription, TestData);

        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the price
            Int32 TestData = 1;
            //assign the data to the price
            AnStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Price, TestData);
        }

        [TestMethod]
        public void AgeRatingOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the age rating
            Int32 TestData = 1;
            //assign the data to the age rating
            AnStock.AgeRating = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.AgeRating, TestData);
        }
        [TestMethod]
        public void GameNumberOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the game number
            Int32 TestData = 1;
            //assign the data to the game number
            AnStock.GameNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.GameNumber, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean vaariable to store the results of valadation
            Boolean Found = false;
            //create some test data to use witht thee method 
            Int32 GameNumber = 21;
            Boolean OK = true;
            //invoke the method 
            Found = AnStock.Find(GameNumber);
            //check stock number
            if (AnStock.GameNumber != 21)
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);

        }
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean vaariable to store the results of valadation
            Boolean Found = false;
            //create some test data to use witht thee method 
            Int32 GameNumber = 21;
            Boolean OK = true;
            //invoke the method 
            Found = AnStock.Find(GameNumber);
            //check stock number
            if (AnStock.DateAdded != Convert.ToDateTime(16 / 09 / 2015))
            {
                OK = false;
            }
            //Test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void GameDescriptionMinLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string GameDescription = "";
            Error = AnStock.Valid(GameDescription, Price, DateAdded, AgeRating);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "a"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameDescriptionMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "aa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GameDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "01234567890123456789012345678"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, AgeRating, GameDescription, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameDescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "012345678901234567890123456789"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GameDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string GameDescription = "012345678901234"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, AgeRating, GameDescription, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void GameDescriptionExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string GameDescription = ""; //this should fail
            GameDescription = GameDescription.PadRight(200, 'a');
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
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
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
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
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
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
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
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
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            clsStock AnStock = new clsStock();
            string Error = "";
            string Price = "";
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "1"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "2"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "999999998"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Price = "999999999"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Price = "1000000000"; //this should fail
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //convert the date variable to a string variable
            string Price = "this is not a price!";
            //invoke the method
            Error = AnStock.Valid(Price, GameDescription, AgeRating, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}
