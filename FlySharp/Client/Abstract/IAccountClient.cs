using FlySharp.Http;
using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;

namespace FlySharp.Client.Abstract;

public interface IAccountClient : IBaseClient
{
    #region ACCOUNTS
    Task<GetAccountResponse> GetAccountByIdAsync(int id);
    Task<GetAccountResponse> GetAccountByUsernameAsync(string username);
    Task<GetAccountsResponse> GetAccountsAsync(GetAccountsRequest request);
    Task<BaseResponse> DeleteAccountAsync(int id);
    Task<BaseResponse> BlockAccountAsync(int id);
    Task<BaseResponse> UnblockAccountAsync(int id);
    Task<ResetAccountPwdResponse> ResetAccountPwdAsync(string username);
    #endregion
    
    #region MINUTES_RATES
    Task<GetAccountMinutPlanResponse>  GetAccountMinutePlanByIdAsync(int id);
    Task<GetAccountRatesResponse>  GetAccountRatesByIdAsync(GetAccountRatesRequest request);
    #endregion
}