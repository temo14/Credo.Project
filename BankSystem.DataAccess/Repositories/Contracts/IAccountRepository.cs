using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;

namespace BankSystem.DataAccess.Repositories.Contracts;
public interface IAccountRepository
{
    Task<IEnumerable<AccountDto>> GetAccounts(int userId);
    Task<LoginResponse> Login(LoginRequest request);
}