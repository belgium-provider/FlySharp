using FlySharp.Models;

namespace FlySharp.Http.Customer;

public class GetCustomersResponse : BaseResponse
{
    public List<Models.Customer> Customers { get; set; } = [];
}