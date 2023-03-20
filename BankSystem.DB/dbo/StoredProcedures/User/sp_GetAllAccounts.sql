CREATE PROCEDURE [dbo].[sp_GetAllAccounts]
AS
begin
	select acc.Id as AccountId, acc.Amount, acc.Iban, acc.Currency, u.FirstName, u.LastName
	from Accounts acc
	inner join Users u on acc.UserID = u.Id
end
