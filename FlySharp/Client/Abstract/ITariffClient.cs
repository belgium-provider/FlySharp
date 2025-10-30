using FlySharp.Http;
using FlySharp.Http.Tariff.Request;
using FlySharp.Http.Tariff.Response;

namespace FlySharp.Client.Abstract;

public interface ITariffClient
{
    Task<GetTariffsResponse> GetTariffsAsync(GetTariffsRequest request);
    Task<BaseResponse> DeleteTariffAsync(int tariffId);
    Task<GetTariffResponse> GetTariffAsync(int tariffId);
}