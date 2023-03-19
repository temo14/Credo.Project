using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;

namespace BankSystem.App.Repository.Contracts;

public interface IAccountRepository
{
    Task<string?> AddAccount(AccountDto request);
    Task<string?> AddCard(CreditCardDto request);
    Task<string?> AddUser(UserDto request);
    Task<string?> Login(LoginRequest request);
}