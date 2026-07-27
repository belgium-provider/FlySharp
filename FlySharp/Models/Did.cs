using Newtonsoft.Json;

namespace FlySharp.Models;

public class Did
{
    [JsonProperty("i_did")]
    public int IDid { get; set; }
    [JsonProperty("did")]
    public required string DidNumber { get; set; }
    [JsonProperty("incoming_did")]
    public required string IncomingDid { get; set; }
    [JsonProperty("translation_rule")]
    public string? TranslationRule { get; set; }
    [JsonProperty("cld_translation_rule")]
    public string? CldTranslationRule { get; set; }
    [JsonProperty("cli_translation_rule")]
    public string? CliTranslationRule { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
    [JsonProperty("i_ivr_application")]
    public int? IIvrApplication { get; set; }
    [JsonProperty("i_account")]
    public int? IAccount { get; set; }
    [JsonProperty("i_dids_charging_group")]
    public int? IDidsChargingGroup { get; set; }
    [JsonProperty("fwd_did")]
    public bool? FwdDid { get; set; }
    [JsonProperty("i_vendor")]
    public int? IVendor { get; set; }
    [JsonProperty("i_connection")]
    public int? IConnection { get; set; }
    [JsonProperty("buying_i_dids_charging_group")]
    public int? BuyingIDidsChargingGroup { get; set; }
    [JsonProperty("i_did_delegation")]
    public int? IDidDelegation { get; set; }
    [JsonProperty("delegated_to")]
    public int? DelegatedTo { get; set; }
    // Null = first delegation
    [JsonProperty("parent_i_did_delegation")]
    public int? ParentIDidDelegation { get; set; }
}
