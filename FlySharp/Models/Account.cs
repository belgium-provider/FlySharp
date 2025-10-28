using Newtonsoft.Json;

namespace FlySharp.Models;

public class Account
{
    [JsonProperty("i_account")]
    public int IAccount {get; set;}
    [JsonProperty("username")]
    public required string Username { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; } = string.Empty;
    [JsonProperty("blocked")]
    public bool Blocked { get; set; }
    [JsonProperty("expired")]
    public bool Expired { get; set; }
    [JsonProperty("balance")]
    public double Balance { get; set; }
    [JsonProperty("credit_limit")]
    public double CreditLimit { get; set; }
    [JsonProperty("base_currency")]
    public required string BaseCurrency { get; set; }
    [JsonProperty("registration_status")]
    public RegistrationStatus? RegistrationStatus { get; set; } = null;
}