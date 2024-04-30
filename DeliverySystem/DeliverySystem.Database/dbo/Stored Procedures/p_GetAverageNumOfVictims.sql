CREATE PROCEDURE [dbo].[p_GetAverageNumOfVictims]
AS
BEGIN
    DECLARE @AverageNumOfVictims INT
    
    SELECT @AverageNumOfVictims = ROUND(AVG(NumOfVictims), 0)
    FROM DeliveryRequest
    
    IF @@ROWCOUNT = 0
    BEGIN
        SET @AverageNumOfVictims = CAST((RAND() * (25 - 15) + 15) AS INT)
    END
    
    SELECT @AverageNumOfVictims AS AverageNumOfVictims
END

RETURN 0
