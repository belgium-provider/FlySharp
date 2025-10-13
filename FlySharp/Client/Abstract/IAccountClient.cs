using FlySharp.Http;

namespace FlySharp.Client.Abstract;

public interface IAccountClient
{
    Task<GetAccountResponse> GetAccountByIdAsync(int id);
    Task<GetAccountResponse> GetAccountByUsernameAsync(string username);
    Task<GetAccountsResponse> GetAccountsAsync(int? offset = null, int? limit = null, int? customerId = null);
}