using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;

namespace BankSystem.DataAccess.Repositories.Contracts;
public interface IAccountRepository
{
    Task<LoginResponse> Login(LoginRequest request);
}