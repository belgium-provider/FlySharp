using Newtonsoft.Json;

namespace FlySharp.Http.Customer.Response;

public class AuthCustomerResponse : BaseResponse
{
    [JsonProperty("i_customer")]
    public int ICustomer { get; set; }
    [JsonProperty("i_web_user")]
    public int IWebUser { get; set; }
    [JsonProperty("i_access_level")]
    public string? IAccessLevel { get; set; }
}
