using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace DomBenchmarks.Tests;

public class StringBuilding
{
    private int _loopCount = 100_000;
    private string _insert = "foobar";

    [Benchmark]
    public void Addition()
    {
        string s = string.Empty;
        for (int i = 0; i < _loopCount; ++i)
            s = "Previous text " + _insert + " Post text";
    }

    [Benchmark]
    public void TemplateLiterals()
    {
        string s = string.Empty;
        for (int i = 0; i < _loopCount; ++i)
            s = $"Previous text {_insert} Post text";
    }
}