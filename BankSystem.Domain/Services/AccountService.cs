using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Domain.Configurations;
using BankSystem.Domain.Services.Contracts;
using BankSystem.Shared.Models.Request;
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

    public async Task<ActionResult<string>> Login(LoginRequest request)
    {
        var response = await _repository.Login(request);
        if (response.LoginStatus)
        {
            return new ActionResult<string>(_token.Generate(response));
        }

        return new ActionResult<string>(string.Empty);
    }
}
