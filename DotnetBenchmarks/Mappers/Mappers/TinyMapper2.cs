using Mappers.Models;
using Nelibur.ObjectMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Mappers
{
    class TinyMapper : IBenchmarkMapper
    {
        public TinyMapper()
        {
            Nelibur.ObjectMapper.TinyMapper.Bind<Entity, EntityDto>();
        }

        public EntityDto Map(Entity entity)
        {
            return Nelibur.ObjectMapper.TinyMapper.Map<EntityDto>(entity);
        }
    }
}
