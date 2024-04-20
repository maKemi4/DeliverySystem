CREATE PROCEDURE [dbo].[p_GetDeliveryQueueRecords]
	@OnlyNotCompleted bit
AS
	SELECT DeliveryQueueId, Importance from dbo.DeliveryQueue q
	LEFT JOIN DeliveryRequest r on q.DeliveryRequestId = r.DeliveryRequestId
	where @OnlyNotCompleted = 0 OR (@OnlyNotCompleted = 1 AND IsCompleted = 0)

RETURN 0
