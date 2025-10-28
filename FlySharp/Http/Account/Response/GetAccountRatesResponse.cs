using FlySharp.Models;

namespace FlySharp.Http.Account.Response;

public class GetAccountRatesResponse : BaseResponse
{
    public string Currency { get; set; } = string.Empty;
    public List<RateModel> Rates { get; set; } = [];
}