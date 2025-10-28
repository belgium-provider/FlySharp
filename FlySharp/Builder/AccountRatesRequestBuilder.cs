using FlySharp.Builder.Abstract;
using FlySharp.Http.Account.Request;

namespace FlySharp.Builder;

public class AccountRatesRequestBuilder : BaseListRequestBuilder<GetAccountRatesRequest, AccountRatesRequestBuilder>
{
    public AccountRatesRequestBuilder(int accountId)
    {
        Request.IAccount = accountId;
    }

    public AccountRatesRequestBuilder WithAccountId(int accountId)
    {
        Request.IAccount = accountId;
        return this;
    }

    public AccountRatesRequestBuilder WithPrefix(string? prefix)
    {
        Request.Prefix = prefix;
        return this;
    }

    public override GetAccountRatesRequest Build() => Request;
}