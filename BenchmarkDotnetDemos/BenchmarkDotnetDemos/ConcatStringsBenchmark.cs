namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;
    using System.Text;

    [MemoryDiagnoser]
    public class ConcatStringsBenchmark
    {
        [Benchmark]
        public void ConcatStringsWithPlusOperator()
        {
            var result = "a";
            for (int i = 0; i < 10; i++)
                result += "a";
        }

        [Benchmark]
        public void ConcatStringsWithStringBuilder()
        {
            var builder = new StringBuilder("a");

            for (int i = 0; i < 10; i++)
                builder.Append("a");

            var result = builder.ToString();
        }
    }
}
