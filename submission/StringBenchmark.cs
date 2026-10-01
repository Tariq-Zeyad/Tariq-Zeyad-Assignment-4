using BenchmarkDotNet.Attributes;
using System.Text;

namespace Academy_Schedule_Analyzer.submission
{
    [MemoryDiagnoser]
    public class StringBenchmark
    {
        [Params(100, 1000, 10000, 100000)]
        public int Iterations;

        [Benchmark]
        public string StringConcatenation()
        {
            string result = "";

            for (int i = 0; i < Iterations; i++)
            {
                result += "Session data\n";
            }

            return result;
        }

        [Benchmark]
        public string StringBuilderConcatenation()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Iterations; i++)
            {
                result.Append("Session data\n");
            }

            return result.ToString();
        }
    }
}