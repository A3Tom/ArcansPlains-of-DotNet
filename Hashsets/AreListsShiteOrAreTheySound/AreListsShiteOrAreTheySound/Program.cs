using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace AreListsShiteOrAreTheySound
{
    [MemoryDiagnoser]
    class Program
    {
        private static readonly CollectionParser _parser = new CollectionParser();

        static void Main(string[] args)
        {
            Console.WriteLine("I HAVE ... BEGUN");

            Console.WriteLine("Hello and welcome, to the first edition of Arecane Plains. Am yer host, Tam.");
            Console.WriteLine("Today am goni see who is shiter; the mighty List<T>, or a painful reference to the Java underworld - Hashset<T>");

            Console.WriteLine("Personally, I do hope that the List wins or is atleast close in hings so that I dont feel pure pish about all the times I've overlooked hashsets and used lists as a pure default option");
            Console.WriteLine("I think it'll be hashset that wins out though - especially in the larger numbers and comparers");

            Console.WriteLine("Right av havered enough pish, lets begin");

            var summary = BenchmarkRunner.Run<CollectionParserBenchmarks>();
        }
    }
}
