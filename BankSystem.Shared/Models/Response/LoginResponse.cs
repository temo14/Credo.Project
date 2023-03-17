using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Shared.Models.Response;
public class LoginResponse
{
    public bool LoginStatus { get; set; }
    public int UserId { get; set; }
    public string Roles { get; set; }
}
