using BenchmarkDotNet.Attributes;
using Mappers.BenchmarkScenarios.LargeDto.Mappers;
using Mappers.Models.LargeDto;

namespace Mappers.BenchmarkScenarios.LargeDto
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class LargeDtoBenchmark
    {
        static readonly Automapper autoMapper = new();
        static readonly ManualMapper manualMapper = new();
        static readonly Mappers.Mapster mapster = new();
        static readonly AgileMapper agileMapper = new();
        static readonly TinyMapper tinyMapper = new();
        static readonly Mappers.ExpressMapper expressMapper = new();
        static readonly MapsterCodeGen mapsterCodeGen = new();

        static readonly LargeEntity entity = new LargeEntityBuilder().Build();

        [Benchmark]
        [IterationTime(100)]
        public void AutoMapper()
        {
            //Console.WriteLine("\nAutoMapper:");
            //CheckIfDeepCopy(entity, autoMapper.Map(entity));
            autoMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void Manual()
        {
            //Console.WriteLine("\nManual:");
            //CheckIfDeepCopy(entity, manualMapper.Map(entity));
            manualMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void Mapster()
        {
            //Console.WriteLine("\nMapster:");
            //CheckIfDeepCopy(entity, mapster.Map(entity));
            mapster.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void AgileMapper()
        {
            //Console.WriteLine("\nAgileMapper:");
            //CheckIfDeepCopy(entity, agileMapper.Map(entity));
            agileMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void TinyMapper()
        {
            //Console.WriteLine("\nTinyMapper:");
            //CheckIfDeepCopy(entity, tinyMapper.Map(entity));
            tinyMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void ExpressMapper()
        {
            //Console.WriteLine("\nExpressMapper");
            //CheckIfDeepCopy(entity, expressMapper.Map(entity));
            expressMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void MapsterCodeGen()
        {
            //Console.WriteLine("\nMapsterCodeGen");
            //CheckIfDeepCopy(entity, mapsterCodeGen.Map(entity));
            mapsterCodeGen.Map(entity);
        }
    }
}
