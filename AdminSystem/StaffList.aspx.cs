using System;
using ClassLibrary;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this happens to be the first time it loads, update the list box.
        if (IsPostBack == false)
        {
            DisplayStaff();
            ListStaffRoles(); //  This displays the drop down menu.
        }
    }

    void DisplayStaff()
    {
        // Creates an instance of the Staff Collection.
        clsStaffCollection StaffyCollection = new clsStaffCollection();
        // Sets data source to list of staff in the collection.
        lstStaffList.DataSource = StaffyCollection.StaffList;
        // Sets the name of the primary key, in this case StaffNo.
        lstStaffList.DataValueField = "StaffNo";
        // Sets the data field to display.
        lstStaffList.DataTextField = "StaffName";
        // Binds the data to the list.
        lstStaffList.DataBind();

        // Adds an if condition in the scenario where the system lacks data due to being fresh and new.
        if (lstStaffList == null)
        {
            lblError.Text += "List is empty. This may be due to a connection issue, or more likely, there isn't data in the system. " +
                "If you find it to be the latter, please enter data." + "<br />";
        }
    }

    // This'll display the staff roles for the end user to select.
    void ListStaffRoles()
    {
        // Creates an instance of the staff collection.
        clsStaffCollection StaffColl = new clsStaffCollection();
        // Sets the data source to list the available roles in the collection.
        DropDownLst.DataSource = StaffColl.StaffList;
        // Sets the name of the primary key, in this case StaffNo
        DropDownLst.DataValueField = "StaffNo";
        // Sets the data field to display.
        DropDownLst.DataTextField = "StaffRole";
        // Binds the data to the list.
        DropDownLst.DataBind();

        if (DropDownLst == null)
        {
            lblError.Text += "List is empty, so the drop down list is also empty. There likely isn't any data in the system, so please add some." + "<br />"; 
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Stores -1 into the session object, showing it's a new record.
        Session["StaffNo"] = -1;
        // Redirects to the data entry page.
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        // Variable that'll get used to store the primary key of the record that's going to be edited.
        Int32 StaffNo;
        // If a record is selected from the list, get the primary key of the value to be edited, store it in a session object and redirect to the edit page.
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffNo"] = StaffNo;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else // If no record is selected, print an error.
        {
            lblError.Text = "Please select a record to edit from the provided list.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // Variable that'll store the primary key of the record to be edited.
        Int32 StaffNo;
        // If a record is selected from the list, get the primary key of the value to be deleted, store it in a session object and redirect to the delete page.
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffNo = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffNo"] = StaffNo;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else // If no record is selected, print an error.
        {
            lblError.Text = "Please select a record to delete from the provided list.";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        // This'll store the primary key of the value that we'll use to filter the list.
        // If a record is selected from the drop down list, it will retrieve its text, then it'll filter the list box.
        if (DropDownLst.SelectedIndex != -1)
        {
            // Creates an instance of the staff collection.
            clsStaffCollection StaffListy = new clsStaffCollection();
            StaffListy.FilterByStaffRole(DropDownLst.SelectedItem.Text);
            lstStaffList.DataSource = StaffListy.StaffList;
            // Sets the primary key.
            lstStaffList.DataValueField = "StaffNo";
            // Sets the name of the field to display.
            lstStaffList.DataTextField = "StaffName";
            // Binds data to the list.
            lstStaffList.DataBind();
        }
    }

    protected void btnFilterClear_Click(object sender, EventArgs e)
    {
        // Creates an instance of the staff collection.
        clsStaffCollection SomeStaff = new clsStaffCollection();
        SomeStaff.FilterByStaffRole("");
        // Sets the drop down menu to blank, ready for a new selection.
        DropDownLst.SelectedIndex = 0;
        lstStaffList.DataSource = SomeStaff.StaffList;
        // Sets the primary key.
        lstStaffList.DataValueField = "StaffNo";
        // Sets the name of the field to display.
        lstStaffList.DataTextField = "StaffName";
        // Binds data to the list.
        lstStaffList.DataBind();
    }
}

