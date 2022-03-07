<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/StaffImagesAndCSS/Staff.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Staff Data Entry Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblStaffNo">
            <asp:Label ID="lblStaffNo" runat="server" Text="Staff No" width="165px"></asp:Label>
            <asp:TextBox ID="txtStaffNo" runat="server" TextMode="Number" ToolTip="Only used for the Find function." ></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" style="margin-left: 8px" Text="Find" OnClick="btnFind_Click" />
        </div>
        <asp:Label ID="lblStaffName" runat="server" Text="Staff Name" width="165px"></asp:Label>
        <asp:TextBox ID="txtStaffName" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffRole" runat="server" Text="Staff Role" width="165px"></asp:Label>
        <asp:TextBox ID="txtStaffRole" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffSalary" runat="server" Text="Staff Salary (£)" width="165px"></asp:Label>
        <asp:TextBox ID="txtStaffSalary" runat="server" TextMode="Number" ToolTip="Negative salary inputs will not be accepted, and will cause an error to occur."></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOfEmployment" runat="server" Text="Date Of Employment"></asp:Label>
        <asp:TextBox ID="txtDateOfEmployment" runat="server" TextMode="Date" ToolTip="The time will be set to default values - 00:00:00 or 12:00:00."></asp:TextBox>
        <br />
        <asp:Label ID="lblIsEmployed" runat="server" Text="Is Employed" ToolTip="Check this if the new entry is employed or not." width="165px"></asp:Label>
        <asp:CheckBox ID="chkIsEmployed" runat="server" />
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="margin-left: 5px" />
        <asp:Button ID="btnListView" runat="server" style="margin-left: 5px" Text="View Staff" Width="88px" OnClick="btnListView_Click" />
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#FF5050"></asp:Label>
    </form>
</body>
</html>
