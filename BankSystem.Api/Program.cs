using BankSystem.Domain.Configurations;
using Microsoft.Net.Http.Headers;
using MinimalAPIDemo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors();

ServiceExtension.Configure(builder);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy =>
    policy.WithOrigins("http://localhost:5047", "http://localhost:5047")
    .AllowAnyMethod()
    .AllowAnyHeader()
);
app.UseHttpsRedirection();

app.ConfigureApi();

app.UseAuthentication();
app.UseAuthorization();

app.Run();
