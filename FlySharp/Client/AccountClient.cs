using FlySharp.Client.Abstract;
using FlySharp.Http;
using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;
using FlySharp.Http.Trunk.Request;
using FlySharp.Http.Trunk.Response;

namespace FlySharp.Client;

public class AccountClient(FlySipOptions options, HttpClient? httpClient = null) : BaseClient(options, httpClient), IAccountClient
{
    public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request) => await this.CallAsync<CreateAccountResponse>("createAccount", request);

    /// <summary>
    /// Get account using it's id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<GetAccountResponse> GetAccountByIdAsync(int id) => await this.CallAsync<GetAccountResponse>("getAccountInfo", new {i_account = id});
    
    /// <summary>
    /// Get account using username
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public async Task<GetAccountResponse> GetAccountByUsernameAsync(string username) => await this.CallAsync<GetAccountResponse>("getAccountInfo", new {username});

    /// <summary>
    /// Listing accounts
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<GetAccountsResponse> GetAccountsAsync(GetAccountsRequest request) => await this.CallAsync<GetAccountsResponse>("listAccounts", request);
    
    /// <summary>
    /// Deleting a single account
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<BaseResponse> DeleteAccountAsync(int id) => await this.CallAsync<BaseResponse>("deleteAccount",  new {i_account = id});
    
    /// <summary>
    /// Blocking a single account
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<BaseResponse> BlockAccountAsync(int id) => await this.CallAsync<BaseResponse>("blockAccount", new {i_account = id});
    
    /// <summary>
    /// Unblocking a single account
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<BaseResponse> UnblockAccountAsync(int id) => await this.CallAsync<BaseResponse>("unblockAccount", new {i_account = id});
    
    /// <summary>
    /// This application is used to reset account's one time password used to login into web interface. Only accounts of authenticated customer can be reset.
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public async Task<ResetAccountPwdResponse> ResetAccountPwdAsync(string username) => await this.CallAsync<ResetAccountPwdResponse>("resetAccountOneTimePassword", new {username});

    #region TRUNKS

    public async Task<TrunkMutationResponse> CreateTrunkAsync(CreateTrunkRequest request) => await this.CallAsync<TrunkMutationResponse>("createTrunk", request);

    public async Task<TrunkMutationResponse> UpdateTrunkAsync(UpdateTrunkRequest request) => await this.CallAsync<TrunkMutationResponse>("updateTrunk", request);

    public async Task<TrunkMutationResponse> DeleteTrunkAsync(int trunkId) => await this.CallAsync<TrunkMutationResponse>("deleteTrunk", new { i_trunk = trunkId });

    public async Task<GetTrunkInfoResponse> GetTrunkAsync(int trunkId) => await this.CallAsync<GetTrunkInfoResponse>("getTrunkInfo", new { i_trunk = trunkId });

    public async Task<GetTrunksListResponse> GetTrunksAsync(GetTrunksListRequest request) => await this.CallAsync<GetTrunksListResponse>("getTrunksList", request);

    #endregion

    #region TRUNK_CONNECTIONS

    public async Task<TrunkConnectionMutationResponse> CreateTrunkConnectionAsync(CreateTrunkConnectionRequest request) => await this.CallAsync<TrunkConnectionMutationResponse>("createTrunkConnection", request);

    public async Task<TrunkConnectionMutationResponse> UpdateTrunkConnectionAsync(UpdateTrunkConnectionRequest request) => await this.CallAsync<TrunkConnectionMutationResponse>("updateTrunkConnection", request);

    public async Task<TrunkConnectionMutationResponse> DeleteTrunkConnectionAsync(int trunkConnectionId) => await this.CallAsync<TrunkConnectionMutationResponse>("deleteTrunkConnection", new { i_trunk_connection = trunkConnectionId });

    public async Task<GetTrunkConnectionInfoResponse> GetTrunkConnectionAsync(int trunkConnectionId) => await this.CallAsync<GetTrunkConnectionInfoResponse>("getTrunkConnectionInfo", new { i_trunk_connection = trunkConnectionId });

    public async Task<GetTrunkConnectionsListResponse> GetTrunkConnectionsAsync(GetTrunkConnectionsListRequest request) => await this.CallAsync<GetTrunkConnectionsListResponse>("getTrunkConnectionsList", request);

    #endregion

    #region MINUTES_RATES
    
    /// <summary>
    /// Get account minute plans based on it's id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<GetAccountMinutPlanResponse> GetAccountMinutePlanByIdAsync(int id) => await this.CallAsync<GetAccountMinutPlanResponse>("getAccountMinutePlans", new {i_account = id});

    /// <summary>
    /// Getting account rates.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<GetAccountRatesResponse> GetAccountRatesByIdAsync(GetAccountRatesRequest request) => await this.CallAsync<GetAccountRatesResponse>("getAccountRates", request);

    #endregion
}