using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Response;

public class GetTariffResponse :  BaseResponse
{
    [JsonProperty("tariff")]
    public Models.Tariff Tariff { get; set; }
}