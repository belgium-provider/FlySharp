using FlySharp.Client.Abstract;
using FlySharp.Http;

namespace FlySharp.Client;

public class AccountClient(IXmlRpcClient xmlRpcClient) : IAccountClient
{
    private readonly IXmlRpcClient _xmlRpcClient = xmlRpcClient;
    
    /// <summary>
    /// Get account using it's id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task<GetAccountResponse> GetAccountByIdAsync(int id) => await _xmlRpcClient.CallAsync<GetAccountResponse>("getAccountInfo", new {i_account = id});
    
    /// <summary>
    /// Get account using username
    /// </summary>
    /// <param name="username"></param>
    /// <returns></returns>
    public async Task<GetAccountResponse> GetAccountByUsernameAsync(string username) => await _xmlRpcClient.CallAsync<GetAccountResponse>("getAccountInfo", new {username});

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

        return await _xmlRpcClient.CallAsync<GetAccountsResponse>("listAccounts", payload);
    }
}