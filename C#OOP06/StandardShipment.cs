namespace C_OOP06;

internal class StandardShipment : Shipment, IInsurable
{
    public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment
    {
        TrackingStatus = "Ready";
    }

    public override decimal EstimatedCost => (DeliveryFee + (Weight * 5));

    public override void PrintShipment()
    {
        Console.WriteLine("=== Standard Shipment Details ===");
        Console.WriteLine($"TracingCode: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"DeliveryFee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"EstimatedCost: {EstimatedCost}");
    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.05m;
    }

    #region Object Copying
    public override Shipment CopyShipment()
    {
        return new StandardShipment(TrackingCode, Description, Weight, DeliveryFee, Destination);  // Destination not => new Address(city, street, number) beacause Address is still struct and it is copied by value.
    }
    #endregion
}
