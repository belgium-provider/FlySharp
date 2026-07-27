using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Request;

public class GetTariffRatesRequest : BaseListRequestObject
{
    [JsonProperty("i_tariff")]
    public int ITariff { get; set; }

    // Required when authenticating as admin/reseller to scope the request under a specific customer.
    [JsonProperty("i_customer")]
    public int? ICustomer { get; set; }
}
