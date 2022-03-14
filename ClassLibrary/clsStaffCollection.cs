using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Creates some class-wide data.
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public clsStaffCollection()
        {
            // Variable that'll get used for the index.
            Int32 Index = 0;
            // Variable that'll be used to store the record count.
            Int32 RecordCount = 0;
            // This'll be used for data connection.
            clsDataConnection DB = new clsDataConnection();
            // Executes stored procedure.
            DB.Execute("sproc_tblStaff_SelectAll");
            // Populates the DB for filtering, if needed.
            //PopulateArray(DB);
            // Get the count of records within the DB.
            RecordCount = DB.Count;
            // So long as there are records to process, the below while loop will occur.
            while (Index < RecordCount)
            {
                // Creates a blank address.
                clsStaff SampleStaff = new clsStaff();
                // Reads in the fields from the DB.
                SampleStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                SampleStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                SampleStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                SampleStaff.DateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEmployment"]);
                SampleStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                SampleStaff.IsEmployed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsEmployed"]);

                // Adds the record to the private data variable.
                mStaffList.Add(SampleStaff);
                // Points to the next index.
                Index++;
            }
        }

        public List<clsStaff> StaffList 
        {
            get
            {
                // Returns the private data.
                return mStaffList;
            }
            set
            {
                // Sets the private data
                mStaffList = value;
            }
        }
        public int Count 
        { 
            get
            {
                // Returns the count of the list.
                return mStaffList.Count;
            }
            set
            {
                // TODO.
            }
        }

        public clsStaff ThisStaff 
        { 
            get
            {
                // Returns the private data.
                return mThisStaff;
            }
            set
            {
                // Sets the private data.
                mThisStaff = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            // Populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            // Creates a variable to store the record count.
            Int32 RecordCount;
            // Get the count of the records.
            RecordCount = DB.Count;
            // Clears the private array list.
            mStaffList = new List<clsStaff>();
            // While there are new records to process, create a blank address, read in the fields from the current record.
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                AStaff.StaffNo = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNo"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffRole = Convert.ToString(DB.DataTable.Rows[Index]["StaffRole"]);
                AStaff.DateOfEmployment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEmployment"]);
                AStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                AStaff.IsEmployed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsEmployed"]);
                // Adds the record to the private data member
                mStaffList.Add(AStaff);
                // Points at the next record.
                Index++;

            }
        }

        public int Add()
        {
            // We'll add a new record to the DB based on the values of thisStaff, and connects to DB.
            clsDataConnection DB = new clsDataConnection();
            // Sets the parameters for the insert stored procedure.
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@DateOfEmployment", mThisStaff.DateOfEmployment);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);
            // Executes the stored procedure to actually store the data.
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            // This'll update an existing record based on the values of thisStaff, and connects to DB.
            clsDataConnection DB = new clsDataConnection();
            // Sets the parameters for the update stored procedure.
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffRole", mThisStaff.StaffRole);
            DB.AddParameter("@DateOfEmployment", mThisStaff.DateOfEmployment);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);
            // Executes the stored procedure to actually store the data.
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            // Deletes the record pointed to by ThisStaff, connects to the DB, sets the parameter and executes the stored procedure.
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNo", mThisStaff.StaffNo);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void FilterByStaffRole(string StaffRole)
        {
            // Filters the records based on the provided staff role.
            clsDataConnection DB = new clsDataConnection();
            // Sends the staff role parameter to the database.
            DB.AddParameter("@StaffRole", StaffRole);
            // Executes stored procedure.
            DB.Execute("sproc_tblStaff_FilterByStaffRole");
            // Populates the array list with the data table.
            PopulateArray(DB);
        }
    }
}