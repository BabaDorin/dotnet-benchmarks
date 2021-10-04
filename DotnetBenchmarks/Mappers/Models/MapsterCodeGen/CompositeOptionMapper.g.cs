namespace Mappers.Models.MapsterCodeGen
{
    public static partial class CompositeOptionMapper
    {
        public static Mappers.Models.Shared.CompositeOption AdaptToCompositeOption(this Mappers.Models.Shared.CompositeOption p1)
        {
            return p1 == null ? null : new Mappers.Models.Shared.CompositeOption()
            {
                Label = p1.Label,
                Value = p1.Value,
                NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.NestedOption)
            };
        }
        public static Mappers.Models.Shared.CompositeOption AdaptTo(this Mappers.Models.Shared.CompositeOption p2, Mappers.Models.Shared.CompositeOption p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p3 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p2.Label;
            result.Value = p2.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p2.NestedOption, result.NestedOption);
            return result;
            
        }
    }
}