using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Response;

public class GetTariffsResponse : BaseResponse
{
    [JsonProperty("tariffs")]
    public List<Models.Tariff> Tariffs { get; set; } = [];
}