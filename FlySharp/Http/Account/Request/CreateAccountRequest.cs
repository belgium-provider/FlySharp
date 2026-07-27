using Newtonsoft.Json;

namespace FlySharp.Http.Account.Request;

public class CreateAccountRequest
{
    #region TRUSTED_MODE

    // Required when authenticating as admin/reseller to scope the new account under a specific customer.
    // Omit when authenticating directly as the owning customer (account then belongs to that customer).
    [JsonProperty("i_customer")]
    public int? ICustomer { get; set; }

    #endregion

    #region CREDENTIALS

    [JsonProperty("username")]
    public required string Username { get; set; }
    [JsonProperty("web_password")]
    public required string WebPassword { get; set; }
    [JsonProperty("authname")]
    public required string Authname { get; set; }
    [JsonProperty("voip_password")]
    public required string VoipPassword { get; set; }
    [JsonProperty("vm_password")]
    public required string VmPassword { get; set; }

    #endregion

    #region SESSION_AND_BILLING

    [JsonProperty("max_sessions")]
    public int MaxSessions { get; set; }
    [JsonProperty("max_credit_time")]
    public int MaxCreditTime { get; set; }
    [JsonProperty("credit_limit")]
    public double CreditLimit { get; set; }
    [JsonProperty("balance")]
    public double Balance { get; set; }
    [JsonProperty("lifetime")]
    public int Lifetime { get; set; }
    [JsonProperty("i_billing_plan")]
    public int IBillingPlan { get; set; }
    [JsonProperty("i_routing_group")]
    public int? IRoutingGroup { get; set; }
    [JsonProperty("i_time_zone")]
    public int ITimeZone { get; set; }
    [JsonProperty("i_lang")]
    public required string ILang { get; set; }
    [JsonProperty("i_password_policy")]
    public int IPasswordPolicy { get; set; }
    [JsonProperty("i_media_relay_type")]
    public int IMediaRelayType { get; set; }
    [JsonProperty("i_export_type")]
    public int IExportType { get; set; }

    #endregion

    #region CALL_SETTINGS

    [JsonProperty("translation_rule")]
    public required string TranslationRule { get; set; }
    [JsonProperty("cli_translation_rule")]
    public required string CliTranslationRule { get; set; }
    [JsonProperty("cpe_number")]
    public required string CpeNumber { get; set; }
    [JsonProperty("reg_allowed")]
    public int RegAllowed { get; set; }
    // Null = Disabled, 0 = G.711u, 3 = GSM, 4 = G.723, 8 = G.711a, 9 = G.722, 15 = G.728, 18 = G.729
    [JsonProperty("preferred_codec")]
    public int? PreferredCodec { get; set; }
    [JsonProperty("use_preferred_codec_only")]
    public bool UsePreferredCodecOnly { get; set; }
    [JsonProperty("trust_cli")]
    public bool TrustCli { get; set; }
    [JsonProperty("disallow_loops")]
    public bool DisallowLoops { get; set; }
    [JsonProperty("blocked")]
    public int Blocked { get; set; }

    #endregion

    #region PAYMENT

    [JsonProperty("payment_currency")]
    public required string PaymentCurrency { get; set; }
    [JsonProperty("payment_method")]
    public int PaymentMethod { get; set; }
    [JsonProperty("min_payment_amount")]
    public double MinPaymentAmount { get; set; }
    // Null = No Action, 0 = Extend Lifetime, 1 = Clear First Use, 2 = Restart Billing
    [JsonProperty("on_payment_action")]
    public int? OnPaymentAction { get; set; }
    [JsonProperty("welcome_call_ivr")]
    public int WelcomeCallIvr { get; set; }

    #endregion

    #region VOICEMAIL

    [JsonProperty("vm_enabled")]
    public int VmEnabled { get; set; }
    [JsonProperty("vm_notify_emails")]
    public required string VmNotifyEmails { get; set; }
    [JsonProperty("vm_forward_emails")]
    public required string VmForwardEmails { get; set; }
    [JsonProperty("vm_del_after_fwd")]
    public bool VmDelAfterFwd { get; set; }
    [JsonProperty("vm_timeout")]
    public int? VmTimeout { get; set; }
    [JsonProperty("vm_check_number")]
    public string? VmCheckNumber { get; set; }

