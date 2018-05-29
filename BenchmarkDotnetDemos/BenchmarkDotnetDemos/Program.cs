namespace BenchmarkDotnetDemos
{
    using System;
    using BenchmarkDotNet.Running;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play with performance tips :D");

            //var benchmarkReportSummary = BenchmarkRunner.Run<SortBenchmark>();
            //var benchmarkReportSummary = BenchmarkRunner.Run<CompareStringsBenchmark>();
            //var benchmarkReportSummary = BenchmarkRunner.Run<CompareSwitchAndDictionaryBenchmark>();
            //var benchmarkReportSummary = BenchmarkRunner.Run<ConcatStringsBenchmark>();
            var benchmarkReportSummary = BenchmarkRunner.Run<SumArraysBenchmark>();

            Console.WriteLine("Press any key to exit and bye bye :D");
            Console.ReadKey();
        }
    }
}
