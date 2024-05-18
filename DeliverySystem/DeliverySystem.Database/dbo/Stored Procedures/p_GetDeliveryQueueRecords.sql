CREATE PROCEDURE [dbo].[p_GetDeliveryQueueRecords]
	@OnlyNotCompleted bit
AS
	SELECT dq.DeliveryQueueId, dq.ImportanceRate, dq.SubmissionDate, dq.IsCompleted, dr.LocalityName,
	c.CustomerSurname + ' ' + c.CustomerName AS CustomerFullName, c.PhoneNum
	FROM dbo.DeliveryQueue dq
	LEFT JOIN DeliveryRequest dr ON dq.DeliveryRequestId = dr.DeliveryRequestId
	LEFT JOIN Customer c ON dr.CustomerId = c.CustomerId
	
	WHERE @OnlyNotCompleted = 0 OR (@OnlyNotCompleted = 1 AND IsCompleted = 0)

RETURN 0
