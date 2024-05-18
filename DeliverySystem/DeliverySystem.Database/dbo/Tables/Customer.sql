CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT PRIMARY KEY IDENTITY, 
    [CustomerName] VARCHAR(32) NOT NULL, 
    [CustomerSurname] VARCHAR(32) NOT NULL, 
    [PhoneNum] VARCHAR(12) NOT NULL, 
    [Email] VARCHAR(32) NOT NULL,
    CONSTRAINT CHK_PhoneNum_Format CHECK (PhoneNum LIKE '380_________' OR PhoneNum LIKE '0_________'),
    CONSTRAINT CK_Email_Format CHECK (Email LIKE '%@%.%' AND PATINDEX('%[^a-zA-Z0-9._%@-]%', Email) = 0),
    CONSTRAINT CHK_CustomerName CHECK (CustomerName NOT LIKE  '%[^а-яА-Яa-zA-Z]%'),
    CONSTRAINT CHK_CustomerSurname CHECK (CustomerSurname NOT LIKE  '%[^а-яА-Яa-zA-Z]%')
)
