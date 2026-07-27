using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Response;

public class GetTrunkConnectionsListResponse : BaseResponse
{
    [JsonProperty("trunk_connections")]
    public List<Models.TrunkConnection> TrunkConnections { get; set; } = [];
}
