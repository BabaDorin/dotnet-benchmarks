using BenchmarkDotNet.Running;

namespace Mappers
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<MapperBenchmark>();
        }
    }
}
