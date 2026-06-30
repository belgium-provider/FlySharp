using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Response;

public class TrunkMutationResponse : BaseResponse
{
    [JsonProperty("i_trunk")]
    public int ITrunk { get; set; }
}
