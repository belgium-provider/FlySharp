using Newtonsoft.Json;

namespace FlySharp.Models;

public class DidChargingGroup
{
    [JsonProperty("i_dids_charging_group")]
    public int IDidsChargingGroup { get; set; }
    [JsonProperty("i_customer")]
    public int ICustomer { get; set; }
    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
    [JsonProperty("connect_fee")]
    public double ConnectFee { get; set; }
    [JsonProperty("free_seconds")]
    public int FreeSeconds { get; set; }
    [JsonProperty("grace_period")]
    public int GracePeriod { get; set; }
    [JsonProperty("price_1")]
    public double Price1 { get; set; }
    [JsonProperty("price_n")]
    public double PriceN { get; set; }
    [JsonProperty("interval_1")]
    public int Interval1 { get; set; }
    [JsonProperty("interval_n")]
    public int IntervalN { get; set; }
    [JsonProperty("iso_4217")]
    public required string Iso4217 { get; set; }
    [JsonProperty("price")]
    public double Price { get; set; }
    [JsonProperty("setup_fee")]
    public double SetupFee { get; set; }
    [JsonProperty("post_call_surcharge")]
    public double PostCallSurcharge { get; set; }
    // 1 = Selling, 2 = Buying
    [JsonProperty("type")]
    public int Type { get; set; }
}
