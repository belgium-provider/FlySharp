using FlySharp.Http;
using FlySharp.Http.Customer;

namespace FlySharp.Client.Abstract;

public interface ICustomerClient : IBaseClient
{
    Task<GetCustomerResponse> GetCustomerByIdAsync(int id, int wholeSalerId);
    Task<GetCustomersResponse> GetCustomersAsync(int wholeSalerId, int? offset = null, int? limit = null);
    Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request);
    Task<BaseResponse> UpdateCustomerAsync(UpdateCustomerRequest request);
}