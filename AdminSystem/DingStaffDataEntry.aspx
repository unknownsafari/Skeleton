

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
        <asp:Label ID="lblPostCode" runat="server" Style="z-index: 1; left: 13px; top: 164px; position: absolute" Text="Post Code" Width="75px" Style="z-index: 1; left: 13px; top: 164px; position: absolute"></asp:Label>
        <asp:Label ID="lblStreet" runat="server" style="z-index: 1; left: 13px; top: 63px; position: absolute" Text="Street" width="75px"></asp:Label>
        <asp:TextBox ID="txtStreet" runat="server" Style="z-index: 1; left: 100px; top: 64px; position: absolute" OnTextChanged="txtStreet_TextChanged"></asp:TextBox>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 13px; top: 99px; position: absolute" Text="Town" width="75px"></asp:Label>
        <asp:Label ID="lblCounty" runat="server" style="z-index: 1; left: 11px; top: 136px; position: absolute" Text="County" width="75px"></asp:Label>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 12px; top: 201px; position: absolute" Text="Date Added"></asp:Label>
        <p>
            <asp:TextBox ID="txtTown" runat="server" Style="z-index: 1; left: 100px; top: 100px; position: absolute" OnTextChanged="txtTown_TextChanged"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 100px; top: 134px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPS" runat="server" style="z-index: 1; left: 103px; top: 167px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 102px; top: 200px; position: absolute"></asp:TextBox>
        <asp:CheckBox ID="chkActive" Style="z-index: 1; left: 121px; top: 251px; position: absolute; width: 16px" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Active" />

        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 31px; top: 291px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 25px; top: 320px; position: absolute; width: 75px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 150px; top: 320px; position: absolute; width: 75px;" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" Style="z-index: 1; left: 275px; top: 320px; position: absolute; width: 75px;" Text="Find"  OnClick="btnFind_Click"/>

    </form>
    
    <p>
        &nbsp;</p>
</body>
</html>
