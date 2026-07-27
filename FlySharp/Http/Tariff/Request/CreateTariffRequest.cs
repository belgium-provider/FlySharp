using Newtonsoft.Json;

namespace FlySharp.Http.Tariff.Request;

public class CreateTariffRequest
{
    #region TRUSTED_MODE

    // Required when authenticating as admin/reseller to scope the new tariff under a specific customer.
    [JsonProperty("i_customer")]
    public int? ICustomer { get; set; }

    #endregion

    #region REQUIRED

    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("currency")]
    public required string Currency { get; set; }

    #endregion

    #region OPTIONAL

    // Default is 1 (server-side) — refer to getSystemDictionary(tariff_types)
    [JsonProperty("i_tariff_type")]
    public int? ITariffType { get; set; }
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

    #endregion
}
