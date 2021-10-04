namespace Mappers.Models.MapsterCodeGen
{
    public static partial class LargeEntityMapper
    {
        public static Mappers.Models.LargeDto.LargeDto AdaptToLargeDto(this Mappers.Models.LargeDto.LargeEntity p1)
        {
            return p1 == null ? null : new Mappers.Models.LargeDto.LargeDto()
            {
                P1 = p1.P1,
                P2 = p1.P2,
                P3 = p1.P3,
                P4 = p1.P4,
                P5 = p1.P5,
                P6 = p1.P6,
                P7 = p1.P7,
                P8 = p1.P8,
                P9 = p1.P9,
                P10 = p1.P10,
                P11 = p1.P11,
                P12 = p1.P12,
                P13 = p1.P13,
                P14 = p1.P14,
                P15 = p1.P15,
                P16 = p1.P16,
                P17 = p1.P17,
                P18 = p1.P18,
                P19 = p1.P19,
                P20 = p1.P20,
                P21 = p1.P21,
                P22 = p1.P22,
                P23 = p1.P23,
                P24 = p1.P24,
                P25 = p1.P25,
                P26 = p1.P26,
                P27 = p1.P27,
                P28 = p1.P28,
                P29 = p1.P29,
                P30 = p1.P30,
                P31 = p1.P31,
                P32 = p1.P32,
                P33 = p1.P33,
                P34 = p1.P34,
                P35 = p1.P35,
                P36 = p1.P36,
                P37 = p1.P37,
                P38 = p1.P38,
                P39 = p1.P39,
                P40 = p1.P40,
                P41 = p1.P41,
                P42 = p1.P42,
                P43 = p1.P43,
                P44 = p1.P44,
                P45 = p1.P45,
                P46 = p1.P46,
                P47 = p1.P47,
                P48 = p1.P48,
                P49 = p1.P49,
                P50 = p1.P50,
                P51 = p1.P51,
                P52 = p1.P52,
                P53 = p1.P53,
                P54 = p1.P54,
                P55 = p1.P55,
                P56 = p1.P56,
                P57 = p1.P57,
                P58 = p1.P58,
                P59 = p1.P59,
                P60 = p1.P60,
                P61 = p1.P61,
                P62 = p1.P62,
                P63 = p1.P63,
                P64 = p1.P64,
                P65 = p1.P65,
                P66 = p1.P66,
                P67 = p1.P67,
                P68 = p1.P68,
                P69 = p1.P69,
                P70 = p1.P70,
                P71 = p1.P71,
                P72 = p1.P72,
                P73 = p1.P73,
                P74 = p1.P74,
                P75 = p1.P75,
                P76 = p1.P76,
                P77 = p1.P77,
                P78 = p1.P78,
                P79 = p1.P79,
                P80 = p1.P80,
                P81 = p1.P81,
                P82 = p1.P82,
                P83 = p1.P83,
                P84 = p1.P84,
                P85 = p1.P85,
                P86 = p1.P86,
                P87 = p1.P87,
                P88 = p1.P88,
                P89 = p1.P89,
                P90 = p1.P90,
                P91 = p1.P91,
                P92 = p1.P92,
                P93 = p1.P93,
                P94 = p1.P94,
                P95 = p1.P95,
                P96 = p1.P96,
                P97 = p1.P97,
                P98 = p1.P98,
                P99 = p1.P99,
                P100 = p1.P100,
                P101 = p1.P101,
                P102 = p1.P102,
                P103 = p1.P103,
                P104 = p1.P104,
                P105 = p1.P105,
                P106 = p1.P106,
                P107 = p1.P107,
                P108 = p1.P108,
                P109 = p1.P109,
                P110 = p1.P110,
                P111 = p1.P111,
                P112 = p1.P112,
                P113 = p1.P113,
                P114 = p1.P114,
                P115 = p1.P115,
                P116 = p1.P116,
                P117 = p1.P117,
                P118 = p1.P118,
                P119 = p1.P119,
                P120 = p1.P120,
                P121 = p1.P121,
                P122 = p1.P122,
                P123 = p1.P123,
                P124 = p1.P124,
                P125 = p1.P125,
                P126 = p1.P126,
                P127 = p1.P127,
                P128 = p1.P128,
                P129 = p1.P129,
                P130 = p1.P130,
                P131 = p1.P131,
                P132 = p1.P132,
                P133 = p1.P133,
                P134 = p1.P134,
                P135 = p1.P135,
                P136 = p1.P136,
                P137 = p1.P137,
                P138 = p1.P138,
                P139 = p1.P139,
                P140 = p1.P140,
                P141 = p1.P141,
                P142 = p1.P142,
                P143 = p1.P143,
                P144 = p1.P144,
                P145 = p1.P145,
                P146 = p1.P146,
                P147 = p1.P147,
                P148 = p1.P148,
                P149 = p1.P149,
                P150 = p1.P150,
                Op151 = p1.Op151 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op151.Label,
                    Value = p1.Op151.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op151.NestedOption)
                },
                Op152 = p1.Op152 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op152.Label,
                    Value = p1.Op152.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op152.NestedOption)
                },
                Op153 = p1.Op153 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op153.Label,
                    Value = p1.Op153.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op153.NestedOption)
                },
                Op154 = p1.Op154 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op154.Label,
                    Value = p1.Op154.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op154.NestedOption)
                },
                Op155 = p1.Op155 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op155.Label,
                    Value = p1.Op155.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op155.NestedOption)
                },
                Op156 = p1.Op156 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op156.Label,
                    Value = p1.Op156.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op156.NestedOption)
                },
                Op157 = p1.Op157 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op157.Label,
                    Value = p1.Op157.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op157.NestedOption)
                },
                Op158 = p1.Op158 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op158.Label,
                    Value = p1.Op158.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op158.NestedOption)
                },
                Op159 = p1.Op159 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op159.Label,
                    Value = p1.Op159.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op159.NestedOption)
                },
                Op160 = p1.Op160 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op160.Label,
                    Value = p1.Op160.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op160.NestedOption)
                },
                Op161 = p1.Op161 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op161.Label,
                    Value = p1.Op161.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op161.NestedOption)
                },
                Op162 = p1.Op162 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op162.Label,
                    Value = p1.Op162.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op162.NestedOption)
                },
                Op163 = p1.Op163 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op163.Label,
                    Value = p1.Op163.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op163.NestedOption)
                },
                Op164 = p1.Op164 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op164.Label,
                    Value = p1.Op164.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op164.NestedOption)
                },
                Op165 = p1.Op165 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op165.Label,
                    Value = p1.Op165.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op165.NestedOption)
                },
                Op166 = p1.Op166 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op166.Label,
                    Value = p1.Op166.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op166.NestedOption)
                },
                Op167 = p1.Op167 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op167.Label,
                    Value = p1.Op167.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op167.NestedOption)
                },
                Op168 = p1.Op168 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op168.Label,
                    Value = p1.Op168.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op168.NestedOption)
                },
                Op169 = p1.Op169 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op169.Label,
                    Value = p1.Op169.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op169.NestedOption)
                },
                Op170 = p1.Op170 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op170.Label,
                    Value = p1.Op170.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op170.NestedOption)
                },
                Op171 = p1.Op171 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op171.Label,
                    Value = p1.Op171.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op171.NestedOption)
                },
                Op172 = p1.Op172 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op172.Label,
                    Value = p1.Op172.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op172.NestedOption)
                },
                Op173 = p1.Op173 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op173.Label,
                    Value = p1.Op173.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op173.NestedOption)
                },
                Op174 = p1.Op174 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op174.Label,
                    Value = p1.Op174.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op174.NestedOption)
                },
                Op175 = p1.Op175 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op175.Label,
                    Value = p1.Op175.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op175.NestedOption)
                },
                Op176 = p1.Op176 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op176.Label,
                    Value = p1.Op176.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op176.NestedOption)
                },
                Op177 = p1.Op177 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op177.Label,
                    Value = p1.Op177.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op177.NestedOption)
                },
                Op178 = p1.Op178 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op178.Label,
                    Value = p1.Op178.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op178.NestedOption)
                },
                Op179 = p1.Op179 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op179.Label,
                    Value = p1.Op179.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op179.NestedOption)
                },
                Op180 = p1.Op180 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op180.Label,
                    Value = p1.Op180.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op180.NestedOption)
                },
                Op181 = p1.Op181 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op181.Label,
                    Value = p1.Op181.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op181.NestedOption)
                },
                Op182 = p1.Op182 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op182.Label,
                    Value = p1.Op182.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op182.NestedOption)
                },
                Op183 = p1.Op183 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op183.Label,
                    Value = p1.Op183.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op183.NestedOption)
                },
                Op184 = p1.Op184 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op184.Label,
                    Value = p1.Op184.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op184.NestedOption)
                },
                Op185 = p1.Op185 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op185.Label,
                    Value = p1.Op185.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op185.NestedOption)
                },
                Op186 = p1.Op186 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op186.Label,
                    Value = p1.Op186.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op186.NestedOption)
                },
                Op187 = p1.Op187 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op187.Label,
                    Value = p1.Op187.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op187.NestedOption)
                },
                Op188 = p1.Op188 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op188.Label,
                    Value = p1.Op188.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op188.NestedOption)
                },
                Op189 = p1.Op189 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op189.Label,
                    Value = p1.Op189.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op189.NestedOption)
                },
                Op190 = p1.Op190 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op190.Label,
                    Value = p1.Op190.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op190.NestedOption)
                },
                Op191 = p1.Op191 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op191.Label,
                    Value = p1.Op191.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op191.NestedOption)
                },
                Op192 = p1.Op192 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op192.Label,
                    Value = p1.Op192.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op192.NestedOption)
                },
                Op193 = p1.Op193 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op193.Label,
                    Value = p1.Op193.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op193.NestedOption)
                },
                Op194 = p1.Op194 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op194.Label,
                    Value = p1.Op194.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op194.NestedOption)
                },
                Op195 = p1.Op195 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op195.Label,
                    Value = p1.Op195.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op195.NestedOption)
                },
                Op196 = p1.Op196 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op196.Label,
                    Value = p1.Op196.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op196.NestedOption)
                },
                Op197 = p1.Op197 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op197.Label,
                    Value = p1.Op197.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op197.NestedOption)
                },
                Op198 = p1.Op198 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op198.Label,
                    Value = p1.Op198.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op198.NestedOption)
                },
                Op199 = p1.Op199 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op199.Label,
                    Value = p1.Op199.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op199.NestedOption)
                },
                Op200 = p1.Op200 == null ? null : new Mappers.Models.Shared.CompositeOption()
                {
                    Label = p1.Op200.Label,
                    Value = p1.Op200.Value,
                    NestedOption = Mapster.TypeAdapter<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>.Map.Invoke(p1.Op200.NestedOption)
                }
            };
        }
        public static Mappers.Models.LargeDto.LargeDto AdaptTo(this Mappers.Models.LargeDto.LargeEntity p2, Mappers.Models.LargeDto.LargeDto p3)
        {
            if (p2 == null)
            {
                return null;
            }
            Mappers.Models.LargeDto.LargeDto result = p3 ?? new Mappers.Models.LargeDto.LargeDto();
            
            result.P1 = p2.P1;
            result.P2 = p2.P2;
            result.P3 = p2.P3;
            result.P4 = p2.P4;
            result.P5 = p2.P5;
            result.P6 = p2.P6;
            result.P7 = p2.P7;
            result.P8 = p2.P8;
            result.P9 = p2.P9;
            result.P10 = p2.P10;
            result.P11 = p2.P11;
            result.P12 = p2.P12;
            result.P13 = p2.P13;
            result.P14 = p2.P14;
            result.P15 = p2.P15;
            result.P16 = p2.P16;
            result.P17 = p2.P17;
            result.P18 = p2.P18;
            result.P19 = p2.P19;
            result.P20 = p2.P20;
            result.P21 = p2.P21;
            result.P22 = p2.P22;
            result.P23 = p2.P23;
            result.P24 = p2.P24;
            result.P25 = p2.P25;
            result.P26 = p2.P26;
            result.P27 = p2.P27;
            result.P28 = p2.P28;
            result.P29 = p2.P29;
            result.P30 = p2.P30;
            result.P31 = p2.P31;
            result.P32 = p2.P32;
            result.P33 = p2.P33;
            result.P34 = p2.P34;
            result.P35 = p2.P35;
            result.P36 = p2.P36;
            result.P37 = p2.P37;
            result.P38 = p2.P38;
            result.P39 = p2.P39;
            result.P40 = p2.P40;
            result.P41 = p2.P41;
            result.P42 = p2.P42;
            result.P43 = p2.P43;
            result.P44 = p2.P44;
            result.P45 = p2.P45;
            result.P46 = p2.P46;
            result.P47 = p2.P47;
            result.P48 = p2.P48;
            result.P49 = p2.P49;
            result.P50 = p2.P50;
            result.P51 = p2.P51;
            result.P52 = p2.P52;
            result.P53 = p2.P53;
            result.P54 = p2.P54;
            result.P55 = p2.P55;
            result.P56 = p2.P56;
            result.P57 = p2.P57;
            result.P58 = p2.P58;
            result.P59 = p2.P59;
            result.P60 = p2.P60;
            result.P61 = p2.P61;
            result.P62 = p2.P62;
            result.P63 = p2.P63;
            result.P64 = p2.P64;
            result.P65 = p2.P65;
            result.P66 = p2.P66;
            result.P67 = p2.P67;
            result.P68 = p2.P68;
            result.P69 = p2.P69;
            result.P70 = p2.P70;
            result.P71 = p2.P71;
            result.P72 = p2.P72;
            result.P73 = p2.P73;
            result.P74 = p2.P74;
            result.P75 = p2.P75;
            result.P76 = p2.P76;
            result.P77 = p2.P77;
            result.P78 = p2.P78;
            result.P79 = p2.P79;
            result.P80 = p2.P80;
            result.P81 = p2.P81;
            result.P82 = p2.P82;
            result.P83 = p2.P83;
            result.P84 = p2.P84;
            result.P85 = p2.P85;
            result.P86 = p2.P86;
            result.P87 = p2.P87;
            result.P88 = p2.P88;
            result.P89 = p2.P89;
            result.P90 = p2.P90;
            result.P91 = p2.P91;
            result.P92 = p2.P92;
            result.P93 = p2.P93;
            result.P94 = p2.P94;
            result.P95 = p2.P95;
            result.P96 = p2.P96;
            result.P97 = p2.P97;
            result.P98 = p2.P98;
            result.P99 = p2.P99;
            result.P100 = p2.P100;
            result.P101 = p2.P101;
            result.P102 = p2.P102;
            result.P103 = p2.P103;
            result.P104 = p2.P104;
            result.P105 = p2.P105;
            result.P106 = p2.P106;
            result.P107 = p2.P107;
            result.P108 = p2.P108;
            result.P109 = p2.P109;
            result.P110 = p2.P110;
            result.P111 = p2.P111;
            result.P112 = p2.P112;
            result.P113 = p2.P113;
            result.P114 = p2.P114;
            result.P115 = p2.P115;
            result.P116 = p2.P116;
            result.P117 = p2.P117;
            result.P118 = p2.P118;
            result.P119 = p2.P119;
            result.P120 = p2.P120;
            result.P121 = p2.P121;
            result.P122 = p2.P122;
            result.P123 = p2.P123;
            result.P124 = p2.P124;
            result.P125 = p2.P125;
            result.P126 = p2.P126;
            result.P127 = p2.P127;
            result.P128 = p2.P128;
            result.P129 = p2.P129;
            result.P130 = p2.P130;
            result.P131 = p2.P131;
            result.P132 = p2.P132;
            result.P133 = p2.P133;
            result.P134 = p2.P134;
            result.P135 = p2.P135;
            result.P136 = p2.P136;
            result.P137 = p2.P137;
            result.P138 = p2.P138;
            result.P139 = p2.P139;
            result.P140 = p2.P140;
            result.P141 = p2.P141;
            result.P142 = p2.P142;
            result.P143 = p2.P143;
            result.P144 = p2.P144;
            result.P145 = p2.P145;
            result.P146 = p2.P146;
            result.P147 = p2.P147;
            result.P148 = p2.P148;
            result.P149 = p2.P149;
            result.P150 = p2.P150;
            result.Op151 = funcMain1(p2.Op151, result.Op151);
            result.Op152 = funcMain2(p2.Op152, result.Op152);
            result.Op153 = funcMain3(p2.Op153, result.Op153);
            result.Op154 = funcMain4(p2.Op154, result.Op154);
            result.Op155 = funcMain5(p2.Op155, result.Op155);
            result.Op156 = funcMain6(p2.Op156, result.Op156);
            result.Op157 = funcMain7(p2.Op157, result.Op157);
            result.Op158 = funcMain8(p2.Op158, result.Op158);
            result.Op159 = funcMain9(p2.Op159, result.Op159);
            result.Op160 = funcMain10(p2.Op160, result.Op160);
            result.Op161 = funcMain11(p2.Op161, result.Op161);
            result.Op162 = funcMain12(p2.Op162, result.Op162);
            result.Op163 = funcMain13(p2.Op163, result.Op163);
            result.Op164 = funcMain14(p2.Op164, result.Op164);
            result.Op165 = funcMain15(p2.Op165, result.Op165);
            result.Op166 = funcMain16(p2.Op166, result.Op166);
            result.Op167 = funcMain17(p2.Op167, result.Op167);
            result.Op168 = funcMain18(p2.Op168, result.Op168);
            result.Op169 = funcMain19(p2.Op169, result.Op169);
            result.Op170 = funcMain20(p2.Op170, result.Op170);
            result.Op171 = funcMain21(p2.Op171, result.Op171);
            result.Op172 = funcMain22(p2.Op172, result.Op172);
            result.Op173 = funcMain23(p2.Op173, result.Op173);
            result.Op174 = funcMain24(p2.Op174, result.Op174);
            result.Op175 = funcMain25(p2.Op175, result.Op175);
            result.Op176 = funcMain26(p2.Op176, result.Op176);
            result.Op177 = funcMain27(p2.Op177, result.Op177);
            result.Op178 = funcMain28(p2.Op178, result.Op178);
            result.Op179 = funcMain29(p2.Op179, result.Op179);
            result.Op180 = funcMain30(p2.Op180, result.Op180);
            result.Op181 = funcMain31(p2.Op181, result.Op181);
            result.Op182 = funcMain32(p2.Op182, result.Op182);
            result.Op183 = funcMain33(p2.Op183, result.Op183);
            result.Op184 = funcMain34(p2.Op184, result.Op184);
            result.Op185 = funcMain35(p2.Op185, result.Op185);
            result.Op186 = funcMain36(p2.Op186, result.Op186);
            result.Op187 = funcMain37(p2.Op187, result.Op187);
            result.Op188 = funcMain38(p2.Op188, result.Op188);
            result.Op189 = funcMain39(p2.Op189, result.Op189);
            result.Op190 = funcMain40(p2.Op190, result.Op190);
            result.Op191 = funcMain41(p2.Op191, result.Op191);
            result.Op192 = funcMain42(p2.Op192, result.Op192);
            result.Op193 = funcMain43(p2.Op193, result.Op193);
            result.Op194 = funcMain44(p2.Op194, result.Op194);
            result.Op195 = funcMain45(p2.Op195, result.Op195);
            result.Op196 = funcMain46(p2.Op196, result.Op196);
            result.Op197 = funcMain47(p2.Op197, result.Op197);
            result.Op198 = funcMain48(p2.Op198, result.Op198);
            result.Op199 = funcMain49(p2.Op199, result.Op199);
            result.Op200 = funcMain50(p2.Op200, result.Op200);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain1(Mappers.Models.Shared.CompositeOption p4, Mappers.Models.Shared.CompositeOption p5)
        {
            if (p4 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p5 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p4.Label;
            result.Value = p4.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p4.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain2(Mappers.Models.Shared.CompositeOption p6, Mappers.Models.Shared.CompositeOption p7)
        {
            if (p6 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p7 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p6.Label;
            result.Value = p6.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p6.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain3(Mappers.Models.Shared.CompositeOption p8, Mappers.Models.Shared.CompositeOption p9)
        {
            if (p8 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p9 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p8.Label;
            result.Value = p8.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p8.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain4(Mappers.Models.Shared.CompositeOption p10, Mappers.Models.Shared.CompositeOption p11)
        {
            if (p10 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p11 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p10.Label;
            result.Value = p10.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p10.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain5(Mappers.Models.Shared.CompositeOption p12, Mappers.Models.Shared.CompositeOption p13)
        {
            if (p12 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p13 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p12.Label;
            result.Value = p12.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p12.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain6(Mappers.Models.Shared.CompositeOption p14, Mappers.Models.Shared.CompositeOption p15)
        {
            if (p14 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p15 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p14.Label;
            result.Value = p14.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p14.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain7(Mappers.Models.Shared.CompositeOption p16, Mappers.Models.Shared.CompositeOption p17)
        {
            if (p16 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p17 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p16.Label;
            result.Value = p16.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p16.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain8(Mappers.Models.Shared.CompositeOption p18, Mappers.Models.Shared.CompositeOption p19)
        {
            if (p18 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p19 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p18.Label;
            result.Value = p18.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p18.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain9(Mappers.Models.Shared.CompositeOption p20, Mappers.Models.Shared.CompositeOption p21)
        {
            if (p20 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p21 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p20.Label;
            result.Value = p20.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p20.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain10(Mappers.Models.Shared.CompositeOption p22, Mappers.Models.Shared.CompositeOption p23)
        {
            if (p22 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p23 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p22.Label;
            result.Value = p22.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p22.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain11(Mappers.Models.Shared.CompositeOption p24, Mappers.Models.Shared.CompositeOption p25)
        {
            if (p24 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p25 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p24.Label;
            result.Value = p24.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p24.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain12(Mappers.Models.Shared.CompositeOption p26, Mappers.Models.Shared.CompositeOption p27)
        {
            if (p26 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p27 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p26.Label;
            result.Value = p26.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p26.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain13(Mappers.Models.Shared.CompositeOption p28, Mappers.Models.Shared.CompositeOption p29)
        {
            if (p28 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p29 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p28.Label;
            result.Value = p28.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p28.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain14(Mappers.Models.Shared.CompositeOption p30, Mappers.Models.Shared.CompositeOption p31)
        {
            if (p30 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p31 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p30.Label;
            result.Value = p30.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p30.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain15(Mappers.Models.Shared.CompositeOption p32, Mappers.Models.Shared.CompositeOption p33)
        {
            if (p32 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p33 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p32.Label;
            result.Value = p32.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p32.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain16(Mappers.Models.Shared.CompositeOption p34, Mappers.Models.Shared.CompositeOption p35)
        {
            if (p34 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p35 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p34.Label;
            result.Value = p34.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p34.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain17(Mappers.Models.Shared.CompositeOption p36, Mappers.Models.Shared.CompositeOption p37)
        {
            if (p36 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p37 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p36.Label;
            result.Value = p36.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p36.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain18(Mappers.Models.Shared.CompositeOption p38, Mappers.Models.Shared.CompositeOption p39)
        {
            if (p38 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p39 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p38.Label;
            result.Value = p38.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p38.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain19(Mappers.Models.Shared.CompositeOption p40, Mappers.Models.Shared.CompositeOption p41)
        {
            if (p40 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p41 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p40.Label;
            result.Value = p40.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p40.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain20(Mappers.Models.Shared.CompositeOption p42, Mappers.Models.Shared.CompositeOption p43)
        {
            if (p42 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p43 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p42.Label;
            result.Value = p42.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p42.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain21(Mappers.Models.Shared.CompositeOption p44, Mappers.Models.Shared.CompositeOption p45)
        {
            if (p44 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p45 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p44.Label;
            result.Value = p44.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p44.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain22(Mappers.Models.Shared.CompositeOption p46, Mappers.Models.Shared.CompositeOption p47)
        {
            if (p46 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p47 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p46.Label;
            result.Value = p46.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p46.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain23(Mappers.Models.Shared.CompositeOption p48, Mappers.Models.Shared.CompositeOption p49)
        {
            if (p48 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p49 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p48.Label;
            result.Value = p48.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p48.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain24(Mappers.Models.Shared.CompositeOption p50, Mappers.Models.Shared.CompositeOption p51)
        {
            if (p50 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p51 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p50.Label;
            result.Value = p50.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p50.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain25(Mappers.Models.Shared.CompositeOption p52, Mappers.Models.Shared.CompositeOption p53)
        {
            if (p52 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p53 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p52.Label;
            result.Value = p52.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p52.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain26(Mappers.Models.Shared.CompositeOption p54, Mappers.Models.Shared.CompositeOption p55)
        {
            if (p54 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p55 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p54.Label;
            result.Value = p54.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p54.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain27(Mappers.Models.Shared.CompositeOption p56, Mappers.Models.Shared.CompositeOption p57)
        {
            if (p56 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p57 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p56.Label;
            result.Value = p56.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p56.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain28(Mappers.Models.Shared.CompositeOption p58, Mappers.Models.Shared.CompositeOption p59)
        {
            if (p58 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p59 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p58.Label;
            result.Value = p58.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p58.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain29(Mappers.Models.Shared.CompositeOption p60, Mappers.Models.Shared.CompositeOption p61)
        {
            if (p60 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p61 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p60.Label;
            result.Value = p60.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p60.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain30(Mappers.Models.Shared.CompositeOption p62, Mappers.Models.Shared.CompositeOption p63)
        {
            if (p62 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p63 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p62.Label;
            result.Value = p62.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p62.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain31(Mappers.Models.Shared.CompositeOption p64, Mappers.Models.Shared.CompositeOption p65)
        {
            if (p64 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p65 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p64.Label;
            result.Value = p64.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p64.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain32(Mappers.Models.Shared.CompositeOption p66, Mappers.Models.Shared.CompositeOption p67)
        {
            if (p66 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p67 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p66.Label;
            result.Value = p66.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p66.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain33(Mappers.Models.Shared.CompositeOption p68, Mappers.Models.Shared.CompositeOption p69)
        {
            if (p68 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p69 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p68.Label;
            result.Value = p68.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p68.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain34(Mappers.Models.Shared.CompositeOption p70, Mappers.Models.Shared.CompositeOption p71)
        {
            if (p70 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p71 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p70.Label;
            result.Value = p70.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p70.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain35(Mappers.Models.Shared.CompositeOption p72, Mappers.Models.Shared.CompositeOption p73)
        {
            if (p72 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p73 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p72.Label;
            result.Value = p72.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p72.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain36(Mappers.Models.Shared.CompositeOption p74, Mappers.Models.Shared.CompositeOption p75)
        {
            if (p74 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p75 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p74.Label;
            result.Value = p74.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p74.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain37(Mappers.Models.Shared.CompositeOption p76, Mappers.Models.Shared.CompositeOption p77)
        {
            if (p76 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p77 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p76.Label;
            result.Value = p76.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p76.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain38(Mappers.Models.Shared.CompositeOption p78, Mappers.Models.Shared.CompositeOption p79)
        {
            if (p78 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p79 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p78.Label;
            result.Value = p78.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p78.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain39(Mappers.Models.Shared.CompositeOption p80, Mappers.Models.Shared.CompositeOption p81)
        {
            if (p80 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p81 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p80.Label;
            result.Value = p80.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p80.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain40(Mappers.Models.Shared.CompositeOption p82, Mappers.Models.Shared.CompositeOption p83)
        {
            if (p82 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p83 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p82.Label;
            result.Value = p82.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p82.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain41(Mappers.Models.Shared.CompositeOption p84, Mappers.Models.Shared.CompositeOption p85)
        {
            if (p84 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p85 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p84.Label;
            result.Value = p84.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p84.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain42(Mappers.Models.Shared.CompositeOption p86, Mappers.Models.Shared.CompositeOption p87)
        {
            if (p86 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p87 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p86.Label;
            result.Value = p86.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p86.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain43(Mappers.Models.Shared.CompositeOption p88, Mappers.Models.Shared.CompositeOption p89)
        {
            if (p88 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p89 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p88.Label;
            result.Value = p88.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p88.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain44(Mappers.Models.Shared.CompositeOption p90, Mappers.Models.Shared.CompositeOption p91)
        {
            if (p90 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p91 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p90.Label;
            result.Value = p90.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p90.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain45(Mappers.Models.Shared.CompositeOption p92, Mappers.Models.Shared.CompositeOption p93)
        {
            if (p92 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p93 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p92.Label;
            result.Value = p92.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p92.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain46(Mappers.Models.Shared.CompositeOption p94, Mappers.Models.Shared.CompositeOption p95)
        {
            if (p94 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p95 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p94.Label;
            result.Value = p94.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p94.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain47(Mappers.Models.Shared.CompositeOption p96, Mappers.Models.Shared.CompositeOption p97)
        {
            if (p96 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p97 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p96.Label;
            result.Value = p96.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p96.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain48(Mappers.Models.Shared.CompositeOption p98, Mappers.Models.Shared.CompositeOption p99)
        {
            if (p98 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p99 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p98.Label;
            result.Value = p98.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p98.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain49(Mappers.Models.Shared.CompositeOption p100, Mappers.Models.Shared.CompositeOption p101)
        {
            if (p100 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p101 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p100.Label;
            result.Value = p100.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p100.NestedOption, result.NestedOption);
            return result;
            
        }
        
        private static Mappers.Models.Shared.CompositeOption funcMain50(Mappers.Models.Shared.CompositeOption p102, Mappers.Models.Shared.CompositeOption p103)
        {
            if (p102 == null)
            {
                return null;
            }
            Mappers.Models.Shared.CompositeOption result = p103 ?? new Mappers.Models.Shared.CompositeOption();
            
            result.Label = p102.Label;
            result.Value = p102.Value;
            result.NestedOption = Mapster.TypeAdapterConfig.GlobalSettings.GetMapToTargetFunction<Mappers.Models.Shared.CompositeOption, Mappers.Models.Shared.CompositeOption>().Invoke(p102.NestedOption, result.NestedOption);
            return result;
            
        }
    }
}