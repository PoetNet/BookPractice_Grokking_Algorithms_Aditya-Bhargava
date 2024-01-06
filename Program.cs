using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using Grokking_Algorithms.Exercises;
using Grokking_Algorithms.Helpers;

// var summary = BenchmarkRunner.Run<TheEasiestBenchmark>(
//     ManualConfig
//         .Create(DefaultConfig.Instance)
//         .AddJob(Job.Default.WithIterationCount(10))
//         );

int[] testArray = ArrayGenerator.GetRandomIntArray(1000);

Console.WriteLine(Printer.GetArrayAsString(testArray));
Console.WriteLine(SortingChapter3.SumRecursive(testArray));
Console.WriteLine(SortingChapter3.CountRecursive(testArray));
Console.WriteLine(SortingChapter3.GetMaxNumberRecursive(testArray));
Console.ReadKey();