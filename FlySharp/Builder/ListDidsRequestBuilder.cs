using FlySharp.Http.Did.Request;

namespace FlySharp.Builder;

public class ListDidsRequestBuilder : Abstract.BaseListRequestBuilder<GetDidsListRequest, ListDidsRequestBuilder>
{
    public ListDidsRequestBuilder WithDid(string? did)
    {
        Request.Did = did;
        return this;
    }

    public ListDidsRequestBuilder WithIncomingDid(string? incomingDid)
    {
        Request.IncomingDid = incomingDid;
        return this;
    }

    public ListDidsRequestBuilder WithDelegatedTo(int? delegatedTo)
    {
        Request.DelegatedTo = delegatedTo;
        return this;
    }

    public ListDidsRequestBuilder WithAccount(string? accountId)
    {
        Request.IAccount = accountId;
        return this;
    }

    public ListDidsRequestBuilder WithIvrApplication(int? ivrApplicationId)
    {
        Request.IIvrApplication = ivrApplicationId;
        return this;
    }

    public ListDidsRequestBuilder NotAssignedOnly()
    {
        Request.NotAssigned = true;
        return this;
    }
}
