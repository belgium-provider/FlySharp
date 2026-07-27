using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Request;

public class UpdateTrunkRequest
{
    [JsonProperty("i_trunk")]
    public required int ITrunk { get; set; }
    [JsonProperty("name")]
    public string? Name { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
}
