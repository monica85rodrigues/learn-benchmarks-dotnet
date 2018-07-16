namespace BenchmarkDotnetDemos
{
    using System;
    using BenchmarkDotNet.Running;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play with performance tips :D");

            var benchmarkSwitcher = new BenchmarkSwitcher(new[]
            {
                typeof(SortBenchmark),
                typeof(CompareStringsBenchmark),
                typeof(CompareSwitchAndDictionaryBenchmark),
                typeof(ConcatStringsBenchmark),
                typeof(SumArraysBenchmark),
                typeof(DictionariesBenchmark)
            });

            benchmarkSwitcher.Run(args);

            Console.WriteLine("Press any key to exit and bye bye :D");
            Console.ReadKey();
        }
    }
}
