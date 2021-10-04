using AgileObjects.AgileMapper;
using Mappers.Contracts;
using Mappers.Models.LargeDto;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    class AgileMapper : IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
            return Mapper.Map(entity).ToANew<Models.LargeDto.LargeDto>();
        }
    }
}
