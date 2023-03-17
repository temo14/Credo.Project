using BankSystem.Shared.Models.Request;

namespace BankSystem.Domain.Services.Contracts;
public interface IOperatorService
{
    Task AddAccount(CreateAccount acc);
    Task AddCreditCard(CreateCreditCard card);
    Task AddUser(CreateUser user);
}
