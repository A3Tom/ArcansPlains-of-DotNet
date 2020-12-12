using BenchmarkDotNet.Attributes;

namespace AreListsShiteOrAreTheySound
{
    [MemoryDiagnoser]
    public class CollectionParserBenchmarks
    {
        private static readonly CollectionParser _parser = new();


        [Benchmark(Baseline = true)]
        public void AddValues_10()
        {
            _parser.Add_ToList(10);
            _parser.Add_ToHashSet(10);
        }
    }
}
