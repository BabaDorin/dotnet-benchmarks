using BenchmarkDotNet.Attributes;
using Mappers.Mappers;
using Mappers.Models;
using System;
using System.Collections.Generic;

namespace Mappers
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class MapperBenchmark
    {
        static readonly Automapper autoMapper = new();
        static readonly ManualMapper manualMapper = new();
        static readonly Mappers.Mapster mapster = new();
        static readonly AgileMapper agileMapper = new();
        static readonly TinyMapper tinyMapper = new();
        static readonly Mappers.ExpressMapper expressMapper = new();
        static readonly MapsterCodeGen mapsterCodeGen = new();

        static readonly Entity entity = new Entity
        {
            P1 = "Hello World",
            P2 = 420,
            P3 = 420,
            P4 = DateTime.UtcNow,
            P5 = 420,
            ListProp = new List<Option>()
                {
                    new Option(),
                    new Option(),
                    new Option(),
                    new Option(),
                    new Option(),
                },
            ObjProp = new Option()
        };

        [Benchmark]
        public void AutoMapper()
        {
            //Console.WriteLine("\nAutoMapper:");
            //CheckIfDeepCopy(entity, autoMapper.Map(entity));

            autoMapper.Map(entity);
        }

        [Benchmark]
        public void Manual()
        {
            //Console.WriteLine("\nManual:");
            //CheckIfDeepCopy(entity, manualMapper.Map(entity));

            manualMapper.Map(entity);
        }

        [Benchmark]
        public void Mapster()
        {
            //Console.WriteLine("\nMapster:");
            //CheckIfDeepCopy(entity, mapster.Map(entity));

            mapster.Map(entity);
        }

        [Benchmark]
        public void AgileMapper()
        {
            //Console.WriteLine("\nAgileMapper:");
            //CheckIfDeepCopy(entity, agileMapper.Map(entity));

            agileMapper.Map(entity);
        }

        [Benchmark]
        public void TinyMapper()
        {
            //Console.WriteLine("\nTinyMapper:");
            //CheckIfDeepCopy(entity, tinyMapper.Map(entity));

            tinyMapper.Map(entity);
        }

        [Benchmark]
        public void ExpressMapper()
        {
            //Console.WriteLine("\nExpressMapper");
            //CheckIfDeepCopy(entity, expressMapper.Map(entity));

            expressMapper.Map(entity);
        }

        [Benchmark]
        public void MapsterCodeGen()
        {
            //Console.WriteLine("\nMapsterCodeGen");
            //CheckIfDeepCopy(entity, mapsterCodeGen.Map(entity));

            mapsterCodeGen.Map(entity);
        }
    }
}
