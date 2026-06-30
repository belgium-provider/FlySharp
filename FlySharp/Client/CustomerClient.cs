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
    public async Task<GetCustomerResponse> GetCustomerByIdAsync(int id, int wholeSalerId) => await this.CallAsync<GetCustomerResponse>("getCustomerInfo", new { i_customer = id, i_wholesaler = wholeSalerId });

    public async Task<GetCustomersResponse> GetCustomersAsync(GetCustomersRequest request) => await this.CallAsync<GetCustomersResponse>("listCustomers", request);

    public async Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request) => await this.CallAsync<AddCustomerResponse>("createCustomer", request);

    public async Task<BaseResponse> UpdateCustomerAsync(UpdateCustomerRequest request) => await this.CallAsync<BaseResponse>("updateCustomer", request);

    public async Task<BaseResponse> DeleteCustomerAsync(int id) => await this.CallAsync<BaseResponse>("deleteCustomer", new { i_customer = id });

    public async Task<BaseResponse> BlockCustomerAsync(int id, int wholeSalerId) => await this.CallAsync<BaseResponse>("blockCustomer", new { i_customer = id, i_wholesaler = wholeSalerId });

    public async Task<BaseResponse> UnblockCustomerAsync(int id, int wholeSalerId) => await this.CallAsync<BaseResponse>("unblockCustomer", new { i_customer = id, i_wholesaler = wholeSalerId });

    public async Task<AuthCustomerResponse> AuthCustomerAsync(string username, string password) => await this.CallAsync<AuthCustomerResponse>("authCustomer", new { username, password });
}
