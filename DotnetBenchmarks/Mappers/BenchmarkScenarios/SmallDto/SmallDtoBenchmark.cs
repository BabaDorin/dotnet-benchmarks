
using BenchmarkDotNet.Attributes;
using Mappers.BenchmarkScenarios.SmallDto.Mappers;
using Mappers.Models.SmallDto;

namespace Mappers.BenchmarkScenarios.SmallDto
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SmallDtoBenchmark
    {
        static readonly Automapper autoMapper = new();
        static readonly ManualMapper manualMapper = new();
        static readonly Mappers.Mapster mapster = new();
        static readonly AgileMapper agileMapper = new();
        static readonly TinyMapper tinyMapper = new();
        static readonly Mappers.ExpressMapper expressMapper = new();
        static readonly MapsterCodeGen mapsterCodeGen = new();

        static readonly SmallEntity entity = new SmallEntityBuilder().Build();

        [Benchmark]
        [IterationTime(100)]
        public void AutoMapper()
        {
            //Console.WriteLine("\nAutoMapper:");
            //CheckIfDeepCopy(entity, autoMapper.Map(entity));

            for (int i = 0; i < 1000000; i++)
            {
                autoMapper.Map(entity);
            }
        }

        [Benchmark]
        [IterationTime(100)]
        public void Manual()
        {
            //Console.WriteLine("\nManual:");
            //CheckIfDeepCopy(entity, manualMapper.Map(entity));

            for (int i = 0; i < 1000000; i++)
            {
                manualMapper.Map(entity);
            }
        }

        [Benchmark]
        [IterationTime(100)]
        public void Mapster()
        {
            //Console.WriteLine("\nMapster:");
            //CheckIfDeepCopy(entity, mapster.Map(entity));
            for (int i = 0; i < 1000000; i++)
            {
                mapster.Map(entity);
            }

        }

        [Benchmark]
        [IterationTime(100)]
        public void AgileMapper()
        {
            //Console.WriteLine("\nAgileMapper:");
            //CheckIfDeepCopy(entity, agileMapper.Map(entity));
            for (int i = 0; i < 1000000; i++)
            {
                agileMapper.Map(entity);
            }
        }

        [Benchmark]
        [IterationTime(100)]
        public void TinyMapper()
        {
            //Console.WriteLine("\nTinyMapper:");
            //CheckIfDeepCopy(entity, tinyMapper.Map(entity));
            for (int i = 0; i < 1000000; i++)
            {
                tinyMapper.Map(entity);
            }
        }

        [Benchmark]
        [IterationTime(100)]
        public void ExpressMapper()
        {
            //Console.WriteLine("\nExpressMapper");
            //CheckIfDeepCopy(entity, expressMapper.Map(entity));
            for (int i = 0; i < 1000000; i++)
            {
                expressMapper.Map(entity);
            }
        }

        [Benchmark]
        [IterationTime(100)]
        public void MapsterCodeGen()
        {
            //Console.WriteLine("\nMapsterCodeGen");
            //CheckIfDeepCopy(entity, mapsterCodeGen.Map(entity));
            for (int i = 0; i < 1000000; i++)
            {
                mapsterCodeGen.Map(entity);
            }
        }
    }
}
