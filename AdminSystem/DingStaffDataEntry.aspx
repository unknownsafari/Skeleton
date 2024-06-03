<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DingStaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Staff ID" width="75px"></asp:Label>
            <asp:TextBox ID="txtStaff" runat="server" style="z-index: 1; left: 96px; top: 7px; position: absolute"></asp:TextBox>
        </div>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 7px; top: 39px; position: absolute" Text="House NO" width="75px"></asp:Label>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 98px; top: 34px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPS" runat="server" style="z-index: 1; left: 13px; top: 164px; position: absolute" Text="Post Code" width="75px"></asp:Label>
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 13px; top: 63px; position: absolute" Text="Street" width="75px"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 100px; top: 64px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 13px; top: 99px; position: absolute" Text="Town" width="75px"></asp:Label>
        <asp:Label ID="lblCounty" runat="server" style="z-index: 1; left: 11px; top: 136px; position: absolute" Text="County" width="75px"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 12px; top: 201px; position: absolute" Text="Date Added"></asp:Label>
        <p>
            <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 100px; top: 100px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 100px; top: 134px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPS" runat="server" style="z-index: 1; left: 103px; top: 167px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 102px; top: 200px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtAct" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 121px; top: 251px; position: absolute; width: 16px"></asp:TextBox>
        <p>
            <asp:Label ID="lblAct" runat="server" style="z-index: 1; left: 147px; top: 250px; position: absolute" Text="Active"></asp:Label>
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 291px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 25px; top: 324px; position: absolute; width: 48px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 129px; top: 322px; position: absolute" Text="Cancel" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
