using Newtonsoft.Json;

namespace FlySharp.Models;

public class TariffRate
{
    [JsonProperty("i_rate")]
    public int IRate { get; set; }
    [JsonProperty("prefix")]
    public string? Prefix { get; set; }
    // Doc labels price_1/price_n as Integer, modeled as double for consistency with other monetary fields in the SDK.
    [JsonProperty("price_1")]
    public double? Price1 { get; set; }
    [JsonProperty("price_n")]
    public double? PriceN { get; set; }
    [JsonProperty("interval_1")]
    public int? Interval1 { get; set; }
    [JsonProperty("interval_n")]
    public int? IntervalN { get; set; }
    // Not returned when the tariff type is "Incoming Tariff".
    [JsonProperty("forbidden")]
    public bool? Forbidden { get; set; }
    [JsonProperty("grace_period_enable")]
    public bool? GracePeriodEnable { get; set; }
    [JsonProperty("activation_date")]
    public DateTime? ActivationDate { get; set; }
    // Null means never expires.
    [JsonProperty("expiration_date")]
    public DateTime? ExpirationDate { get; set; }

    #region LOCAL_CALLING
    // Only present when the tariff type is "Tariff" and local_calling is enabled on it.

    [JsonProperty("local_price_1")]
    public double? LocalPrice1 { get; set; }
    [JsonProperty("local_price_n")]
    public double? LocalPriceN { get; set; }
    [JsonProperty("local_interval_1")]
    public int? LocalInterval1 { get; set; }
    [JsonProperty("local_interval_n")]
    public int? LocalIntervalN { get; set; }
    [JsonProperty("area_name")]
    public string? AreaName { get; set; }

    #endregion
}
