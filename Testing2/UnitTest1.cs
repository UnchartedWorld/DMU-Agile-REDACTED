using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class UnitTest1
    {
        //good test data 
        //create some test data to pass to the method
        string CustomerName = "Abdul";
        string CustomerEmail = "Test@gmail.com";
        string DateAdded = DateTime.Now.Date.ToString();
        string CustomerPassword = "p4ssword";

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

        [TestMethod]

        public void FindMethodOK()
        { //create an instance of the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = Acustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestCustomerIdFound()
        {//create an instance of the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //Boolean variable to store the results of the search
            Boolean Found = false;
            //Boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = Acustomer.Find(CustomerId);
            //check the customer id 
            if (Acustomer.CustomerID != 1)
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
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.DateAdded != Convert.ToDateTime("20/03/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestUsernameAvailableFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.UsernameAvailable != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerEmailFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.CustomerEmail != "Test@gmail.com")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerPasswordFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.CustomerPassword != "p4ssword")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.CustomerName != "Abdul")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            // Invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the mothod
            string CustomerName = ""; // should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerName = "p"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            String CustomerName = "pp"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "aaaaa";

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void CustomerNameMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass the method
            string CustomerName = "aaaaaa";

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerNameMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string CustomerName = "aaa";

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass the method
            string CustomerName = "aaaaaaa";

            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //test data
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'a');//this should fail
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date varaiable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddDays(-1);
            //convert the date varaiable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date varaiable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]

        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date!";
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerEmailMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerEmail = "a"; //this should be okay
            CustomerEmail = CustomerEmail.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]

        public void CustomerPasswordMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = ""; //this should trigger an error
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "aa"; //this should be okay
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(49, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPasswordMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(50, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]

        public void CustomerPasswordMid()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            //create some test data to pass to the method
            string CustomerPassword = "a"; //this should be okay
            CustomerPassword = CustomerPassword.PadRight(25, 'a');
            //invoke the method
            Error = ACustomer.Valid(CustomerName, CustomerEmail, CustomerPassword, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }
}

