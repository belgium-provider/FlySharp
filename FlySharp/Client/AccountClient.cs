using FlySharp.Client.Abstract;
using FlySharp.Http.Account;

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
    /// <param name="offset"></param>
    /// <param name="limit"></param>
    /// <param name="customerId"></param>
    /// <returns></returns>
    public async Task<GetAccountsResponse> GetAccountsAsync(int? offset = null, int? limit = null, int? customerId = null)
    {
        int page = offset ?? 0;
        int pageSize = limit ?? 100;
        
        var payload = new Dictionary<string, object>
        {
            ["offset"] = page,
            ["limit"] = pageSize
        };

        if (customerId.HasValue)
            payload["i_customer"] = customerId.Value;

        return await this.CallAsync<GetAccountsResponse>("listAccounts", payload);
    }
    
    #region MINUTES_RATES
    
    /// <summary>
    /// Get account minute plans based on it's id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<GetAccountMinutPlanResponse> GetAccountMinutPlanByIdAsync(int id) => await this.CallAsync<GetAccountMinutPlanResponse>("getAccountMinutePlans", new {i_account = id});

    public async Task<GetAccountRatesResponse> GetAccountRatesByIdAsync(int id, int? offset = null, int? limit = null, string? prefix = null)
    {
        int page = offset ?? 0;
        int pageSize = limit ?? 100;
        
        var payload = new Dictionary<string, object>
        {
            ["i_account"] = id,
            ["offset"] = page,
            ["limit"] = pageSize
        };

        if (prefix != null)
            payload["prefix"] = prefix;

        return await this.CallAsync<GetAccountRatesResponse>("getAccountRates", payload);
    }

    #endregion
}