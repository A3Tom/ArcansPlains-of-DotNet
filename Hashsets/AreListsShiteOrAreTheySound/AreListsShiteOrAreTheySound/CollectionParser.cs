using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace AreListsShiteOrAreTheySound
{
    public class CollectionParser
    {
        [Benchmark(Baseline = true)]
        public void Add_ToList(int repetitions)
        {
            List<int> result = new();

            for (int i = 0; i < repetitions; i++)
            {
                result.Add(i);
            }
        }

        public void Add_ToHashSet(int repetitions)
        {
            List<int> result = new();

            for (int i = 0; i < repetitions; i++)
            {
                result.Add(i);
            }
        }

    }
}
