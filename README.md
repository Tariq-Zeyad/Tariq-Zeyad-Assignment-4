<div align="center">

# Academy Schedule Analyzer

### Assignment 4

**Eng. Tariq Zeyad**

A C# console application that implements the required academy schedule operations, C# concepts, LeetCode solutions, benchmarking, and technical documentation.

</div>

---

## `Program.cs`

The main application of the project.

It implements the **Academy Schedule Analyzer** as a menu-driven C# console application. The program works with session names, dates, and durations and provides 16 operations for analyzing and managing the schedule.

The implemented operations include:

1. Display all sessions
2. Search for a session
3. Sort session names
4. Reverse session names
5. Find a session index
6. Check whether a session exists
7. Display duration statistics
8. Display session date details
9. Display past and upcoming sessions
10. Find the next session
11. Compare two session dates
12. Read and validate a custom date
13. Select a session by index
14. Validate session duration
15. Generate a report using `string`
16. Generate a report using `StringBuilder`

The file also demonstrates the required C# concepts through practical implementations, including:

* Arrays
* Methods and functions
* `ref`
* `out`
* `params`
* `DateTime`
* `TimeSpan`
* Exception handling
* String manipulation
* Searching and sorting
* Input validation
* `string`
* `StringBuilder`

---

## `StringBenchmark.cs`

A separate **BenchmarkDotNet** implementation for measuring the performance of string building.

The file compares:

* `string` concatenation
* `StringBuilder` concatenation

Different iteration counts are tested to show how execution time and memory allocation change as the workload increases.

The benchmark is intentionally kept separate from `Program.cs` so that the main application remains focused on the schedule analyzer.

---

## `BENCHMARK.md`

Contains the benchmark results generated from the actual execution of `StringBenchmark.cs`.

The results include measurements such as:

* Mean execution time
* Error
* Standard deviation
* Median
* Garbage collection information
* Memory allocation

The results provide the practical performance comparison between `string` concatenation and `StringBuilder`.

---

## `LeetCode/ValidAnagram.cs`

Contains the C# solution for the **Valid Anagram** problem.

The implementation first checks whether the two strings have the same length, then processes their characters and compares the resulting character sequences to determine whether the strings are anagrams.

---

## `LeetCode/GcdOfStrings.cs`

Contains the C# solution for the **Greatest Common Divisor of Strings** problem.

The implementation calculates the greatest common divisor of the two string lengths, creates a possible common string, and verifies that the candidate can construct both input strings.

---

## `LeetCode/README.md`

Contains the documentation for the LeetCode section of the assignment.

It documents the completed problems, their related solution files, problem references, and accepted submission information.

---

## `LeetCode/images/`

Contains the screenshots used as proof of the accepted LeetCode submissions.

The folder includes:

* `valid-anagram-accepted.png`
* `gcd-of-strings-accepted.png`

---

## `LinkedIn/README.md`

Contains the documentation and published links for the four technical LinkedIn posts created for the assignment.

The posts cover practical C# concepts related to the work, including:

* Arrays and Functions
* Reference Types and `ref`
* `params`
* `string` vs `StringBuilder`

Each topic is explained with a practical C# example and its relation to real programming use cases.

---

## Assignment Submission

The assignment is prepared on the required branch:

`assignment/1-4`

The corresponding Pull Request title is:

`[S1-A4] Assignment 4`

---

<div align="center">

### C# — Assignment 4

**Academy Schedule Analyzer**

**Eng. Tariq Zeyad**

</div>
