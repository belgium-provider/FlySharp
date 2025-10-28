using Newtonsoft.Json;

namespace FlySharp.Http.Payments;

public class BaseAddFundRequest
{
    [JsonProperty("amount")]
    public double Amount { get; set; }
    [JsonProperty("currency")]
    public required string Currency { get; set; }
    [JsonProperty("payment_notes")]
    public required string PaymentNotes { get; set; }
}