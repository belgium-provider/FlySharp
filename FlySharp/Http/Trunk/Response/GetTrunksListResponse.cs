using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Response;

public class GetTrunksListResponse : BaseResponse
{
    [JsonProperty("trunks")]
    public List<Models.Trunk> Trunks { get; set; } = [];
}
