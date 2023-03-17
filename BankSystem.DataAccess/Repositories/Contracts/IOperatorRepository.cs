using BankSystem.Shared.Models.Request;

namespace BankSystem.DataAccess.Repositories.Contracts;
public interface IOperatorRepository
{
    Task InsertAccount(CreateAccount account);
    Task InsertCreditCard(CreateCreditCard creditCard);
    Task InsertUser(CreateUser user);
}