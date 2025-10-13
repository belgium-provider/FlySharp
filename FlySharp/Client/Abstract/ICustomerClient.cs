using FlySharp.Http.Customer;

namespace FlySharp.Client.Abstract;

public interface ICustomerClient
{
    Task<GetCustomerResponse> GetCustomerByIdAsync(int id, int wholeSalerId);
    Task<GetCustomersResponse> GetCustomersAsync(int wholeSalerId, int? offset = null, int? limit = null);
}