using FlySharp.Http.Account;

namespace FlySharp.Client.Abstract;

public interface IAccountClient
{
    Task<GetAccountResponse> GetAccountByIdAsync(int id);
    Task<GetAccountResponse> GetAccountByUsernameAsync(string username);
    Task<GetAccountsResponse> GetAccountsAsync(int? offset = null, int? limit = null, int? customerId = null);
    
    #region MINUTES_RATES
    Task<GetAccountMinutPlanResponse>  GetAccountMinutPlanByIdAsync(int id);
    Task<GetAccountRatesResponse>  GetAccountRatesByIdAsync(int id, int? offset = null, int? limit = null, string? prefix = null);
    #endregion
}