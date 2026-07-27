using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Response;

public class GetTrunkInfoResponse : BaseResponse
{
    [JsonProperty("trunk")]
    public Models.Trunk? Trunk { get; set; }
}
