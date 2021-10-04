using BenchmarkDotNet.Running;
using Mappers.BenchmarkScenarios.LargeDto;
using Mappers.BenchmarkScenarios.LargeDto1mTimes;
using Mappers.BenchmarkScenarios.SmallDto;
using Mappers.BenchmarkScenarios.SmallDto1mTimes;

namespace Mappers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------Small dto---------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            BenchmarkRunner.Run<SmallDtoBenchmark>();
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("----------Small dto 1m times-----------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            BenchmarkRunner.Run<SmallDto1mTimesBenchmark>();
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("-----------------large dto-------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            BenchmarkRunner.Run<LargeDtoBenchmark>();
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("----------Large dto 1m times-----------");
            System.Console.WriteLine("---------------------------------------");
            System.Console.WriteLine("---------------------------------------");
            BenchmarkRunner.Run<LargeDto1mTimesBenchmark>();
        }
    }
}
