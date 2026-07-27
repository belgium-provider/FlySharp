using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Request;

public class GetTrunksListRequest
{
    [JsonProperty("i_account")]
    public required int IAccount { get; set; }
    [JsonProperty("name_pattern")]
    public string? NamePattern { get; set; }
}
