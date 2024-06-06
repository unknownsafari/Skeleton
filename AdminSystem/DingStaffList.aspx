<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DingStaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lstStaffList">
            <asp:ListBox runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" ID="lstStaffList" Height="429px" Width="478px"></asp:ListBox>
            <asp:Button ID="btnReturntoMainMenu" runat="server" OnClick="btnReturntoMainMenu_Click" style="z-index: 1; left: 564px; top: 50px; position: absolute" Text="ReturntoMainMenu" />
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 89px; top: 462px; position: absolute" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 239px; top: 461px; position: absolute" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 332px; top: 462px; position: absolute" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 32px; top: 569px; position: absolute; height: 19px"></asp:Label>
        </p>
    </form>
</body>
</html>
