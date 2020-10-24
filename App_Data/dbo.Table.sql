CREATE TABLE [dbo].[Table]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [year] VARCHAR(50) NULL, 
    [make] VARCHAR(50) NULL, 
    [model] VARCHAR(50) NULL, 
    [type] VARCHAR(50) NULL, 
    [description] VARCHAR(MAX) NULL, 
    [cost] FLOAT NULL, 
    [image] VARCHAR(50) NULL
)
