namespace BenchmarkDotnetDemos
{
    using BenchmarkDotNet.Attributes;
    using System.Collections.Generic;

    [MemoryDiagnoser]
    public class CompareSwitchAndDictionaryBenchmark
    {
        [Benchmark]
        public string SwitchVersion()
        {
            var jobType = "Junior";
            var value = string.Empty;

            switch (jobType)
            {
                case "Junior":
                    value = "I'm a junior developer";
                    break;
                case "Middle":
                    value = "I'm a middle developer";
                    break;
                case "Senior":
                    value = "I'm a senior developer";
                    break;
                case "Principal":
                    value = "I'm a principal developer";
                    break;
            }

            return value;
        }

        [Benchmark]
        static string DictionaryVersion()
        {
            var dictionary = new Dictionary<string, string>()
            {
                { "Junior", "I'm a junior developer" },
                { "Middle", "I'm a middle developer" },
                { "Senior", "I'm a senior developer" },
                { "Principal", "I'm a principal developer" },
            };

            return dictionary["Junior"];
        }
    }
}
