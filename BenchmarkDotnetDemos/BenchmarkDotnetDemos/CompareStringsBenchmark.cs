namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;
    using System;

    [MemoryDiagnoser]
    public class CompareStringsBenchmark
    {
        [Benchmark]
        public bool CompareStringsWithEqualsOperator()
        {
            return "xpto".ToLower() == "XPTO".ToLower();
        }

        [Benchmark]
        public bool CompareStringsWithCompareMethod()
        {
            return string.Compare("xpto", "XPTO") == 0;
        }

        [Benchmark]
        public bool CompareStringsWithEqualsMethod()
        {
            return "xpto".Equals("XPTO", StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
