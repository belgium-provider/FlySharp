using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Request;

public class CreateTrunkConnectionRequest
{
    [JsonProperty("i_trunk")]
    public required int ITrunk { get; set; }
    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("destination")]
    public required string Destination { get; set; }
    // Can be an integer, "first", or "last"
    [JsonProperty("order_no")]
    public object? OrderNo { get; set; }
    [JsonProperty("username")]
    public string? Username { get; set; }
    [JsonProperty("password")]
    public string? Password { get; set; }
    [JsonProperty("outbound_ip")]
    public string? OutboundIp { get; set; }
    [JsonProperty("outbound_cld")]
    public string? OutboundCld { get; set; }
    [JsonProperty("capacity")]
    public int? Capacity { get; set; }
    [JsonProperty("max_cps")]
    public double? MaxCps { get; set; }
    [JsonProperty("from_domain")]
    public string? FromDomain { get; set; }
    [JsonProperty("random_call_id")]
    public bool? RandomCallId { get; set; }
}
