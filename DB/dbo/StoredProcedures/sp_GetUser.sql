CREATE PROCEDURE [dbo].[sp_GetUser]
	@Id int
AS
begin
	select Id, FirstName, LastName, IdNumber, BirthDate, CreateDate, IsDeleted, Username
	from dbo.[Users]
	where Id = @Id;
end

