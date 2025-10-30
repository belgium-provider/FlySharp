using Newtonsoft.Json;

namespace FlySharp.Http.Payments;

public class AddVendorFundRequest : BaseAddFundRequest
{
    [JsonProperty("i_vendor")]
    public int IVendor { get; set; }
}