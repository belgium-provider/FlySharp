using FlySharp.Http;

namespace FlySharp.Client.Abstract;

public interface IXmlRpcClient
{
    Task<T> CallAsync<T>(string method, object? parameters = null) where T : BaseResponse, new();
}