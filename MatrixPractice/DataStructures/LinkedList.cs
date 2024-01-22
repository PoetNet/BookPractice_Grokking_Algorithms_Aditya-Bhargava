using System.Collections;
using System.Diagnostics;

namespace Grokking_Algorithms.DataStructures;

public class LinkedList<T> : IEnumerable<T>
{
    internal LinkedListNode<T>? head = null;

    public int Count()
    {
        if (head == null)
        {
            return 0;
        }

        int result = 1;
        LinkedListNode<T> current = head;

        while (current.next != null && current.next != head)
        {
            current = current.next;
            result++;
        }

        return result;
    }

    public void PrintAllNodesData()
    {
        if (head == null)
        {
            Console.WriteLine("Empty list");
            return;
        }

        LinkedListNode<T> current = head;
        Console.WriteLine(current.item);

        while (current.next != null && current.next != head)
        {
            Console.WriteLine(current.item);
            current = current.next;
        }
    }

    public LinkedListNode<T> AddFirst(T value)
    {
        LinkedListNode<T> result = new LinkedListNode<T>(this, value);
        if (head == null)
        {
            InternalInsertNodeToEmptyList(result);
        }
        else
        {
            InternalInsertNodeBefore(head, result);
            head = result;
        }
        return result;
    }

    public LinkedListNode<T> AddLast(T value)
    {
        LinkedListNode<T> result = new LinkedListNode<T>(this, value);
        if (head == null)
        {
            InternalInsertNodeToEmptyList(result);
        }
        else
        {
            InternalInsertNodeBefore(head, result);
        }
        return result;
    }

    public LinkedListNode<T>? FindFirst(T value)
    {
        LinkedListNode<T>? node = head;
        EqualityComparer<T> comparer = EqualityComparer<T>.Default;
        if (node != null)
        {
            if (value != null)
            {
                do
                {
                    if (comparer.Equals(node!.item, value))
                    {
                        return node;
                    }
                    node = node.next;
                } while (node != head);
            }
            else
            {
                do
                {
                    if (node!.item == null)
                    {
                        return node;
                    }
                    node = node.next;
                } while (node != head);
            }
        }
        return null;
    }

    public bool RemoveFirstNodeWithValue(T value)
    {
        LinkedListNode<T>? node = FindFirst(value);
        if (node == null)
        {
            return false;
        }

        InternalRemoveNode(node);
        return true;
    }
    public bool RemoveNode(LinkedListNode<T>? node)
    {
        if (node == null)
        {
            return false;
        }

        InternalRemoveNode(node);
        return true;
    }

    internal void InternalInsertNodeToEmptyList(LinkedListNode<T> newNode)
    {
        newNode.next = newNode;
        newNode.prev = newNode;
        head = newNode;
    }

    internal void InternalInsertNodeBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
    {
        newNode.next = node;
        newNode.prev = node.prev;
        node.prev!.next = newNode;
        node.prev = newNode;
    }

    internal void InternalRemoveNode(LinkedListNode<T> node)
    {
        Debug.Assert(node.list == this, "Deleting the node from another list!");
        Debug.Assert(head != null, "This method shouldn't be called on empty list!");

        if (node.next == node)
        {
            Debug.Assert(head == node, "this should only be true for a list with only one node");
            head = null;
        }
        else
        {
            node.next!.prev = node.prev;
            node.prev!.next = node.next;
            if (head == node)
            {
                head = node.next;
            }
        }
        node.Invalidate();
    }

    public IEnumerator<T> GetEnumerator()
    {
        if (head == null)
        {
            yield break;
        }

        LinkedListNode<T> current = head;

        do
        {
            yield return current.item;
            current = current.next;
        } while (current != head);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
