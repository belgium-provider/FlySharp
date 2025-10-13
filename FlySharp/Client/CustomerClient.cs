using FlySharp.Client.Abstract;
using FlySharp.Http;

namespace FlySharp.Client;

/// <summary>
/// This class is destinated to supper admin usage. Managing whole server
/// </summary>
/// <param name="xmlRpcClient"></param>
public class CustomerClient(IXmlRpcClient xmlRpcClient) : ICustomerClient
{
    private readonly IXmlRpcClient _xmlRpcClient = xmlRpcClient;

    /// <summary>
    /// Retrieve a single customer using it's id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="wholeSalerId"></param>
    /// <returns></returns>
    public async Task<GetCustomerResponse> GetCustomerByIdAsync(int id, int wholeSalerId) => await _xmlRpcClient.CallAsync<GetCustomerResponse>("getCustomerInfo", new {i_customer = id, i_wholesaler = wholeSalerId });

    /// <summary>
    /// retrieve list of customers.
    /// </summary>
    /// <param name="offset"></param>
    /// <param name="limit"></param>
    /// <param name="wholeSalerId"></param>
    /// <returns></returns>
    public async Task<GetCustomersResponse> GetCustomersAsync(int wholeSalerId, int? offset = null, int? limit = null)
    {
        int page = offset ?? 0;
        int pageSize = limit ?? 100;
        
        return await _xmlRpcClient.CallAsync<GetCustomersResponse>("listCustomers", new {offset = page, limit = pageSize, i_wholesaler =  wholeSalerId});
    }
}