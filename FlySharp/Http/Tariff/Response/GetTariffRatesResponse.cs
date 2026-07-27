using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Response;

public class GetTariffRatesResponse : BaseResponse
{
    [JsonProperty("rates")]
    public List<Models.TariffRate> Rates { get; set; } = [];
}
