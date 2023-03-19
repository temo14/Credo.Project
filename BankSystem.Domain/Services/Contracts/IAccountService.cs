using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Domain.Services.Contracts;
public interface IAccountService
{
    Task<IEnumerable<AccountDto>> GetUserAccoutns(int id);
    public Task<ActionResult<string>> Login(LoginRequest request);
}
