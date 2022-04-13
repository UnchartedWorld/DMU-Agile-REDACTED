using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderNo = Convert.ToInt32(Session["OrderNo"]);
        if (IsPostBack == false)
        {
            if (OrderNo != -1)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection Order = new clsOrderCollection();
        Order.ThisOrder.Find(OrderNo);
        txtOrderNo.Text = Order.ThisOrder.OrderNo.ToString();
        txtTotalPrice.Text = Order.ThisOrder.TotalPrice.ToString();
        txtGameNo.Text = Order.ThisOrder.GameNo.ToString();
        txtGameTitle.Text = Order.ThisOrder.GameTitle;
        txtDateAdded.Text = Order.ThisOrder.DateAdded.ToString();
        chkAvailable.Checked = Order.ThisOrder.Available;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order number
        String GameTitle = txtGameTitle.Text;
        String TotalPrice = txtTotalPrice.Text;
        String DateAdded = txtDateAdded.Text;
        String GameNo = txtGameNo.Text;

        string Error = "";
        Error = AnOrder.Valid(GameTitle, TotalPrice, GameNo, DateAdded);

        if (Error == "")
        {
            AnOrder.OrderNo = OrderNo;
            AnOrder.GameTitle = GameTitle;
            AnOrder.Available = chkAvailable.Checked;
            AnOrder.TotalPrice = Convert.ToInt32(txtTotalPrice.Text);
            AnOrder.DateAdded = Convert.ToDateTime(DateAdded);
            AnOrder.GameNo = Convert.ToInt32(txtGameNo.Text);
            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderNo == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();

            }
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblerror.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        {
            //create an instance of the order class
            clsOrder AnOrder = new clsOrder();
            //variable to store the primary key
            Int32 OrderNo;
            //variable to store the result of the find operation
            Boolean Found = false;

            String OrderNumber = txtOrderNo.Text;

            string Error = "";

            if (Error == "")
            {
                AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);

                //get the primary key entered by the user
                OrderNo = Convert.ToInt32(txtOrderNo.Text);
                //find the record
                Found = AnOrder.Find(OrderNo);
                //if found
                if (Found == true)
                {
                    //display the values of the properties in the form
                    txtOrderNo.Text = AnOrder.OrderNo.ToString();
                    txtGameTitle.Text = AnOrder.GameTitle;
                    txtDateAdded.Text = AnOrder.DateAdded.ToString();
                    txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
                    txtGameNo.Text = AnOrder.GameNo.ToString();
                }
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {

    }
}