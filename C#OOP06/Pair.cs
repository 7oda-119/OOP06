namespace C_OOP06;

internal class Pair <TKey, TValue>
{
    public TKey Key { get; set; }
    public TValue Value { get; set; }

    public Pair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Key = {Key}, Value = {Value}");
    }

}
