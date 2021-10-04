using AutoMapper;
using Mappers.Contracts;
using Mappers.Models.Shared;
using Mappers.Models.SmallDto;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    public class Automapper: IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        readonly MapperConfiguration config;
        readonly IMapper mapper;

        public Automapper()
        {
            config = new(cfg => {
                cfg.CreateMap<SmallEntity, Models.SmallDto.SmallDto>();
                cfg.CreateMap<Option, Option>();
            }) ;

            mapper = config.CreateMapper();
        }

        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
           return mapper.Map<Models.SmallDto.SmallDto>(entity);
        }
    }
}
