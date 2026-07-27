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
    /// Creating a new tariff
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<CreateTariffResponse> CreateTariffAsync(CreateTariffRequest request) => await this.CallAsync<CreateTariffResponse>("createTariff", request);

    /// <summary>
    /// Updating an existing tariff
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<BaseResponse> UpdateTariffAsync(UpdateTariffRequest request) => await this.CallAsync<BaseResponse>("updateTariff", request);

    /// <summary>
    /// Getting the list of rates available within a tariff
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<GetTariffRatesResponse> GetTariffRatesAsync(GetTariffRatesRequest request) => await this.CallAsync<GetTariffRatesResponse>("getTariffRatesList", request);

    /// <summary>
    /// Delete a single constant
    /// </summary>
    /// <param name="tariffId"></param>
    /// <returns></returns>
    public async Task<BaseResponse> DeleteTariffAsync(int tariffId) => await this.CallAsync<BaseResponse>("deleteTariff", new { i_tariff = tariffId });

    /// <summary>
    /// Getting a single tariff
    /// </summary>
    /// <param name="tariffId"></param>
    /// <returns></returns>
    public async Task<GetTariffResponse> GetTariffAsync(int tariffId) => await this.CallAsync<GetTariffResponse>("getTariffInfo", new { i_tariff = tariffId });
}