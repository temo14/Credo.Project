using BankSystem.DataAccess.Models.Request;
using DataAccess.Models;

namespace BankSystem.Domain.Services.Contracts;
public interface IOperatorService
{
    Task AddAccount(Account acc);
    Task AddCreditCard(CreditCard card);
    Task AddUser(User user);
    Task<int> Login(LoginRequest request);
}
