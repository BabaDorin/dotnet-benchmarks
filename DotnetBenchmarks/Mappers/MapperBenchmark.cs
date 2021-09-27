using BenchmarkDotNet.Attributes;
using Mappers.Mappers;
using Mappers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class MapperBenchmark
    {
        static readonly Entity entity = Entity.Mock();

        static readonly Automapper autoMapper = new();
        static readonly ManualMapper manualMapper = new();
        static readonly Mappers.Mapster mapster = new();
        static readonly AgileMapper agileMapper = new();
        static readonly TinyMapper tinyMapper = new();
        static readonly Mappers.ExpressMapper expressMapper = new();

        public void Run()
        {
            AutoMapper();
            Manual();
            AgileMapper();
            Mapster();
            TinyMapper();
            ExpressMapper();
        }

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

        private void CheckIfDeepCopy(Entity entity, EntityDto entityDto)
        {
            bool listDeepCopied = true;
            bool objectDeepCopied = true;

            if(entity.ListProp == entityDto.ListProp)
            {
                Console.WriteLine("entity.ListProp == entityDto.ListProp");
                listDeepCopied = false;
            }

            for (int i = 0; i < entityDto.ListProp.Count; i++)
            {
                if(entity.ListProp[i] == entityDto.ListProp[i])
                {
                    Console.WriteLine($"entity.ListProp[{i}] == entityDto.ListProp[{i}]");
                    listDeepCopied = false;
                }
            }

            if (entity.ObjProp == entityDto.ObjProp)
            {
                Console.WriteLine("entity.ObjProp == entityDto.ObjProp");
                objectDeepCopied = false;
            }

            Console.WriteLine($"\nSummary: List deep copied: {listDeepCopied}, object deep copied: {objectDeepCopied}");
        }
    }
}
