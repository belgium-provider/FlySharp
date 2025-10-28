using Newtonsoft.Json;

namespace FlySharp.Http.Customer.Request;

public class GetCustomersRequest : BaseListRequestObject
{
    [JsonProperty("i_wholesaler")]
    public int WholeSaler {get; set;}
}