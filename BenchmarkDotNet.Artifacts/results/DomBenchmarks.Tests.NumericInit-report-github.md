```

BenchmarkDotNet v0.15.8, Linux Ubuntu 24.04.4 LTS (Noble Numbat)
AMD Ryzen 5 PRO 7530U with Radeon Graphics 1.10GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 10.0.103
  [Host]     : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.3 (10.0.3, 10.0.326.7603), X64 RyuJIT x86-64-v3


```
| Method           | Mean      | Error     | StdDev    | Median    |
|----------------- |----------:|----------:|----------:|----------:|
| DecimalInit      | 0.0045 ns | 0.0035 ns | 0.0033 ns | 0.0033 ns |
| DecimalInitInt32 | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |
| LongInit         | 0.0017 ns | 0.0012 ns | 0.0011 ns | 0.0017 ns |
| LongInitInt32    | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |
| FloatInit        | 0.0003 ns | 0.0006 ns | 0.0006 ns | 0.0000 ns |
| FloatInitInt32   | 0.0000 ns | 0.0000 ns | 0.0000 ns | 0.0000 ns |
