CREATE TABLE [dbo].[Cars]
(
	[CarsId] INT NOT NULL PRIMARY KEY,
	[Model] VARCHAR(250) NOT NULL,
	[RetailValue] DECIMAL,
	[DateManufactured] DATETIME NOT NULL,
	[TopSpeed] INT NOT NULL
)
