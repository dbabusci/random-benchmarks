```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD Ryzen 5 PRO 7530U with Radeon Graphics 3.19GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3


```
| Method           | Mean      | Error     | StdDev    | Median    |
|----------------- |----------:|----------:|----------:|----------:|
| DecimalInit      | 0.0006 ns | 0.0011 ns | 0.0010 ns | 0.0000 ns |
| DecimalInitInt32 | 0.0051 ns | 0.0030 ns | 0.0025 ns | 0.0048 ns |
| LongInit         | 0.0014 ns | 0.0062 ns | 0.0049 ns | 0.0000 ns |
| LongInitInt32    | 0.0002 ns | 0.0004 ns | 0.0004 ns | 0.0000 ns |
| FloatInit        | 0.0131 ns | 0.0166 ns | 0.0156 ns | 0.0055 ns |
| FloatInitInt32   | 0.0001 ns | 0.0004 ns | 0.0003 ns | 0.0000 ns |
