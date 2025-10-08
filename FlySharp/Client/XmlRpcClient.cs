using FlySharp.Client.Abstract;
using FlySharp.Models.Http;
using Newtonsoft.Json;

namespace FlySharp.Client;

public class XmlRpcClient : IXmlRpcClient
{
    /// <summary>
    /// Main method for call FlySIP XML RPC API
    /// </summary>
    /// <param name="method"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Task<FlySipHttpResponse<T>> CallAsync<T>(string method, object? parameters = null)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Base method for building parameters in FLySIP requests.
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns></returns>
    public string BuildRequestParams(object? parameters = null)
    {
        if (parameters == null)
            return string.Empty;

        return JsonConvert.SerializeObject(parameters);
    }
}