CREATE PROCEDURE [dbo].[sp_GetAllUser]
AS
begin
	select Id, FirstName, LastName, IdNumber, BirthDate, CreateDate, IsDeleted
	from dbo.[Users];
end