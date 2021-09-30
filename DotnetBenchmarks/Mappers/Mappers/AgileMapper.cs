using AgileObjects.AgileMapper;
using Mappers.Models;

namespace Mappers.Mappers
{
    class AgileMapper : IBenchmarkMapper
    {
        public EntityDto Map(Entity entity)
        {
            return Mapper.Map(entity).ToANew<EntityDto>();
        }
    }
}
