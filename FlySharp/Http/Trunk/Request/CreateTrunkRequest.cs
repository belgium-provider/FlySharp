using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Request;

public class CreateTrunkRequest
{
    [JsonProperty("i_account")]
    public required int IAccount { get; set; }
    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
}
