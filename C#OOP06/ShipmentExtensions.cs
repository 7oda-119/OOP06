namespace C_OOP06;

internal static class ShipmentExtensions
{
    public static string GetSummary(this Shipment shipment)
    {
        string trackingStatus = shipment is ITrackable trackableShipment ? trackableShipment.GetTrackingStatus() : "UnKnown";
        string shipmentType = shipment.GetType().Name.Replace("Shipment", "");
        return $"{shipment.TrackingCode} | {shipmentType} | {shipment.Weight} | {trackingStatus}";
    }

    public static bool IsDelivered(this Shipment shipment)
    {
        if (shipment is not ITrackable trackableShipment)
            return false;
        return trackableShipment.GetTrackingStatus().Contains("Delivered");
    }
    
}
