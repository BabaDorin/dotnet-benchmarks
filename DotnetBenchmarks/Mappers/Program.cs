using BenchmarkDotNet.Running;
using Mappers.Models;
using System;

namespace Mappers
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MapperBenchmark>();

            //MapperBenchmark m = new MapperBenchmark();
            //m.Run();
        }
    }
}
