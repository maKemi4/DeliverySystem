CREATE PROCEDURE [dbo].[p_GetDeliveryQueueRecords]
	@OnlyNotCompleted bit
AS
	SELECT DeliveryQueueId, ImportanceRate, SubmissionDate  from dbo.DeliveryQueue
	where @OnlyNotCompleted = 0 OR (@OnlyNotCompleted = 1 AND IsCompleted = 0)

RETURN 0
