CREATE PROCEDURE [dbo].[p_UpdateDeliveryQueueRecord]
	@CustomerName varchar(32) not null,
	@CustomerSurname varchar (32) not null, 
	@Email varchar (32) null,
	@PhoneNum varchar(12) not null,
	@LocalityName varchar (32) not null,
	@Latitude decimal(18,2) not null,
	@Longitude decimal(18,2) not null,
	@NumOfVictims int not null,
	@NumOfSeverelVictims int null,
	@ConditionType int not null,
	@SituationDescription varchar(50) null,
	@Importance int not null, 
	@ImportanceRate decimal(18,2) not null,
	@IsCompleted bit not null 

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

	INSERT INTO DeliveryRequest (CustomerId, LocalityName, Latitude, Longitude, NumOfVictims, NumOfSeverelVictims, ConditionType, SituationDescription)
	VALUES (@CustomerId, @LocalityName, @Latitude, @Longitude, @NumOfVictims, @NumOfSeverelVictims, @ConditionType, @SituationDescription)

	SELECT @DeliveryRequestId = SCOPE_IDENTITY();

	INSERT INTO DeliveryQueue (DeliveryRequestId, Importance, ImportanceRate, IsCompleted)
	VALUES (@DeliveryRequestId, @Importance, @ImportanceRate, @IsCompleted)

RETURN 0
