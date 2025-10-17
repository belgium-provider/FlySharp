using FlySharp.Client.Abstract;
using FlySharp.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FlySharp.Client;

public abstract class BaseClient(FlySipOptions options, HttpClient? httpClient = null) : IDisposable
{
    /// <summary>
    /// handling HTTP requests
    /// </summary>
    private readonly HttpClient _httpClient = httpClient ?? new HttpClient();
    
    /// <summary>
    /// FlySip options object
    /// </summary>
    private readonly FlySipOptions _options = options;
    
    /// <summary>
    /// Configure JSON settings for handling snake_case returns
    /// </summary>
    private static readonly JsonSerializerSettings JsonSettings = new()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy()
        },
        MissingMemberHandling = MissingMemberHandling.Ignore,
        NullValueHandling = NullValueHandling.Ignore
    };

    /// <summary>
    /// Main method for call FlySIP XML RPC API
    /// </summary>
    /// <param name="method"></param>
    /// <param name="parameters"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public async Task<T> CallAsync<T>(string method, object? parameters = null) where T : BaseResponse, new()
    {
        try
        {
            string finalApiEndpoint = string.Concat(BuildApiEndpoint(), $"&action={method}");
            if (parameters != null)
                finalApiEndpoint = string.Concat(finalApiEndpoint, $"&JSONString={Uri.EscapeDataString(JsonConvert.SerializeObject(parameters))}");

            HttpResponseMessage httpResponse = await _httpClient.GetAsync(new Uri(finalApiEndpoint));
            string content = await httpResponse.Content.ReadAsStringAsync();
            
            if (!httpResponse.IsSuccessStatusCode)
                throw new Exception("HTTP ERROR : " + content);
            
            return JsonConvert.DeserializeObject<T>(content, JsonSettings) ?? throw new Exception("JSON PARSING ERROR : " + content);
        }
        catch (Exception e)
        {
            return new T(){Result = e.Message};
        }
    }

    /// <summary>
    /// Building api endpoint using flysip options
    /// </summary>
    /// <returns></returns>
    private string BuildApiEndpoint() => $"{_options.ProviderUrl}/api.php?username={_options.Username}&apipassword={_options.Password}";
    
    /// <summary>
    /// Dispose http client
    /// </summary>
    void IDisposable.Dispose() =>  _httpClient.Dispose();
}