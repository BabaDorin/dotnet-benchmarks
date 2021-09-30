using Mappers.Models;

namespace Mappers.Mappers
{
    class TinyMapper : IBenchmarkMapper
    {
        public TinyMapper()
        {
            Nelibur.ObjectMapper.TinyMapper.Bind<Entity, EntityDto>();
        }

        public EntityDto Map(Entity entity)
        {
            return Nelibur.ObjectMapper.TinyMapper.Map<EntityDto>(entity);
        }
    }
}
