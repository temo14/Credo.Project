CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select Id, FirstName, LastName, IdNumber, BirthDate, CreateDate, IsDeleted
	from dbo.[Users];
end