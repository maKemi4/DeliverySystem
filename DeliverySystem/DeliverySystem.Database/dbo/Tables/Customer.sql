CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT PRIMARY KEY IDENTITY, 
    [CustomerName] VARCHAR(32) NOT NULL, 
    [CustomerSurname] VARCHAR(32) NOT NULL, 
    [PhoneNum] VARCHAR(12) NOT NULL, 
    [Email] VARCHAR(32) NOT NULL 
)
