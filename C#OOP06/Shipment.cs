namespace C_OOP06;

internal abstract partial class Shipment : ITrackable
{
    string trackingCode;
    string description;
    decimal weight;
    decimal deliveryFee;
    private static int totalShipmentsCreated;
    public static int TotalShipmentsCreated 
    {
        get
        {
            return totalShipmentsCreated;
        }
        private set
        {
            totalShipmentsCreated = value;
        }
    } 

    #region Constructors
    //The first constructor receives only trackingCode.
    //• The first constructor uses default values: Description = "Unknown", Weight = 1, DeliveryFee = 50, and a default destination.
    //• The second constructor receives trackingCode, description, weight, deliveryFee, and destination.
    //• Each constructor must initialize the object with valid data.
    public Shipment(string trackingCode)
    {
        if (string.IsNullOrWhiteSpace(trackingCode))
            throw new ArgumentNullException(nameof(trackingCode), "TrackingCode cannot be null or empty");

        this.trackingCode = trackingCode;
        description = "Unknown";
        weight = 1;
        deliveryFee = 50;
        Destination = new DeliveryAddress("New York", "5th Avenue", 100);

        TotalShipmentsCreated++;
    }

    public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : this (trackingCode)
    {

        if (string.IsNullOrWhiteSpace(description))
            throw new ArgumentNullException(nameof(description), "Description cannot be null or empty");
        if (weight < 0)
            throw new ArgumentOutOfRangeException(nameof(weight), "Weight must be greater than 0");
        if (deliveryFee < 0)
            throw new ArgumentOutOfRangeException(nameof(deliveryFee), "DeliveryFee must be greater than 0");

        this.trackingCode = trackingCode;
        this.description = description;
        this.weight = weight;
        this.deliveryFee = deliveryFee;
        Destination = destination;

        TotalShipmentsCreated++;
    }

    static Shipment()
    {
        TotalShipmentsCreated = 0;
        Console.WriteLine("Shipment System initialized.");
    }
    #endregion


    #region Properities
    // Automatic Read-Write Properity
    public DeliveryAddress Destination { get; set; }

    // Read only properity
    public string TrackingCode
    {
        get => trackingCode;
    }

    // Read-Write Properity
    public string Description
    {
        get => description;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                description = value;
        }
    }

    // Read-Write Properity
    public decimal Weight
    {
        get => weight;
        set
        {
            if (value > 0)
                weight = value;
        }
    }

    // Read-private set properity  ==> can be accesed only in the same class
    public decimal DeliveryFee
    {
        get => deliveryFee;
        private set
        {
            if (value > 0)
                deliveryFee = value;
        }
    }

    // Calculated Properity
    public abstract decimal EstimatedCost { get; }

    #endregion

    #region Question04
    //3. Add the following methods to Shipment:
    //• UpdateDeliveryFee(decimal newFee) : updates the fee only when newFee is greater than 0.
    //• PrintShipment() : prints all shipment information, including the estimated cost.

    public void UpdateDeliveryFee(decimal newFee)
    {
        if (newFee > 0)
            DeliveryFee = newFee;
    }

    public abstract void PrintShipment();
    #endregion

    #region UpdateWeight
    public void UpdateWeight(decimal weight)
    {
        Weight = weight;
    }
    public void UpdateWeight(decimal weight, decimal packingWeigh)
    {
        Weight = weight + packingWeigh;
    }
    #endregion

    #region Object Copying
    public abstract Shipment CopyShipment();
    #endregion

    #region Shallow Copy
    public Shipment ShallowCopy()
    {
        return (Shipment)this.MemberwiseClone();
    }
    #endregion

    #region Deep Copy
    public Shipment DeepCopy()
    {
        Shipment copy = ShallowCopy();
        copy.Destination = Destination is null ? new DeliveryAddress() : new DeliveryAddress(Destination.city, Destination.street, Destination.buildingNumber);
        return copy;
    }
    #endregion

    #region Static method
    static int GetTotalShipmentsCreated()
    {
        return TotalShipmentsCreated;
    }
    #endregion
}
