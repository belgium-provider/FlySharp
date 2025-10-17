using FlySharp.Http;
using FlySharp.Http.Payments;

namespace FlySharp.Client.Abstract;

public interface IPaymentClient : IBaseClient
{
    Task<BaseResponse> AddAccountFundsAsync(AddAccountFundRequest payload);
    Task<BaseResponse> AddCustomerFundsAsync(AddCustomerFundRequest payload);
}