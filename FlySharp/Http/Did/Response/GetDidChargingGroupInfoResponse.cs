using Newtonsoft.Json;

namespace FlySharp.Http.Did.Response;

public class GetDidChargingGroupInfoResponse : BaseResponse
{
    [JsonProperty("charging_group")]
    public Models.DidChargingGroup? ChargingGroup { get; set; }
}
