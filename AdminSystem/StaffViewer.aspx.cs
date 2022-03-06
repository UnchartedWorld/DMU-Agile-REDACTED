using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Creates a new instance of the class.
        clsStaff staff = new clsStaff();
        // Retrieves the data from the session object.
        staff = (clsStaff)Session["sampleStaffData"];
        // Displays the stored session data from the Staff Data Entry page.
        Response.Write(staff.StaffName + "<br />" + staff.StaffRole + "<br />" + "£" + staff.StaffSalary + "<br />" + staff.DateOfEmployment + "<br />" + staff.IsEmployed);
    }
}
