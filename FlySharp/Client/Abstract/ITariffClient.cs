using FlySharp.Http;
using FlySharp.Http.Tariff.Request;
using FlySharp.Http.Tariff.Response;

namespace FlySharp.Client.Abstract;

public interface ITariffClient : IBaseClient
{
    Task<GetTariffsResponse> GetTariffsAsync(GetTariffsRequest request);
    Task<CreateTariffResponse> CreateTariffAsync(CreateTariffRequest request);
    Task<BaseResponse> UpdateTariffAsync(UpdateTariffRequest request);
    Task<BaseResponse> DeleteTariffAsync(int tariffId);
    Task<GetTariffResponse> GetTariffAsync(int tariffId);
    Task<GetTariffRatesResponse> GetTariffRatesAsync(GetTariffRatesRequest request);
}