namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    [MemoryDiagnoser]
    public class SortBenchmark
    {
        [Params(1_000, 100_000)]
        public int ItemsCount { get; set; }

        List<int> values;

        [IterationSetup]
        public void Setup()
        {
            var rand = new Random(0);
            values = new List<int>();
            for (var counter = 0; counter < ItemsCount; counter++)
            {
                values.Add(rand.Next());
            }
        }

        [Benchmark]
        public IEnumerable<int> OrderBy()
        {
            return values.OrderBy(a => a).ToList();
        }

        [Benchmark]
        public IEnumerable<int> OrderByDescending()
        {
            return values.OrderByDescending(a => a).ToList();
        }

        [Benchmark]
        public IEnumerable<int> Sort()
        {
            var clone = values.ToList();
            clone.Sort();
            return clone;
        }

        [Benchmark]
        public IEnumerable<int> SortDescending()
        {
            var clone = values.ToList();
            clone.Sort(new Comparison<int>((a, b) => b - a));
            return clone;
        }
    }
}
