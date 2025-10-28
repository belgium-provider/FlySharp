using Newtonsoft.Json;

namespace FlySharp.Http;

public class BaseListRequestObject
{
    [JsonProperty("offset")]
    public int Offset { get; set; } = 0;
    [JsonProperty("limit")]
    public int Limit { get; set; } = 100;
}