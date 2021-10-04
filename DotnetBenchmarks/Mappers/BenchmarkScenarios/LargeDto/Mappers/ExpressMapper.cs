using ExpressMapper;
using ExpressMapper.Extensions;
using Mappers.Contracts;
using Mappers.Models.LargeDto;
using Mappers.Models.Shared;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    class ExpressMapper : IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        public ExpressMapper()
        {
            Mapper.Register<LargeEntity, Models.LargeDto.LargeDto>();
            Mapper.Register<CompositeOption, CompositeOption>();
        }

        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
            return entity.Map<LargeEntity, Models.LargeDto.LargeDto>();
        }
    }
}
