namespace C_OOP06;

internal class Container <T>
{
    private T item;

    public void AddItem(T newItem)
    {
        item = newItem;
    }

    public T GetItem()
    {
        return item;
    }

}
