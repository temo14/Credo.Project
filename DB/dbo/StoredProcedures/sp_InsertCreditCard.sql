CREATE PROCEDURE [dbo].[sp_InsertCreditCard]
	@UserID int,
	@AccountId int,
	@CardNumber nvarchar(16),
	@Cvv nvarchar(4),
	@Pin nvarchar(4)
AS
begin
	insert into CreditCards(UserID, AccountID, CardNumber, Cvv, Pin)
	values(@UserID, @AccountId, @CardNumber, @Cvv, @Pin);
end
