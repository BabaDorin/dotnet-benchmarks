using ExpressMapper;
using ExpressMapper.Extensions;
using Mappers.Contracts;
using Mappers.Models.SmallDto;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    class ExpressMapper : IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        public ExpressMapper()
        {
            Mapper.Register<SmallEntity, Models.SmallDto.SmallDto>();
        }

        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
            return entity.Map<SmallEntity, Models.SmallDto.SmallDto>();
        }
    }
}
