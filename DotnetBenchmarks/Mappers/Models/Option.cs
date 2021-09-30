using Mapster;

namespace Mappers.Models
{
    [AdaptTo(typeof(Option)), GenerateMapper] // <= Used by Mapster for code generation
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
