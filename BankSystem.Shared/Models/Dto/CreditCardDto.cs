using System.ComponentModel.DataAnnotations;

namespace BankSystem.Shared.Models.Request;
public class CreditCardDto
{
    [Required]
    public int UserId { get; set; }
    [Required]
    public int AccountId { get; set; }
    [Required]
    public string CardNumber { get; set; }
    [Required]
    public string Cvv { get; set; }
    [Required]
    public string Pin { get; set; }
    public DateTime CardExpireDate { get; set; }
}
