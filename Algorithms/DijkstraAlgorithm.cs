namespace Grokking_Algorithms.Algorithms;
public class DijkstraAlgorithm
{
    private Dictionary<string, Dictionary<string, int>> _graph;

    private Dictionary<string, int> _costs;

    private Dictionary<string, string> _parents;
    private HashSet<string> _processed = new();
    private List<string> _optimalRoute = new();

    public DijkstraAlgorithm(
        Dictionary<string, Dictionary<string, int>> graph,
        Dictionary<string, int> costs,
        Dictionary<string, string> parents)
    {
        _graph = graph;
        _costs = costs;
        _parents = parents;
    }

    public List<string> OptimalRoute  => _optimalRoute;

    public void RunDijkstra()
    {
        var node = FindLowestCostNode(_costs);

        while (node != null)
        {
            if (_costs.TryGetValue(node, out var cost))
            {
                var neighbors = _graph[node];
                foreach (var n in neighbors.Keys)
                {
                    var newCost = cost + neighbors[n];

                    if (_costs[n] > newCost)
                    {
                        _costs[n] = newCost;
                        _parents[n] = node;
                    }
                }
            }

            _processed.Add(node);
            node = FindLowestCostNode(_costs);

            if (node == string.Empty)
            {
                break;
            }
        }

        PopulateOptimalRoute();
    }

    private void PopulateOptimalRoute()
    {
        var destination = "fin";
        _optimalRoute.Clear();

        while (destination != "start")
        {
            _optimalRoute.Insert(0, destination);
            destination = _parents[destination];
        }

        _optimalRoute.Insert(0,"start");
    }

    private string FindLowestCostNode(Dictionary<string, int> costs)
    {
        int lowestCost = int.MaxValue;
        string lowestCostNode = string.Empty;

        foreach (var node in costs.Keys)
        {
            var cost = costs[node];
            if (cost < lowestCost && !_processed.Contains(node))
            {
                lowestCost = cost;
                lowestCostNode = node;
            }
        }

        return lowestCostNode;
    }
}
