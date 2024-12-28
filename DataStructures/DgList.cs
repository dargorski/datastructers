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
        Capacity = 0;
    }

    public void Add(T item)
    {
        if (_size == 0)
        {
            _items = new T[_initialCapacity];
            Capacity = _initialCapacity;
            _items[_size++] = item;
        }

        else if (_size == _items.Length)
        {
            EnsureCapacity(_size + 1);
            _items[_size++] = item;
        }
        else
        {
            _items[_size++] = item;
        }
    }

    public T At(int index)
    {
        if (index < 0 || index > _size - 1)
        {
            throw new IndexOutOfRangeException();
        }

        return _items[index];
    }

    public T Pop()
    {
        if (_size == 0)
        {
            throw new IndexOutOfRangeException();
        }

        var valueToReturn = _items[_size - 1];
        DeleteAt(_size - 1);

        return valueToReturn;
    }

    public T DeleteAt(int index)
    {
        if (index < 0 || index > _size - 1)
        {
            throw new IndexOutOfRangeException();
        }

        _size--;
        var itemToReturn = _items[index];
        if (index < _size)
        {
            Array.Copy(_items, index + 1, _items, index, _size - index);
        }

        _items[_size] = default;
        DecreaseCapacity();
        
        return itemToReturn;
    }

    public int Capacity
    {
        get => _items.Length;
        private set
        {
            if (value != _items.Length)
            {
                if (value > 0)
                {
                    var newItems = new T[value];
                    if (_size > 0)
                    {
                        Array.Copy(_items, 0, newItems, 0, _size);
                    }

                    _items = newItems;
                }
                else
                {
                    _items = _emptyArray;
                }
            }
        }
    }

    public int Length()
    {
        return _size;
    }

    public bool IsEmpty()
    {
        return _size == 0;
    }
    
    private void EnsureCapacity(int min)
    {
        if (_items.Length >= min) return;
        
        var newCapacity = _items.Length == 0 ? _initialCapacity : _items.Length * 2;
        if ((uint)newCapacity > Array.MaxLength) newCapacity = Array.MaxLength;
        if (newCapacity < min) newCapacity = min;
        Capacity = newCapacity;
    }

    private void DecreaseCapacity()
    {
        if (_size > _initialCapacity && _size <= Capacity / 4 )
        {
            Capacity /= 2;
        }
    }
}