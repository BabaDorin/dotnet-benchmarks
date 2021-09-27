using Mappers.Models;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Mappers
{
    class Mapster : IBenchmarkMapper
    {
        public EntityDto Map(Entity entity)
        {
            return entity.Adapt<EntityDto>();
        }
    }
}
