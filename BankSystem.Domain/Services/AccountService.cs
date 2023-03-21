using BankSystem.DataAccess.Repositories.Contracts;
using BankSystem.Domain.Configurations;
using BankSystem.Domain.nbgApi;
using BankSystem.Domain.Services.Contracts;
using BankSystem.Shared.Enums;
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
    public async Task TransferMoney(TransferRequest request)
    {
        var tranasaction = new TransactionDto
        {
            Currency = request.FromAccountCurrency.ToString(),
            FromUserId = request.FromUserId,
            RecieverAccountID = request.ToAccountId,
            ToUserId = request.ToUserId,
            SenderAccountID = request.FromAccountId,
            MoneyToSend = request.MoneyToSend,
            MoneyToRecieve = request.MoneyToSend,
            TransactionType = request.TransactionType.ToString(),
            TransferFee = request.ToUserId == request.FromUserId ?
                                            0 : request.MoneyToSend * 0.01m + 0.5m
        };
        if (request.FromAccountCurrency != request.ToAccountCurrency)
        {
            var senderCurrencyRate = request.FromAccountCurrency == Currency.GEL ? 1m : Client.GetRate(request.FromAccountCurrency.ToString());

            var recieverCurrencyRate = request.ToAccountCurrency == Currency.GEL ? 1m : Client.GetRate(request.ToAccountCurrency.ToString());

            var neededRate = senderCurrencyRate / recieverCurrencyRate;

            tranasaction.MoneyToRecieve *= neededRate;
        }

        await _repository.Transfer(tranasaction);
    }
}
