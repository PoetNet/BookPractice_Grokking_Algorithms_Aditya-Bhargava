namespace Grokking_Algorithms.MatrixPractice.DataStructures;
public class CustomQueue<T>
{
    public T[] Items;
    private int _front;
    private int _rear;

    public int Count => _rear - _front + 1;
    public CustomQueue(int capacity)
    {
        Items = new T[capacity];
        _front = 0;
        _rear = -1;
    }

    public void Enqueue(T item)
    {
        if (_rear == Items.Length - 1)
        {
            throw new InvalidOperationException("The queue is full");
        }

        Items[++_rear] = item;
    }


    public T Dequeue()
    {
        if (_front > _rear)
        {
            throw new InvalidOperationException("The queue is empty");
        }

        T item = Items[_front];
        _front++;

        if (_front > _rear)
        {
            _front = 0;
            _rear = -1;
        }
        return item;
    }

}

