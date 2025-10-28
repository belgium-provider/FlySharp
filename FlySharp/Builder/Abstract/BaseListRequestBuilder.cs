using FlySharp.Http;

namespace FlySharp.Builder.Abstract;

public class BaseListRequestBuilder<TRequest, TBuilder> where TRequest : BaseListRequestObject, new() where TBuilder : BaseListRequestBuilder<TRequest, TBuilder>
{
    protected readonly TRequest Request = new();

    public TBuilder SetOffset(int offset)
    {
        Request.Offset = offset;
        return (TBuilder)this;
    }

    public TBuilder SetLimit(int limit)
    {
        Request.Limit = limit;
        return (TBuilder)this;
    }

    public virtual TRequest Build() => Request;
}