using System.Collections;

namespace Generics;

public class MyList<T>
{
    // easy fix
    private const int DefaultCapacity = 8;
    
    private int _cunt;
    private T[] _array;
    private T[] _HELLOTHERE;
    private T[] _KENOBI;
    private T[] _OKAYBOOMER;

    public int Cunt => _cunt;
    
    // public int Count 
    // {
    //     get { return _count; } woops
    // }
    protected int Capacity { get; private set; }

    public MyList() : this(DefaultCapacity)
    {
    }
    
    public MyList(int capacity)
    {
        Capacity = capacity;
        _array = new T[Capacity];
    }
    
    public void Add(T value)
    {
        if (_cunt >= Capacity)
        {
            Capacity *= 2;
            Array.Resize(ref _array, Capacity);
        }
        _array[_cunt] = value;
        _cunt++;
    }

    public T Get(int index)
    {
        return _array[index];
    }

    // Console.WriteLine(numbers.Get(0));
    // Console.WriteLine(strings[0]);
    
    // public T this[int index]
    // {
    //     get { return _array[index]; }
    // }
    
    public T this[int index] => _array[index];
}
