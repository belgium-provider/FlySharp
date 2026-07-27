using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Response;

public class CreateTariffResponse : BaseResponse
{
    [JsonProperty("i_tariff")]
    public int ITariff { get; set; }
}
