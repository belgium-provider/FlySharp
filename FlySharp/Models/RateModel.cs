using Newtonsoft.Json;

namespace FlySharp.Models;

public class RateModel
{
    [JsonProperty("prefix")]
    public required string Prefix { get; set; }
    [JsonProperty("country")]
    public required string Country { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; } = string.Empty;
    [JsonProperty("rate")]
    public double Rate { get; set; }
    [JsonProperty("local_rate")]
    public double LocalRate { get; set; }
}