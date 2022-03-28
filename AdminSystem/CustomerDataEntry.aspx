<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID" width="100px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email" width="100px"></asp:Label>
            <asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCustomerPassword" runat="server" Text="Customer Password" width="100px"></asp:Label>
            <asp:TextBox ID="txtCustomerPassword" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="100px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="height: 26px" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>

