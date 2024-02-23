namespace Grokking_Algorithms.Algorithms;
public class GreedyAlgorithm
{
    private HashSet<string> _itemsNeeded;
    private Dictionary<string, HashSet<string>> _data;
    private HashSet<string> _finalData = new();

    public GreedyAlgorithm(
        HashSet<string> itemsNeeded,
        Dictionary<string, HashSet<string>> data)
    {
        _itemsNeeded = itemsNeeded;
        _data = data;
    }

    public void FindFinalData()
    {
        while (_itemsNeeded.Count > 0)
        {
            string? bestDataItem = null;
            HashSet<string> itemsCovered = new();

            foreach (var dataItem in _data.Keys)
            {
                HashSet<string> items = _data[dataItem];
                HashSet<string> covered = _itemsNeeded.Intersect(items).ToHashSet();

                if (covered.Count > itemsCovered.Count)
                {
                    bestDataItem = dataItem;
                    itemsCovered = covered;
                }
            }

            _itemsNeeded.ExceptWith(itemsCovered);
            _finalData.Add(bestDataItem);
        }

        PrintFinalStations();
    }

    private void PrintFinalStations()
    {
        Console.WriteLine($"Final stations: {string.Join(", ", _finalData)}");
    }
}
