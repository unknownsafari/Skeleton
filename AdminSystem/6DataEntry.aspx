<%@ Page Language="C#" AutoEventWireup="true" CodeFile="6DataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblstaff" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; right: 1837px" Text="Staff ID"></asp:Label>
        <div>
            <asp:TextBox ID="txtstaff" runat="server" OnTextChanged="txtstaff_TextChanged" style="z-index: 1; left: 190px; top: 14px; position: absolute; width: 191px"></asp:TextBox>
            <br />
        </div>
        <p>
            <asp:TextBox ID="txtStaffNUM" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 187px; top: 53px; position: absolute; width: 197px"></asp:TextBox>
            <asp:Label ID="lblNUM" runat="server" style="z-index: 1; left: 13px; top: 57px; position: absolute" Text="Staff NUM"></asp:Label>
            <asp:Label ID="lblPosition" runat="server" style="z-index: 1; left: 10px; top: 116px; position: absolute" Text="Position"></asp:Label>
            <asp:TextBox ID="txtposition" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 187px; top: 118px; position: absolute"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lbldatejoin" runat="server" style="z-index: 1; left: 3px; top: 174px; position: absolute; right: 1760px" Text="date of joining"></asp:Label>
            <asp:TextBox ID="lbldate" runat="server" style="z-index: 1; top: 172px; position: absolute; left: 195px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged1" style="z-index: 1; left: 192px; top: 234px; position: absolute; margin-top: 0px"></asp:TextBox>
        </p>
        <asp:Label ID="lblsalary" runat="server" style="z-index: 1; left: 10px; top: 236px; position: absolute" Text="salary"></asp:Label>
        <p>
            <asp:Label ID="chkActive" runat="server" style="z-index: 1; top: 298px; position: absolute; left: 245px" Text="Active"></asp:Label>
        </p>
        <asp:TextBox ID="txtact" runat="server" style="z-index: 1; left: 197px; top: 299px; position: absolute; width: 21px"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 23px; top: 326px; position: absolute" Text="Label"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 17px; top: 381px; position: absolute; width: 81px" Text="OK" />
        </p>
        <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 157px; top: 383px; position: absolute" Text="Button" />
    </form>
</body>
</html>
