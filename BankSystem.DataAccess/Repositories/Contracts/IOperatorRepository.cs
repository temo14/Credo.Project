using BankSystem.DataAccess.Models.Request;
using DataAccess.Models;

namespace DataAccess.Repositories.Contracts;
public interface IOperatorRepository
{
    Task InsertAccount(Account account);
    Task InsertCreditCard(CreditCard creditCard);
    Task InsertUser(User user);
    Task<int> Login(LoginRequest request);
}