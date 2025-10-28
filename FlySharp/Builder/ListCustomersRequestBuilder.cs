using FlySharp.Builder.Abstract;
using FlySharp.Http.Customer.Request;

namespace FlySharp.Builder;

public class ListCustomersRequestBuilder : BaseListRequestBuilder<GetCustomersRequest, ListCustomersRequestBuilder>
{
    public ListCustomersRequestBuilder(int wholeSaler)
    {
        Request.WholeSaler = wholeSaler;
    }

    public override GetCustomersRequest Build() => Request;
}