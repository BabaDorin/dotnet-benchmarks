using Mappers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mappers.Mappers
{
    class ManualMapper : IBenchmarkMapper
    {
        public EntityDto Map(Entity entity)
        {
            return EntityToDto(entity);
        }

        private EntityDto EntityToDto(Entity entity)
        {
            var dto = new EntityDto
            {
                P1 = entity.P1,
                P2 = entity.P2,
                P3 = entity.P3,
                P4 = entity.P4,
                P5 = entity.P5
            };

            if(entity.ListProp != null)
            {
                dto.ListProp = new List<Option>();

                for(int i = 0;  i < entity.ListProp.Count; i++)
                {
                    dto.ListProp.Add(entity.ListProp[i].Clone());
                }
            }

            if(entity.ObjProp != null)
            {
                dto.ObjProp = entity.ObjProp.Clone();
            }

            return dto;
        }
    }
}
