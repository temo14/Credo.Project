using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Domain.nbgApi.Models;
public class ResponseModel
{
    public DateTime date { get; set; }

    public CurrencyModel[] currencies { get; set; }
}
