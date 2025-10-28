using Newtonsoft.Json;

namespace FlySharp.Models;

public class Customer
{
    [JsonProperty("i_customer")]
    public int ICustomer {get; set;}
    [JsonProperty("name")]
    public required string Name {get; set;}
    [JsonProperty("web_login")]
    public required string WebLogin { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; } = string.Empty;
    [JsonProperty("balance")]
    public double Balance {get; set;}
    [JsonProperty("credit_limit")]
    public double CreditLimit {get; set;}
    [JsonProperty("base_currency")]
    public string BaseCurrency {get; set;} = string.Empty;
}