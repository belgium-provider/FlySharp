using FlySharp.Http;
using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;
using FlySharp.Http.Trunk.Request;
using FlySharp.Http.Trunk.Response;

namespace FlySharp.Client.Abstract;

public interface IAccountClient : IBaseClient
{
    #region TRUNKS
    Task<TrunkMutationResponse> CreateTrunkAsync(CreateTrunkRequest request);
    Task<TrunkMutationResponse> UpdateTrunkAsync(UpdateTrunkRequest request);
    Task<TrunkMutationResponse> DeleteTrunkAsync(int trunkId);
    Task<GetTrunkInfoResponse> GetTrunkAsync(int trunkId);
    Task<GetTrunksListResponse> GetTrunksAsync(GetTrunksListRequest request);
    #endregion

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