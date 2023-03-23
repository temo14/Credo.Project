using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Domain.Configurations;
public class JwtSettings
{
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public string SecrectKey { get; set; }
}
