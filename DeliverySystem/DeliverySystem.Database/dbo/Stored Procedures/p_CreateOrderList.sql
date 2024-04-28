CREATE PROCEDURE [dbo].[p_CreateOrderList]
	@DeliveryQueueItemIds NVARCHAR(255),
	@OrderExecutorId int
AS
	INSERT INTO [Order] (OrderExecutorId)
	VALUES (@OrderExecutorId)

	DECLARE @OrderId INT = SCOPE_IDENTITY()

	Create Table #ids (DeliveryQueueId int);

	INSERT INTO #ids (DeliveryQueueId)
	SELECT value FROM STRING_SPLIT(@DeliveryQueueItemIds, ',') 

	INSERT INTO OrderItem (OrderId, [DeliveryQueueId])
	SELECT @OrderId, DeliveryQueueId FROM #ids

	UPDATE DeliveryQueue 
	SET IsCompleted = 1
	WHERE DeliveryQueueId in (SELECT * FROM #ids)

	-- end of sp
	Drop Table #ids

	SELECT @OrderId as OrderId

RETURN 0
