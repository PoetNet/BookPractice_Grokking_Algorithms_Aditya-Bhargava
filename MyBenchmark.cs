using BenchmarkDotNet.Attributes;
using System.Text;

public class TheEasiestBenchmark
{
    [Benchmark(Description = "With BinarySearch")]
    public int TestWithBinarySearch()
    {
        return new int();
    }
}
