CREATE PROCEDURE [dbo].[p_UpdateDeliveryQueueRecord]
	@CustomerName varchar(32) null,
	@CustomerSurname varchar (32) null, 
	@Email varchar (32) null,
	@PhoneNum varchar(12) null,
	@LocalityName varchar (32) null,
	@Latitude decimal(18,2) null,
	@Longitude decimal(18,2) null,
	@NumOfVictims int null,
	@NumOfSeveralyVictims int null,
	@ConditionType int null,
	@AgeGroup int null,
	@NeededSpecialist int null,
	@SituationDescription varchar(50) null,
	@Importance int null, 
	@ImportanceRate decimal(18,2) null
AS
	DECLARE @CustomerId INT;
	DECLARE @DeliveryRequestId INT;

	-- Check if customer already exists
	IF NOT EXISTS(SELECT TOP 1 * FROM Customer WHERE CustomerName = @CustomerName AND CustomerSurname = @CustomerSurname)
	BEGIN
		INSERT INTO Customer (CustomerName, CustomerSurname, Email, PhoneNum)
		VALUES (@CustomerName, @CustomerSurname, @Email, @PhoneNum)

		SELECT @CustomerId = SCOPE_IDENTITY();
	END
	ELSE
	BEGIN
		SELECT @CustomerId = CustomerId FROM Customer WHERE CustomerName = @CustomerName AND CustomerSurname = @CustomerSurname;
	END

	INSERT INTO DeliveryRequest (CustomerId, LocalityName, Latitude, Longitude, NumOfVictims, NumOfSeveralyVictims, ConditionType, SituationDescription, Importance, AgeGroup, NeededSpecialist)
	VALUES (@CustomerId, @LocalityName, @Latitude, @Longitude, @NumOfVictims, @NumOfSeveralyVictims, @ConditionType, @SituationDescription, @Importance, @AgeGroup, @NeededSpecialist)

	SELECT @DeliveryRequestId = SCOPE_IDENTITY();

	INSERT INTO DeliveryQueue (DeliveryRequestId, ImportanceRate)
	VALUES (@DeliveryRequestId, @ImportanceRate)

RETURN 0
