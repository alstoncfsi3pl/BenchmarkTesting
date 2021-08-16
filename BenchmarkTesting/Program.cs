using BenchmarkDotNet.Running;
using System;

namespace BenchmarkTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BenchmarkRunner.Run<BinarySearch>();
        }
    }
}
