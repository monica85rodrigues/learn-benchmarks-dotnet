using BenchmarkDotNet.Attributes;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace BenchmarkDotnetDemos
{
    [MemoryDiagnoser]
    public class DictionariesBenchmark
    {
        private IDictionary<string,string> dict = new Dictionary<string, string>();
        private ConcurrentDictionary<string, string> concurrentDict = new ConcurrentDictionary<string, string>();

        [Benchmark]
        public IDictionary<string, string> AddDictionary()
        {
            dict.TryAdd("key", "value");
            return dict;
        }

        [Benchmark]
        public ConcurrentDictionary<string, string> AddConcurrentDictionary()
        {
            concurrentDict.TryAdd<string, string>("key", "value");
            return concurrentDict;
        }

        [Benchmark]
        public string GetValueFromDictionary()
        {
            dict.TryGetValue("key", out string value);
            return value;
        }

        [Benchmark]
        public string GetValueFromConcurrentDictionary()
        {
            concurrentDict.TryGetValue("key", out string value);
            return value;
        }
    }
}
