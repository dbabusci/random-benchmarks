```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD Ryzen 5 PRO 7530U with Radeon Graphics 1.10GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3


```
| Method           | Mean     | Error   | StdDev  |
|----------------- |---------:|--------:|--------:|
| Addition         | 732.5 μs | 3.90 μs | 3.65 μs |
| TemplateLiterals | 729.2 μs | 4.71 μs | 4.41 μs |
