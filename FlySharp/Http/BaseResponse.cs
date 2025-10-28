using Newtonsoft.Json;

namespace FlySharp.Http;

public class BaseResponse
{
    [JsonProperty("result")]
    public string Result { get; set; } = "OK";
}