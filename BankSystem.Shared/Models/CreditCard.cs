namespace BankSystem.Shared.Models;
public class CreditCard
{
    public int UserId { get; set; }
    public int AccountId { get; set; }
    public string CardNumber { get; set; }
    public string Cvv { get; set; }
    public string Pin { get; set; }
    public DateTime CardExpireDate { get; set; }
}
