using System.Collections;


// Implement interface IEnumerable to make sure that MyList is collection of enumerable items.
// Implement interface IEnumerator to make sure that MyList has collection enumerator.
class MyDictionary <TKey, TValue> : IEnumerable, IEnumerator
{
    // Init public field _array as array of Elements.
    public (TKey, TValue)[] _array = new (TKey, TValue)[0];

    // Declare property - number of elements of MyList
    public int Count { get { return _array.Length; } }

    // Declare  initial value of List enumerator.  
    int elemPosition = -1;

    public object Current
    {
        get
        {
            return _array[elemPosition];
        }
    }
    public (TKey,TValue) this[int index]
    {
        get
        {
            return _array[index - 1];
        }
    }
    public void Add(TKey newKey, TValue newValue)
    {
        Array.Resize(ref _array, _array!.Length + 1);
        _array[^1] = ( newKey,  newValue);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this as IEnumerator;
    }

    // Implement method Reset() of interface IEnumerator.
    public bool MoveNext()
    {
        if (elemPosition < _array!.Length - 1)
        {
            elemPosition++;
            return true;
        }
        else
        {
            Reset();
            return false;
        }
    }

    // Implement method Reset() of interface IEnumerator.
    public void Reset()
    {
        elemPosition = -1;
    }
}