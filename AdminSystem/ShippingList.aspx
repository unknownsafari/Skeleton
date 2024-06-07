<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 546px; position: absolute" Text="Add" />
        </div>
        <asp:ListBox ID="lstShippingList" runat="server" Height="490px" Width="662px"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 138px; top: 549px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 263px; top: 547px; position: absolute" Text="Delete" />
        <asp:Button ID="btnApplyFliter" runat="server" OnClick="btnApplyFliter_Click" style="z-index: 1; left: 33px; top: 657px; position: absolute" Text="Apply Filter" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 729px; position: absolute; height: 19px"></asp:Label>
        <asp:Button ID="btnClearFilter" runat="server" style="z-index: 1; left: 228px; top: 657px; position: absolute" Text="Clear Filter" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 39px; top: 602px; position: absolute" Text="Enter a Order Id"></asp:Label>
        <asp:TextBox ID="txtbxOrderId" runat="server" style="z-index: 1; left: 209px; top: 600px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
