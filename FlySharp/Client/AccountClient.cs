using FlySharp.Client.Abstract;
using FlySharp.Http;
using FlySharp.Http.Account.Request;
using FlySharp.Http.Account.Response;

namespace FlySharp.Client;

public class AccountClient(FlySipOptions options, HttpClient? httpClient = null) : BaseClient(options, httpClient), IAccountClient
{
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