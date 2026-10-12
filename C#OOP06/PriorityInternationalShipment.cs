namespace C_OOP06;

internal class PriorityInternationalShipment : InternationalShipment
{
    public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
    {
    }

    #region Sealed Method
    public sealed override void GenerateCustomsReport()
    {
        Console.WriteLine("=== Priority International Shipment Customs Report ===");
        Console.WriteLine($"Tracking Code: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight} kg");
        Console.WriteLine($"Delivery Fee: {DeliveryFee:C}");
        Console.WriteLine($"Destination Address: {Destination}");
        Console.WriteLine($"Destination Country: {DestinationCountry}");
        Console.WriteLine($"Customs Fee: {CustomsFee:C}");
        Console.WriteLine($"Estimated Cost: {EstimatedCost:C}");
    }
    #endregion
}

