using Mappers.Contracts;
using Mappers.Models.SmallDto;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    class TinyMapper : IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        public TinyMapper()
        {
            Nelibur.ObjectMapper.TinyMapper.Bind<SmallEntity, Models.SmallDto.SmallDto>();
        }

        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
            return Nelibur.ObjectMapper.TinyMapper.Map<Models.SmallDto.SmallDto>(entity);
        }
    }
}
