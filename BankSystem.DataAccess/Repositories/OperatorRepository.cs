using BankSystem.DataAccess.DbAccess;
using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;

namespace BankSystem.DataAccess.Data;

public class OperatorRepository : IOperatorRepository
{
    private readonly ISqlDataAccess _db;

    public OperatorRepository(ISqlDataAccess db)
    {
        _db = db;
    }
    public Task InsertUser(UserDto user) =>
        _db.SaveData(
            "dbo.sp_InsertUser",
            new { user.FirstName, user.LastName, user.Username, user.IdNumber, user.Roles, user.BirthDate, user.Password });

    public Task InsertAccount(AccountDto account) =>
        _db.SaveData(
            "dbo.sp_InsertAccount",
            new { account.Amount, account.Currency, account.Iban, account.UserId });

    public Task InsertCreditCard(CreditCardDto creditCard) =>
        _db.SaveData(
            "dbo.sp_InsertCreditCard",
            new { creditCard.UserId, creditCard.AccountId, creditCard.CardNumber, creditCard.Cvv, creditCard.Pin });

    public Task<IEnumerable<User>> GetUsers() =>
    _db.LoadData<User, dynamic>("dbo.sp_GetAllUser", new { });

    public async Task<User?> GetUser(int id)
    {
        var results = await _db.LoadData<User, dynamic>(
            "dbo.spUser_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }
}
