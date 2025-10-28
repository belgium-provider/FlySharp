using FlySharp.Client.Abstract;
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