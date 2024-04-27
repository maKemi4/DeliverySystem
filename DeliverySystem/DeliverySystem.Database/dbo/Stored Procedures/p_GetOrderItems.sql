CREATE PROCEDURE [dbo].[p_GetOrderItems]
	@OrderId int
AS
-- для задачі комівояжера
	SELECT oi.OrderId, dr.DeliveryRequestId, dr.LocalityName, dr.Longitude, dr.Latitude, dr.Importance, dq.ImportanceRate FROM OrderItem oi
		LEFT JOIN [Order] o on o.OrderId = oi.OrderId
		LEFT JOIN [DeliveryQueue] dq on dq.DeliveryQueueId = oi.DeliveryQueueId
		LEFT JOIN [DeliveryRequest] dr on dr.DeliveryRequestId = dq.DeliveryRequestId
	WHERE o.OrderId = @OrderId
RETURN 0
