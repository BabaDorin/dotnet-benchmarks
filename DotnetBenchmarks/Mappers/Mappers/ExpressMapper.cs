using ExpressMapper;
using ExpressMapper.Extensions;
using Mappers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Mappers
{
    class ExpressMapper : IBenchmarkMapper
    {
        public ExpressMapper()
        {
            Mapper.Register<Entity, EntityDto>();
        }

        public EntityDto Map(Entity entity)
        {
            return entity.Map<Entity, EntityDto>();
        }
    }
}
