using FlySharp.Models;

namespace FlySharp.Http;

public class GetCustomerResponse : BaseResponse
{
    public Customer? Customer { get; set; }
}