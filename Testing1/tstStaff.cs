using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {

        // Test data that can be used to test and pass methods.
        string StaffName = "Timothy Jones";
        string StaffRole = "Team Manager";
        int StaffSalary = 10000;
        string DateOfEmployment = DateTime.Now.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Test to see that it exists.
            Assert.IsNotNull(sampleStaff);
        }

        [TestMethod]
        public void DateOfEmploymentPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            DateTime fakeDate = DateTime.Now.Date;
            // Assign the data to a property.
            sampleStaff.DateOfEmployment = fakeDate;
            // Check to see if both are the same.
            Assert.AreEqual(sampleStaff.DateOfEmployment, fakeDate);
        }

        [TestMethod]
        public void IsEmployedPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            Boolean testData = true;
            // Assigns data to a property.
            sampleStaff.IsEmployed = testData;
            // Checks to see if both are the same.
            Assert.AreEqual(sampleStaff.IsEmployed, testData);
        }

        [TestMethod]
        public void StaffNamePropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            string fakeName = "Bilbo Baggins";
            // Assigns the data to a property.
            sampleStaff.StaffName = fakeName;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffName, fakeName);
        }

        [TestMethod]
        public void StaffNoPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            int testNo = 1;
            // Assigns the data to a property.
            sampleStaff.StaffNo = testNo;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffNo, testNo);
        }

        [TestMethod]
        public void StaffRolePropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            string fakeRole = "Team Manager";
            // Assigns the data to property.
            sampleStaff.StaffRole = fakeRole;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffRole, fakeRole);
        }

        [TestMethod]
        public void StaffSalaryPropertyOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Creates some test data to assign to property.
            int fakeSalary = 15500;
            // Assigns the data to property.
            sampleStaff.StaffSalary = fakeSalary;
            // Checks to see if they're both the same.
            Assert.AreEqual(sampleStaff.StaffSalary, fakeSalary);
        }

        // The following will be used to ensure the hard-coded Find method works.

        [TestMethod]
        public void FindMethodOk()
        {
            // Creates an instance of the class we wnat to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Tests to see if the result happens to be true.
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void StaffNoFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOK = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff number. 
            if (sampleStaff.StaffNo != 1)
            {
                dataOK = false;                
            }
            Assert.IsTrue(dataOK);
        } 
        [TestMethod]
        public void StaffNameFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff name.
            if(sampleStaff.StaffName != "Bilbo Baggins")
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void StaffRoleFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff role.
            if (sampleStaff.StaffRole != "Ring Bearer")
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void DateOfEmploymentFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the date of employment.
            if (sampleStaff.DateOfEmployment != Convert.ToDateTime("04/03/2022 00:00:00"))
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void StaffSalaryFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the staff salary.
            if (sampleStaff.StaffSalary != Convert.ToInt32(23000))
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }
        [TestMethod]
        public void IsEmployedFindOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // Boolean variable that'll store the results of the validation check.
            Boolean Found = false;
            // Boolean variable to record if data is okay.
            Boolean dataOk = true;
            // Creates some sample test data to use with this method.
            Int32 StaffNo = 1;
            // Invokes the method.
            Found = sampleStaff.Find(StaffNo);
            // Checks the boolean IsEmployed.
            if (sampleStaff.IsEmployed != true)
            {
                dataOk = false;
            }
            Assert.IsTrue(dataOk);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            // Creates an instance of the class we want to create.
            clsStaff sampleStaff = new clsStaff();
            // String variable to store any error message.
            String Error = "";
            // Invokes the validation method.
            Error = sampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
        }
    }
}

namespace TestPlanImplementation
{
    [TestClass]
    public class tstStaff
    {
        // Test data that can be used to test and pass methods.
        string StaffName = "Timothy Jones";
        string StaffRole = "Team Manager";
        int StaffSalary = 10000;
        string DateOfEmployment = DateTime.Now.Date.ToString();

