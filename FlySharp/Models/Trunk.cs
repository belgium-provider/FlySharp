using Newtonsoft.Json;

namespace FlySharp.Models;

public class Trunk
{
    [JsonProperty("i_trunk")]
    public int ITrunk { get; set; }
    [JsonProperty("i_account")]
    public int IAccount { get; set; }
    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("description")]
    public string Description { get; set; } = string.Empty;
}
