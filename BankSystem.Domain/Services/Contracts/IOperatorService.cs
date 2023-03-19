using BankSystem.Shared.Models.Request;

namespace BankSystem.Domain.Services.Contracts;
public interface IOperatorService
{
    Task AddAccount(AccountDto acc);
    Task AddCreditCard(CreditCardDto card);
    Task AddUser(UserDto user);
}
