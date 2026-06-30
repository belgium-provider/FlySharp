using FlySharp.Http.Trunk.Request;

namespace FlySharp.Builder;

public class ListTrunksRequestBuilder(int accountId)
{
    private readonly GetTrunksListRequest _request = new() { IAccount = accountId };

    public ListTrunksRequestBuilder WithNamePattern(string? namePattern)
    {
        _request.NamePattern = namePattern;
        return this;
    }

    public GetTrunksListRequest Build() => _request;
}
