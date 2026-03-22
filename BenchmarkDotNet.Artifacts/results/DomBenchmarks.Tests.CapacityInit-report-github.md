```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD Ryzen 5 PRO 7530U with Radeon Graphics 1.10GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3


```
| Method | Mean     | Error   | StdDev  |
|------- |---------:|--------:|--------:|
| Init   | 230.8 μs | 0.52 μs | 0.46 μs |
| NoInit | 331.7 μs | 0.58 μs | 0.51 μs |
