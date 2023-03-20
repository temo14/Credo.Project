using BankSystem.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Shared.Models.Response;
public class TransferAccounts
{
    public int AccountId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Amount { get; set; }
    public string Iban { get; set; }
    public Currency Currency { get; set; }
}
