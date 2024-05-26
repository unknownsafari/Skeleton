<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   &nbsp;<form id ="form1" runat="server">
       <div>   
           <asp:Label runat="server" Text="Product ID" ID="lblProductId" width="210px"></asp:Label>     
           <asp:TextBox runat="server" ID="txtProductID" width="188px"></asp:TextBox>
       </div>
       <div>&nbsp;</div>
       <div>
           <asp:Label runat="server" Text="Product Name" ID="lblProductName" width="210px"></asp:Label>     
           <asp:TextBox runat="server" ID="txtProductName" width="188px"></asp:TextBox>&nbsp;</div>
       <div>&nbsp;</div>
       <div><asp:Label runat="server" Text="Current Stock Level" ID="lblCurrentStockLevel" Height="21px" width="127px"></asp:Label>                      
           <asp:TextBox runat="server" ID="txtCurrentStockLevel" style="margin-left: 87px" width="188px"></asp:TextBox></div>
       <div>&nbsp;</div>
       <div>
           <asp:Label runat="server" Text="Unit Price" ID="lblUnitPrice" width="210px"></asp:Label>
           <asp:TextBox runat="server" ID="txtUnitPrice" width="188px"></asp:TextBox>&nbsp;</div>
       <div>&nbsp;</div>
       <div>
           <asp:Label runat="server" Text="Minimum Recorder Level" ID="lblMinimumRecorder" width="210px"></asp:Label>
           <asp:TextBox runat="server" ID="txtMinimumRecorder"></asp:TextBox>&nbsp;</div>
       <div>&nbsp;</div>
       <div>
           <asp:Label runat="server" Text="Platform" ID="lblPlatform" width="210px"></asp:Label>&nbsp;<asp:TextBox runat="server" ID="txtPlatform" width="188px"></asp:TextBox></div>
       <div>&nbsp;</div>
       <div>
           <asp:Label runat="server" Text="Publisher" ID="lblPublisher" width="210px"></asp:Label>&nbsp;<asp:TextBox runat="server" ID="txtPublisher" width="188px"></asp:TextBox></div>
       <div>&nbsp;</div>
       <div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:CheckBox runat="server" ID="chkActive" Text="Limited Edition"></asp:CheckBox></div>
       <div>&nbsp;</div>
       <div><div>&nbsp;<asp:Label runat="server" ID="lblError"></asp:Label></div>
       <div>&nbsp;</div>
       <div>&nbsp; <asp:Button runat="server" Text="OK" ID="btnOK" OnClick="btnOK_Click" Width="50px"></asp:Button>                                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                                                <asp:Button runat="server" Text="Cancel" ID="btnCancel"></asp:Button></div>
       <div>&nbsp;</div>
       <div>&nbsp;</div>
       
       
       
       
       
          
    </form>
</body>
</html>
