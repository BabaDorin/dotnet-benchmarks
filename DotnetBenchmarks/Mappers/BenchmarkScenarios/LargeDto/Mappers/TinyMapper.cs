using Mappers.Contracts;
using Mappers.Models.LargeDto;
using Mappers.Models.Shared;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    class TinyMapper : IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        public TinyMapper()
        {
            Nelibur.ObjectMapper.TinyMapper.Bind<LargeEntity, Models.LargeDto.LargeDto>();
            Nelibur.ObjectMapper.TinyMapper.Bind<CompositeOption, CompositeOption>();
        }

        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
            return Nelibur.ObjectMapper.TinyMapper.Map<Models.LargeDto.LargeDto>(entity);
        }
    }
}
