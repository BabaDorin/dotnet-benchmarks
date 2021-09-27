using System;

namespace Mappers.Models
{
    public class Option
    {
        public string Label { get; set; }
        public string Value { get; set; }

        public Option Clone()
        {
            return new Option
            {
                Label = this.Label,
                Value = this.Value
            };
        }
    }
}
