using Grokking_Algorithms.DataStructures;

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

Console.ReadKey();

#region Additional classes

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
