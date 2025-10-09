using FlySharp.Client.Abstract;
using Newtonsoft.Json;

namespace FlySharp.Client;

public class XmlRpcClient(HttpClient httpClient, string apiEndpoint) : IXmlRpcClient
{
    /// <summary>
    /// handling HTTP requests
    /// </summary>
    private readonly HttpClient _httpClient = httpClient;
    
    /// <summary>
    /// client based. (each client has his own connection string)
    /// https://support.flysip.com/en/xml-rpc-rest-api/introduction-to-fly-sip-xml-rpc-api
    /// Ex : $"{_pProviderUrl}/api.php?username={_pUsername}&apipassword={_pPassword}";
    /// </summary>
    private readonly string _apiEndpoint = apiEndpoint.TrimEnd('/');

    /// <summary>
    /// Main method for call FlySIP XML RPC API
    /// </summary>
    /// <param name="method"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public async Task<dynamic?> CallAsync(string method, object? parameters = null)
    {
        try
        {
            string finalApiEndpoint = $"{_apiEndpoint}&action={method}";
            if (parameters != null)
                finalApiEndpoint = string.Concat(finalApiEndpoint,
                    $"&JSONString={JsonConvert.SerializeObject(parameters)}");

            HttpResponseMessage httpResponse = await _httpClient.GetAsync(new Uri(finalApiEndpoint));
            string content = await httpResponse.Content.ReadAsStringAsync();
            
            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("HTTP ERROR : " + content);
            
            return JsonConvert.DeserializeObject<dynamic>(content);
        }
        catch (Exception)
        {
            return null;
        }
    }
}