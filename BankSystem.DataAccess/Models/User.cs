﻿namespace DataAccess.Models;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string IdNumber { get; set; }
    public string Roles { get; set; }
    public DateTime BirthDate { get; set; }
}
