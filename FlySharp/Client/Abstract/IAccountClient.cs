using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;

namespace FlySharp.Client.Abstract;

public interface IAccountClient : IBaseClient
{
    Task<GetAccountResponse> GetAccountByIdAsync(int id);
    Task<GetAccountResponse> GetAccountByUsernameAsync(string username);
    Task<GetAccountsResponse> GetAccountsAsync(GetAccountsRequest request);
    
    #region MINUTES_RATES
    Task<GetAccountMinutPlanResponse>  GetAccountMinutePlanByIdAsync(int id);
    Task<GetAccountRatesResponse>  GetAccountRatesByIdAsync(GetAccountRatesRequest request);
    #endregion
}