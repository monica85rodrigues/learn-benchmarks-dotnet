namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class SumArraysBenchmark
    {
        [Benchmark]
        public void SumArrayValueWithFor()
        {
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = 0;

            for (var i = 0; i < items.Length; i++)
            {
                sum += items[i];
            }
        }

        [Benchmark]
        public void SumArrayValueWithForeach()
        {
            var items = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sum = 0;

            foreach (var item in items)
            {
                sum += item;
            }
        }
    }
}
