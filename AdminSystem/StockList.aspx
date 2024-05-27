<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     &nbsp;<form id="form1" runat="server">
        <div>
         <asp:ListBox runat="server" ID="lstStockList" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged" Height="521px" Width="704px"></asp:ListBox>
       
               
        </div>
         <div>&nbsp;</div>
         <div>
             <asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
             <br />
         </div>
         <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>