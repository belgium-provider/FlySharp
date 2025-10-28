using FlySharp.Models;

namespace FlySharp.Http.Account.Response;

public class GetAccountResponse : BaseResponse
{
    public Models.Account? Account { get; set; }
}