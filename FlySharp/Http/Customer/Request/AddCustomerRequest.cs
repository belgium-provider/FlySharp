using Newtonsoft.Json;

namespace FlySharp.Http.Customer.Request;

public class AddCustomerRequest : BaseResponse
{
    #region REQUIRED

    [JsonProperty("i_wholesaler")]
    public int IWholesaler { get; set; }
    [JsonProperty("name")]
    public required string Name { get; set; }
    [JsonProperty("web_password")]
    public required string WebPassword { get; set; }
    // Null = own tariff
    [JsonProperty("i_tariff")]
    public int? ITariff { get; set; }

    #endregion

    #region BILLING

    [JsonProperty("balance")]
    public double? Balance { get; set; }
    [JsonProperty("credit_limit")]
    public double? CreditLimit { get; set; }
    [JsonProperty("payment_currency")]
    public string? PaymentCurrency { get; set; }
    [JsonProperty("payment_method")]
    public int? PaymentMethod { get; set; }
    [JsonProperty("min_payment_amount")]
    public double? MinPaymentAmount { get; set; }
    [JsonProperty("i_routing_group")]
    public int? IRoutingGroup { get; set; }
    [JsonProperty("i_commission_agent")]
    public int? ICommissionAgent { get; set; }
    [JsonProperty("commission_size")]
    public double? CommissionSize { get; set; }
    [JsonProperty("max_sessions")]
    public int? MaxSessions { get; set; }
    [JsonProperty("max_calls_per_second")]
    public double? MaxCallsPerSecond { get; set; }

    #endregion

    #region MANAGEMENT_RIGHTS

    // Bitmask: bit0=add, bit1=edit, bit2=delete
    [JsonProperty("accounts_mgmt")]
    public int? AccountsMgmt { get; set; }
    [JsonProperty("customers_mgmt")]
    public int? CustomersMgmt { get; set; }
    [JsonProperty("tariffs_mgmt")]
    public int? TariffsMgmt { get; set; }
    [JsonProperty("vouchers_mgmt")]
    public int? VouchersMgmt { get; set; }
    [JsonProperty("system_mgmt")]
    public int? SystemMgmt { get; set; }
    [JsonProperty("use_own_tariff")]
    public int? UseOwnTariff { get; set; }
    [JsonProperty("max_depth")]
    public int? MaxDepth { get; set; }
    [JsonProperty("accounts_matching_rule")]
    public string? AccountsMatchingRule { get; set; }

    #endregion

    #region PERSONAL_INFO

    [JsonProperty("company_name")]
    public string? CompanyName { get; set; }
    [JsonProperty("salutation")]
    public string? Salutation { get; set; }
    [JsonProperty("first_name")]
    public string? FirstName { get; set; }
    [JsonProperty("last_name")]
    public string? LastName { get; set; }
    [JsonProperty("mid_init")]
    public string? MidInit { get; set; }
    [JsonProperty("street_addr")]
    public string? StreetAddr { get; set; }
    [JsonProperty("state")]
    public string? State { get; set; }
    [JsonProperty("postal_code")]
    public string? PostalCode { get; set; }
    [JsonProperty("city")]
    public string? City { get; set; }
    [JsonProperty("country")]
    public string? Country { get; set; }
    [JsonProperty("contact")]
    public string? Contact { get; set; }
    [JsonProperty("phone")]
    public string? Phone { get; set; }
    [JsonProperty("fax")]
    public string? Fax { get; set; }
    [JsonProperty("alt_phone")]
    public string? AltPhone { get; set; }
    [JsonProperty("alt_contact")]
    public string? AltContact { get; set; }
    [JsonProperty("email")]
    public string? Email { get; set; }
    [JsonProperty("cc")]
    public string? Cc { get; set; }
    [JsonProperty("bcc")]
    public string? Bcc { get; set; }
    [JsonProperty("mail_from")]
    public string? MailFrom { get; set; }

    #endregion

    #region FEATURES

    [JsonProperty("api_access")]
    public int? ApiAccess { get; set; }
    [JsonProperty("api_password")]
    public string? ApiPassword { get; set; }
    [JsonProperty("api_mgmt")]
    public int? ApiMgmt { get; set; }
    [JsonProperty("callshop_enabled")]
    public bool? CallshopEnabled { get; set; }
    [JsonProperty("overcommit_protection")]
    public bool? OvercommitProtection { get; set; }
    [JsonProperty("overcommit_limit")]
    public double? OvercommitLimit { get; set; }
    [JsonProperty("did_pool_enabled")]
    public bool? DidPoolEnabled { get; set; }
    [JsonProperty("ivr_apps_enabled")]
    public bool? IvrAppsEnabled { get; set; }
    [JsonProperty("asr_acd_enabled")]
    public bool? AsrAcdEnabled { get; set; }
    [JsonProperty("debit_credit_cards_enabled")]
    public bool? DebitCreditCardsEnabled { get; set; }
    [JsonProperty("conferencing_enabled")]
    public bool? ConferencingEnabled { get; set; }
    [JsonProperty("share_payment_processors")]
    public bool? SharePaymentProcessors { get; set; }
    [JsonProperty("dncl_enabled")]
    public bool? DnclEnabled { get; set; }

    #endregion

    #region PREFERENCES

    [JsonProperty("web_login")]
    public string? WebLogin { get; set; }
    [JsonProperty("i_time_zone")]
    public int? ITimeZone { get; set; }
    [JsonProperty("i_lang")]
    public string? ILang { get; set; }
    [JsonProperty("i_export_type")]
    public int? IExportType { get; set; }
    [JsonProperty("i_password_policy")]
    public int? IPasswordPolicy { get; set; }
    [JsonProperty("start_page")]
    public int? StartPage { get; set; }
    [JsonProperty("css")]
    public string? Css { get; set; }
    [JsonProperty("dns_alias")]
    public string? DnsAlias { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }

    #endregion
}
