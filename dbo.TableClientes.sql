CREATE TABLE [dbo].[Table]
(
	[Cliente_Id] INT NOT NULL PRIMARY KEY, 
    [Nome] VARCHAR(100) NOT NULL, 
    [Razao] VARCHAR(300) NOT NULL, 
    [Inclusao] DATETIME NOT NULL, 
    [Ativo] NUMERIC(1) NOT NULL
)
