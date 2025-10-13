using FlySharp.Models;

namespace FlySharp.Http.Account;

public class GetAccountMinutPlanResponse : BaseResponse
{
    private List<MinutePlan> MinutePlans { get; set; } = [];
}