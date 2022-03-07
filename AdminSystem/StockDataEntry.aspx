<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblGameNumber" runat="server" Text="Game Number" width="109px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtGameNumber" runat="server" Height="19px" style="margin-left: 0px" Width="119px"></asp:TextBox>
        <br />
        <asp:Label ID="lblAgeRating" runat="server" Text="Age Rating" width="109px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtAgeRating" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="109px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="109px"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblGameDescription" runat="server" Text="Game Description"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtGameDescription" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
