namespace FlySharp.Http.Payments;

public class AddCustomerFundRequest : BaseAddFundRequest
{
    public int ICustomer { get; set; }
}