using BankSystem.DataAccess.Repositories.Contracts;
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
        return _repository.InsertAccount(acc);
    }
    public Task AddCreditCard(CreditCardDto card)
    {
        return _repository.InsertCreditCard(card);
    }
}
