namespace FlySharp.Models;

public class Customer
{
    public int ICustomer {get; set;}
    public required string Name {get; set;}
    public required string WebLogin { get; set; }
    public string Description { get; set; } = string.Empty;
    public double Balance {get; set;}
    public double CreditLimit {get; set;}
    public string BaseCurrency {get; set;} = string.Empty;
}