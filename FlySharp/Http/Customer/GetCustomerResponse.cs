using FlySharp.Models;

namespace FlySharp.Http.Customer;

public class GetCustomerResponse : BaseResponse
{
    public Models.Customer? Customer { get; set; }
}