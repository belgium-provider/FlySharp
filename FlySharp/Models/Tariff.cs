using Newtonsoft.Json;

namespace FlySharp.Models;

public class Tariff
{
    [JsonProperty("i_tariff")]
    public int ITariff { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; } = string.Empty;
    [JsonProperty("currency")]
    public string Currency { get; set; } = string.Empty;
    [JsonProperty("i_tariff_type")]
    public int ITariffType { get; set; }
}