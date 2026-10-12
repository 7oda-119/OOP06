namespace C_OOP06;

internal class DeliveryAddress
{
    public string city;
    public string street;
    public int buildingNumber;

    public DeliveryAddress()
    {

    }
    public DeliveryAddress(string city, string street, int buildingNumber)
    {
        this.city = city;
        this.street = street;
        this.buildingNumber = buildingNumber;
    }

    public string GetFullAddress()
    {
        return $"{buildingNumber} {street}, {city}";
    }

}
