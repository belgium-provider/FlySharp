using FlySharp.Models;

namespace FlySharp.Http.Account;

public class GetAccountResponse : BaseResponse
{
    public Models.Account? Account { get; set; }
}