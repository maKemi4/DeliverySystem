CREATE PROCEDURE [dbo].[p_UpdateOrderExecutor]
	@ExecutorName varchar(32) null,
	@ExecutorSurname varchar (32) null, 
	@OrganizationName varchar (32) null
AS
    BEGIN
        INSERT INTO OrderExecutor (ExecutorName, ExecutorSurname, OrganizationName)
        VALUES (@ExecutorName, @ExecutorSurname, @OrganizationName)
    
        SELECT SCOPE_IDENTITY() as OrderExecutorId;
    END

RETURN 0