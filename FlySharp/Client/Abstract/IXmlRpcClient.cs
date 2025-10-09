namespace FlySharp.Client.Abstract;

public interface IXmlRpcClient
{
    Task<dynamic?> CallAsync(string method, object? parameters = null);
}