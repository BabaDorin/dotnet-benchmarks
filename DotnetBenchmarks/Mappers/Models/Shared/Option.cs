using Mapster;

namespace Mappers.Models.Shared
{
    [AdaptTo(typeof(Option)), GenerateMapper] // <= Used by Mapster for code generation
    public class Option
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }
}
