using FlySharp.Models;

namespace FlySharp.Http.Customer.Response;

public class GetCustomersResponse : BaseResponse
{
    public List<Models.Customer> Customers { get; set; } = [];
}