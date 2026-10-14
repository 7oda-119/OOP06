namespace C_OOP06;

internal abstract partial class Shipment
{
    public string TrackingStatus { get; set; }
    public string GetTrackingStatus()
    {
        return $"Shipment {TrackingCode} is {TrackingStatus}";
    }

    public void UpdateTrackingStatus(string newStatus)
    {
        TrackingStatus = newStatus;
    }
}
