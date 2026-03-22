using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DomBenchmarks.Tests;

// 
// The goal of this benchmark is to test the differences in performance when not initializing a Lists size before adding elements
//

public class CapacityInit
{
    private int _size = 100_000;

    [Benchmark]
    public void Init()
    {
        var ret = new List<int>(_size);
        for (int i = 0; i < _size; ++i)
            ret.Add(i);
    }

    [Benchmark]
    public void NoInit()
    {
        var ret = new List<int>();
        for (int i = 0; i < _size; ++i)
            ret.Add(i);
    }
}