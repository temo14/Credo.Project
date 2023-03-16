CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	Username varchar(30) not null,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	[Password] varbinary(100) NOT NULL,
	IdNumber nvarchar(11) NOT NULL,
	Roles nvarchar(100) not null default('User'),
	BirthDate DATETIME,
	CreateDate datetime not null default(GetDate()),
	IsDeleted bit not null default(0)
)