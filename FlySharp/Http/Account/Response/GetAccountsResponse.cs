using FlySharp.Models;

namespace FlySharp.Http.Account.Response;

public class GetAccountsResponse : BaseResponse
{
    public List<Models.Account> Accounts { get; set; } = [];
}