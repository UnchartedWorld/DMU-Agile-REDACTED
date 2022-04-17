using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void TestMethod1()
        {            
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);

        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create 
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.UsernameAvailable = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "Test@gmail.com";
            TestItem.CustomerName = "Abdul";
            TestItem.CustomerPassword = "p4ssword";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            // test to see that two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);

        }

       
        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            // create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.UsernameAvailable = true;
            TestCustomer.CustomerID = 1;
            TestCustomer.CustomerEmail = "Test@gmail.com";
            TestCustomer.CustomerName = "Abdul";
            TestCustomer.CustomerPassword = "p4ssword";
            TestCustomer.DateAdded = DateTime.Now.Date;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list 
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.UsernameAvailable = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerEmail = "Test@gmail.com";
            TestItem.CustomerName = "Abdul";
            TestItem.CustomerPassword = "p4ssword";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            // test to see that two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the prinary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UsernameAvailable = true;
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerName = "AbdulB";
            TestItem.CustomerEmail = "Test123@gmail.com";
            TestItem.CustomerPassword = "p4ssword123";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data
            // TestItem.UsernameAvailability = true;
            // TestItem.CustomerID = 11;
            //TestItem.DateAdded = DateTime.Now.Date;
            // TestItem.CustomerName = "AnotherGuy";
            // TestItem.CustomerEmail = "AnotherGuy@outlook.com";
            // TestItem.CustomerAddress = "98 Random Street";
            //set the record based on the new test data
            // AllCustomers.ThisCustomer = TestItem;
            //update the record
            // AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.UsernameAvailable = true;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerName = "AbdulB";
            TestItem.CustomerEmail = "Test123@gmail.com";
            TestItem.CustomerPassword = "p4ssword123";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the test data 
            TestItem.UsernameAvailable = false;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerName = "AbdulC";
            TestItem.CustomerEmail = "Test123@gmail.co.uk";
            TestItem.CustomerPassword = "p4ssword123b";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see ThisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK() 
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properites
            TestItem.UsernameAvailable = true;
            TestItem.CustomerID = 1;
            TestItem.CustomerName = "Abdul";
            TestItem.CustomerPassword = "p4ssword";
            TestItem.CustomerEmail = "Test@gmail.com";
            TestItem.DateAdded = DateTime.Now.Date;
            //set thisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }



    }
}
