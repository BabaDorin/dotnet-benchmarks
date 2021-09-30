namespace Mappers.Models
{
    public static partial class OptionMapper
    {
        public static Mappers.Models.Option AdaptToOption(this Mappers.Models.Option p1)
        {
            return p1 == null ? null : new Mappers.Models.Option()
            {
                Label = p1.Label,
                Value = p1.Value
            };
        }
        public static Mappers.Models.Option AdaptTo(this Mappers.Models.Option p2, Mappers.Models.Option p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Mappers.Models.Option result = p3 ?? new Mappers.Models.Option();
            
            result.Label = p2.Label;
            result.Value = p2.Value;
            return result;
            
        }
    }
}