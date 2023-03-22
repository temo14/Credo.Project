using BankSystem.Shared.Enums;

namespace BankSystem.Shared.Models.Request;
public class AccountDto
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public double Amount { get; set; }
    public string Iban { get; set; }
    public string Currency { get; set; }
}