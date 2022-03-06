using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // Variable that can be used to store the primary key with page level scope.
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        // If any pre-existing error is there, it should clear it.
        lblError.Text = "";
        // Gets the number of the staff to be processed, if needed.
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            // If it's not a new record, it'll display the current data for the record.
            if (StaffNo != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        // Creates an instance of the staff collection.
        clsStaffCollection StaffColl = new clsStaffCollection();
        // Finds the record to update.
        StaffColl.ThisStaff.Find(StaffNo);
        // Displays the data for this record.
        txtStaffNo.Text = StaffColl.ThisStaff.StaffNo.ToString();
        txtStaffName.Text = StaffColl.ThisStaff.StaffName;
        txtStaffRole.Text = StaffColl.ThisStaff.StaffRole;
        txtDateOfEmployment.Text = StaffColl.ThisStaff.DateOfEmployment.ToString();
        txtStaffSalary.Text = StaffColl.ThisStaff.StaffSalary.ToString();
        chkIsEmployed.Checked = StaffColl.ThisStaff.IsEmployed;
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        // Creates a new instance of clsStaff.
        clsStaff sampleStaffData = new clsStaff();
        // The following section captures all the data field entries.
        //string StaffNo = txtStaffNo.Text;
        string StaffName = txtStaffName.Text;
        string StaffRole = txtStaffRole.Text;
        int StaffSalary = Convert.ToInt32(txtStaffSalary.Text); 
        string DateOfEmployment = txtDateOfEmployment.Text;

        // Creates a variable to store any error message.
        string Error = "";

        // Validates the data.
        Error = sampleStaffData.Validation(StaffName, StaffRole, StaffSalary, DateOfEmployment);
        if (Error == "")
        {
            // Captures the user's input data
            sampleStaffData.StaffNo = StaffNo;
            // Adds a staff name.
            sampleStaffData.StaffName = StaffName;
            // Adds a staff role.
            sampleStaffData.StaffRole = StaffRole;
            // Adds salary as an integer.
            sampleStaffData.StaffSalary = StaffSalary;
            // Adds date, so long as it adheres to the DateTime format - dd/mm/yyyy - hh:mm:ss
            sampleStaffData.DateOfEmployment = Convert.ToDateTime(DateOfEmployment);
            // Adds checkbox data for whether they're employed or not.
            sampleStaffData.IsEmployed = chkIsEmployed.Checked;
            // Creates an instance of the staff collection.
            clsStaffCollection StaffList = new clsStaffCollection();

            // If this is new, then add the record.
            if (StaffNo == -1)
            {
                // Sets ThisStaff property, and adds new record.
                StaffList.ThisStaff = sampleStaffData;
                // Adds the new record.
                StaffList.Add();
            }

            // Otherwise, it'll evidently be an update.
            else
            {
                // Finds the record to update, sets the needed property and updates it.
                StaffList.ThisStaff.Find(StaffNo);
                StaffList.ThisStaff = sampleStaffData;
                StaffList.Update();
            }
            // Redirects to the list page.
            Response.Redirect("StaffList.aspx");

            //Session["sampleStaffData"] = sampleStaffData
            // This will make it navigate to the Viewer page.
            //Response.Redirect("StaffViewer.aspx");
        }
        else
        {
            // Displays the error message.
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        // Creates an instance of the Staff class, necessary to find anything else.
        clsStaff findStaff = new clsStaff();
        // Variable that stores the primary key.
        Int32 staffNo;
        // Variable that's used to store the result of the find operation.
        Boolean Found = false;
        // Retrieves the primary key given by the end-user.
        staffNo = Convert.ToInt32(txtStaffNo.Text);
        // Looks for the record.
        Found = findStaff.Find(staffNo);
        // If it's found, then it will fill the remaining text boxes with the relevant information.
        if (Found == true)
        {
            txtStaffName.Text = findStaff.StaffName;
            txtStaffRole.Text = findStaff.StaffRole;
            txtDateOfEmployment.Text = findStaff.DateOfEmployment.ToString();
            txtStaffSalary.Text = findStaff.StaffSalary.ToString();
            // This one makes sure to click the checkbox IF it finds that the individual is employed or not.
            chkIsEmployed.Checked = findStaff.IsEmployed;
        }
        // This simply states that, should it not find the entry, the error message simply states that the entry doesn't exist.
        else
            lblError.Text = "Entry not found in database, try another number.";
    }

    protected void btnListView_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}