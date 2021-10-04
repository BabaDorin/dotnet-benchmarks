using Mappers.Contracts;
using Mappers.Models.SmallDto;
using Mapster;
using Mappers.Models.MapsterCodeGen;
using System;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    class MapsterCodeGen : IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        private readonly MapsterMapper.IMapper mapsterMapper;
        private readonly TypeAdapterConfig config;

        public MapsterCodeGen()
        {
            config = new();
            config.NewConfig<SmallEntity, Models.SmallDto.SmallDto>();
            mapsterMapper = new MapsterMapper.Mapper(config);
        }

        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
            return entity.AdaptToSmallDto();
        }
    }
}
