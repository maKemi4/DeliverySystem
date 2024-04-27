CREATE TABLE [dbo].[OrderItem]
(
	[OrderItemId] INT PRIMARY KEY IDENTITY, 
    [DeliveryQueueId] INT NOT NULL, 
    [OrderId] INT NOT NULL, 
    CONSTRAINT [FK_OrderItems_DeliveryQueue_DeliveryQueueId] FOREIGN KEY ([DeliveryQueueId]) REFERENCES [DeliveryQueue]([DeliveryQueueId]), 
    CONSTRAINT [FK_OrderItems_Order_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Order]([OrderId])
)
