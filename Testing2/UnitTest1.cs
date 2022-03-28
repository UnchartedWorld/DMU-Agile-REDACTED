using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        
        
        }
        [TestMethod]
        public void UsernameAvailableOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.UsernameAvailable = TestData;
            //testc to see if the two values are the same
            Assert.AreEqual(ACustomer.UsernameAvailable, TestData);
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.UsernameAvailable, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to assign to the property
            ACustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }
        [TestMethod]
        public void CustomerEmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "p2594193@my365.dmu.ac.uk";
            //assign the data to assign to the property
            ACustomer.CustomerEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerEmail, TestData);

        }

        [TestMethod]
        public void CustomerNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "Abdul";
            //assign the data to assign to the property
            ACustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerName, TestData);

        }
        [TestMethod]
        public void CustomerPasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data
            string TestData = "P4ssword";
            //assign the data to assign to the property
            ACustomer.CustomerPassword = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerPassword, TestData);

        }

        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to assign to the property
            ACustomer.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerID, TestData);


        }


    }
}
