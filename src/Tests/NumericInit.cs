using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DomBenchmarks.Tests;

public class NumericInit
{
    [Benchmark]
    public void DecimalInit()
    {
        decimal i = 0m;
    }

    [Benchmark]
    public void DecimalInitInt32()
    {
        decimal i = 0;
    }

    [Benchmark]
    public void LongInit()
    {
        long i = 0L;
    }

    [Benchmark]
    public void LongInitInt32()
    {
        long i = 0;
    }

    [Benchmark]
    public void FloatInit()
    {
        float i = 0f;
    }

    [Benchmark]
    public void FloatInitInt32()
    {
        float i = 0;
    }
}