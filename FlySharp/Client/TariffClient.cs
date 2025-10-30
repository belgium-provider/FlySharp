using FlySharp.Client.Abstract;
using FlySharp.Http;
using FlySharp.Http.Tariff.Request;
using FlySharp.Http.Tariff.Response;

namespace FlySharp.Client;

public class TariffClient(FlySipOptions options, HttpClient? httpClient = null) : BaseClient(options, httpClient), ITariffClient
{
    /// <summary>
    /// Getting tariffs response
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<GetTariffsResponse> GetTariffsAsync(GetTariffsRequest request) => await this.CallAsync<GetTariffsResponse>("getTariffsList", request);
    
    /// <summary>
    /// Delete a single constant
    /// </summary>
    /// <param name="tariffId"></param>
    /// <returns></returns>
    public async Task<BaseResponse> DeleteTariffAsync(int tariffId) => await this.CallAsync<BaseResponse>("deleteTariff", tariffId);

    /// <summary>
    /// Getting a single tariff
    /// </summary>
    /// <param name="tariffId"></param>
    /// <returns></returns>
    public async Task<GetTariffResponse> GetTariffAsync(int tariffId) => await this.CallAsync<GetTariffResponse>("getTariffInfo",  tariffId);
}