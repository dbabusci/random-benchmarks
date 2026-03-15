using DomBenchmarks.Enums;
using DomBenchmarks.Services;

Console.WriteLine($"Program init: {DateTime.Now}");

ProgramOptions options = ProgramExecutionHandler.GetUserInput();
ProgramExecutionHandler.ExecuteBenchmark(options);

Console.WriteLine($"Program finished: {DateTime.Now}");
