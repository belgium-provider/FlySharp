namespace FlySharp.Http.Payments;

public class BaseAddFundRequest
{
    public double Amount { get; set; }
    public required string Currency { get; set; }
    public required string PaymentNotes { get; set; }
}