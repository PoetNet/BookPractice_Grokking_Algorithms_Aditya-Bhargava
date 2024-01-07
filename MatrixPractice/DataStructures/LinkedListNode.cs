namespace Grokking_Algorithms.DataStructures;

public sealed class LinkedListNode<T>
{
    internal LinkedList<T>? list;
    internal LinkedListNode<T>? next;
    internal LinkedListNode<T>? prev = null;
    internal T item;

    public LinkedListNode(T value)
    {
        item = value;
    }

    public LinkedListNode(LinkedList<T> list, T value)
    {
        this.list = list;
        item = value;
    }

    public LinkedList<T>? List { get { return list; } }

    public LinkedListNode<T>? Next
    {
        get { return next == null || next == list!.head ? null : next; }
    }

    public LinkedListNode<T>? Previous
    {
        get { return prev == null || next == list!.head ? null : prev; }
    }

    public T Value
    {
        get { return item; }
        set { item = value; }
    }

    public ref T ValueRef => ref item;

    internal void Invalidate()
    {
        list = null;
        next = null;
        prev = null;
    }
}