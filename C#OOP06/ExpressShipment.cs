namespace C_OOP06;

internal class ExpressShipment : Shipment, IInsurable
{
    decimal extraFee;
    public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal extraFee) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment 
    {
        ExtraFee = extraFee;
        TrackingStatus = "Out for Delivery";
    }

    public decimal ExtraFee
    {
        get => extraFee;
        set
        {
            if (value >= 0)
                extraFee = value;
        }
    }

    public override decimal EstimatedCost => (DeliveryFee + (Weight * 5) + ExtraFee);

    public override void PrintShipment()
    {
        Console.WriteLine("=== Express Shipment Details ===");
        Console.WriteLine($"TracingCode: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"DeliveryFee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"EstimatedCost: {EstimatedCost}");
        Console.WriteLine($"ExtraFee: {ExtraFee}");
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.08m;
    }

    #region Object Copying
    public override Shipment CopyShipment()
    {
        return new ExpressShipment(TrackingCode, Description, Weight, DeliveryFee, Destination, ExtraFee);
    }
    #endregion
}
