CREATE PROCEDURE [dbo].[sp_GetCreditCards]
	@accountId int
AS
begin
	select * 
	from CreditCards
	where AccountID = @accountId
end
