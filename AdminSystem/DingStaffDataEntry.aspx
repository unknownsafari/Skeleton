<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DingStaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblstaff" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute; right: 1770px" Text="Staff " width="72px"></asp:Label>
            <asp:Label ID="lblstaff0" runat="server" style="z-index: 1; left: 11px; top: 15px; position: absolute; right: 1770px" Text="StaffID" width="72px"></asp:Label>
            <asp:TextBox ID="txtstaff" runat="server" OnTextChanged="txtstaff_TextChanged" style="z-index: 1; left: 178px; top: 14px; position: absolute; width: 191px"></asp:TextBox>
        </div>
        <p>
            <asp:Label ID="lblNUM" runat="server" style="z-index: 1; left: 13px; top: 57px; position: absolute" Text="StaffNum" width="72px"></asp:Label>
            <asp:TextBox ID="txtStaffNUM" runat="server" height="26px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 178px; top: 53px; position: absolute; width: 191px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPosition" runat="server" style="z-index: 1; left: 10px; top: 116px; position: absolute; bottom: 840px" Text="Position" width="72px"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtposition" runat="server" height="26px" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 179px; top: 118px; position: absolute" width="191px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbldatejoin" runat="server" style="z-index: 1; left: 3px; top: 174px; position: absolute; right: 1793px; width: 109px" Text="date of joining"></asp:Label>
            <asp:TextBox ID="lbldate" runat="server" height="26px" style="z-index: 1; top: 183px; position: absolute; left: 180px" width="191px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblsalary" runat="server" style="z-index: 1; left: 10px; top: 236px; position: absolute" Text="salary"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" height="26px" OnTextChanged="TextBox1_TextChanged1" style="z-index: 1; left: 180px; top: 235px; position: absolute; margin-top: 0px" width="191px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="chkActive" runat="server" style="z-index: 1; top: 298px; position: absolute; left: 245px" Text="Active"></asp:Label>
            <asp:TextBox ID="txtact" runat="server" style="z-index: 1; left: 197px; top: 299px; position: absolute; width: 21px; right: 1679px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 17px; top: 381px; position: absolute; width: 81px" Text="OK" />
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 157px; top: 383px; position: absolute" Text="Button" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 29px; top: 340px; position: absolute" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
