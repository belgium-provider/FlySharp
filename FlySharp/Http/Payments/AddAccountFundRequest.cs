using Newtonsoft.Json;

namespace FlySharp.Http.Payments;

public class AddAccountFundRequest : BaseAddFundRequest
{
    [JsonProperty("i_account")]
    public int IAccount { get; set; }
}