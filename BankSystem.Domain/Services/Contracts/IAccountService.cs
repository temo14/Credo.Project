using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace BankSystem.Domain.Services.Contracts;
public interface IAccountService
{
    Task<IEnumerable<CreditCardDto>> GetCreditCards(int id);
    Task<IEnumerable<AccountDto>> GetAccoutns(int Id);
    public Task<string> Login(LoginRequest request);
    Task<IEnumerable<TransferAccounts>> GetAllAccoutns();
    Task TransferMoney(TransferRequest request);
}
