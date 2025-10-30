using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Request;

public class GetTariffsRequest : BaseListRequestObject
{
    [JsonProperty("name_pattern")]
    public string?  NamePattern { get; set; } = null;
}