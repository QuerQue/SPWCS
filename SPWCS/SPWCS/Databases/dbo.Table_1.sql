CREATE TABLE [dbo].[Users]
(
	[Pesel] CHAR(11) NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Users_PersonalData] FOREIGN KEY ([Pesel]) REFERENCES [PersonalData]([Pesel])
)