        [TestMethod]
        public void StaffNameLessOne()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            String StaffName = "";
            // Invokes validation method. This should result in an error (since StaffName cannot be null).
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void StaffNameMin()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            String StaffName  = "x";
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            String StaffName = "xx";
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMid()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffName = "";
            StaffName = StaffName.PadRight(32, 'x');
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffName = "";
            StaffName = StaffName.PadRight(63, 'x');
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMax()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffName = "";
            StaffName = StaffName.PadRight(64, 'x');
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffName = "";
            StaffName = StaffName.PadRight(65, 'x');
            // Invokes validation method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameExtremeMax()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffName = "";
            StaffName = StaffName.PadRight(320, 'x');
            // Invokes validation method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffNameContainsNumber()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffName = "32Johnny Tyler 16Blevins 31";
            // Invokes validation method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleLessOne()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            String StaffRole = "";
            // Invokes validation method. This should result in an error (since StaffName cannot be null).
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMin()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            String StaffRole = "x";
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMinPlusOne()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            String StaffRole = "xx";
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMid()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(32, 'x');
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxLessOne()
        {
            // Creates new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(63, 'x');
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMax()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(64, 'x');
            // Invokes validation method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleMaxPlusOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(65, 'x');
            // Invokes validation method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleExtremeMax()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffRole = "";
            StaffRole = StaffRole.PadRight(320, 'x');
            // Invokes validation method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffRoleContainsNumber()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates some test data to pass to method.
            string StaffRole = "32Johnny Tyler 16Blevins 31";
            // Invokes validation method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentExtremeMin()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates a variable to store the test date data.
            DateTime TestDate;
            // Set the date to today's date.
            TestDate = DateTime.Now.Date;
            // Changes the TestDate variable to 1000 years before today.
            TestDate = TestDate.AddYears(-1000);
            // Convert the date variable to a string variable.
            string DateOfEmployment = TestDate.ToString();
            // Invoke the method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correect.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentMinLessOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates a variable to store the test date data.
            DateTime TestDate;
            // Set the date to today's date.
            TestDate = DateTime.Now.Date;
            // Changes the TestDate variable to yesterday.
            TestDate = TestDate.AddDays(-1);
            // Convert the date variable to a string variable.
            string DateOfEmployment = TestDate.ToString();
            // Invoke the method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentMin()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates a variable to store the test date data.
            DateTime TestDate;
            // Set the date to today's date.
            TestDate = DateTime.Now.Date;
            // Convert the date variable to a string variable.
            string DateOfEmployment = TestDate.ToString();
            // Invokes the method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Test to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentMinPlusOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates a variable to store the test date data.
            DateTime TestDate;
            // Sets the date to today's date.
            TestDate = DateTime.Now.Date;
            // Adds a single day to the TestDate variable.
            TestDate = TestDate.AddDays(1);
            // Convert the date variable to a string variable.
            string DateOfEmployment = TestDate.ToString();
            // Invokes the method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOfEmploymentExtremeMax()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Creates a variable to store the test date data.
            DateTime TestDate;
            // Sets the date to today's date.
            TestDate = DateTime.Now.Date;
            // Adds a single day to the TestDate variable.
            TestDate = TestDate.AddYears(1000);
            //Convert the date variable to a string variable.
            string DateOfEmployment = TestDate.ToString();
            // Invokes the method. This shoudn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryExtremeMin()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Sets salary variable to a value.
            int StaffSalary = -2147483648;
            // Invokes the method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinLessOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Sets salary variable to a value.
            int StaffSalary = -1;
            // Invokes the method. This shouldn't 'pass'.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMin()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Sets salary variable to a value.
            int StaffSalary = 0;
            // Invokes the method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMinPlusOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Sets salary variable to a value.
            int StaffSalary = 1;
            // invokes the method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMaxLessOne()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Sets salary variable to a value.
            int StaffSalary = 2147483646;
            // Invokes the method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if the result is correct.
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffSalaryMax()
        {
            // Creates a new instance of the class that we need.
            clsStaff SampleStaff = new clsStaff();
            // String variable to store any errors that may occur.
            String Error = "";
            // Sets salary variable to a value.
            int StaffSalary = 2147483647;
            // Invokes the method. This should pass.
            Error = SampleStaff.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
            // Tests to see if this result is correct.
            Assert.AreEqual(Error, "");
        }
    }
}

namespace AddEditDeleteUpdateTests
{
    [TestClass]
    public class tstStaff
    {

