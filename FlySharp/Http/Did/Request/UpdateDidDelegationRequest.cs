using Newtonsoft.Json;

namespace FlySharp.Http.Did.Request;

public class UpdateDidDelegationRequest
{
    [JsonProperty("i_did_delegation")]
    public required int IDidDelegation { get; set; }
    [JsonProperty("delegated_to")]
    public required int DelegatedTo { get; set; }
    [JsonProperty("i_dids_charging_group")]
    public int? IDidsChargingGroup { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
}
