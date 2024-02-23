using Grokking_Algorithms.Algorithms;

// var summary = BenchmarkRunner.Run<TheEasiestBenchmark>(
//     ManualConfig
//         .Create(DefaultConfig.Instance)
//         .AddJob(Job.Default.WithIterationCount(10))
//         );

//int[] testArray = ArrayGenerator.GetRandomIntArray(1000);

// Console.WriteLine(Printer.GetArrayAsString(testArray));
// Console.WriteLine(SortingChapter3.SumRecursive(testArray));
// Console.WriteLine(SortingChapter3.CountRecursive(testArray));
// Console.WriteLine(SortingChapter3.GetMaxNumberRecursive(testArray));

#region Custom LinkedList testing

//Grokking_Algorithms.DataStructures.LinkedList<string> cll = new();
//cll.AddFirst("Hello1");
//cll.AddFirst("Magical1");
//cll.AddFirst("World1");

//cll.AddLast("Hello2");
//cll.AddLast("Magical2");
//cll.AddLast("World2");

//Console.WriteLine(cll.FindFirst("World2")?.Value);

//var testNodeForDeleting = cll.FindFirst("World2");
//Console.WriteLine(cll.RemoveNode(testNodeForDeleting));

//Console.WriteLine(cll.FindFirst("World2")?.Value);
//Console.WriteLine(cll.RemoveFirstNodeWithValue("Magical1"));
//Console.WriteLine(cll.RemoveFirstNodeWithValue("Magicals"));
//Console.WriteLine(cll.Count());

#endregion

#region HashTable with LinkedList testing

//var hashTable1 = new HashTable<string, string>();

//hashTable1.Add("one", "first");
//hashTable1.Add("two", "second");
//hashTable1.Add("three", "third");

//Console.WriteLine("Value for key 'one': " + hashTable1.GetValue("one"));
//Console.WriteLine("Value for key 'two': " + hashTable1.GetValue("two"));
//Console.WriteLine("Value for key 'four': " + hashTable1.GetValue("four")); // null

//var person1 = new Person { Name = "Alice", Age = 25 };
//var person2 = new Person { Name = "Bob", Age = 30 };

//var hashTable2 = new HashTable<Person, int>();
//hashTable2.Add(person1, 42);
//hashTable2.Add(person2, 30);

//Console.WriteLine("Value for person1: " + hashTable2.GetValue(person1));
//Console.WriteLine("Value for person2: " + hashTable2.GetValue(person2));

#endregion

#region LIFO and FIFO (Stack and Queue)

//CustomStack<string> customStack = new CustomStack<string>(3);
//customStack.Push("White");
//customStack.Push("Blue");
//customStack.Push("Red");

//Console.WriteLine(string.Join("\t", customStack.Items));

//Console.WriteLine("Custom Stack Count: " + customStack.Count);
//Console.WriteLine("Pop from Custom Stack: " + customStack.Pop());
//Console.WriteLine("Custom Stack Count after Pop: " + customStack.Count);

//customStack.Push("Новенький");

//Console.WriteLine(string.Join("\t", customStack.Items), "\n\n");

//CustomQueue<string> customQueue = new CustomQueue<string>(3);
//customQueue.Enqueue("A");
//customQueue.Enqueue("B");
//customQueue.Enqueue("C");

//Console.WriteLine(string.Join("\t", customQueue.Items));

//Console.WriteLine("Custom Queue Count: " + customQueue.Count);
//Console.WriteLine("Dequeue from Custom Queue: " + customQueue.Dequeue());
//Console.WriteLine("Dequeue from Custom Queue: " + customQueue.Dequeue());
//Console.WriteLine("Dequeue from Custom Queue: " + customQueue.Dequeue());
//Console.WriteLine("Custom Queue Count after Dequeue: " + customQueue.Count);

//Console.WriteLine(string.Join("\t", customQueue.Items));

//customQueue.Enqueue("Новенький1");
//customQueue.Enqueue("Новенький2");
//Console.WriteLine("Dequeue from Custom Queue: " + customQueue.Dequeue());
//customQueue.Enqueue("Новенький4");

//Console.WriteLine(string.Join("\t", customQueue.Items));

#endregion

#region MergeSort (Алгоритм устойчивой сортировки не хуже  O(n*log(n)) в среднем - Соритровка слиянием)

//int[] arr = { 12, 11, 13, 5, 11, 89, 89, 6, 7 };
//Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
//MergeSort.Sort(arr);
//Console.WriteLine("Sorted array: " + string.Join(", ", arr));

