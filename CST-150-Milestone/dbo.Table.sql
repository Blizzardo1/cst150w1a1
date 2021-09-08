CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[Name] VARCHAR(256),
    [Age] DECIMAL,
    [BirthDate] DATE,
    [EmailAddress] TEXT,
    [StudentId] TEXT,
    [BirthPlace] TEXT,
    [GradePointAverage] DECIMAL,
    [ProfilePicture] VARBINARY(MAX),
    [Notes] TEXT,

)
