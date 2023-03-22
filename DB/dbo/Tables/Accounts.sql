CREATE TABLE [dbo].[Accounts]
(
	[Id] INT NOT NULL PRIMARY KEY Identity,
	UserID int not null,
	Amount money not null DEFAULT 1000,
	Iban nvarchar(34) not null,
	Currency nvarchar(3) not null DEFAULT 'GEL',
	CreateDate datetime not null default(GetDate()),
	IsDeleted bit not null default(0),
	CONSTRAINT FK_Accounts_Users FOREIGN KEY (UserID) REFERENCES [dbo].[Users] (Id)
)