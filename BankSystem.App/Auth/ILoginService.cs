namespace BankSystem.App.Auth;

public interface ILoginService
{
    Task Login(string userToken);
    Task Logout();
}
