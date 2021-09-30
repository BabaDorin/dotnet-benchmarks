﻿using System;
using System.Collections.Generic;

namespace Mappers.Models
{
    public class EntityDto
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