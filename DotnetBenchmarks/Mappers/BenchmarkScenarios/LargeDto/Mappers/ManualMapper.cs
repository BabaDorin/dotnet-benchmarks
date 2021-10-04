using Mappers.Contracts;
using Mappers.Models.LargeDto;
using Mappers.Models.Shared;
using System;

namespace Mappers.BenchmarkScenarios.LargeDto.Mappers
{
    class ManualMapper : IBenchmarkMapper<LargeEntity, Models.LargeDto.LargeDto>
    {
        public Models.LargeDto.LargeDto Map(LargeEntity entity)
        {
            var dto = new Models.LargeDto.LargeDto
            {
                P1 = entity.P1,
                P2 = entity.P2,
                P3 = entity.P3,
                P4 = entity.P4,
                P5 = entity.P5,
                P6 = entity.P6,
                P7 = entity.P7,
                P8 = entity.P8,
                P9 = entity.P9,
                P10 = entity.P10,
                P11 = entity.P11,
                P12 = entity.P12,
                P13 = entity.P13,
                P14 = entity.P14,
                P15 = entity.P15,
                P16 = entity.P16,
                P17 = entity.P17,
                P18 = entity.P18,
                P19 = entity.P19,
                P20 = entity.P20,
                P21 = entity.P21,
                P22 = entity.P22,
                P23 = entity.P23,
                P24 = entity.P24,
                P25 = entity.P25,
                P26 = entity.P26,
                P27 = entity.P27,
                P28 = entity.P28,
                P29 = entity.P29,
                P30 = entity.P30,
                P31 = entity.P31,
                P32 = entity.P32,
                P33 = entity.P33,
                P34 = entity.P34,
                P35 = entity.P35,
                P36 = entity.P36,
                P37 = entity.P37,
                P38 = entity.P38,
                P39 = entity.P39,
                P40 = entity.P40,
                P41 = entity.P41,
                P42 = entity.P42,
                P43 = entity.P43,
                P44 = entity.P44,
                P45 = entity.P45,
                P46 = entity.P46,
                P47 = entity.P47,
                P48 = entity.P48,
                P49 = entity.P49,
                P50 = entity.P50,
                P51 = entity.P51,
                P52 = entity.P52,
                P53 = entity.P53,
                P54 = entity.P54,
                P55 = entity.P55,
                P56 = entity.P56,
                P57 = entity.P57,
                P58 = entity.P58,
                P59 = entity.P59,
                P60 = entity.P60,
                P61 = entity.P61,
                P62 = entity.P62,
                P63 = entity.P63,
                P64 = entity.P64,
                P65 = entity.P65,
                P66 = entity.P66,
                P67 = entity.P67,
                P68 = entity.P68,
                P69 = entity.P69,
                P70 = entity.P70,
                P71 = entity.P71,
                P72 = entity.P72,
                P73 = entity.P73,
                P74 = entity.P74,
                P75 = entity.P75,
                P76 = entity.P76,
                P77 = entity.P77,
                P78 = entity.P78,
                P79 = entity.P79,
                P80 = entity.P80,
                P81 = entity.P81,
                P82 = entity.P82,
                P83 = entity.P83,
                P84 = entity.P84,
                P85 = entity.P85,
                P86 = entity.P86,
                P87 = entity.P87,
                P88 = entity.P88,
                P89 = entity.P89,
                P90 = entity.P90,
                P91 = entity.P91,
                P92 = entity.P92,
                P93 = entity.P93,
                P94 = entity.P94,
                P95 = entity.P95,
                P96 = entity.P96,
                P97 = entity.P97,
                P98 = entity.P98,
                P99 = entity.P99,
                P100 = entity.P100,
                P101 = entity.P101,
                P102 = entity.P102,
                P103 = entity.P103,
                P104 = entity.P104,
                P105 = entity.P105,
                P106 = entity.P106,
                P107 = entity.P107,
                P108 = entity.P108,
                P109 = entity.P109,
                P110 = entity.P110,
                P111 = entity.P111,
                P112 = entity.P112,
                P113 = entity.P113,
                P114 = entity.P114,
                P115 = entity.P115,
                P116 = entity.P116,
                P117 = entity.P117,
                P118 = entity.P118,
                P119 = entity.P119,
                P120 = entity.P120,
                P121 = entity.P121,
                P122 = entity.P122,
                P123 = entity.P123,
                P124 = entity.P124,
                P125 = entity.P125,
                P126 = entity.P126,
                P127 = entity.P127,
                P128 = entity.P128,
                P129 = entity.P129,
                P130 = entity.P130,
                P131 = entity.P131,
                P132 = entity.P132,
                P133 = entity.P133,
                P134 = entity.P134,
                P135 = entity.P135,
                P136 = entity.P136,
                P137 = entity.P137,
                P138 = entity.P138,
                P139 = entity.P139,
                P140 = entity.P140,
                P141 = entity.P141,
                P142 = entity.P142,
                P143 = entity.P143,
                P144 = entity.P144,
                P145 = entity.P145,
                P146 = entity.P146,
                P147 = entity.P147,
                P148 = entity.P148,
                P149 = entity.P149,
                P150 = entity.P150,
            };

            //if (entity.Op151 != null)
            //{
            //    dto.Op151 = new CompositeOption()
            //    {
            //        Value = entity.Op151.Value,
            //        Label = entity.Op151.Value
            //    };

            //    var currentNestedOp = entity.Op151.NestedOption;
            //    if (currentNestedOp != null)
            //    {
            //        dto.Op151.NestedOption = new CompositeOption()
            //        {
            //            Value = currentNestedOp.Value,
            //            Label = currentNestedOp.Value,
            //        };

            //        currentNestedOp = currentNestedOp.NestedOption;
            //        if (currentNestedOp != null)
            //        {
            //            dto.Op151.NestedOption.NestedOption = new CompositeOption()
            //            {
            //                Value = currentNestedOp.Value,
            //                Label = currentNestedOp.Value,
            //            };

            //            currentNestedOp = currentNestedOp.NestedOption;
            //            if (currentNestedOp != null)
            //            {
            //                dto.Op151.NestedOption.NestedOption.NestedOption = new CompositeOption()
            //                {
            //                    Value = currentNestedOp.Value,
            //                    Label = currentNestedOp.Value,
            //                };
            //            }
            //        }
            //    }
            //}

            if (entity.Op151 != null) { dto.Op151 = new CompositeOption() { Value = entity.Op151.Value, Label = entity.Op151.Value }; var currentNestedOp = entity.Op151.NestedOption; if (currentNestedOp != null) { dto.Op151.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op151.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op151.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op152 != null) { dto.Op152 = new CompositeOption() { Value = entity.Op152.Value, Label = entity.Op152.Value }; var currentNestedOp = entity.Op152.NestedOption; if (currentNestedOp != null) { dto.Op152.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op152.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op152.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op153 != null) { dto.Op153 = new CompositeOption() { Value = entity.Op153.Value, Label = entity.Op153.Value }; var currentNestedOp = entity.Op153.NestedOption; if (currentNestedOp != null) { dto.Op153.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op153.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op153.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op154 != null) { dto.Op154 = new CompositeOption() { Value = entity.Op154.Value, Label = entity.Op154.Value }; var currentNestedOp = entity.Op154.NestedOption; if (currentNestedOp != null) { dto.Op154.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op154.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op154.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op155 != null) { dto.Op155 = new CompositeOption() { Value = entity.Op155.Value, Label = entity.Op155.Value }; var currentNestedOp = entity.Op155.NestedOption; if (currentNestedOp != null) { dto.Op155.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op155.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op155.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op156 != null) { dto.Op156 = new CompositeOption() { Value = entity.Op156.Value, Label = entity.Op156.Value }; var currentNestedOp = entity.Op156.NestedOption; if (currentNestedOp != null) { dto.Op156.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op156.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op156.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op157 != null) { dto.Op157 = new CompositeOption() { Value = entity.Op157.Value, Label = entity.Op157.Value }; var currentNestedOp = entity.Op157.NestedOption; if (currentNestedOp != null) { dto.Op157.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op157.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op157.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op158 != null) { dto.Op158 = new CompositeOption() { Value = entity.Op158.Value, Label = entity.Op158.Value }; var currentNestedOp = entity.Op158.NestedOption; if (currentNestedOp != null) { dto.Op158.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op158.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op158.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op159 != null) { dto.Op159 = new CompositeOption() { Value = entity.Op159.Value, Label = entity.Op159.Value }; var currentNestedOp = entity.Op159.NestedOption; if (currentNestedOp != null) { dto.Op159.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op159.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op159.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op160 != null) { dto.Op160 = new CompositeOption() { Value = entity.Op160.Value, Label = entity.Op160.Value }; var currentNestedOp = entity.Op160.NestedOption; if (currentNestedOp != null) { dto.Op160.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op160.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op160.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op161 != null) { dto.Op161 = new CompositeOption() { Value = entity.Op161.Value, Label = entity.Op161.Value }; var currentNestedOp = entity.Op161.NestedOption; if (currentNestedOp != null) { dto.Op161.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op161.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op161.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op162 != null) { dto.Op162 = new CompositeOption() { Value = entity.Op162.Value, Label = entity.Op162.Value }; var currentNestedOp = entity.Op162.NestedOption; if (currentNestedOp != null) { dto.Op162.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op162.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op162.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op163 != null) { dto.Op163 = new CompositeOption() { Value = entity.Op163.Value, Label = entity.Op163.Value }; var currentNestedOp = entity.Op163.NestedOption; if (currentNestedOp != null) { dto.Op163.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op163.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op163.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op164 != null) { dto.Op164 = new CompositeOption() { Value = entity.Op164.Value, Label = entity.Op164.Value }; var currentNestedOp = entity.Op164.NestedOption; if (currentNestedOp != null) { dto.Op164.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op164.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op164.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op165 != null) { dto.Op165 = new CompositeOption() { Value = entity.Op165.Value, Label = entity.Op165.Value }; var currentNestedOp = entity.Op165.NestedOption; if (currentNestedOp != null) { dto.Op165.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op165.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op165.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op166 != null) { dto.Op166 = new CompositeOption() { Value = entity.Op166.Value, Label = entity.Op166.Value }; var currentNestedOp = entity.Op166.NestedOption; if (currentNestedOp != null) { dto.Op166.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op166.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op166.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op167 != null) { dto.Op167 = new CompositeOption() { Value = entity.Op167.Value, Label = entity.Op167.Value }; var currentNestedOp = entity.Op167.NestedOption; if (currentNestedOp != null) { dto.Op167.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op167.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op167.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op168 != null) { dto.Op168 = new CompositeOption() { Value = entity.Op168.Value, Label = entity.Op168.Value }; var currentNestedOp = entity.Op168.NestedOption; if (currentNestedOp != null) { dto.Op168.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op168.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op168.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op169 != null) { dto.Op169 = new CompositeOption() { Value = entity.Op169.Value, Label = entity.Op169.Value }; var currentNestedOp = entity.Op169.NestedOption; if (currentNestedOp != null) { dto.Op169.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op169.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op169.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op170 != null) { dto.Op170 = new CompositeOption() { Value = entity.Op170.Value, Label = entity.Op170.Value }; var currentNestedOp = entity.Op170.NestedOption; if (currentNestedOp != null) { dto.Op170.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op170.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op170.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op171 != null) { dto.Op171 = new CompositeOption() { Value = entity.Op171.Value, Label = entity.Op171.Value }; var currentNestedOp = entity.Op171.NestedOption; if (currentNestedOp != null) { dto.Op171.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op171.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op171.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op172 != null) { dto.Op172 = new CompositeOption() { Value = entity.Op172.Value, Label = entity.Op172.Value }; var currentNestedOp = entity.Op172.NestedOption; if (currentNestedOp != null) { dto.Op172.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op172.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op172.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op173 != null) { dto.Op173 = new CompositeOption() { Value = entity.Op173.Value, Label = entity.Op173.Value }; var currentNestedOp = entity.Op173.NestedOption; if (currentNestedOp != null) { dto.Op173.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op173.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op173.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op174 != null) { dto.Op174 = new CompositeOption() { Value = entity.Op174.Value, Label = entity.Op174.Value }; var currentNestedOp = entity.Op174.NestedOption; if (currentNestedOp != null) { dto.Op174.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op174.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op174.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op175 != null) { dto.Op175 = new CompositeOption() { Value = entity.Op175.Value, Label = entity.Op175.Value }; var currentNestedOp = entity.Op175.NestedOption; if (currentNestedOp != null) { dto.Op175.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op175.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op175.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op176 != null) { dto.Op176 = new CompositeOption() { Value = entity.Op176.Value, Label = entity.Op176.Value }; var currentNestedOp = entity.Op176.NestedOption; if (currentNestedOp != null) { dto.Op176.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op176.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op176.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op177 != null) { dto.Op177 = new CompositeOption() { Value = entity.Op177.Value, Label = entity.Op177.Value }; var currentNestedOp = entity.Op177.NestedOption; if (currentNestedOp != null) { dto.Op177.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op177.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op177.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op178 != null) { dto.Op178 = new CompositeOption() { Value = entity.Op178.Value, Label = entity.Op178.Value }; var currentNestedOp = entity.Op178.NestedOption; if (currentNestedOp != null) { dto.Op178.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op178.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op178.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op179 != null) { dto.Op179 = new CompositeOption() { Value = entity.Op179.Value, Label = entity.Op179.Value }; var currentNestedOp = entity.Op179.NestedOption; if (currentNestedOp != null) { dto.Op179.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op179.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op179.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op180 != null) { dto.Op180 = new CompositeOption() { Value = entity.Op180.Value, Label = entity.Op180.Value }; var currentNestedOp = entity.Op180.NestedOption; if (currentNestedOp != null) { dto.Op180.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op180.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op180.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op181 != null) { dto.Op181 = new CompositeOption() { Value = entity.Op181.Value, Label = entity.Op181.Value }; var currentNestedOp = entity.Op181.NestedOption; if (currentNestedOp != null) { dto.Op181.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op181.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op181.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op182 != null) { dto.Op182 = new CompositeOption() { Value = entity.Op182.Value, Label = entity.Op182.Value }; var currentNestedOp = entity.Op182.NestedOption; if (currentNestedOp != null) { dto.Op182.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op182.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op182.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op183 != null) { dto.Op183 = new CompositeOption() { Value = entity.Op183.Value, Label = entity.Op183.Value }; var currentNestedOp = entity.Op183.NestedOption; if (currentNestedOp != null) { dto.Op183.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op183.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op183.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op184 != null) { dto.Op184 = new CompositeOption() { Value = entity.Op184.Value, Label = entity.Op184.Value }; var currentNestedOp = entity.Op184.NestedOption; if (currentNestedOp != null) { dto.Op184.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op184.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op184.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op185 != null) { dto.Op185 = new CompositeOption() { Value = entity.Op185.Value, Label = entity.Op185.Value }; var currentNestedOp = entity.Op185.NestedOption; if (currentNestedOp != null) { dto.Op185.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op185.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op185.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op186 != null) { dto.Op186 = new CompositeOption() { Value = entity.Op186.Value, Label = entity.Op186.Value }; var currentNestedOp = entity.Op186.NestedOption; if (currentNestedOp != null) { dto.Op186.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op186.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op186.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op187 != null) { dto.Op187 = new CompositeOption() { Value = entity.Op187.Value, Label = entity.Op187.Value }; var currentNestedOp = entity.Op187.NestedOption; if (currentNestedOp != null) { dto.Op187.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op187.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op187.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op188 != null) { dto.Op188 = new CompositeOption() { Value = entity.Op188.Value, Label = entity.Op188.Value }; var currentNestedOp = entity.Op188.NestedOption; if (currentNestedOp != null) { dto.Op188.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op188.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op188.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op189 != null) { dto.Op189 = new CompositeOption() { Value = entity.Op189.Value, Label = entity.Op189.Value }; var currentNestedOp = entity.Op189.NestedOption; if (currentNestedOp != null) { dto.Op189.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op189.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op189.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op190 != null) { dto.Op190 = new CompositeOption() { Value = entity.Op190.Value, Label = entity.Op190.Value }; var currentNestedOp = entity.Op190.NestedOption; if (currentNestedOp != null) { dto.Op190.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op190.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op190.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op191 != null) { dto.Op191 = new CompositeOption() { Value = entity.Op191.Value, Label = entity.Op191.Value }; var currentNestedOp = entity.Op191.NestedOption; if (currentNestedOp != null) { dto.Op191.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op191.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op191.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op192 != null) { dto.Op192 = new CompositeOption() { Value = entity.Op192.Value, Label = entity.Op192.Value }; var currentNestedOp = entity.Op192.NestedOption; if (currentNestedOp != null) { dto.Op192.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op192.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op192.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op193 != null) { dto.Op193 = new CompositeOption() { Value = entity.Op193.Value, Label = entity.Op193.Value }; var currentNestedOp = entity.Op193.NestedOption; if (currentNestedOp != null) { dto.Op193.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op193.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op193.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op194 != null) { dto.Op194 = new CompositeOption() { Value = entity.Op194.Value, Label = entity.Op194.Value }; var currentNestedOp = entity.Op194.NestedOption; if (currentNestedOp != null) { dto.Op194.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op194.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op194.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op195 != null) { dto.Op195 = new CompositeOption() { Value = entity.Op195.Value, Label = entity.Op195.Value }; var currentNestedOp = entity.Op195.NestedOption; if (currentNestedOp != null) { dto.Op195.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op195.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op195.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op196 != null) { dto.Op196 = new CompositeOption() { Value = entity.Op196.Value, Label = entity.Op196.Value }; var currentNestedOp = entity.Op196.NestedOption; if (currentNestedOp != null) { dto.Op196.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op196.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op196.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op197 != null) { dto.Op197 = new CompositeOption() { Value = entity.Op197.Value, Label = entity.Op197.Value }; var currentNestedOp = entity.Op197.NestedOption; if (currentNestedOp != null) { dto.Op197.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op197.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op197.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op198 != null) { dto.Op198 = new CompositeOption() { Value = entity.Op198.Value, Label = entity.Op198.Value }; var currentNestedOp = entity.Op198.NestedOption; if (currentNestedOp != null) { dto.Op198.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op198.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op198.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op199 != null) { dto.Op199 = new CompositeOption() { Value = entity.Op199.Value, Label = entity.Op199.Value }; var currentNestedOp = entity.Op199.NestedOption; if (currentNestedOp != null) { dto.Op199.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op199.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op199.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }
            if (entity.Op200 != null) { dto.Op200 = new CompositeOption() { Value = entity.Op200.Value, Label = entity.Op200.Value }; var currentNestedOp = entity.Op200.NestedOption; if (currentNestedOp != null) { dto.Op200.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op200.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; currentNestedOp = currentNestedOp.NestedOption; if (currentNestedOp != null) { dto.Op200.NestedOption.NestedOption.NestedOption = new CompositeOption() { Value = currentNestedOp.Value, Label = currentNestedOp.Value, }; } } } }

            return dto;
        }
    }
}
