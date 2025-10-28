using Newtonsoft.Json;

namespace FlySharp.Http.Customer.Request;

public class AddCustomerResponse : BaseResponse
{
    [JsonProperty("i_customer")]
    public int ICustomer { get; set; }
}