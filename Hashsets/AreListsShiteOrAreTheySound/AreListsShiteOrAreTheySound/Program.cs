using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

/*
    I HAVE ... BEGUN

    Hello and welcome, to the first edition of Arecane Plains. Am yer host, Tam.
    Today am goni see who is shiter; the mighty List<T>, or a painful reference to the Java underworld - Hashset<T>

    Personally, I do hope that the List wins or is atleast close in hings so that I dont feel pure pish about all the times I've overlooked hashsets and used lists as a pure default option
    I think it'll be hashset that wins out though - especially in the larger numbers and comparers

    Right av havered enough pish, lets begin
*/

/*
    So it would seem after running the Search comparison that identifying a record in a list would be faster in a hashset. Mental man, only by ~200ms but it would seem less consistent with a 3x higher std dev
    Fuckin cool result though. I think I'll switch to hashsets when running readonly collections of non system objects
*/

namespace AreListsShiteOrAreTheySound
{
    [MemoryDiagnoser]
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListVsHashset_Search>();

            Console.Read();
        }
    }
}
