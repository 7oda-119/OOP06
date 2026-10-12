namespace C_OOP06;

internal class InternationalShipment : Shipment, ITrackable, IInsurable
{
    string destinationCountry;
    decimal customsFee;
    public string DestinationCountry
    {
        get => destinationCountry;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                destinationCountry = value;
        }
    }
    public decimal CustomsFee
    {
        get => customsFee;
        set
        {
            if (value >= 0)
                customsFee = value;
        }
    }

    public override decimal EstimatedCost => (DeliveryFee + (Weight * 5) + CustomsFee);
    public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)  //Added from previous Assignment
    {
        DestinationCountry = destinationCountry;
        CustomsFee = customsFee;
    }

    public override void PrintShipment()
    {
        Console.WriteLine("=== International Shipment Details ===");
        Console.WriteLine($"TracingCode: {TrackingCode}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Weight: {Weight}");
        Console.WriteLine($"DeliveryFee: {DeliveryFee}");
        Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        Console.WriteLine($"EstimatedCost: {EstimatedCost}");
        Console.WriteLine($"DestinationCountry: {DestinationCountry}");
        Console.WriteLine($"CustomsFee: {CustomsFee}");
    }

    public string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} has been Delivered";
    }

    public virtual void GenerateCustomsReport()
    {

    }

    public decimal CalculateInsurance()
    {
        return EstimatedCost * 0.12m;
    }

    public override Shipment CopyShipment()
    {
        return new InternationalShipment(TrackingCode, Description, Weight, DeliveryFee, Destination, DestinationCountry, CustomsFee);
    }
}

