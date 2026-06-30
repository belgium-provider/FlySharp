using Newtonsoft.Json;

namespace FlySharp.Http.Account.Response;

public class CreateAccountResponse : BaseResponse
{
    [JsonProperty("i_account")]
    public int IAccount { get; set; }
    [JsonProperty("username")]
    public string? Username { get; set; }
    [JsonProperty("web_password")]
    public string? WebPassword { get; set; }
    [JsonProperty("authname")]
    public string? Authname { get; set; }
    [JsonProperty("voip_password")]
    public string? VoipPassword { get; set; }
    [JsonProperty("vm_password")]
    public string? VmPassword { get; set; }
    [JsonProperty("vpn_password")]
    public string? VpnPassword { get; set; }
}
