using Newtonsoft.Json;

namespace FlySharp.Http.Did.Response;

public class GetDidInfoResponse : BaseResponse
{
    [JsonProperty("did")]
    public Models.Did? Did { get; set; }
}
