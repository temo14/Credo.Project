using BankSystem.Shared.Enums;

namespace BankSystem.Shared.Models;
public class Account
{
    public int UserId { get; set; }
    public double Amount { get; set; } = 10000;
    public string Iban { get; set; }
    public Currency Currency { get; set; } = 0;
}
