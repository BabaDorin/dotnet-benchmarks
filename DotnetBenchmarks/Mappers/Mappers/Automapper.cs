using AutoMapper;
using Mappers.Models;

namespace Mappers.Mappers
{
    public class Automapper: IBenchmarkMapper
    {
        readonly MapperConfiguration config;
        readonly IMapper mapper;

        public Automapper()
        {
            config = new(cfg => {
                cfg.CreateMap<Entity, EntityDto>();
                cfg.CreateMap<Option, Option>();
            }) ;

            mapper = config.CreateMapper();
        }

        public EntityDto Map(Entity entity)
        {
           return mapper.Map<EntityDto>(entity);
        }
    }
}
