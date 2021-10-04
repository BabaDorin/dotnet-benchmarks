
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
            autoMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void Manual()
        {
            manualMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void Mapster()
        {
            mapster.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void AgileMapper()
        {
            agileMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void TinyMapper()
        {
            tinyMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void ExpressMapper()
        {
            expressMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void MapsterCodeGen()
        {
            mapsterCodeGen.Map(entity);
        }
    }
}
