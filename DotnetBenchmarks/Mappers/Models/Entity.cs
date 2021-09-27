using System;
using System.Collections.Generic;

namespace Mappers.Models
{
    public class Entity
    {
        public string P1 { get; set; }
        public int P2 { get; set; }
        public double P3 { get; set; }
        public DateTime P4 { get; set; }
        public float P5 { get; set; }
        public List<Option> ListProp { get; set; }
        public Option ObjProp { get; set; }

        public static Entity Mock()
        {
            return new Entity
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
