using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;

namespace BankSystem.DataAccess.Repositories.Contracts;
public interface IAccountRepository
{
    Task<IEnumerable<AccountDto>> GetAccounts(int Id);
    Task<IEnumerable<TransferAccounts>> GetAllAccounts();
    Task<IEnumerable<CreditCardDto>> GetCards(int Id);
    Task Transfer(TransactionDto request);
    Task<LoginResponse> Login(LoginRequest request);
}