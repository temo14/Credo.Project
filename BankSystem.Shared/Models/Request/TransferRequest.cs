using BankSystem.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Shared.Models.Request;
public class TransferRequest
{
    public int FromUserId { get; set; }
    public int FromAccountId { get; set; }
    public Currency FromAccountCurrency { get; set; }
    public int ToUserId { get; set; }
    public int ToAccountId { get; set; }
    public Currency ToAccountCurrency { get; set; }
    public decimal MoneyToSend { get; set; }
    public TransactionType TransactionType { get; set; }
}
