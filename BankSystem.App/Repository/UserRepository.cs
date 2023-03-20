using BankSystem.App.Pages.Register;
using BankSystem.App.Repository.Contracts;
using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using BankSystem.Shared.Models.Response;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace BankSystem.App.Repository;

public class UserRepository : IUserRepository
{
    private readonly HttpClient httpClient;

    public UserRepository(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<AccountDto>> GetAccounts(int userId)
    {
        try
        {
            var response = await httpClient.GetAsync($"/user/{userId}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<AccountDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
        }
        catch (Exception ex)
        {
            var r = ex.Message;
            //Log exception
            throw;
        }
    }
    public async Task<IEnumerable<CreditCardDto>> GetCreditCards(int accountId)
    {
        try
        {
            var response = await httpClient.GetAsync($"/account/{accountId}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<CreditCardDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
        }
        catch (Exception ex)
        {
            //Log exception
            throw;
        }
    }
    public async Task<IEnumerable<TransferAccounts>> GetAllAccounts()
    {
        try
        {
            var response = await httpClient.GetAsync($"/accounts");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<TransferAccounts>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
        }
        catch (Exception ex)
        {
            //Log exception
            throw;
        }
    }
}
