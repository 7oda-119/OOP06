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
        OnTrackingStatusChanged(newStatus);
    }

    partial void OnTrackingStatusChanged(string newStatus)
    {
        Console.WriteLine($"Tracking status changed to: {newStatus}");
    }
}
