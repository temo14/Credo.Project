CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Username varchar(30),
	@IdNumber nvarchar(11),
	@Roles nvarchar(100),
	@BirthDate DATETIME,
	@Password varchar(30)
AS
begin
	insert into [Users](FirstName, LastName, Username, IdNumber, Roles, BirthDate, [Password])
	values(@FirstName, @LastName, @Username, @IdNumber, @Roles, @BirthDate, HASHBYTES('SHA2_256', @Password))
end