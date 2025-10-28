using Newtonsoft.Json;

namespace FlySharp.Http.Account.Request;

public class GetAccountRatesRequest() : BaseListRequestObject
{
    [JsonProperty("i_account")]
    public int IAccount { get; set; }
    
    [JsonProperty("prefix")]
    public string? Prefix { get; set; } = null;
}