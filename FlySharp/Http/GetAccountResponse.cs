using FlySharp.Models;

namespace FlySharp.Http;

public class GetAccountResponse : BaseResponse
{
    public List<Account> Accounts { get; set; } = [];
}