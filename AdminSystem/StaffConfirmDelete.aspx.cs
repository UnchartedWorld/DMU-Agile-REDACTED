using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // Creates a new instance of the staff collection class.
        clsStaffCollection StaffColl = new clsStaffCollection();
        // Finds the record to delete
        StaffColl.ThisStaff.Find(StaffNo);
        // Deletes the record.
        StaffColl.Delete();
        // Redirects to the main page.
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}