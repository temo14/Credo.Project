
using BankSystem.App.Pages.Register;
using BankSystem.App.Repository.Contracts;
using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace BankSystem.App.Repository;

public class AccountRepository : IAccountRepository
{
    private readonly HttpClient httpClient;

    public AccountRepository(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task<string?> Login(LoginRequest request)
    {
        try
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"/auth", content);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<string>();
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
    public async Task AddUser(UserDto request)
    {
        try
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"/users", content);

            if (response.IsSuccessStatusCode)
            {
                return;
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
    public async Task AddCard(CreditCardDto request)
    {
        try
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"/creditcard", content);

            if (response.IsSuccessStatusCode)
            {
                return;
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
    public async Task AddAccount(AccountDto request)
    {
        try
        {
            var jsonRequest = JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync($"/account", content);

            if (response.IsSuccessStatusCode)
            {
                return;
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
    public async Task<IEnumerable<AccountDto>> GetAllAccaount()
    {
        try
        {
            var response = await httpClient.GetAsync($"/accounts");

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
            //Log exception
            throw;
        }
    }
}
