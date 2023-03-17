using BankSystem.Shared.Models.Request;

namespace BankSystem.App.Repository.Contracts;

public interface IAccountRepository
{
    Task<string?> Login(LoginRequest request);
}