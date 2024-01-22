namespace Grokking_Algorithms.DataStructures;

public class HashTable<TKey, TValue>
{
    private const int _capacity = 1000;
    private readonly LinkedList<KeyValuePair<TKey, TValue>>[] _table;

    public HashTable()
    {
        _table = new LinkedList<KeyValuePair<TKey, TValue>>[_capacity];
    }

    private int HashFunction(TKey key)
    {
        if (key == null)
        {
            return "null".GetHashCode() % _capacity;
        }
        return Math.Abs(key.GetHashCode()) % _capacity;
    }

    public void Add(TKey key, TValue value)
    {
        int index = HashFunction(key);

        if (_table[index] == null)
        {
            _table[index] = new LinkedList<KeyValuePair<TKey, TValue>>();
        }

        _table[index].AddLast(new KeyValuePair<TKey, TValue>(key, value));
    }

    public TValue? GetValue(TKey key)
    {
        int index = HashFunction(key);

        if (_table[index] != null)
        {
            foreach (var pair in _table[index])
            {
                if (pair.Key.Equals(key))
                    return pair.Value;
            }
        }
        return default(TValue?);
    }
}
