using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Request;

public class UpdateTariffRequest
{
    [JsonProperty("i_tariff")]
    public required int ITariff { get; set; }

    // currency and i_tariff_type cannot be changed after creation — omitted here on purpose.
    [JsonProperty("name")]
    public string? Name { get; set; }
    [JsonProperty("connect_fee")]
    public double? ConnectFee { get; set; }
    [JsonProperty("free_seconds")]
    public int? FreeSeconds { get; set; }
    [JsonProperty("post_call_surcharge")]
    public double? PostCallSurcharge { get; set; }
    [JsonProperty("grace_period")]
    public int? GracePeriod { get; set; }
    [JsonProperty("loss_protection")]
    public bool? LossProtection { get; set; }
    [JsonProperty("max_loss")]
    public double? MaxLoss { get; set; }
    [JsonProperty("cost_round_up")]
    public bool? CostRoundUp { get; set; }
    [JsonProperty("decimal_precision")]
    public int? DecimalPrecision { get; set; }
    [JsonProperty("average_duration")]
    public int? AverageDuration { get; set; }
    [JsonProperty("local_calling")]
    public bool? LocalCalling { get; set; }
    [JsonProperty("local_calling_cli_validation_rule")]
    public string? LocalCallingCliValidationRule { get; set; }
}
