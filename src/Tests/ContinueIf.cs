using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DomBenchmarks.Tests;

//
// The goal of this benchmark is to see a time comparison between if not vs if continue
//

public class ContinueIf
{
    private int _loopCount = 100_000;

    [Benchmark]
    public void IfNotAdd()
    {
        List<int> list = [];
        for (int i = 0; i < _loopCount; ++i)
        {
            if (i % 2 == 0)
                list.Add(i);
        }
    }

    [Benchmark]
    public void IfContinue()
    {
        List<int> list = [];
        for (int i = 0; i < _loopCount; ++i)
        {
            if (i % 2 != 0)
                continue;
            list.Add(i);
        }
    }
}