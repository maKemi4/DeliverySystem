CREATE PROCEDURE [dbo].[p_CreateOrderList]
	@DeliveryQueueItemIds NVARCHAR(255), -- "1,2,3,4,5"
	@ExecutorName VARCHAR(50),
	@ExecutorSurname VARCHAR(50),
	@OrganizationName VARCHAR(50)
AS
	DECLARE @OrderExecutorId INT;
	-- Insert into Замовлення
	IF NOT EXISTS(SELECT TOP 1 * FROM OrderExecutor WHERE ExecutorName = @ExecutorName and ExecutorSurname = @ExecutorSurname)
	BEGIN 
		INSERT INTO OrderExecutor (ExecutorName, ExecutorSurname, OrganizationName)
		VALUES (@ExecutorName, @ExecutorSurname, @OrganizationName)
		SELECT @OrderExecutorId = SCOPE_IDENTITY();
	END
	ELSE
	BEGIN 
		SELECT @OrderExecutorId = OrderExecutorId FROM OrderExecutor WHERE ExecutorName = @ExecutorName and ExecutorSurname = @ExecutorSurname;
	END

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
