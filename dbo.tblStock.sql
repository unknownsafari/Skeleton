CREATE TABLE [dbo].[tblStock] (
    [ProductId]            INT             IDENTITY (1, 1) NOT NULL,
    [ProductName]          VARCHAR (50)    NOT NULL,
    [CurrentStockLevel]    INT             NOT NULL,
    [UnitPrice]            DECIMAL (18, 2) NOT NULL,
    [MinimumRecorderLEvel] INT             NULL,
    [Platform]             VARCHAR (15)    NULL,
    [Publisher]            VARCHAR (20)    NULL,
    PRIMARY KEY CLUSTERED ([ProductId] ASC)
);

