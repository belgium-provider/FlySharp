namespace FlySharp.Models;

public class MinutePlan
{
    public int IServicePlan { get; set; }
    public string Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public int? SecondsTotal { get; set; } = null;
    public int? SecondsLeft { get; set; } = null;
    public int ChargeableSeconds { get; set; } = 0;
}