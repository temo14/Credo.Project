CREATE PROCEDURE [dbo].[sp_Login]
	@Username varchar(30),
	@Password varchar(30)
AS
begin
	declare @UserID int = (
		select Id from Users where Username = @Username and Password = hashbytes('SHA2_256', @Password)
	);

	if @UserId is not null
	begin
		return 0;
	end

	return -1;
end
