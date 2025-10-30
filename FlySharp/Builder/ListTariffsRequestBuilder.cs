using FlySharp.Builder.Abstract;
using FlySharp.Http.Tariff.Request;

namespace FlySharp.Builder;

public class ListTariffsRequestBuilder : BaseListRequestBuilder<GetTariffsRequest, ListTariffsRequestBuilder>
{
    public ListTariffsRequestBuilder(){}

    public ListTariffsRequestBuilder SetNamePattern(string? namePattern)
    {
        Request.NamePattern = namePattern;
        return this;
    }
}