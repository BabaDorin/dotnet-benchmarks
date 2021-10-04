namespace Mappers.Models.MapsterCodeGen
{
    public static partial class SmallEntityMapper
    {
        public static Mappers.Models.SmallDto.SmallDto AdaptToSmallDto(this Mappers.Models.SmallDto.SmallEntity p1)
        {
            return p1 == null ? null : new Mappers.Models.SmallDto.SmallDto()
            {
                P1 = p1.P1,
                P2 = p1.P2,
                P3 = p1.P3,
                P4 = p1.P4,
                P5 = p1.P5,
                ListProp = funcMain1(p1.ListProp),
                ObjProp = p1.ObjProp == null ? null : new Mappers.Models.Shared.Option()
                {
                    Label = p1.ObjProp.Label,
                    Value = p1.ObjProp.Value
                }
            };
        }
        public static Mappers.Models.SmallDto.SmallDto AdaptTo(this Mappers.Models.SmallDto.SmallEntity p3, Mappers.Models.SmallDto.SmallDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            Mappers.Models.SmallDto.SmallDto result = p4 ?? new Mappers.Models.SmallDto.SmallDto();
            
            result.P1 = p3.P1;
            result.P2 = p3.P2;
            result.P3 = p3.P3;
            result.P4 = p3.P4;
            result.P5 = p3.P5;
            result.ListProp = funcMain2(p3.ListProp, result.ListProp);
            result.ObjProp = funcMain3(p3.ObjProp, result.ObjProp);
            return result;
            
        }
        
        private static System.Collections.Generic.List<Mappers.Models.Shared.Option> funcMain1(System.Collections.Generic.List<Mappers.Models.Shared.Option> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            System.Collections.Generic.List<Mappers.Models.Shared.Option> result = new System.Collections.Generic.List<Mappers.Models.Shared.Option>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                Mappers.Models.Shared.Option item = p2[i];
                result.Add(item == null ? null : new Mappers.Models.Shared.Option()
                {
                    Label = item.Label,
                    Value = item.Value
                });
                i++;
            }
            return result;
            
        }
        
        private static System.Collections.Generic.List<Mappers.Models.Shared.Option> funcMain2(System.Collections.Generic.List<Mappers.Models.Shared.Option> p5, System.Collections.Generic.List<Mappers.Models.Shared.Option> p6)
        {
            if (p5 == null)
            {
                return null;
            }
            System.Collections.Generic.List<Mappers.Models.Shared.Option> result = new System.Collections.Generic.List<Mappers.Models.Shared.Option>(p5.Count);
            
            int i = 0;
            int len = p5.Count;
            
            while (i < len)
            {
                Mappers.Models.Shared.Option item = p5[i];
                result.Add(item == null ? null : new Mappers.Models.Shared.Option()
                {
                    Label = item.Label,
                    Value = item.Value
                });
                i++;
            }
            return result;
            
        }
        
        private static Mappers.Models.Shared.Option funcMain3(Mappers.Models.Shared.Option p7, Mappers.Models.Shared.Option p8)
        {
            if (p7 == null)
            {
                return null;
            }
            Mappers.Models.Shared.Option result = p8 ?? new Mappers.Models.Shared.Option();
            
            result.Label = p7.Label;
            result.Value = p7.Value;
            return result;
            
        }
    }
}