CREATE TABLE [dbo].[DeliveryRequest]
(
	[DeliveryRequestId] INT PRIMARY KEY IDENTITY, 
    [LocalityName] VARCHAR(32) NOT NULL, 
    [Latitude] DECIMAL(18, 6) NOT NULL, 
    [Longitude] DECIMAL(18, 6) NOT NULL, 
    [NumOfVictims] INT NOT NULL, 
    [NumOfSeveralyVictims] INT NOT NULL, 
    [ConditionType] INT NOT NULL , 
    [SituationDescription] VARCHAR(50) NULL, 
    [Importance] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    CONSTRAINT [FK_DeliveryRequest_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId])
)
