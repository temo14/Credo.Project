﻿using BankSystem.Domain.Services.Contracts;
using BankSystem.Shared.Models;
using BankSystem.Shared.Models.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //User
        app.MapPost("/auth", Login);
        app.MapGet("/user/{userId:int}", GetAccounts);
        app.MapGet("/accounts", GetAllAccounts);
        app.MapGet("/account/{accountId:int}", GetAccountCreditCard);
        app.MapPost("/users", InsertUser);
        app.MapPost("/account", InsertAccount);
        app.MapPost("/creditcard", InsertCreditCard);
        //app.MapPut("/Users", UpdateUser);
        //app.MapDelete("/Users", DeleteUser);
        //Account

    }
    #region OperatorApi

    [Authorize(Roles = "Operator")]
    private static async Task<IResult> InsertUser(UserDto user, IOperatorService data)
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

    [Authorize(Roles = "Operator")]
    private static async Task<IResult> InsertAccount(AccountDto acc, IOperatorService data)
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

    [Authorize(Roles = "Operator")]
    private static async Task<IResult> InsertCreditCard(CreditCardDto acc, IOperatorService data)
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
    #endregion

    #region UserApi
    [Authorize(Roles = "User")]
    private static async Task<IResult> GetAccounts(int userId, IAccountService service)
    {
        try
        {
            return Results.Ok(await service.GetAccoutns(userId));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    [Authorize(Roles = "User")]
    private static async Task<IResult> GetAllAccounts(IAccountService service)
    {
        try
        {
            return Results.Ok(await service.GetAllAccoutns());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    [Authorize(Roles = "User")]
    private static async Task<IResult> GetAccountCreditCard(int accountId, IAccountService service)
    {
        try
        {
            return Results.Ok(await service.GetCreditCards(accountId));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    #endregion

    private static async Task<IResult> Login(LoginRequest request, IAccountService data)
    {
        try
        {
            return Results.Ok(await data.Login(request));
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}