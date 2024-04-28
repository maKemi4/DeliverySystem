CREATE PROCEDURE [dbo].[p_GetOrderExecutor]
	@OrderExecutorId int
AS
	SELECT ex.ExecutorName, ex.ExecutorSurname, ex.OrganizationName FROM OrderExecutor ex
	WHERE ex.OrderExecutorId = @OrderExecutorId

RETURN 0
