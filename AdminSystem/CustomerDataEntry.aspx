<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    &nbsp;<form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Customer ID" width="145px"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server" style="z-index: 1; left: 193px; top: 15px; position: absolute; width: 183px;"></asp:TextBox>
        </div>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 40px; position: absolute" Text="First Name" width="145px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 192px; top: 41px; position: absolute; width: 183px;"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 10px; top: 66px; position: absolute" Text="Last Name" width="145px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 191px; top: 67px; position: absolute; width: 183px;"></asp:TextBox>
        <asp:Label ID="lblEmailAddress" runat="server" style="z-index: 1; left: 10px; top: 94px; position: absolute" Text="Email Address" width="145px"></asp:Label>
        <asp:TextBox ID="txtEmailAddress" runat="server" style="z-index: 1; left: 190px; top: 93px; position: absolute; width: 183px;"></asp:TextBox>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 10px; top: 119px; position: absolute; right: 1330px;" Text="Phone Number" width="145px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" style="z-index: 1; left: 189px; top: 119px; position: absolute; width: 183px;"></asp:TextBox>
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 10px; top: 144px; position: absolute" Text="Date of Birth" width="145px"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 188px; top: 144px; position: absolute; width: 183px;"></asp:TextBox>
        <asp:Label ID="lblNewsletter" runat="server" style="z-index: 1; left: 10px; top: 168px; position: absolute" Text="Newsletter Subscription"></asp:Label>
        <asp:CheckBox ID="chkNewsletter" runat="server" style="z-index: 1; left: 184px; top: 170px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 204px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 244px; position: absolute; width: 87px" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 116px; top: 244px; position: absolute; width: 87px" Text="Cancel" />
    </form>
</body>
</html>
