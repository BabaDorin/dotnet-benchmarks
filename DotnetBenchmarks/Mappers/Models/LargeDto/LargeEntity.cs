using Mappers.Models.Shared;
using Mapster;
using System;

namespace Mappers.Models.LargeDto
{
    /// <summary>
    ///  Large entity => 200 properties, from which 150 are of type string, other 50 - of type CompositeOption
    /// </summary>
    [AdaptTo(typeof(LargeDto)), GenerateMapper] // <= Used by Mapster for code generation
    public class LargeEntity
    {
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }
        public string P5 { get; set; }
        public string P6 { get; set; }
        public string P7 { get; set; }
        public string P8 { get; set; }

        public string P9 { get; set; }
        public string P10 { get; set; }
        public string P11 { get; set; }
        public string P12 { get; set; }
        public string P13 { get; set; }
        public string P14 { get; set; }
        public string P15 { get; set; }
        public string P16 { get; set; }
        public string P17 { get; set; }
        public string P18 { get; set; }
        public string P19 { get; set; }
        public string P20 { get; set; }
        public string P21 { get; set; }
        public string P22 { get; set; }
        public string P23 { get; set; }
        public string P24 { get; set; }
        public string P25 { get; set; }
        public string P26 { get; set; }
        public string P27 { get; set; }
        public string P28 { get; set; }
        public string P29 { get; set; }
        public string P30 { get; set; }
        public string P31 { get; set; }
        public string P32 { get; set; }
        public string P33 { get; set; }
        public string P34 { get; set; }
        public string P35 { get; set; }
        public string P36 { get; set; }
        public string P37 { get; set; }
        public string P38 { get; set; }
        public string P39 { get; set; }
        public string P40 { get; set; }
        public string P41 { get; set; }
        public string P42 { get; set; }
        public string P43 { get; set; }
        public string P44 { get; set; }
        public string P45 { get; set; }
        public string P46 { get; set; }
        public string P47 { get; set; }
        public string P48 { get; set; }
        public string P49 { get; set; }
        public string P50 { get; set; }
        public string P51 { get; set; }
        public string P52 { get; set; }
        public string P53 { get; set; }
        public string P54 { get; set; }
        public string P55 { get; set; }
        public string P56 { get; set; }
        public string P57 { get; set; }
        public string P58 { get; set; }
        public string P59 { get; set; }
        public string P60 { get; set; }
        public string P61 { get; set; }
        public string P62 { get; set; }
        public string P63 { get; set; }
        public string P64 { get; set; }
        public string P65 { get; set; }
        public string P66 { get; set; }
        public string P67 { get; set; }
        public string P68 { get; set; }
        public string P69 { get; set; }
        public string P70 { get; set; }
        public string P71 { get; set; }
        public string P72 { get; set; }
        public string P73 { get; set; }
        public string P74 { get; set; }
        public string P75 { get; set; }
        public string P76 { get; set; }
        public string P77 { get; set; }
        public string P78 { get; set; }
        public string P79 { get; set; }
        public string P80 { get; set; }
        public string P81 { get; set; }
        public string P82 { get; set; }
        public string P83 { get; set; }
        public string P84 { get; set; }
        public string P85 { get; set; }
        public string P86 { get; set; }
        public string P87 { get; set; }
        public string P88 { get; set; }
        public string P89 { get; set; }
        public string P90 { get; set; }
        public string P91 { get; set; }
        public string P92 { get; set; }
        public string P93 { get; set; }
        public string P94 { get; set; }
        public string P95 { get; set; }
        public string P96 { get; set; }
        public string P97 { get; set; }
        public string P98 { get; set; }
        public string P99 { get; set; }
        public string P100 { get; set; }
        public string P101 { get; set; }
        public string P102 { get; set; }
        public string P103 { get; set; }
        public string P104 { get; set; }
        public string P105 { get; set; }
        public string P106 { get; set; }
        public string P107 { get; set; }
        public string P108 { get; set; }
        public string P109 { get; set; }
        public string P110 { get; set; }
        public string P111 { get; set; }
        public string P112 { get; set; }
        public string P113 { get; set; }
        public string P114 { get; set; }
        public string P115 { get; set; }
        public string P116 { get; set; }
        public string P117 { get; set; }
        public string P118 { get; set; }
        public string P119 { get; set; }
        public string P120 { get; set; }
        public string P121 { get; set; }
        public string P122 { get; set; }
        public string P123 { get; set; }
        public string P124 { get; set; }
        public string P125 { get; set; }
        public string P126 { get; set; }
        public string P127 { get; set; }
        public string P128 { get; set; }
        public string P129 { get; set; }
        public string P130 { get; set; }
        public string P131 { get; set; }
        public string P132 { get; set; }
        public string P133 { get; set; }
        public string P134 { get; set; }
        public string P135 { get; set; }
        public string P136 { get; set; }
        public string P137 { get; set; }
        public string P138 { get; set; }
        public string P139 { get; set; }
        public string P140 { get; set; }
        public string P141 { get; set; }
        public string P142 { get; set; }
        public string P143 { get; set; }
        public string P144 { get; set; }
        public string P145 { get; set; }
        public string P146 { get; set; }
        public string P147 { get; set; }
        public string P148 { get; set; }
        public string P149 { get; set; }
        public string P150 { get; set; }

        public CompositeOption Op151 { get; set; }
        public CompositeOption Op152 { get; set; }
        public CompositeOption Op153 { get; set; }
        public CompositeOption Op154 { get; set; }
        public CompositeOption Op155 { get; set; }
        public CompositeOption Op156 { get; set; }
        public CompositeOption Op157 { get; set; }
        public CompositeOption Op158 { get; set; }
        public CompositeOption Op159 { get; set; }
        public CompositeOption Op160 { get; set; }
        public CompositeOption Op161 { get; set; }
        public CompositeOption Op162 { get; set; }
        public CompositeOption Op163 { get; set; }
        public CompositeOption Op164 { get; set; }
        public CompositeOption Op165 { get; set; }
        public CompositeOption Op166 { get; set; }
        public CompositeOption Op167 { get; set; }
        public CompositeOption Op168 { get; set; }
        public CompositeOption Op169 { get; set; }
        public CompositeOption Op170 { get; set; }
        public CompositeOption Op171 { get; set; }
        public CompositeOption Op172 { get; set; }
        public CompositeOption Op173 { get; set; }
        public CompositeOption Op174 { get; set; }
        public CompositeOption Op175 { get; set; }
        public CompositeOption Op176 { get; set; }
        public CompositeOption Op177 { get; set; }
        public CompositeOption Op178 { get; set; }
        public CompositeOption Op179 { get; set; }
        public CompositeOption Op180 { get; set; }
        public CompositeOption Op181 { get; set; }
        public CompositeOption Op182 { get; set; }
        public CompositeOption Op183 { get; set; }
        public CompositeOption Op184 { get; set; }
        public CompositeOption Op185 { get; set; }
        public CompositeOption Op186 { get; set; }
        public CompositeOption Op187 { get; set; }
        public CompositeOption Op188 { get; set; }
        public CompositeOption Op189 { get; set; }
        public CompositeOption Op190 { get; set; }
        public CompositeOption Op191 { get; set; }
        public CompositeOption Op192 { get; set; }
        public CompositeOption Op193 { get; set; }
        public CompositeOption Op194 { get; set; }
        public CompositeOption Op195 { get; set; }
        public CompositeOption Op196 { get; set; }
        public CompositeOption Op197 { get; set; }
        public CompositeOption Op198 { get; set; }
        public CompositeOption Op199 { get; set; }
        public CompositeOption Op200 { get; set; }
    }
}
