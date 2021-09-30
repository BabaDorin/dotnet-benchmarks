namespace Mappers.Models
{
    public static partial class EntityMapper
    {
        public static Models.EntityDto AdaptToDto(this Models.Entity p1)
        {
            return p1 == null ? null : new Models.EntityDto()
            {
                P1 = p1.P1,
                P2 = p1.P2,
                P3 = p1.P3,
                P4 = p1.P4,
                P5 = p1.P5,
                ListProp = funcMain1(p1.ListProp),
                ObjProp = p1.ObjProp == null ? null : new Models.Option()
                {
                    Label = p1.ObjProp.Label,
                    Value = p1.ObjProp.Value
                }
            };
        }
        public static Models.EntityDto AdaptTo(this Models.Entity p3, Models.EntityDto p4)
        {
            if (p3 == null)
            {
                return null;
            }
            Models.EntityDto result = p4 ?? new Models.EntityDto();
            
            result.P1 = p3.P1;
            result.P2 = p3.P2;
            result.P3 = p3.P3;
            result.P4 = p3.P4;
            result.P5 = p3.P5;
            result.ListProp = funcMain2(p3.ListProp, result.ListProp);
            result.ObjProp = funcMain3(p3.ObjProp, result.ObjProp);
            return result;
            
        }
        
        private static System.Collections.Generic.List<Models.Option> funcMain1(System.Collections.Generic.List<Models.Option> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            System.Collections.Generic.List<Models.Option> result = new System.Collections.Generic.List<Models.Option>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                Models.Option item = p2[i];
                result.Add(item == null ? null : new Models.Option()
                {
                    Label = item.Label,
                    Value = item.Value
                });
                i++;
            }
            return result;
            
        }
        
        private static System.Collections.Generic.List<Models.Option> funcMain2(System.Collections.Generic.List<Models.Option> p5, System.Collections.Generic.List<Models.Option> p6)
        {
            if (p5 == null)
            {
                return null;
            }
            System.Collections.Generic.List<Models.Option> result = new System.Collections.Generic.List<Models.Option>(p5.Count);
            
            int i = 0;
            int len = p5.Count;
            
            while (i < len)
            {
                Models.Option item = p5[i];
                result.Add(item == null ? null : new Models.Option()
                {
                    Label = item.Label,
                    Value = item.Value
                });
                i++;
            }
            return result;
            
        }
        
        private static Models.Option funcMain3(Models.Option p7, Models.Option p8)
        {
            if (p7 == null)
            {
                return null;
            }
            Models.Option result = p8 ?? new Models.Option();
            
            result.Label = p7.Label;
            result.Value = p7.Value;
            return result;
            
        }
    }
}