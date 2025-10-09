namespace FlySharp.Models;

public class Account
{
    public int IAccount {get; set;}
    public required string Username { get; set; }
    public string Description { get; set; } = string.Empty;
    public bool Blocked { get; set; }
    public bool Expired { get; set; }
    public double Balance { get; set; }
    public double CreditLimit { get; set; }
    public required string BaseCurrency { get; set; }
    public RegistrationStatus? RegistrationStatus { get; set; } = null;
}