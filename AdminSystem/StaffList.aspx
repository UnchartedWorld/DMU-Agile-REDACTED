<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/StaffImagesAndCSS/Staff.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Staff List Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStaffList" runat="server" Height="277px" Width="262px"></asp:ListBox>
        <h4>
            <asp:Button ID="btnAdd" runat="server" Height="31px" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnUpdate" runat="server" Height="31px" OnClick="btnUpdate_Click" style="margin-left: 5px" Text="Update" />
            <asp:Button ID="btnDelete" runat="server" Height="31px" OnClick="btnDelete_Click" style="margin-left: 5px" Text="Delete" />
            <br />
            <asp:Label ID="lblFilterByRole" runat="server" Text="Staff role filter: "></asp:Label>
            <asp:DropDownList ID="DropDownLst" runat="server" AppendDataBoundItems="true" style="margin-top: 24px">
                <asp:ListItem Text="" Value="0" />
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnFilter" runat="server" OnClick="btnFilter_Click" style="margin-top: 5px" Text="Filter" />
            <asp:Button ID="btnFilterClear" runat="server" OnClick="btnFilterClear_Click" style="margin-left: 5px" Text="Clear Filter" />
        </h4>
        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Italic="True" ForeColor="#FF5050"></asp:Label>
    </form>
</body>
</html>