#endregion

#region QuickSort (Алгоритм неустойчивой сортировки не хуже  O(n*log(n)) в среднем - Быстрая сортировка)

//int[] arr = { 12, 11, 13, 5, 11, 89, 89, 6, 7 };
//Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
////QuickSort.Sort(arr);
////Console.WriteLine("Sorted array: " + string.Join(", ", arr));

//List<int> testList = OtherQuickSort.Sort(arr.ToList());
//Console.WriteLine("Sorted array: " + string.Join(", ", testList));

#endregion

#region BubbleSort (Пызрьковая сортировка)

//int[] arr = { 12, 11, 13, 5, 11, 89, 89, 6, 7 };
//Console.WriteLine("Unsorted array: " + string.Join(", ", arr));
//BubbleSort.Sort(arr);
//Console.WriteLine("Sorted array: " + string.Join(", ", arr));

#endregion

#region CustomBreadthFirstSearch

//var graph = BreadthFirstSearch.ArrangeSomeValues();
//var searchResult = BreadthFirstSearch.SearchMangoSeller(graph);

//Console.WriteLine($"Seller is found: {searchResult.Item1}");
//Console.WriteLine($"Searched persons: {string.Join(", ", searchResult.Item2)}");
//Console.WriteLine($"Mango seller: {searchResult.Item3}");

//Queue<string> searchQueue = new();

//foreach (string item in graph["you"])
//{
//    searchQueue.Enqueue(item);
//}

//List<string> searched = new();
//while (searchQueue.Count > 0)
//{
//    string person = searchQueue.Dequeue();
//    if (!searched.Contains(person))
//    {
//        if (BreadthFirstSearch.PersonIsSeller(person))
//        {
//            Console.WriteLine($"Person '{person}' is mango seller");
//        }
//        else
//        {
//            searched.Add(person);
//            foreach (string item in graph[person])
//            {
//                searchQueue.Enqueue(item);
//            }
//        }
//    }
//}

//Console.WriteLine($"Your friends have no mango sellers in facebook");

#endregion

#region DijkstraAlgorithm

//Dictionary<string, Dictionary<string, int>> graphDictionary = new();
//graphDictionary["start"] = new()
//{
//    { "a", 6 },
//    { "b", 2 }
//};
//graphDictionary["a"] = new()
//{
//    { "fin", 1 }
//};
//graphDictionary["b"] = new()
//{
//    { "a", 3 },
//    { "fin", 5 }
//};

//graphDictionary["fin"] = new();

//Dictionary<string, int> costs = new()
//{
//    {"a", 6},
//    {"b", 2},
//    {"fin", int.MaxValue}
//};
//Dictionary<string, string> parents = new()
//{
//    {"a", "start"},
//    {"b", "start"},
//    {"fin", "-"}
//};

//var dijkstra = new DijkstraAlgorithm(graphDictionary, costs, parents);
//dijkstra.RunDijkstra();

//Console.WriteLine($"Optimal route: {string.Join(',', dijkstra.OptimalRoute)}");

#endregion

#region GreedyAlgorithm

//HashSet<string> statesNeeded = new() { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
//var stations = new Dictionary<string, HashSet<string>>
//{
//    { "kone", new HashSet<string> { "id", "nv", "ut" } },
//    { "ktwo", new HashSet<string> { "wa", "id", "mt" } },
//    { "kthree", new HashSet<string> { "or", "nv", "ca" } },
//    { "kfour", new HashSet<string> { "nv", "ut" } },
//    { "kfive", new HashSet<string> { "ca", "az" } }
//};
//GreedyAlgorithm greedy = new(statesNeeded, stations);
//greedy.FindFinalData();

#endregion

#region StringSequenceCalculator

string expectedString = "fish";
string search1 = "hish";
string search2 = "fosh";
string search3 = "finn";

int stingSequence1 = StringSequenceCalculator.CalculateSequence(expectedString, search1);
int stingSequence2 = StringSequenceCalculator.CalculateSequence(expectedString, search2);
int stingSequence3 = StringSequenceCalculator.CalculateSequence(expectedString, search3);
Console.WriteLine(stingSequence1.ToString() + ", " + stingSequence2.ToString() + ", " + stingSequence3.ToString());

#endregion

Console.ReadKey();

#region AdditionalClasses
class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Age.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (!(obj is Person otherPerson))
            return false;

        return Name == otherPerson.Name && Age == otherPerson.Age;
    }
}

#endregion

