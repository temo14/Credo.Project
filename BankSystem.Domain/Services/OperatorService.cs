using BankSystem.DataAccess.Models.Request;
using BankSystem.Domain.Services.Contracts;
using DataAccess.Models;
using DataAccess.Repositories.Contracts;

namespace BankSystem.Domain.Services;
public class OperatorService : IOperatorService
{
    private readonly IOperatorRepository _repository;

    public OperatorService(IOperatorRepository repository)
    {
        _repository=repository;
    }
    public async Task<int> Login(LoginRequest request)
    {
        return await _repository.Login(request);
    }
    public Task AddUser(User user)
    {
        return _repository.InsertUser(user);
    }
    public Task AddAccount(Account acc)
    {
        return _repository.InsertAccount(acc);
    }
    public Task AddCreditCard(CreditCard card)
    {
        return _repository.InsertCreditCard(card);
    }
}
