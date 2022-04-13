<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderNo" runat="server" height="46px" Text="Order Number" width="191px"></asp:Label>
        <asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" />
        <p>
            <asp:Label ID="lblGameNo" runat="server" height="46px" Text="Game Number" width="191px"></asp:Label>
            <asp:TextBox ID="txtGameNo" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblGameTitle" runat="server" height="46px" Text="Game Title" width="191px"></asp:Label>
            <asp:TextBox ID="txtGameTitle" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="191px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateAdded" runat="server" height="46px" Text="Date Added" width="191px"></asp:Label>
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <p>
            <asp:Label ID="lblerror" runat="server" Text="[lblError]"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click1" Text="Cancel" />
    </form>
</body>
</html>
