<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="~/StaffImagesAndCSS/Staff.css" rel="stylesheet" type="text/css" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Staff Confirm/Delete Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2> Are you certain you wish to delete this record?</h2>
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" style="margin-left: 5px" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" Text="No" style="margin-left: 5px" OnClick="btnNo_Click" />
    </form>
</body>
</html>
