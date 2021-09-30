namespace Mappers.Models
{
    public static partial class OptionMapper
    {
        public static Models.Option AdaptToOption(this Models.Option p1)
        {
            return p1 == null ? null : new Models.Option()
            {
                Label = p1.Label,
                Value = p1.Value
            };
        }
        public static Models.Option AdaptTo(this Models.Option p2, Models.Option p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Models.Option result = p3 ?? new Models.Option();
            
            result.Label = p2.Label;
            result.Value = p2.Value;
            return result;
            
        }
    }
}