# Benchmark Results

## Benchmark Setup

In this benchmark, I compared two ways of adding strings:

* `StringConcatenation`
* `StringBuilderConcatenation`

I used BenchmarkDotNet to test both methods with different numbers of iterations.

### Environment

* Windows 11
* .NET 10.0.11
* BenchmarkDotNet 0.15.8
* 11th Gen Intel Core i5-1135G7 2.40 GHz
* 8 logical processors
* 4 physical cores

## Results

| Method                     | Iterations |                Mean |        Allocated |
| -------------------------- | ---------: | ------------------: | ---------------: |
| StringConcatenation        |        100 |          6,208.6 ns |        130.62 KB |
| StringBuilderConcatenation |        100 |            574.9 ns |          7.13 KB |
| StringConcatenation        |      1,000 |        526,373.3 ns |     12,732.38 KB |
| StringBuilderConcatenation |      1,000 |          4,043.1 ns |         57.81 KB |
| StringConcatenation        |     10,000 |    145,265,156.0 ns |  1,270,019.88 KB |
| StringBuilderConcatenation |     10,000 |        165,069.8 ns |        521.79 KB |
| StringConcatenation        |    100,000 | 52,727,932,791.0 ns | 126,963,946.5 KB |
| StringBuilderConcatenation |    100,000 |      3,273,749.7 ns |      5,100.61 KB |

## Questions

### 1. Which method was faster at 100 iterations?

`StringBuilderConcatenation` was faster.

* String Concatenation: 6,208.6 ns
* StringBuilder: 574.9 ns

### 2. Which method was faster at 100,000 iterations?

`StringBuilderConcatenation` was much faster.

* String Concatenation: about 52.7 seconds
* StringBuilder: about 3.27 milliseconds

### 3. Which method allocated more memory?

`StringConcatenation` allocated much more memory.

At 100,000 iterations:

* String Concatenation: 126,963,946.5 KB
* StringBuilder: 5,100.61 KB

### 4. What happened to String Concatenation as the loop count increased?

It became much slower as the number of iterations increased.

At 100 iterations, it took about 6.2 microseconds. At 100,000 iterations, it took about 52.7 seconds.

The memory usage also increased a lot.

### 5. Why does repeated string concatenation create many allocations?

Strings in C# are immutable, which means they cannot be changed after they are created.

For example:

```csharp
result += "Session data\n";
```

creates a new string each time. The old string has to be copied into the new one, so repeating this many times creates many allocations.

### 6. Why is StringBuilder usually better for repeated additions?

`StringBuilder` is made for building strings with many changes.

It uses an internal buffer, so it does not need to create a completely new string every time something is added.

Because of this, it can be much faster and use less memory when there are many additions.

### 7. Is StringBuilder always better?

No.

If I only need to combine a few strings, normal string concatenation is simple and works well.

`StringBuilder` is more useful when I need to add or change strings many times, especially inside a loop.

## Conclusion

The benchmark showed that `StringBuilder` performed much better when the number of iterations became larger.

The difference was small in terms of code, but the performance and memory difference became very large at 10,000 and 100,000 iterations.

Overall, for repeated string additions, `StringBuilder` was much more efficient in this benchmark.
