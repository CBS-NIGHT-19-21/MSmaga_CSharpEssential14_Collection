using System.Collections;


// Implement interface IEnumerable to make sure that MyList is collection of enumerable items.
// Implement interface IEnumerator to make sure that MyList has collection enumerator.
internal class MyList<T> : IEnumerable<T>, IEnumerator
{
    // Init public field _array as array of Elements.
    public T[] _array = new T[0];

    // Declare property - number of elements of MyList
    public int Count { get { return _array.Length; } }

    // Declare  initial value of List enumerator.  
    int elemPosition = -1;

    // Declare MyList constructor. 
    public MyList()
    {

    }

    public object Current
    {
        get
        {
            return _array[elemPosition];
        }
    }
    public T this[int index]
    {
        get
        {
            return _array[index - 1];
        }
    }
    public void Add(T newEmelent)
    {
        Array.Resize<T>(ref _array, _array!.Length + 1);
        _array[^1] = newEmelent;
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

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this as IEnumerator;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_array).GetEnumerator();
    }
}