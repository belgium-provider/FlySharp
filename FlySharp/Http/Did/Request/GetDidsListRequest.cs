using Newtonsoft.Json;

namespace FlySharp.Http.Did.Request;

public class GetDidsListRequest : BaseListRequestObject
{
    [JsonProperty("did")]
    public string? Did { get; set; }
    [JsonProperty("incoming_did")]
    public string? IncomingDid { get; set; }
    [JsonProperty("delegated_to")]
    public int? DelegatedTo { get; set; }
    [JsonProperty("i_account")]
    public string? IAccount { get; set; }
    [JsonProperty("i_ivr_application")]
    public int? IIvrApplication { get; set; }
    [JsonProperty("not_assigned")]
    public bool? NotAssigned { get; set; }
}
