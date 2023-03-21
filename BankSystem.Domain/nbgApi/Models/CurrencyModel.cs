using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Domain.nbgApi.Models;
public class CurrencyModel
{
    public string code { get; set; }

    public int quantity { get; set; }

    public string rateFormated { get; set; }

    public string diffFormated { get; set; }

    public decimal rate { get; set; }

    public string name { get; set; }

    public float diff { get; set; }

    public DateTime date { get; set; }

    public DateTime validFromDate { get; set; }
}
