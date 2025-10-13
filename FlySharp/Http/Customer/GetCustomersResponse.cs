using FlySharp.Models;

namespace FlySharp.Http;

public class GetCustomersResponse : BaseResponse
{
    public List<Customer> Customers { get; set; } = [];
}