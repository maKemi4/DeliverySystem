CREATE TABLE [dbo].[OrderExecutor]
(
	[OrderExecutorId] INT NOT NULL PRIMARY KEY, 
    [ExecutorName] VARCHAR(50) NOT NULL, 
    [ExecutorSurname] VARCHAR(50) NOT NULL, 
    [OrganizationName] VARCHAR(50) NOT NULL
)
