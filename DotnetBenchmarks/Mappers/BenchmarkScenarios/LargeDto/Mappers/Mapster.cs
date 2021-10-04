using Mappers.Contracts;
using Mappers.Models.LargeDto;
using Mapster;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    class Mapster : IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
            return entity.Adapt<Models.LargeDto.LargeDto>();
        }
    }
}
