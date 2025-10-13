namespace FlySharp.Http.Customer;

public class AddCustomerRequest : BaseResponse
{
    //required
    public int IWholesaler { get; set; } //local admin (superadmin)
    public required string Name { get; set; }
    public required string WebPassword { get; set; }
    public int ITariff { get; set; } //tariff plan
    
    //other => based on request
}