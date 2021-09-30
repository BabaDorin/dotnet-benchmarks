using Mappers.Models;
using Mapster;

namespace Mappers.Mappers
{
    class MapsterCodeGen : IBenchmarkMapper
    {
        private readonly MapsterMapper.IMapper mapsterMapper;
        private readonly TypeAdapterConfig config;

        public MapsterCodeGen()
        {
            config = new();
            config.NewConfig<Entity, EntityDto>();
            mapsterMapper = new MapsterMapper.Mapper(config);
        }

        public EntityDto Map(Entity entity)
        {
            return entity.AdaptToDto();
            //return null;
        }
    }
}
