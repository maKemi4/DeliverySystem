CREATE PROCEDURE [dbo].[p_GetDeliveryQueueRecords]
	@OnlyNotCompleted bit
AS
	SELECT Id, Importance from dbo.DeliveryQueue q
	LEFT JOIN Customer c on q.CustomerId = c.Id
	where @OnlyNotCompleted = 0 OR (@OnlyNotCompleted = 1 AND IsCompleted = 0)

RETURN 0
