using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
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
        }
    }

    void DisplayStaff()
    {
        // Creates an instance of the Staff Collection.
        clsStaffCollection StaffyCollection = new clsStaffCollection();
        // Sets data source to list of addresses in the collection.
        lstStaffList.DataSource = StaffyCollection.StaffList;
        // Sets the name of the primary key, in this case StaffNo.
        lstStaffList.DataValueField = "StaffNo";
        // Sets the data field to display.
        lstStaffList.DataTextField = "StaffName";
        // Binds the data to the list.
        lstStaffList.DataBind();
    }
}

