using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkTesting
{
    public class BinarySearch
    {
        List<string> dinosaurs = new List<string>();

        public BinarySearch()
        {
            dinosaurs.Add("Pachycephalosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
        }

        [Benchmark]
        public void BinaryListSearch()
        {                        
            var result = dinosaurs.BinarySearch("Deinonychus");
        }

        [Benchmark]
        public void ListSearch()
        {
            var result = dinosaurs.Where(a => a == "Deinonychus").FirstOrDefault();
        }

        [Benchmark]
        public void ListIndexOfSearch()
        {
            var result = dinosaurs.IndexOf("Deinonychus");
        }
    }
}
