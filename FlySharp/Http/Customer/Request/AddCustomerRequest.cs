using Newtonsoft.Json;

namespace FlySharp.Http.Customer.Request;

public class AddCustomerRequest : BaseResponse
{
    //required
    [JsonProperty("i_wholesaler")]
    public int IWholesaler { get; set; } //local admin (superadmin)
    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("web_password")]
    public required string WebPassword { get; set; }
    [JsonProperty("i_tariff")]
    public int ITariff { get; set; } //tariff plan
    
    //other => based on request
}