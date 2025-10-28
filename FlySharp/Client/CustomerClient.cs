using FlySharp.Client.Abstract;
using FlySharp.Http;
using FlySharp.Http.Customer.Request;
using FlySharp.Http.Customer.Response;

namespace FlySharp.Client;

/// <summary>
/// This class is destinated to supper admin usage. Managing whole server
/// </summary>
public class CustomerClient(FlySipOptions options, HttpClient? httpClient = null) : BaseClient(options, httpClient), ICustomerClient
{

    /// <summary>
    /// Retrieve a single customer using it's id.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="wholeSalerId"></param>
    /// <returns></returns>
    public async Task<GetCustomerResponse> GetCustomerByIdAsync(int id, int wholeSalerId) => await this.CallAsync<GetCustomerResponse>("getCustomerInfo", new {i_customer = id, i_wholesaler = wholeSalerId });

    /// <summary>
    /// retrieve list of customers.
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<GetCustomersResponse> GetCustomersAsync(GetCustomersRequest request) => await this.CallAsync<GetCustomersResponse>("listCustomers", request);
    
    /// <summary>
    /// Creating a new customer
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request) => await this.CallAsync<AddCustomerResponse>("createCustomer", request);
    
    /// <summary>
    /// Update a single customer information
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<BaseResponse> UpdateCustomerAsync(UpdateCustomerRequest request) => await this.CallAsync<BaseResponse>("updateCustomer", request);
}