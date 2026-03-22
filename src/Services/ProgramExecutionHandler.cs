using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Running;
using DomBenchmarks.Enums;
using DomBenchmarks.Tests;

namespace DomBenchmarks.Services;

public class ProgramExecutionHandler
{
    private static readonly List<string> _inputs = new List<string>()
    {
        "Enter the benchmark you want to run:\n",
        "\tNSee the effects of numeric literals when initalizing variables -> 1\n",
        "\tDifference between string literal constructio and string concatination -> 2\n",
        "\tDifference between adding to list when capcity is initialized vs when it is not -> 3\n",
        "Option: "
    };

    public static ProgramOptions GetUserInput()
    {
        foreach (string s in _inputs)
            Console.Write(s);

        string? rawText = Console.ReadLine();
        if (string.IsNullOrEmpty(rawText))
            return ProgramOptions.Error;

        if (int.TryParse(rawText, out int i))
            return (ProgramOptions) i;

        return (ProgramOptions)i;
    }

    public static void ExecuteBenchmark(ProgramOptions options)
    {
        switch (options)
        {
            case ProgramOptions.NumericInit:
                BenchmarkRunner.Run<NumericInit>();
                break;
            case ProgramOptions.StringBuilding:
                BenchmarkRunner.Run<StringBuilding>();
                break;
            case ProgramOptions.CapacityInit:
                BenchmarkRunner.Run<CapacityInit>();
                break;
            case ProgramOptions.Error:
            default:
                Console.WriteLine("Some kind of error happened!");
                break;
        }
    }
}