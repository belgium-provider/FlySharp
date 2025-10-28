using FlySharp.Http;
using FlySharp.Http.Customer.Request;
using FlySharp.Http.Customer.Response;

namespace FlySharp.Client.Abstract;

public interface ICustomerClient : IBaseClient
{
    Task<GetCustomerResponse> GetCustomerByIdAsync(int id, int wholeSalerId);
    Task<GetCustomersResponse> GetCustomersAsync(GetCustomersRequest request);
    Task<AddCustomerResponse> AddCustomerAsync(AddCustomerRequest request);
    Task<BaseResponse> UpdateCustomerAsync(UpdateCustomerRequest request);
}