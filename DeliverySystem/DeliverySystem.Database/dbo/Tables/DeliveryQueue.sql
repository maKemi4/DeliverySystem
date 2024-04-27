CREATE TABLE [dbo].[DeliveryQueue]
(
	[DeliveryQueueId] INT PRIMARY KEY IDENTITY,
	[SubmissionDate] DATETIME NOT NULL DEFAULT GETDATE(), 
    [ImportanceRate] DECIMAL(18, 2) NOT NULL, 
    [IsCompleted] BIT NOT NULL DEFAULT 0, 
    [DeliveryRequestId] INT NOT NULL, 
    CONSTRAINT [FK_DeliveryQueue_DeliveryRequest_DeliveryRequestId] FOREIGN KEY ([DeliveryRequestId]) REFERENCES [DeliveryRequest]([DeliveryRequestId]), 
)
