CREATE PROCEDURE [dbo].[p_GetOrder]
	@OrderId int
AS
-- для задачі комівояжера
	SELECT dr.Longitude, dr.Latitude, dq.ImportanceRate FROM OrderItem oi
		LEFT JOIN [Order] o on o.OrderId = oi.OrderId
		LEFT JOIN [DeliveryQueue] dq on dq.DeliveryQueueId = oi.DeliveryQueueId
		LEFT JOIN [DeliveryRequest] dr on dr.DeliveryRequestId = dq.DeliveryRequestId
	WHERE o.OrderId = @OrderId
RETURN 0
