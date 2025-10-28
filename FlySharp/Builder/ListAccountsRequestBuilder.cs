using FlySharp.Builder.Abstract;
using FlySharp.Http.Account.Request;

namespace FlySharp.Builder;

public class ListAccountsRequestBuilder : BaseListRequestBuilder<GetAccountsRequest, ListAccountsRequestBuilder>
{
    public ListAccountsRequestBuilder(){}

    public ListAccountsRequestBuilder WithCustomerId(int? customerId)
    {
        Request.ICustomer = customerId;
        return this;
    }

    public override GetAccountsRequest Build() => Request;
}