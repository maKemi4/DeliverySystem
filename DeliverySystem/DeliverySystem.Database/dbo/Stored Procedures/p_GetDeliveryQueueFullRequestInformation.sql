CREATE PROCEDURE [dbo].[p_GetDeliveryQueueFullRequestInformation]
    @DeliveryQueueId int null
AS
    BEGIN
        SELECT dq.DeliveryQueueId, dq.ImportanceRate, dq.IsCompleted, dq.SubmissionDate, 
               dr.LocalityName, dr.Importance, dr.Latitude, dr.Longitude, dr.NumOfVictims,
               dr.NumOfSeveralyVictims, dr.ConditionType, dr.AgeGroup, dr.InjuriesType, dr.SituationDescription,
               c.CustomerName, c.CustomerSurname, c.PhoneNum, c.Email
        FROM DeliveryQueue dq
        LEFT JOIN DeliveryRequest dr ON dq.DeliveryRequestId = dr.DeliveryRequestId
        LEFT JOIN Customer c ON dr.CustomerId = c.CustomerId
        WHERE dq.DeliveryQueueId = @DeliveryQueueId
    END

RETURN 0