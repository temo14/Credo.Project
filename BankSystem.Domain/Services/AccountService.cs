using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Domain.Configurations;
using BankSystem.Domain.Services.Contracts;
using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Domain.Services;
public class AccountService : IAccountService
{
    private readonly IAccountRepository _repository;
    private readonly TokenGenerator _token;
    public AccountService(IAccountRepository repository, TokenGenerator token)
    {
        _repository = repository;
        _token = token;
    }

    public async Task<string> Login(LoginRequest request)
    {
        var response = await _repository.Login(request);
        if (response.LoginStatus)
        {
            return _token.Generate(response);
        }

        return string.Empty;
    }
    public async Task<IEnumerable<AccountDto>> GetAccoutns(int Id)
    {
        return await _repository.GetAccounts(Id);
    }
    public async Task<IEnumerable<CreditCardDto>> GetCreditCards(int id)
    {
        return await _repository.GetCards(id);
    }
    public async Task<IEnumerable<TransferAccounts>> GetAllAccoutns()
    {
        return await _repository.GetAllAccounts();
    }
}
