using Mappers.Models.Shared;
using Mappers.Models.SmallDto;
using System;
using System.Collections.Generic;

namespace Mappers.BenchmarkScenarios.SmallDto
{
    class SmallEntityBuilder
    {
        public SmallEntity Build()
        {
            return new SmallEntity
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
        }
    }
}
