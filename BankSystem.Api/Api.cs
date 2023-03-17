using BankSystem.Domain.Services.Contracts;
using BankSystem.Shared.Models.Request;
using Microsoft.AspNetCore.Authorization;

namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //User
        app.MapPost("/Login", Login);
        //app.MapGet("/Users/{id}", GetUser);
        app.MapPost("/Users", InsertUser);
        app.MapPost("/Account", InsertAccount);
        app.MapPost("/CreditCard", InsertCreditCard);
        //app.MapPut("/Users", UpdateUser);
        //app.MapDelete("/Users", DeleteUser);
        //Account

    }
    //#region OperatorApi

    [Authorize(Roles = "Operator")]
    private static async Task<IResult> InsertUser(CreateUser user, IOperatorService data)
    {
        try
        {
            await data.AddUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    //[Authorize(Roles = "Operator")]
    private static async Task<IResult> InsertAccount(CreateAccount acc, IOperatorService data)
    {
        try
        {
            await data.AddAccount(acc);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    //[Authorize(Roles = "Operator")]
    private static async Task<IResult> InsertCreditCard(CreateCreditCard acc, IOperatorService data)
    {
        try
        {
            await data.AddCreditCard(acc);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    //#endregion

    //#region UserApi

    //#endregion

    private static async Task<IResult> Login(LoginRequest request, IAccountService data)
    {
        try
        {
            var result = await data.Login(request);
            return Results.Ok(result.Value);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}