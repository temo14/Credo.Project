namespace BankSystem.Shared.Models.Request;
public class CreateCreditCard
{
    public int UserId { get; set; }
    public int AccountId { get; set; }
    public string CardNumber { get; set; }
    public string Cvv { get; set; }
    public string Pin { get; set; }
    public DateTime CardExpireDate { get; set; }
}
