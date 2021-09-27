using AgileObjects.AgileMapper;
using AgileObjects.AgileMapper.Extensions;
using Mappers.Models;
using System.Collections.Generic;

namespace Mappers.Mappers
{
    class AgileMapper : IBenchmarkMapper
    {
        public AgileMapper()
        {
            //Mapper.WhenMapping
            //    .From<Entity>()
            //    .To<EntityDto>()
            //    .Map((e, eDto) => e.ListProp.DeepClone<List<Option>>())
            //    .To(e => e.ListProp)
            //    .And
            //    .Map((e, eDto) => e.ObjProp.DeepClone<Option>())
            //    .To(e => e.ObjProp);
        }

        public EntityDto Map(Entity entity)
        {
            return Mapper.Map(entity).ToANew<EntityDto>();
        }
    }
}
