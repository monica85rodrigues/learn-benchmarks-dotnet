namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;
    using System.Text;

    [MemoryDiagnoser]
    public class ConcatStringsBenchmark
    {
        [Benchmark]
        public string ConcatStringsWithPlusOperator()
        {
            var result = "a";
            for (int i = 0; i < 10; i++)
                result += "a";

            return result;
        }

        [Benchmark]
        public string ConcatStringsWithStringBuilder()
        {
            var builder = new StringBuilder("a");

            for (int i = 0; i < 10; i++)
                builder.Append("a");

            return builder.ToString();
        }
    }
}
