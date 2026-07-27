using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Response;

public class TrunkConnectionMutationResponse : BaseResponse
{
    [JsonProperty("i_trunk_connection")]
    public int ITrunkConnection { get; set; }
}
