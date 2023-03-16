using BankSystem.DataAccess.Models.Request;
using DataAccess.DbAccess;
using DataAccess.Models;
using DataAccess.Repositories.Contracts;

namespace DataAccess.Data;

public class OperatorRepository : IOperatorRepository
{
    private readonly ISqlDataAccess _db;

    public OperatorRepository(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task InsertUser(User user) =>
        _db.SaveData(
            "dbo.spUser_Insert",
            new { user.FirstName, user.LastName, user.Username, user.IdNumber, user.Roles, user.BirthDate, user.Password });

    public Task InsertAccount(Account account) =>
        _db.SaveData(
            "dbo.spAccount_Insert",
            new { account.Amount, account.Currency, account.Iban, account.UserId });

    public Task InsertCreditCard(CreditCard creditCard) =>
        _db.SaveData(
            "dbo.spCreditCard_Insert",
            new { creditCard.UserId, creditCard.AccountId, creditCard.CardNumber, creditCard.Cvv, creditCard.Pin });

    public async Task<int> Login(LoginRequest request)
    {
        var result = await _db.LoadData<int, dynamic>("dbo.sp_Login", new { request.UserName, request.Password });
        return result.FirstOrDefault();
    }

    public Task<IEnumerable<User>> GetUsers() =>
    _db.LoadData<User, dynamic>("dbo.spUser_GetAll", new { });

    public async Task<User?> GetUser(int id)
    {
        var results = await _db.LoadData<User, dynamic>(
            "dbo.spUser_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }
}
