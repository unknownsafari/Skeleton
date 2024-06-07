CREATE PROCEDURE sproc_tblshipping_FilterbyOrderId
    @OrderId varchar(50)
AS

    SELECT * FROM tblShipping
    WHERE OrderId LIKE @OrderId + '%';

