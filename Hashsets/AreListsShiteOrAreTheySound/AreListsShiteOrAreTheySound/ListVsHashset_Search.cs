using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace AreListsShiteOrAreTheySound
{
    public class ListVsHashset_Search
    {
        public static readonly int N = 500;

        public static Random _rnd = new Random();

        public static List<AContraversialWeaponOfChoice> ListOfRecords()
        {
            List<AContraversialWeaponOfChoice> result = new();

            for (int i = 0; i < 10000; i++)
            {
                result.Add(new AContraversialWeaponOfChoice(
                    Id: i,
                    FirstName: _rnd.Next(1, 10000).ToString(),
                    LastName: _rnd.Next(1, 10000).GetHashCode().ToString()
                    ));
            }

            return result;
        }

        public static HashSet<AContraversialWeaponOfChoice> HashsetOfRecords()
        {
            HashSet<AContraversialWeaponOfChoice> result = new();

            for (int i = 0; i < 10000; i++)
            {
                result.Add(new AContraversialWeaponOfChoice(
                    Id: i,
                    FirstName: _rnd.ToString(),
                    LastName: _rnd.GetHashCode().ToString()
                    ));
            }

            return result;
        }

        [Benchmark]
        public bool ListSearch()
        {
            for (int i = 0; i < N; i++)
            {
                var rec = ListOfRecords()
                    .Where(x => x.Id == _rnd.Next(1, 10000));
            }

            return true;
        }

        [Benchmark]
        public bool HashsetSearch()
        {
            for (int i = 0; i < N; i++)
            {
                var test = _rnd.Next(1, 10000);
                var rec = HashsetOfRecords()
                    .Where(x => x.Id == _rnd.Next(1, 10000));
            }

            return true;
        }
    }

    public record AContraversialWeaponOfChoice(int Id, string FirstName, string LastName);
}
