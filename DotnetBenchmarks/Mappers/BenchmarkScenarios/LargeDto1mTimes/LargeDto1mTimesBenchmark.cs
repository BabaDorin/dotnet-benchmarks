using BenchmarkDotNet.Attributes;
using Mappers.BenchmarkScenarios.LargeDto;
using Mappers.BenchmarkScenarios.LargeDto.Mappers;
using Mappers.Models.LargeDto;

namespace Mappers.BenchmarkScenarios.LargeDto1mTimes
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class LargeDto1mTimesBenchmark
    {
        static readonly Automapper autoMapper = new();
        static readonly ManualMapper manualMapper = new();
        static readonly LargeDto.Mappers.Mapster mapster = new();
        static readonly AgileMapper agileMapper = new();
        static readonly TinyMapper tinyMapper = new();
        static readonly LargeDto.Mappers.ExpressMapper expressMapper = new();
        static readonly MapsterCodeGen mapsterCodeGen = new();

        static readonly LargeEntity entity = new LargeEntityBuilder().Build();
        
        private int n = 1_000_000;

        [Benchmark]
        [IterationTime(100)]
        public void AutoMapper()
        {
            for(int i = 0; i < n; i++)
                autoMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void Manual()
        {
            for(int i = 0; i < n; i++)
                manualMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void Mapster()
        {
            for(int i = 0; i < n; i++)
                mapster.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void AgileMapper()
        {
            for(int i = 0; i < n; i++)
                agileMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void TinyMapper()
        {
            for(int i = 0; i < n; i++)
                tinyMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void ExpressMapper()
        {
            for(int i = 0; i < n; i++)
                expressMapper.Map(entity);
        }

        [Benchmark]
        [IterationTime(100)]
        public void MapsterCodeGen()
        {
            for(int i = 0; i < n; i++)
                mapsterCodeGen.Map(entity);
        }
    }
}
