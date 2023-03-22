CREATE PROCEDURE [dbo].[sp_Login]
	@Username varchar(30),
	@Password varchar(30)
AS
begin
	declare @Roles nvarchar(100), @UserId int, @Name varchar(30);

	select @UserId = Id, @Roles = Roles, @Name = FirstName
	from Users
	where Username = @Username and Password = HASHBYTES('SHA2_256', @Password);

	if @UserId is not null
	begin
		select cast(1 as bit) as LoginStatus, @UserId as UserId, @Roles as Roles, @Name as FirstName;
	end

	select cast(0 as bit) as LoginStatus, @UserId as UserId, @Roles as Roles, @Name as FirstName;
end