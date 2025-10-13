using FlySharp.Client.Abstract;
using FlySharp.Http;
using FlySharp.Http.Payments;

namespace FlySharp.Client;

public class PaymentClient(IXmlRpcClient rpcClient) : IPaymentClient
{
    private readonly IXmlRpcClient _rpcClient = rpcClient;
    
    /// <summary>
    /// Add funds to an account.
    /// </summary>
    /// <param name="payload"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<BaseResponse> AddAccountFundsAsync(AddAccountFundRequest payload) => await _rpcClient.CallAsync<BaseResponse>("accountAddFunds", payload);
    
    /// <summary>
    /// Add funds to a customer account.
    /// </summary>
    /// <param name="payload"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<BaseResponse> AddCustomerFundsAsync(AddCustomerFundRequest payload) => await _rpcClient.CallAsync<BaseResponse>("customerAddFunds", payload);
}