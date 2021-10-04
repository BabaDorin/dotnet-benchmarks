using Mappers.Contracts;
using Mappers.Models.LargeDto;
using Mappers.Models.MapsterCodeGen;
using Mappers.Models.Shared;
using Mapster;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    class MapsterCodeGen : IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        private readonly MapsterMapper.IMapper mapsterMapper;
        private readonly TypeAdapterConfig config;

        public MapsterCodeGen()
        {
            config = new();
            config.NewConfig<LargeEntity, Models.LargeDto.LargeDto>();
            config.NewConfig<CompositeOption, CompositeOption>();
            mapsterMapper = new MapsterMapper.Mapper(config);
        }

        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
            return entity.AdaptToLargeDto();
        }
    }
}
