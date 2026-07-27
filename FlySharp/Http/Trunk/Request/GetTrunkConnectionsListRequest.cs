using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Request;

public class GetTrunkConnectionsListRequest
{
    [JsonProperty("i_trunk")]
    public required int ITrunk { get; set; }
    [JsonProperty("name_pattern")]
    public string? NamePattern { get; set; }
}
