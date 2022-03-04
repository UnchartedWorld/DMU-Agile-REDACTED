using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        // Creates some class-wide data.
        List<clsStaff> mClassList = new List<clsStaff>();

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
                SampleStaff.DateofEmployment = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateOfEmployment"]);
                SampleStaff.StaffSalary = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffSalary"]);
                SampleStaff.IsEmployed = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsEmployed"]);

                // Adds the record to the private data variable.
                mClassList.Add(SampleStaff);
                // Points to the next index.
                Index++;
            }
        }

        public List<clsStaff> StaffList 
        {
            get
            {
                // Returns the private data.
                return mClassList;
            }
            set
            {
                // Sets the private data
                mClassList = value;
            }
        }
        public int Count 
        { 
            get
            {
                // Returns the count of the list.
                return mClassList.Count;
            }
            set
            {
                // TODO.
            }
        }

        public clsStaff ThisStaff { get; set; }
    }
}