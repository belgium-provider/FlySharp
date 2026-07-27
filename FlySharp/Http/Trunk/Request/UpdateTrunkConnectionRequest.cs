using Newtonsoft.Json;

namespace FlySharp.Http.Trunk.Request;

public class UpdateTrunkConnectionRequest
{
    [JsonProperty("i_trunk_connection")]
    public required int ITrunkConnection { get; set; }
    [JsonProperty("name")]
    public string? Name { get; set; }
    [JsonProperty("destination")]
    public string? Destination { get; set; }
    // Can be an integer, "first", "last", "up", or "down"
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
