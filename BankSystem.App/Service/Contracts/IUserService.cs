﻿using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;

namespace BankSystem.App.Repository.Contracts;

public interface IUserService
{
    public Task<IEnumerable<AccountDto>> GetAccounts(int userId);
    Task<IEnumerable<BankSystem.Shared.Models.Response.TransferAccounts>> GetAllAccounts();
    Task<IEnumerable<CreditCardDto>> GetCreditCards(int id);
    Task TransferMoney(TransferRequest request);
}
