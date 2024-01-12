namespace Grokking_Algorithms.MatrixPractice.DataStructures;

public class CustomStack<T>
{
    public T[] Items;
    private int _top;

    private const int DefaultCapacity = 4;
    
    public int Count => _top + 1;
    public CustomStack(int capacity)
    {
        Items = new T[capacity];
        _top = -1;
    }

    public CustomStack()
    {
        Items = new T[DefaultCapacity];
        _top = -1;
    }

    public void Push(T item)
    {
        if (_top == Items.Length)
        {
            throw new InvalidOperationException("The stack is full");
        }

        Items[++_top] = item;
    }

    public T Pop()
    {
        if (_top == -1)
        {
            throw new InvalidOperationException("The stack is empty");
        }

        T item = Items[_top];

        _top--;
        return item;
    }
}
