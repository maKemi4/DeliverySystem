CREATE PROCEDURE [dbo].[p_GetOrderExecutor]
	@OrderExecutorId int
AS
	SELECT ex.OrderExecutorId, ex.ExecutorName, ex.ExecutorSurname, ex.OrganizationName FROM OrderExecutor ex
	WHERE ex.OrderExecutorId = @OrderExecutorId

RETURN 0
