using ExpressMapper;
using ExpressMapper.Extensions;
using Mappers.Models;

namespace Mappers.Mappers
{
    class ExpressMapper : IBenchmarkMapper
    {
        public ExpressMapper()
        {
            Mapper.Register<Entity, EntityDto>();
        }

        public EntityDto Map(Entity entity)
        {
            return entity.Map<Entity, EntityDto>();
        }
    }
}
