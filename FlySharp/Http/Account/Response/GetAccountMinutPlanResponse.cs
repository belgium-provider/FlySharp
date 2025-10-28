using FlySharp.Models;

namespace FlySharp.Http.Account.Response;

public class GetAccountMinutPlanResponse : BaseResponse
{
    private List<MinutePlan> MinutePlans { get; set; } = [];
}