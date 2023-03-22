CREATE PROCEDURE [dbo].[sp_GetUserAccounts]
	@userId int = null
AS
begin
	if @userId is null
	begin
		select Id, Amount, Iban, Currency
		from Accounts
	end
	else
	begin
		select Id, Amount, Iban, Currency
		from Accounts
		where UserID = @userId
	end
end