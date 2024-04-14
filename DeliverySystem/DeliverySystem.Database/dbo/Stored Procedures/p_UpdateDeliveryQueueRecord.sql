CREATE PROCEDURE [dbo].[p_UpdateDeliveryQueueRecord]
	@NumOfVictims int, -- ??
	@NumOfSeverelyVictims int NULL, -- ??
	@Description NVARCHAR(MAX),
	@Longtitude DECIMAL,
	@Settlement NVARCHAR(255)
	--....
AS
	DECLARE @CustomerId INT;
	-- Find if cutomer already exists
	IF NOT EXISTS(SELECT TOP 1 * FROM Customer WHERE Settlement = @Settlement)
	BEGIN
		INSERT INTO Customer (Name, Surname, PhoneNumber, Longtituede) --......)
		VALUES (@Name, @Surname, @PhoneNumber)
	END

	SELECT @CustomerId = Id FROM Customer WHERE Settlement = @Settlement

	INSERT INTO DeliveryQueue (CustomerId) --......)
	VALUES (@CustomerId)

RETURN 0
