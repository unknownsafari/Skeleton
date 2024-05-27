<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     &nbsp;<form id="form1" runat="server">
        <div>
         <asp:ListBox runat="server" ID="lstStockList" OnSelectedIndexChanged="lstStockList_SelectedIndexChanged"></asp:ListBox>
       
               
        </div>
         <div>&nbsp;</div>
         <div>
             <asp:Button runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"></asp:Button>&nbsp;</div>
    </form>
</body>
</html>