using BankSystem.DataAccess.DbAccess;
using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;

namespace BankSystem.DataAccess.Data;

public class AccountRepository : IAccountRepository
{
    private readonly ISqlDataAccess _db;

    public AccountRepository(ISqlDataAccess db)
    {
        _db = db;
    }

    //public Task<IEnumerable<User>> GetAccounts() =>
    //    _db.LoadData<Account, dynamic>("dbo.spUser_GetAll", new { });

    public async Task<LoginResponse> Login(LoginRequest request)
    {
        var result = await _db.LoadData<LoginResponse, dynamic>("dbo.sp_Login", new { request.UserName, request.Password });
        return result.FirstOrDefault()!;
    }
    public async Task<IEnumerable<AccountDto>> GetAccounts(int Id)
    {
        return await _db.LoadData<AccountDto, dynamic>("dbo.sp_GetAccounts", new { userId = Id });
    }
    public async Task<IEnumerable<CreditCardDto>> GetCards(int Id)
    {
        return await _db.LoadData<CreditCardDto, dynamic>("dbo.sp_GetCreditCards", new { accountId = Id });
    }
    public async Task<IEnumerable<TransferAccounts>> GetAllAccounts()
    {
        return await _db.LoadData<TransferAccounts, dynamic>("dbo.sp_GetAllAccounts", new { });
    }
    public Task Transfer(TransactionDto request) =>
        _db.SaveData(
            "dbo.spTransaction_Insert",
            new
            {
                request.Currency,
                request.FromUserId,
                request.RecieverAccountID,
                request.ToUserId,
                request.SenderAccountID,
                request.MoneyToSend,
                request.MoneyToRecieve,
                request.TransactionType,
                request.TransferFee
            });
}
