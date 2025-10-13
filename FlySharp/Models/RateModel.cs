namespace FlySharp.Models;

public class RateModel
{
    public required string Prefix { get; set; }
    public required string Country { get; set; }
    public string Description { get; set; } = string.Empty;
    public double Rate { get; set; }
    public double LocalRate { get; set; }
}