CREATE PROCEDURE [dbo].[spCreditCard_Insert]
	@UserID int,
	@AccountId int,
	@CardNumber nvarchar(16),
	@Cvv nvarchar(4),
	@Pin nvarchar(4)
AS
begin
	insert into CreditCards(UserID, AcountID, CardNumber, Cvv, Pin)
	values(@UserID, @AccountId, @CardNumber, @Cvv, @Pin);
end