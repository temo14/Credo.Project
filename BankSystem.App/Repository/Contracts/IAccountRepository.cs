using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;

namespace BankSystem.App.Repository.Contracts;

public interface IAccountRepository
{
    Task AddAccount(AccountDto request);
    Task AddCard(CreditCardDto request);
    Task AddUser(UserDto request);
    Task<string> Login(LoginRequest request);
}