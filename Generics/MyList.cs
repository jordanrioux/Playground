using System.Collections;

namespace Generics;

public class MyList<T>
{
    // easy fix
    private const int DefaultCapacity = 8;
    
    private int _count;
    private T[] _array;
    private T[] _HELLOTHERE;
    private T[] _KENOBI;

    public int Count => _count;
    
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
        if (_count >= Capacity)
        {
            Capacity *= 2;
            Array.Resize(ref _array, Capacity);
        }
        _array[_count] = value;
        _count++;
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