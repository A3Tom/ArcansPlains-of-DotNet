using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace AreListsShiteOrAreTheySound
{
    public class ListVsHashset_Addition
    {
        [Params(100, 1000000)]
        public int N;

        [Benchmark]
        public List<int> AddToList()
        {
            List<int> sut = new();

            for (int i = 0; i < N; i++)
            {
                sut.Add(i);
            }

            return sut;
        }


        [Benchmark]
        public HashSet<int> AddToHashset()
        {
            HashSet<int> sut = new();

            for (int i = 0; i < N; i++)
            {
                sut.Add(i);
            }

            return sut;
        }
    }
}
