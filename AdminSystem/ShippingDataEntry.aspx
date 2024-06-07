<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>


    <body id="chkActive">
        <form id="form1" runat="server">


    <asp:TextBox ID="txtShipmentId" runat="server"  style="z-index: 1; left: 179px; top: 57px; position: absolute" height="15px"></asp:TextBox>
    <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 3px; top: 121px; position: absolute" Text="Order ID" height="19px" width="164px"></asp:Label>
    <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 179px; top: 121px; position: absolute; height: 15px;" width="128px"></asp:TextBox>
    <asp:Label ID="lblCarrierId" runat="server" style="z-index: 1; left: 12px; top: 174px; position: absolute; width: 164px" Text="Carrier" height="19px"></asp:Label>
    <asp:TextBox ID="txtCarrierId" runat="server" style="z-index: 1; left: 179px; top: 175px; position: absolute" height="15px" width="128px"></asp:TextBox>
    <p>
        <asp:Button ID="BtnFind" runat="server" OnClick="BtnFind_Click" style="z-index: 1; left: 379px; top: 54px; position: absolute" Text="Find" />
        <asp:Label ID="lblShipmentId" runat="server" Text="Shipment Id"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblTrackingNumberId" runat="server" style="z-index: 1; left: 10px; top: 222px; position: absolute" Text="Tracking Number" height="19px" width="164px"></asp:Label>
        <asp:TextBox ID="txtTrackingNumberId" runat="server" style="z-index: 1; top: 219px; position: absolute; left: 179px" height="15px" width="128px"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="lblActualDeliveryDateId" runat="server" style="z-index: 1; left: 5px; top: 310px; position: absolute; width: 136px; height: 19px;" Text="Actual Delivery Date"></asp:Label>
        <asp:TextBox ID="txtShippingDateId" runat="server" style="z-index: 1; left: 179px; top: 270px; position: absolute; height: 15px;" width="128px"></asp:TextBox>
    </p>
    <asp:Label ID="lblShippingdateId" runat="server" style="z-index: 1; left: 15px; top: 271px; position: absolute; height: 19px" Text="Shipping Date" width="164px"></asp:Label>
    <p>
        &nbsp;</p>
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 29px; top: 485px; position: absolute; height: 19px;"></asp:Label>

    <p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 69px; top: 533px; position: absolute; right: 378px; height: 26px;" Text="OK" width="60px" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 215px; top: 533px; position: absolute" Text="Cancel" />
    </p>
        
      
        <asp:TextBox ID="txtActualDeliveryDateId" runat="server" style="z-index: 1; left: 179px; top: 307px; position: absolute; height: 15px;" width="128px"></asp:TextBox>
       
          
                &nbsp;<asp:CheckBox ID="chkDelivered" runat="server" style="z-index: 1; left: 106px; top: 385px; position: absolute; height: 34px;" Text="Delivered" />
            
            <p>
                &nbsp;</p>
        </form>
        </body>


        