using Mappers.Contracts;
using Mappers.Models.Shared;
using Mappers.Models.SmallDto;
using System.Collections.Generic;

namespace Mappers.BenchmarkScenarios.SmallDto.Mappers
{
    class ManualMapper : IBenchmarkMapper<SmallEntity, Models.SmallDto.SmallDto>
    {
        public Models.SmallDto.SmallDto Map(SmallEntity entity)
        {
            return EntityToDto(entity);
        }

        private Models.SmallDto.SmallDto EntityToDto(SmallEntity entity)
        {
            var dto = new Models.SmallDto.SmallDto
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
                    dto.ListProp.Add(new Option() 
                    { 
                        Label = entity.ListProp[i].Label, 
                        Value = entity.ListProp[i].Value 
                    });
                }
            }

            if(entity.ObjProp != null)
            {
                dto.ObjProp = new Option()
                {
                    Value = entity.ObjProp.Value,
                    Label = entity.ObjProp.Label
                };
            }

            return dto;
        }
    }
}
