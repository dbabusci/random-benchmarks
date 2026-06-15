```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD Ryzen 5 PRO 7530U with Radeon Graphics 1.10GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3


```
| Method     | Mean     | Error   | StdDev   | Median   |
|----------- |---------:|--------:|---------:|---------:|
| IfNotAdd   | 277.4 μs | 3.20 μs |  3.00 μs | 277.9 μs |
| IfContinue | 267.2 μs | 5.33 μs | 12.97 μs | 272.4 μs |
