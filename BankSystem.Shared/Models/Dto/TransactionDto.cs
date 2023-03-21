using BankSystem.Shared.Enums;

namespace BankSystem.Shared.Models.Request;
public class TransactionDto
{
    public int FromUserId { get; set; }
    public int SenderAccountID { get; set; }
    public int ToUserId { get; set; }
    public int RecieverAccountID { get; set; }
    public decimal TransferFee { get; set; }
    public decimal MoneyToSend { get; set; }
    public decimal MoneyToRecieve { get; set; }
    public string Currency { get; set; }
    public string TransactionType { get; set; }
}