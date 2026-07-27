using FlySharp.Builder.Abstract;
using FlySharp.Http.Tariff.Request;

namespace FlySharp.Builder;

public class ListTariffRatesRequestBuilder : BaseListRequestBuilder<GetTariffRatesRequest, ListTariffRatesRequestBuilder>
{
    public ListTariffRatesRequestBuilder(int iTariff)
    {
        Request.ITariff = iTariff;
    }
}
