<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DingStaffBookLogin.aspx.cs" Inherits="StaffBookLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 51px; top: 59px; position: absolute" Text="UserName"></asp:Label>
        </div>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 57px; top: 97px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 148px; top: 61px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 146px; top: 102px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 52px; top: 168px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 177px; top: 166px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 326px; top: 170px; position: absolute; height: 19px"></asp:Label>
    </form>
</body>
</html>
