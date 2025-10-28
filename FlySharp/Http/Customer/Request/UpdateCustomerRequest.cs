using Newtonsoft.Json;

namespace FlySharp.Http.Customer.Request;

public class UpdateCustomerRequest : AddCustomerRequest
{
    [JsonProperty("i_customer")]
    public int ICustomer { get; set; }
}