using Newtonsoft.Json;

namespace FlySharp.Http.Account.Request;

public class GetAccountsRequest : BaseListRequestObject
{
    [JsonProperty("i_customer")]
    public int? ICustomer { get; set; } = null;
}