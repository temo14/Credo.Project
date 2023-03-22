using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Domain.Configurations;
using BankSystem.Domain.Services.Contracts;
using BankSystem.Shared.Models.Request;

namespace BankSystem.Domain.Services;
public class OperatorService : IOperatorService
{
    private readonly IOperatorRepository _repository;

    public OperatorService(IOperatorRepository repository)
    {
        _repository=repository;
    }

    public Task AddUser(UserDto user)
    {
        return _repository.InsertUser(user);
    }
    public Task AddAccount(AccountDto acc)
    {
        if (IbanValidation.IsValid(acc.Iban)) throw new InvalidOperationException("Invalid Iban");
        return _repository.InsertAccount(acc);
    }
    public Task AddCreditCard(CreditCardDto card)
    {
        return _repository.InsertCreditCard(card);
    }
}
