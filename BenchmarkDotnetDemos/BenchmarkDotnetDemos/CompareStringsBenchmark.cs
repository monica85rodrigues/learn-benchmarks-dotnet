namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;
    using System;

    [MemoryDiagnoser]
    public class CompareStringsBenchmark
    {
        [Benchmark]
        public void CompareStringsWithEqualsOperator()
        {
            var result = "xpto".ToLower() == "XPTO".ToLower();
        }

        [Benchmark]
        public void CompareStringsWithCompareMethod()
        {
            var result = string.Compare("xpto", "XPTO") == 0;
        }

        [Benchmark]
        public void CompareStringsWithEqualsMethod()
        {
            var result = "xpto".Equals("XPTO", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
