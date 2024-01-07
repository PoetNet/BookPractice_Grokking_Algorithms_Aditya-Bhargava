using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Grokking_Algorithms.Exercises;
using Grokking_Algorithms.Helpers;
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

Grokking_Algorithms.DataStructures.LinkedList<string> cll = new();
cll.AddFirst("Hello1");
cll.AddFirst("Magical1");
cll.AddFirst("World1");

cll.AddLast("Hello2");
cll.AddLast("Magical2");
cll.AddLast("World2");

//cll.PrintAllNodesData();
Console.WriteLine(cll.FindFirst("World2")?.Value);

var testNodeForDeleting = cll.FindFirst("World2");
Console.WriteLine(cll.RemoveNode(testNodeForDeleting));

Console.WriteLine(cll.FindFirst("World2")?.Value);
Console.WriteLine(cll.RemoveFirstNodeWithValue("Magical1"));
Console.WriteLine(cll.RemoveFirstNodeWithValue("Magicals"));
Console.WriteLine(cll.Count());
Console.ReadKey();