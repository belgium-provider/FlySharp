using Newtonsoft.Json;

namespace FlySharp.Http.Did.Response;

public class GetDidsListResponse : BaseResponse
{
    [JsonProperty("dids")]
    public List<Models.Did> Dids { get; set; } = [];
}
