using BenchmarkDotNet.Attributes;

public class TheEasiestBenchmark
{
    [Benchmark(Description = "With BinarySearch")]
    public int TestWithBinarySearch()
    {
        return new int();
    }
}
