namespace DataStructures;

public class DgList<T>
{
    private T[] _items;
    private const int _initialCapacity = 4;
    private int _size;

    private static readonly T[] _emptyArray = [];

    public DgList()
    {
        _items = _emptyArray;
    }
    
    

    public int Capacity()
    {
        return _size;
    }
    

    public int Length()
    {
        return _items.Length;
    }

    public bool IsEmpty()
    {
        return Length() == 0;
    }
}