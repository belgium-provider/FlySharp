using Newtonsoft.Json;

namespace FlySharp.Http.Did.Response;

public class DidDelegationMutationResponse : BaseResponse
{
    [JsonProperty("i_did_delegation")]
    public int IDidDelegation { get; set; }
}
