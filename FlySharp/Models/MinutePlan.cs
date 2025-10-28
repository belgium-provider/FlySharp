using Newtonsoft.Json;

namespace FlySharp.Models;

public class MinutePlan
{
    [JsonProperty("i_service_plan")]
    public int IServicePlan { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; } = string.Empty;
    [JsonProperty("price")]
    public double Price { get; set; }
    [JsonProperty("seconds_total")]
    public int? SecondsTotal { get; set; } = null;
    [JsonProperty("seconds_left")]
    public int? SecondsLeft { get; set; } = null;
    [JsonProperty("chargeable_seconds")]
    public int ChargeableSeconds { get; set; } = 0;
}