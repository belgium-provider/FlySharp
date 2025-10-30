namespace FlySharp.Http.Account.Response;

public class ResetAccountPwdResponse : BaseResponse
{
    public string Password { get; set; } = string.Empty;
}