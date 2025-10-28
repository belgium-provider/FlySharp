using FlySharp.Models;

namespace FlySharp.Http.Customer.Response;

public class GetCustomerResponse : BaseResponse
{
    public Models.Customer? Customer { get; set; }
}