    #endregion

    #region PERSONAL_INFO

    [JsonProperty("company_name")]
    public required string CompanyName { get; set; }
    [JsonProperty("salutation")]
    public required string Salutation { get; set; }
    [JsonProperty("first_name")]
    public required string FirstName { get; set; }
    [JsonProperty("last_name")]
    public required string LastName { get; set; }
    [JsonProperty("mid_init")]
    public required string MidInit { get; set; }
    [JsonProperty("street_addr")]
    public required string StreetAddr { get; set; }
    [JsonProperty("state")]
    public required string State { get; set; }
    [JsonProperty("postal_code")]
    public required string PostalCode { get; set; }
    [JsonProperty("city")]
    public required string City { get; set; }
    [JsonProperty("country")]
    public required string Country { get; set; }
    [JsonProperty("contact")]
    public required string Contact { get; set; }
    [JsonProperty("phone")]
    public required string Phone { get; set; }
    [JsonProperty("fax")]
    public required string Fax { get; set; }
    [JsonProperty("alt_phone")]
    public required string AltPhone { get; set; }
    [JsonProperty("alt_contact")]
    public required string AltContact { get; set; }
    [JsonProperty("email")]
    public required string Email { get; set; }
    [JsonProperty("cc")]
    public required string Cc { get; set; }
    [JsonProperty("bcc")]
    public required string Bcc { get; set; }

    #endregion

    #region OPTIONAL

    [JsonProperty("i_account_class")]
    public int? IAccountClass { get; set; }
    [JsonProperty("i_commission_agent")]
    public int? ICommissionAgent { get; set; }
    [JsonProperty("commission_size")]
    public double? CommissionSize { get; set; }
    [JsonProperty("vpn_enabled")]
    public bool? VpnEnabled { get; set; }
    [JsonProperty("vpn_password")]
    public string? VpnPassword { get; set; }
    [JsonProperty("lan_access")]
    public bool? LanAccess { get; set; }
    [JsonProperty("batch_tag")]
    public string? BatchTag { get; set; }
    // Null = Disabled, 1 = Linksys
    [JsonProperty("i_provisioning")]
    public int? IProvisioning { get; set; }
    [JsonProperty("invoicing_enabled")]
    public bool? InvoicingEnabled { get; set; }
    [JsonProperty("i_invoice_template")]
    public int? IInvoiceTemplate { get; set; }
    // 1 = Pass-Through, 2 = First-Name M.I. Last-Name, 3 = Custom, 4 = CLI as Caller Name
    [JsonProperty("i_caller_name_type")]
    public int? ICallerNameType { get; set; }
    [JsonProperty("caller_name")]
    public string? CallerName { get; set; }
    [JsonProperty("followme_enabled")]
    public bool? FollowmeEnabled { get; set; }
    [JsonProperty("vm_dialin_access")]
    public bool? VmDialinAccess { get; set; }
    [JsonProperty("hide_own_cli")]
    public bool? HideOwnCli { get; set; }
    [JsonProperty("block_incoming_anonymous")]
    public bool? BlockIncomingAnonymous { get; set; }
    // 1 = Reject, 2 = Play prompt and reject, 3 = Send to voicemail
    [JsonProperty("i_incoming_anonymous_action")]
    public int? IIncomingAnonymousAction { get; set; }
    [JsonProperty("dnd_enabled")]
    public bool? DndEnabled { get; set; }
    [JsonProperty("description")]
    public string? Description { get; set; }
    [JsonProperty("pass_p_asserted_id")]
    public bool? PassPAssertedId { get; set; }
    [JsonProperty("p_assrt_id_translation_rule")]
    public string? PAssrtIdTranslationRule { get; set; }
    [JsonProperty("dncl_lookup")]
    public bool? DnclLookup { get; set; }
    [JsonProperty("generate_ringbacktone")]
    public bool? GenerateRingbacktone { get; set; }
    [JsonProperty("max_calls_per_second")]
    public double? MaxCallsPerSecond { get; set; }
    [JsonProperty("allow_free_onnet_calls")]
    public bool? AllowFreeOnnetCalls { get; set; }
    // 1 = Calls History, 4 = My Preferences
    [JsonProperty("start_page")]
    public int? StartPage { get; set; }

    #endregion
}
