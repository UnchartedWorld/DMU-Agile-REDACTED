using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestingFramework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            // Creates an instance of the class we want.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Tests to see if exists as a class.
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOk()
        {
            // Creates an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Creates some test data to use, a list in this case.
            List<clsStaff> TestList = new List<clsStaff>();
            // Adds an item to the list and creates said item.
            clsStaff TestData = new clsStaff();
            // Sets the properties needed.
            TestData.StaffNo = 2;
            TestData.StaffName = "Timothy Jones";
            TestData.StaffRole = "Union Buster";
            TestData.DateOfEmployment = DateTime.Now.Date;
            TestData.StaffSalary = 30000;
            TestData.IsEmployed = true;
            // Adds the data to the list.
            TestList.Add(TestData);
            // Assigns the test list to the property.
            AllStaff.StaffList = TestList;
            // Checks to see if the two will be the same.
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOk()
        {
            // Creates an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Creates some test data to assign to the property.
            clsStaff TestStaff = new clsStaff();
            // Sets properties of the test object.
            TestStaff.StaffNo = 2;
            TestStaff.StaffName = "Timothy Jones";
            TestStaff.StaffRole = "Union Buster";
            TestStaff.DateOfEmployment = DateTime.Now.Date;
            TestStaff.StaffSalary = 30000;
            TestStaff.IsEmployed = true;
            // Assigns the data to the property.
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void StaffListAndCountOk()
        {
            // Creates an instance of the class.
            clsStaffCollection AllStaff = new clsStaffCollection();
            // Creates a list, and subsequently data to assign.
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestData = new clsStaff();
            // Sets properties.
            TestData.StaffNo = 3;
            TestData.StaffName = "Timothy Jones";
            TestData.StaffRole = "Union Worker";
            TestData.DateOfEmployment = DateTime.Now.Date;
            TestData.StaffSalary = 25000;
            TestData.IsEmployed = true;
            // Assigns data to test list.
            TestList.Add(TestData);
            // Assigns data to property.
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
    }
}
