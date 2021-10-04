namespace Mappers.Models.MapsterCodeGen
{
    public static partial class OptionMapper
    {
        public static Mappers.Models.Shared.Option AdaptToOption(this Mappers.Models.Shared.Option p1)
        {
            return p1 == null ? null : new Mappers.Models.Shared.Option()
            {
                Label = p1.Label,
                Value = p1.Value
            };
        }
        public static Mappers.Models.Shared.Option AdaptTo(this Mappers.Models.Shared.Option p2, Mappers.Models.Shared.Option p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Mappers.Models.Shared.Option result = p3 ?? new Mappers.Models.Shared.Option();
            
            result.Label = p2.Label;
            result.Value = p2.Value;
            return result;
            
        }
    }
}