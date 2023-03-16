CREATE PROCEDURE [dbo].[spAccount_Insert]
	@UserID int,
	@Amount money,
	@Iban nvarchar(34),
	@Currency nvarchar(3)
AS
begin
	insert into Accounts(UserID, Amount, Iban, Currency)
	values(@UserID, @Amount, @Iban, @Currency);
end
