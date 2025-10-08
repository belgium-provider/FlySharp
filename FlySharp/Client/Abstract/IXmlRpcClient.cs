using FlySharp.Models.Http;

namespace FlySharp.Client.Abstract;

public interface IXmlRpcClient
{
    Task<FlySipHttpResponse<T>> CallAsync<T>(string method, object? parameters = null);
}