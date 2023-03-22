CREATE PROCEDURE [dbo].[sp_InsertUser]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Username varchar(30),
	@IdNumber nvarchar(11),
	@Roles nvarchar(100) = null,
	@BirthDate DATETIME,
	@Password varchar(30)
AS
begin
	insert into [Users](FirstName, LastName, Username, IdNumber, Roles, BirthDate, [Password])
	VALUES(@FirstName, @LastName, @Username, @IdNumber, COALESCE(@Roles, 'User'), @BirthDate, HASHBYTES('SHA2_256', @Password))
end