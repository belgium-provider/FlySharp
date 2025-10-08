namespace FlySharp.Models.Http;

public class FlySipHttpResponse<T>
{
    public required string Result { get; set; }
    public T? Data { get; set; }
}