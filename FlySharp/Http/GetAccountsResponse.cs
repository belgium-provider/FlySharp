using FlySharp.Models;

namespace FlySharp.Http;

public class GetAccountsResponse : BaseResponse
{
    public List<Account> Accounts { get; set; } = [];
}