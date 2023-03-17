namespace BankSystem.App.Services;

public class UserService
{
    private readonly HttpClient httpClient;

    public UserService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task GetItem(int id)
    {
        //try
        //{
        //    var response = await httpClient.GetAsync($"api/Product/{id}");

        //    if (response.IsSuccessStatusCode)
        //    {
        //        if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
        //        {
        //            return default(ProductDto);
        //        }

        //        return await response.Content.ReadFromJsonAsync<ProductDto>();
        //    }
        //    else
        //    {
        //        var message = await response.Content.ReadAsStringAsync();
        //        throw new Exception($"Http status code: {response.StatusCode} message: {message}");
        //    }
        //}
        //catch (Exception)
        //{
        //    //Log exception
        //    throw;
        //}
    }
}
