using Mapster;

namespace Mappers.Models.Shared
{
    [AdaptTo(typeof(CompositeOption)), GenerateMapper] // <= Used by Mapster for code generation
    public class CompositeOption
    {
        public string Label { get; set; }
        public string Value { get; set; }
        public CompositeOption NestedOption { get; set; }
    }
}
