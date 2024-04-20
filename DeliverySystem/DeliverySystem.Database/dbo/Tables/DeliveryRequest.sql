﻿CREATE TABLE [dbo].[DeliveryRequest]
(
	[DeliveryRequestId] INT NOT NULL PRIMARY KEY, 
    [LocalityName] VARCHAR(32) NOT NULL, 
    [Latitude] DECIMAL(18, 2) NOT NULL, 
    [Longitude] DECIMAL(18, 2) NOT NULL, 
    [NumOfVictims] INT NOT NULL, 
    [NumOfSeverelVictims] INT NOT NULL, 
    [ConditionType] INT NOT NULL , 
    [SituationDescription] VARCHAR(50) NULL, 
    [CustomerId] INT NOT NULL, 
    CONSTRAINT [FK_DeliveryRequest_Customer_CustomerId] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([CustomerId])
)