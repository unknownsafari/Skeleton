<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="btnYes1">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 196px; top: 310px; position: absolute; width: 56px" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 397px; top: 309px; position: absolute; width: 62px" Text="No" />
            <asp:Label ID="lblshippingdelete" runat="server" style="z-index: 1; left: 210px; top: 229px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
    </form>
</body>
</html>
