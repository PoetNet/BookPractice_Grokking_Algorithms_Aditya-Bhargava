using System.Collections;

namespace Grokking_Algorithms.Algorithms;

public class BreadthFirstSearch
{
    public static (bool, List<string>, string) SearchMangoSeller(Dictionary<string, List<string>> graph)
    {
        Queue<string> searchQueue = new();

        foreach (string item in graph["you"])
        {
            searchQueue.Enqueue(item);
        }

        List<string> searched = new();
        while (searchQueue.Count > 0)
        {
            string person = searchQueue.Dequeue();
            if (!searched.Contains(person))
            {
                if (PersonIsSeller(person))
                {
                    return (true, searched, person);
                }
                else
                {
                    searched.Add(person);
                    foreach (string item in graph[person])
                    {
                        searchQueue.Enqueue(item);
                    }
                }
            }
        }
        return (false, searched, "Nobody");
    }

    public static Dictionary<string, List<string>> ArrangeSomeValues()
    {
        Dictionary<string, List<string>> graph = new ();

        graph["you"] = new () { "alice", "bob", "claire" };
        graph["bob"] = new() { "anuj", "peggy" };
        graph["alice"] = new(){ "peggy" };
        graph["claire"] = new() { "thom", "jonny" };

        graph["anuj"] = new();
        graph["peggy"] = new();
        graph["thom"] = new();
        graph["jonny"] = new();

        return graph;
    }

    public static bool PersonIsSeller(string person)
    {
        if (person.EndsWith('m'))
        {
            return true;
        }

        return false;
    }
}

