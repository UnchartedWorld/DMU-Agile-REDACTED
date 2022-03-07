using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
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
    }
}
