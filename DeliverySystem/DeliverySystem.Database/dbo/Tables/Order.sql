CREATE TABLE [dbo].[Order]
(
	[OrderId] INT PRIMARY KEY IDENTITY, 
    [CreationDate] DATETIME DEFAULT GETDATE() NOT NULL, 
    [OrderExecutorId] INT NOT NULL, 
    CONSTRAINT [FK_Order_OrderExecutor_OrderExecutorId] FOREIGN KEY ([OrderExecutorId]) REFERENCES [OrderExecutor](OrderExecutorId)
)
