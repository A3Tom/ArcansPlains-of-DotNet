``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.630 (2004/?/20H1)
Intel Core i7-9750H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


```
|       Method |       N |            Mean |         Error |          StdDev |          Median |
|------------- |-------- |----------------:|--------------:|----------------:|----------------:|
|    **AddToList** |     **100** |        **376.0 ns** |      **27.79 ns** |        **81.50 ns** |        **342.2 ns** |
| AddToHashset |     100 |      1,814.1 ns |     109.35 ns |       318.99 ns |      1,693.4 ns |
|    **AddToList** | **1000000** |  **4,607,690.3 ns** |  **90,907.44 ns** |   **234,661.13 ns** |  **4,567,780.1 ns** |
| AddToHashset | 1000000 | 24,015,439.9 ns | 492,339.35 ns | 1,428,365.72 ns | 24,104,937.5 ns |
