using BankSystem.Shared.Models.Request;

namespace BankSystem.App.Repository.Contracts;

public interface IUserRepository
{
    public Task<IEnumerable<AccountDto>> GetAccounts(int userId);
}
