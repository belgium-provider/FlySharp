using FlySharp.Models;

namespace FlySharp.Http;

public class GetAccountResponse : BaseResponse
{
    public Account? Account { get; set; }
}