        [TestMethod]
        public void AddMethodOk()
        {
            // Creates an instance of the class that we want to create.
            clsStaffCollection StaffColl = new clsStaffCollection();
            // Creates the item of test data.
            clsStaff TestStaff = new clsStaff();
            // Variable that'll store the primary key.
            Int32 PrimaryKey = 0;
            // Sets the test staff's properties.
            TestStaff.StaffNo = 0;
            TestStaff.StaffName = "Tommy Fury";
            TestStaff.StaffRole = "Team Killer";
            TestStaff.DateOfEmployment = DateTime.Now.Date;
            TestStaff.StaffSalary = 32000;
            TestStaff.IsEmployed = true;
            // Sets thisStaff to the sample data.
            StaffColl.ThisStaff = TestStaff;
            // Adds the record
            PrimaryKey = StaffColl.Add();
            // Sets the primary key of the test data.
            TestStaff.StaffNo = PrimaryKey;
            // "Finds" the record.
            StaffColl.ThisStaff.Find(PrimaryKey);
            // Checks to see if they're the same.
            Assert.AreEqual(StaffColl.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            // Creates an instance of the class we want to create.
            clsStaffCollection SampleColl = new clsStaffCollection();
            // Creates an item of test data.
            clsStaff TestStaff = new clsStaff();
            // Variable used to store the primary key.
            Int32 PrimaryKey = 0;
            // Sets properties.
            TestStaff.StaffName = "Timothy Jones";
            TestStaff.StaffRole = "CEO Eliminator";
            TestStaff.DateOfEmployment = DateTime.Now.Date;
            TestStaff.StaffSalary = 65000;
            TestStaff.IsEmployed = true;
            // Sets ThisAddress to the sample data.
            SampleColl.ThisStaff = TestStaff;
            // Adds a record.
            PrimaryKey = SampleColl.Add();
            // Sets the primary key of the test data.
            TestStaff.StaffNo = PrimaryKey;
            // Modifies the test data.
            TestStaff.StaffName = "Bobby Burns";
            TestStaff.StaffRole = "CEO Protector";
            TestStaff.DateOfEmployment = DateTime.Now.Date;
            TestStaff.StaffSalary = 70000;
            TestStaff.IsEmployed = true;
            // Sets the record, based on new data.
            SampleColl.ThisStaff = TestStaff;
            // Updates the record.
            SampleColl.Update();
            // Finds the record.
            SampleColl.ThisStaff.Find(PrimaryKey);
            // Checks to see if they're the same, and thus updated.
            Assert.AreEqual(SampleColl.ThisStaff, TestStaff);
        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            // Creates an instance of the class we want to create.
            clsStaffCollection SampleColl = new clsStaffCollection();
            // Creates an item of test data.
            clsStaff TestStaff = new clsStaff();
            // Variable used to store the primary key.
            Int32 PrimaryKey = 0;
            // Sets properties.
            TestStaff.StaffName = "Timothy Jones";
            TestStaff.StaffRole = "CEO Eliminator";
            TestStaff.DateOfEmployment = DateTime.Now.Date;
            TestStaff.StaffSalary = 65000;
            TestStaff.IsEmployed = true;
            // Sets ThisAddress to the sample data.
            SampleColl.ThisStaff = TestStaff;
            // Adds a record.
            PrimaryKey = SampleColl.Add();
            // Sets the primary key of the test data.
            TestStaff.StaffNo = PrimaryKey;
            // Finds the record.
            SampleColl.ThisStaff.Find(PrimaryKey);
            // Deletes the record.
            SampleColl.Delete();
            // Tries to find the record, which hopefully it shouldn't.
            Boolean Found = SampleColl.ThisStaff.Find(PrimaryKey);
            // Tests to see if the record was not found.
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void FilterByStaffRoleOk()
        {
            clsStaffCollection StaffColl = new clsStaffCollection();
            // Creates an instance of the filtered data.
            clsStaffCollection FilteredStaffColl = new clsStaffCollection();
            // Applies a blank string (should return all records);
            FilteredStaffColl.FilterByStaffRole("");
            // Tests to see that two values are the same.
            Assert.AreEqual(StaffColl.Count, FilteredStaffColl.Count);
        }

        [TestMethod]
        public void FilterByStaffRoleDataFound()
        {
            // Creates an instance of the filtered data.
            clsStaffCollection FilteredStaffColl = new clsStaffCollection();
            // Variable that'll store outcome.
            Boolean Ok = true;
            // Apply to a staff role that currently exists. 
            FilteredStaffColl.FilterByStaffRole("Manager");
            // Check that the correct number of records are found.
            if (FilteredStaffColl.Count == 1)
            {
                // Check if the ID of the record is correct.
                if (FilteredStaffColl.StaffList[0].StaffNo != 1)
                {
                    Ok = false;
                }
                else
                {
                    Ok = false;
                }
            }
            Assert.IsTrue(Ok);
        }
    }
}