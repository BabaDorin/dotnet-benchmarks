using Mappers.Models.Shared;
using Mapster;
using System;
using System.Collections.Generic;

namespace Mappers.Models.SmallDto
{
    [AdaptTo(typeof(SmallDto)), GenerateMapper] // <= Used by Mapster for code generation
    public class SmallEntity
    {
        public string P1 { get; set; }
        public int P2 { get; set; }
        public double P3 { get; set; }
        public DateTime P4 { get; set; }
        public float P5 { get; set; }
        public List<Option> ListProp { get; set; }
        public Option ObjProp { get; set; }
    }
}
