CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [NumerCzesci] INT NOT NULL, 
    [Linia] NCHAR(100) NOT NULL, 
    [DataUruchomieniaSortu] NCHAR(10) NOT NULL, 
    [Opis] NCHAR(100) NOT NULL, 
    [MQE] NCHAR(20) NOT NULL
)
