using FlySharp.Models;

namespace FlySharp.Http.Account;

public class GetAccountsResponse : BaseResponse
{
    public List<Models.Account> Accounts { get; set; } = [];
}