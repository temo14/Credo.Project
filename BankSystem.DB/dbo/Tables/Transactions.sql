CREATE TABLE [dbo].[Transactions]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	UserID int not null,
	RecieverUserID int not null,
	TransferFee decimal(18, 2) not null,
	TransferAmount decimal(18, 2) not null,
	Currency nvarchar(3) not null,
	TransactionType int not null,
	TransactionDate datetime not null default(GetDate()),
	CreateDate datetime not null default(GetDate()),
	IsDeleted bit not null default(0)
	CONSTRAINT FK_Transactions_Users FOREIGN KEY (UserID) REFERENCES [dbo].[Users] (Id)
)
