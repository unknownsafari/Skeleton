<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Are you sure you want to delete this record?" ID="lblStockDelete"></asp:Label>
        </div>
        <div>&nbsp;</div>
        <div>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button runat="server" Text="Yes" ID="btnYes" OnClick="btnYes_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button runat="server" Text="No" ID="btnNo" OnClick="btnNo_Click"></asp:Button>&nbsp;</div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
