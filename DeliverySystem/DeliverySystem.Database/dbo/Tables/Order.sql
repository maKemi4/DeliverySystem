﻿CREATE TABLE [dbo].[Order]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [CreationDate] DATETIME NOT NULL, 
    [OrderExecutorId] INT NOT NULL, 
    CONSTRAINT [FK_Order_OrderExecutor_OrderExecutorId] FOREIGN KEY ([OrderExecutorId]) REFERENCES [OrderExecutor](OrderExecutorId)
)