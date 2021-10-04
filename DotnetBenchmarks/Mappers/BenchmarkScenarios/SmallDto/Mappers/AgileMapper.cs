using AgileObjects.AgileMapper;
using Mappers.Contracts;
using Mappers.Models.SmallDto;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    class AgileMapper : IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
            return Mapper.Map(entity).ToANew<Models.SmallDto.SmallDto>();
        }
    }
}
