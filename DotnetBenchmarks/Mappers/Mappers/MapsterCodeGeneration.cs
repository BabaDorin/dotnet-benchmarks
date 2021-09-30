using Mappers.Models;
using Mapster;
using System;

namespace Mappers.Mappers
{
    class MapsterCodeGeneration : IBenchmarkMapper
    {
        private readonly MapsterMapper.IMapper mapsterMapper;
        private readonly TypeAdapterConfig config;

        public MapsterCodeGeneration()
        {
            config = new();
            config.NewConfig<Entity, EntityDto>();
            mapsterMapper = new MapsterMapper.Mapper(config);
        }

        public EntityDto Map(Entity entity)
        {
            return mapsterMapper.From(entity).AdaptToType<EntityDto>();
        }
    }
}
