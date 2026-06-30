using FlySharp.Http.Trunk.Request;

namespace FlySharp.Builder;

public class ListTrunkConnectionsRequestBuilder(int trunkId)
{
    private readonly GetTrunkConnectionsListRequest _request = new() { ITrunk = trunkId };

    public ListTrunkConnectionsRequestBuilder WithNamePattern(string? namePattern)
    {
        _request.NamePattern = namePattern;
        return this;
    }

    public GetTrunkConnectionsListRequest Build() => _request;
}
