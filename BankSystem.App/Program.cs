using BankSystem.App;
using BankSystem.App.Auth;
using BankSystem.App.Repository;
using BankSystem.App.Repository.Contracts;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7145/") });

// use same instance for AuthenticationStateProvider and ILoginService
builder.Services.AddScoped<JWTAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationStateProvider>(
    provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
    );

builder.Services.AddScoped<ILoginService, JWTAuthenticationStateProvider>(
    provider => provider.GetRequiredService<JWTAuthenticationStateProvider>()
    );

builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddAuthorizationCore();

//LocalStorage.GetToken = () => "";

await builder.Build().RunAsync();
