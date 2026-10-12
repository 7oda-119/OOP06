namespace C_OOP06;

internal static class DeliveryReport
{
    public static void PrintShipment(ITrackable shipment)
    {
        Console.WriteLine($"{shipment.GetTrackingStatus()}");
    }

    public static void PrintInsurance(IInsurable shipment)
    {
        Console.WriteLine($"{shipment.GetType().Name} Insurance  : {shipment.CalculateInsurance():F2} EGP");
    }

}
