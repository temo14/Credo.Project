using BankSystem.Shared.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Domain.Services.Contracts;
public interface IAccountService
{
    public Task<ActionResult<string>> Login(LoginRequest request);
}
