CREATE TABLE [dbo].[OrderExecutor]
(
	[OrderExecutorId] INT PRIMARY KEY IDENTITY, 
    [ExecutorName] VARCHAR(50) NOT NULL, 
    [ExecutorSurname] VARCHAR(50) NOT NULL, 
    [OrganizationName] VARCHAR(50) NOT NULL
)
