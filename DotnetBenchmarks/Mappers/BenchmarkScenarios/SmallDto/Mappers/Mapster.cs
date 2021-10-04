using Mappers.Contracts;
using Mappers.Models.SmallDto;
using Mapster;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    class Mapster : IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
            return entity.Adapt<Models.SmallDto.SmallDto>();
        }
    }
}
