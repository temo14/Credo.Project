CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
begin
	select Id, FirstName, LastName, IdNumber, BirthDate, CreateDate, IsDeleted, Username
	from dbo.[Users]
	where Id = @Id;
end
