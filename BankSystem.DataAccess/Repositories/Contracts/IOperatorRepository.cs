using BankSystem.Shared.Models.Request;

namespace BankSystem.DataAccess.Repositories.Contracts;
public interface IOperatorRepository
{
    Task InsertAccount(AccountDto account);
    Task InsertCreditCard(CreditCardDto creditCard);
    Task InsertUser(UserDto user);
}