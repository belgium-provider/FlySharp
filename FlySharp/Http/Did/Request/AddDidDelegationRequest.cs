using Newtonsoft.Json;

namespace FlySharp.Http.Did.Request;

public class AddDidDelegationRequest
{
    [JsonProperty("i_did")]
    public required int IDid { get; set; }
    [JsonProperty("delegated_to")]
    public required int DelegatedTo { get; set; }
    // Null = first delegation; omitting this field when null is handled by NullValueHandling.Ignore
    [JsonProperty("parent_i_did_delegation")]
    public int? ParentIDidDelegation { get; set; }
    [JsonProperty("i_dids_charging_group")]
    public int? IDidsChargingGroup { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
}
