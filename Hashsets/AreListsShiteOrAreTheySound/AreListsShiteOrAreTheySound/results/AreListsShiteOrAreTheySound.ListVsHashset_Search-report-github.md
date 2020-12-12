``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|        Method |     Mean |    Error |    StdDev |   Median |
|-------------- |---------:|---------:|----------:|---------:|
|    ListSearch | 991.9 ms | 19.54 ms |  39.91 ms | 991.2 ms |
| HashsetSearch | 778.7 ms | 39.67 ms | 116.97 ms | 705.9 ms |
