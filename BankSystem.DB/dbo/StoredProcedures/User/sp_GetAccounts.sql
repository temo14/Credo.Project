CREATE PROCEDURE [dbo].[sp_GetAccounts]
	@userId int
AS
begin
	select Id, Amount, Iban, Currency
	from Accounts
	where UserID = @userId
end