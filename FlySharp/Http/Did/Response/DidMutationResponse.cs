using Newtonsoft.Json;

namespace FlySharp.Http.Did.Response;

public class DidMutationResponse : BaseResponse
{
    [JsonProperty("i_did")]
    public int IDid { get; set; }
}
