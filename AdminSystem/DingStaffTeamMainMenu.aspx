<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DingStaffTeamMainMenu.aspx.cs" Inherits="StaffTeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Staff&nbsp; Main Menu</p>
        <p>
            <asp:Button ID="btnStaff" runat="server" OnClick="btnStaff_Click" style="z-index: 1; left: 136px; top: 88px; position: absolute" Text="Staff" />
            <asp:Button ID="btnCustomer" runat="server" style="z-index: 1; left: 179px; top: 89px; position: absolute" Text="Customer" />
            <asp:Button ID="btnShipping" runat="server" style="z-index: 1; left: 265px; top: 88px; position: absolute" Text="Shipping" />
            <asp:Button ID="btnOrders" runat="server" style="z-index: 1; left: 342px; top: 87px; position: absolute" Text="Orders" />
            <asp:Button ID="btnStock" runat="server" style="z-index: 1; left: 404px; top: 90px; position: absolute" Text="Stock" />
        </p>
    </form>
</body>
</html>
