using AutoMapper;
using Mappers.Contracts;
using Mappers.Models.LargeDto;
using Mappers.Models.Shared;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    public class Automapper: IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        readonly MapperConfiguration config;
        readonly IMapper mapper;

        public Automapper()
        {
            config = new(cfg => {
                cfg.CreateMap<LargeEntity, Models.LargeDto.LargeDto>();
                cfg.CreateMap<Option, Option>();
                cfg.CreateMap<CompositeOption, CompositeOption>();
            }) ;

            mapper = config.CreateMapper();
        }

        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
           return mapper.Map<Models.LargeDto.LargeDto>(entity);
        }
    }
}
