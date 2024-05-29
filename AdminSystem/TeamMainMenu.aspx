<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label runat="server" Text="Games Galaxy Main Menu" ID="lblMainMenu"></asp:Label>
        </div>
        <div>&nbsp;</div>
        <div>&nbsp;<asp:Button runat="server" Text="Staff" ID="btnStaff"></asp:Button>
            <asp:Button runat="server" Text="Customer" ID="btnCustomer"></asp:Button>
            </asp:Button><asp:Button runat="server" Text="Shipping" ID="btnShipping"></asp:Button>
            <asp:Button runat="server" Text="Orders" ID="btnOrders"></asp:Button>
            <asp:Button runat="server" Text="Stock" ID="btnStock" OnClick="btnStock_Click"></asp:Button></div>
        <div>&nbsp;</div>
    </form>
</body>
</html>
