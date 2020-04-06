Day 2 Benchmark Results

|                              Method | NumberToTest |     Mean |    Error |   StdDev | Rank |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------ |------------- |---------:|---------:|---------:|-----:|-------:|------:|------:|----------:|
|       FindHappyNumberUsing2Pointers |           19 | 114.1 ns |  2.55 ns |  7.36 ns |    1 | 0.0592 |     - |     - |     248 B |
| FindHappyNumberUsingListWithoutLinq |           19 | 579.0 ns | 11.54 ns | 32.54 ns |    2 | 0.1583 |     - |     - |     664 B |
|            FindHappyNumberUsingList |           19 | 682.9 ns | 13.52 ns | 21.84 ns |    3 | 0.1755 |     - |     - |     736 B |
|      FindHappyNumberUsingDictionary |           19 | 850.0 ns | 16.11 ns | 14.28 ns |    4 | 0.2384 |     - |     - |    1000 B |
|         FindHappyNumberUsingHashSet |           19 | 889.0 ns | 15.08 ns | 11.77 ns |    5 | 0.2308 |     - |     - |     968 B |