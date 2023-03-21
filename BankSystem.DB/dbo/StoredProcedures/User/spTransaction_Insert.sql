CREATE PROCEDURE [dbo].[spTransaction_Insert]
	@FromUserId int,
	@ToUserId int,
	@SenderAccountID int,
	@RecieverAccountID int,
	@TransferFee decimal(18,2),
	@MoneyToSend decimal(18,2),
	@MoneyToRecieve decimal(18,2),
	@Currency nvarchar(3),
	@TransactionType nvarchar(20)
AS
begin
	begin try
		begin tran
			update Accounts
			set Amount -= @MoneyToSend
			where Id = @SenderAccountID

			update Accounts
			set Amount += @MoneyToRecieve
			where Id = @RecieverAccountID
		
			insert into Transactions(UserID, RecieverUserID, TransferFee, TransferAmount, Currency, TransactionType)
			values (@FromUserId, @ToUserId, @TransferFee, @MoneyToSend, @Currency, @TransactionType)
		commit tran
	end try
	begin catch
		rollback tran;
		throw;
	end catch
end