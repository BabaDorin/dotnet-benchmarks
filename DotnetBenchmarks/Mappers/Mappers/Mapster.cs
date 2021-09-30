using Mappers.Models;
using Mapster;

namespace Mappers.Mappers
{
    class Mapster : IBenchmarkMapper
    {
        public EntityDto Map(Entity entity)
        {
            return entity.Adapt<EntityDto>();
        }
    }
}
