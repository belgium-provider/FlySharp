using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Response;

public class GetTrunkConnectionInfoResponse : BaseResponse
{
    [JsonProperty("trunk_connection")]
    public Models.TrunkConnection? TrunkConnection { get; set; }
}
