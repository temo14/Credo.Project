CREATE TABLE [dbo].[CreditCards]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	UserID int not null,
	AcountID int not null,
	CardNumber nvarchar(16) not null,
	Cvv nvarchar(4) not null,
	Pin nvarchar(4) not null,
	CardExpireDate datetime not null DEFAULT DATEADD(month, 5, GETDATE()),
	CreateDate datetime not null default(GetDate()),
	IsDeleted bit not null default(0)
	CONSTRAINT FK_CreditCard_Users FOREIGN KEY (UserID) REFERENCES [dbo].[Users] (Id)
	CONSTRAINT FK_CreditCard_Acount FOREIGN KEY (AcountID) REFERENCES [dbo].[Accounts] (Id)
)
