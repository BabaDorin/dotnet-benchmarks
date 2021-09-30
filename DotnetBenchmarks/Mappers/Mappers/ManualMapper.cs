using Mappers.Models;
using System.Collections.Generic;

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
                P0 = entity.P0,
                P1 = entity.P1,
                P2 = entity.P2,
                P3 = entity.P3,
                P4 = entity.P4,
                P7 = entity.P7,
                P8 = entity.P8,
                P9 = entity.P9,
                P10 = entity.P10,
                P11 = entity.P11,
                P14 = entity.P14,
                P15 = entity.P15,
                P16 = entity.P16,
                P17 = entity.P17,
                P18 = entity.P18,
                P21 = entity.P21,
                P22 = entity.P22,
                P23 = entity.P23,
                P24 = entity.P24,
                P25 = entity.P25,
                P28 = entity.P28,
                P29 = entity.P29,
                P30 = entity.P30,
                P31 = entity.P31,
                P32 = entity.P32,
                P35 = entity.P35,
                P36 = entity.P36,
                P37 = entity.P37,
                P38 = entity.P38,
                P39 = entity.P39,
                P42 = entity.P42,
                P43 = entity.P43,
                P44 = entity.P44,
                P45 = entity.P45,
                P46 = entity.P46,
                P49 = entity.P49,
                P50 = entity.P50,
                P51 = entity.P51,
                P52 = entity.P52,
                P53 = entity.P53,
                P56 = entity.P56,
                P57 = entity.P57,
                P58 = entity.P58,
                P59 = entity.P59,
                P60 = entity.P60,
                P63 = entity.P63,
                P64 = entity.P64,
                P65 = entity.P65,
                P66 = entity.P66,
                P67 = entity.P67,
                P70 = entity.P70,
                P71 = entity.P71,
                P72 = entity.P72,
                P73 = entity.P73,
                P74 = entity.P74,
                P77 = entity.P77,
                P78 = entity.P78,
                P79 = entity.P79,
                P80 = entity.P80,
                P81 = entity.P81,
                P84 = entity.P84,
                P85 = entity.P85,
                P86 = entity.P86,
                P87 = entity.P87,
                P88 = entity.P88,
                P91 = entity.P91,
                P92 = entity.P92,
                P93 = entity.P93,
                P94 = entity.P94,
                P95 = entity.P95,
                P98 = entity.P98,
                P99 = entity.P99,
                P100 = entity.P100,
                P101 = entity.P101,
                P102 = entity.P102,
                P105 = entity.P105,
                P106 = entity.P106,
                P107 = entity.P107,
                P108 = entity.P108,
                P109 = entity.P109,
                P112 = entity.P112,
                P113 = entity.P113,
                P114 = entity.P114,
                P115 = entity.P115,
                P116 = entity.P116,
                P119 = entity.P119,
                P120 = entity.P120,
                P121 = entity.P121,
                P122 = entity.P122,
                P123 = entity.P123,
                P126 = entity.P126,
                P127 = entity.P127,
                P128 = entity.P128,
                P129 = entity.P129,
                P130 = entity.P130,
                P133 = entity.P133,
                P134 = entity.P134,
                P135 = entity.P135,
                P136 = entity.P136,
                P137 = entity.P137,
                P140 = entity.P140,
                P141 = entity.P141,
                P142 = entity.P142,
                P143 = entity.P143,
                P144 = entity.P144,
                P147 = entity.P147,
                P148 = entity.P148,
                P149 = entity.P149,
                P150 = entity.P150,
                P151 = entity.P151,
                P154 = entity.P154,
                P155 = entity.P155,
                P156 = entity.P156,
                P157 = entity.P157,
                P158 = entity.P158,
                P161 = entity.P161,
                P162 = entity.P162,
                P163 = entity.P163,
                P164 = entity.P164,
                P165 = entity.P165,
                P168 = entity.P168,
                P169 = entity.P169,
                P170 = entity.P170,
                P171 = entity.P171,
                P172 = entity.P172,
                P175 = entity.P175,
                P176 = entity.P176,
                P177 = entity.P177,
                P178 = entity.P178,
                P179 = entity.P179,
                P182 = entity.P182,
                P183 = entity.P183,
                P184 = entity.P184,
                P185 = entity.P185,
                P186 = entity.P186,
                P189 = entity.P189,
                P190 = entity.P190,
                P191 = entity.P191,
                P192 = entity.P192,
                P193 = entity.P193,
                P196 = entity.P196,
                P197 = entity.P197,
                P198 = entity.P198,
                P199 = entity.P199,
                P200 = entity.P200,
                P203 = entity.P203,
                P204 = entity.P204,
                P205 = entity.P205,
                P206 = entity.P206,
                P207 = entity.P207,
                P210 = entity.P210,
                P211 = entity.P211,
                P212 = entity.P212,
                P213 = entity.P213,
                P214 = entity.P214,
                P217 = entity.P217,
                P218 = entity.P218,
                P219 = entity.P219,
                P220 = entity.P220,
                P221 = entity.P221,
                P224 = entity.P224,
                P225 = entity.P225,
                P226 = entity.P226,
                P227 = entity.P227,
                P228 = entity.P228,
                P231 = entity.P231,
                P232 = entity.P232,
                P233 = entity.P233,
                P234 = entity.P234,
                P235 = entity.P235,
                P238 = entity.P238,
                P239 = entity.P239,
                P240 = entity.P240,
                P241 = entity.P241,
                P242 = entity.P242,
                P245 = entity.P245,
                P246 = entity.P246,
                P247 = entity.P247,
                P248 = entity.P248,
                P249 = entity.P249,
                P252 = entity.P252,
                P253 = entity.P253,
                P254 = entity.P254,
                P255 = entity.P255,
                P256 = entity.P256,
                P259 = entity.P259,
                P260 = entity.P260,
                P261 = entity.P261,
                P262 = entity.P262,
                P263 = entity.P263,
                P266 = entity.P266,
                P267 = entity.P267,
                P268 = entity.P268,
                P269 = entity.P269,
                P270 = entity.P270,
                P273 = entity.P273,
                P274 = entity.P274,
                P275 = entity.P275,
                P276 = entity.P276,
                P277 = entity.P277,
                P280 = entity.P280,
                P281 = entity.P281,
                P282 = entity.P282,
                P283 = entity.P283,
                P284 = entity.P284,
                P287 = entity.P287,
                P288 = entity.P288,
                P289 = entity.P289,
                P290 = entity.P290,
                P291 = entity.P291,
                P294 = entity.P294,
                P295 = entity.P295,
                P296 = entity.P296,
                P297 = entity.P297,
                P298 = entity.P298,
                P301 = entity.P301,
                P302 = entity.P302,
                P303 = entity.P303,
                P304 = entity.P304,
                P305 = entity.P305,
                P308 = entity.P308,
                P309 = entity.P309,
                P310 = entity.P310,
                P311 = entity.P311,
                P312 = entity.P312,
                P315 = entity.P315,
                P316 = entity.P316,
                P317 = entity.P317,
                P318 = entity.P318,
                P319 = entity.P319,
                P322 = entity.P322,
                P323 = entity.P323,
                P324 = entity.P324,
                P325 = entity.P325,
                P326 = entity.P326,
                P329 = entity.P329,
                P330 = entity.P330,
                P331 = entity.P331,
                P332 = entity.P332,
                P333 = entity.P333,
                P336 = entity.P336,
                P337 = entity.P337,
                P338 = entity.P338,
                P339 = entity.P339,
                P340 = entity.P340,
                P343 = entity.P343,
                P344 = entity.P344,
                P345 = entity.P345,
                P346 = entity.P346,
                P347 = entity.P347,
                P350 = entity.P350,
                P351 = entity.P351,
                P352 = entity.P352,
                P353 = entity.P353,
                P354 = entity.P354,
                P357 = entity.P357,
                P358 = entity.P358,
                P359 = entity.P359,
                P360 = entity.P360,
                P361 = entity.P361,
                P364 = entity.P364,
                P365 = entity.P365,
                P366 = entity.P366,
                P367 = entity.P367,
                P368 = entity.P368,
                P371 = entity.P371,
                P372 = entity.P372,
                P373 = entity.P373,
                P374 = entity.P374,
                P375 = entity.P375,
                P378 = entity.P378,
                P379 = entity.P379,
                P380 = entity.P380,
                P381 = entity.P381,
                P382 = entity.P382,
                P385 = entity.P385,
                P386 = entity.P386,
                P387 = entity.P387,
                P388 = entity.P388,
                P389 = entity.P389,
                P392 = entity.P392,
                P393 = entity.P393,
                P394 = entity.P394,
                P395 = entity.P395,
                P396 = entity.P396,
                P399 = entity.P399,
                P400 = entity.P400,
                P401 = entity.P401,
                P402 = entity.P402,
                P403 = entity.P403,
                P406 = entity.P406,
                P407 = entity.P407,
                P408 = entity.P408,
                P409 = entity.P409,
                P410 = entity.P410,
                P413 = entity.P413,
                P414 = entity.P414,
                P415 = entity.P415,
                P416 = entity.P416,
                P417 = entity.P417,
                P420 = entity.P420,
                P421 = entity.P421,
                P422 = entity.P422,
                P423 = entity.P423,
                P424 = entity.P424,
                P427 = entity.P427,
                P428 = entity.P428,
                P429 = entity.P429,
                P430 = entity.P430,
                P431 = entity.P431,
                P434 = entity.P434,
                P435 = entity.P435,
                P436 = entity.P436,
                P437 = entity.P437,
                P438 = entity.P438,
                P441 = entity.P441,
                P442 = entity.P442,
                P443 = entity.P443,
                P444 = entity.P444,
                P445 = entity.P445,
                P448 = entity.P448,
                P449 = entity.P449,
                P450 = entity.P450,
                P451 = entity.P451,
                P452 = entity.P452,
                P455 = entity.P455,
                P456 = entity.P456,
                P457 = entity.P457,
                P458 = entity.P458,
                P459 = entity.P459,
                P462 = entity.P462,
                P463 = entity.P463,
                P464 = entity.P464,
                P465 = entity.P465,
                P466 = entity.P466,
                P469 = entity.P469,
                P470 = entity.P470,
                P471 = entity.P471,
                P472 = entity.P472,
                P473 = entity.P473,
                P476 = entity.P476,
                P477 = entity.P477,
                P478 = entity.P478,
                P479 = entity.P479,
                P480 = entity.P480,
                P483 = entity.P483,
                P484 = entity.P484,
                P485 = entity.P485,
                P486 = entity.P486,
                P487 = entity.P487,
                P490 = entity.P490,
                P491 = entity.P491,
                P492 = entity.P492,
                P493 = entity.P493,
                P494 = entity.P494,
                P497 = entity.P497,
                P498 = entity.P498,
                P499 = entity.P499,
                P500 = entity.P500,
                P501 = entity.P501,
                P504 = entity.P504,
                P505 = entity.P505,
                P506 = entity.P506,
                P507 = entity.P507,
                P508 = entity.P508,
                P511 = entity.P511,
                P512 = entity.P512,
                P513 = entity.P513,
                P514 = entity.P514,
                P515 = entity.P515,
                P518 = entity.P518,
                P519 = entity.P519,
                P520 = entity.P520,
                P521 = entity.P521,
                P522 = entity.P522,
                P525 = entity.P525,
                P526 = entity.P526,
                P527 = entity.P527,
                P528 = entity.P528,
                P529 = entity.P529,
                P532 = entity.P532,
                P533 = entity.P533,
                P534 = entity.P534,
                P535 = entity.P535,
                P536 = entity.P536,
                P539 = entity.P539,
                P540 = entity.P540,
                P541 = entity.P541,
                P542 = entity.P542,
                P543 = entity.P543,
                P546 = entity.P546,
                P547 = entity.P547,
                P548 = entity.P548,
                P549 = entity.P549,
                P550 = entity.P550,
                P553 = entity.P553,
                P554 = entity.P554,
                P555 = entity.P555,
                P556 = entity.P556,
                P557 = entity.P557,
                P560 = entity.P560,
                P561 = entity.P561,
                P562 = entity.P562,
                P563 = entity.P563,
                P564 = entity.P564,
                P567 = entity.P567,
                P568 = entity.P568,
                P569 = entity.P569,
                P570 = entity.P570,
                P571 = entity.P571,
                P574 = entity.P574,
                P575 = entity.P575,
                P576 = entity.P576,
                P577 = entity.P577,
                P578 = entity.P578,
                P581 = entity.P581,
                P582 = entity.P582,
                P583 = entity.P583,
                P584 = entity.P584,
                P585 = entity.P585,
                P588 = entity.P588,
                P589 = entity.P589,
                P590 = entity.P590,
                P591 = entity.P591,
                P592 = entity.P592,
                P595 = entity.P595,
                P596 = entity.P596,
                P597 = entity.P597,
                P598 = entity.P598,
                P599 = entity.P599,
                P602 = entity.P602,
                P603 = entity.P603,
                P604 = entity.P604,
                P605 = entity.P605,
                P606 = entity.P606,
                P609 = entity.P609,
                P610 = entity.P610,
                P611 = entity.P611,
                P612 = entity.P612,
                P613 = entity.P613,
                P616 = entity.P616,
                P617 = entity.P617,
                P618 = entity.P618,
                P619 = entity.P619,
                P620 = entity.P620,
                P623 = entity.P623,
                P624 = entity.P624,
                P625 = entity.P625,
                P626 = entity.P626,
                P627 = entity.P627,
                P630 = entity.P630,
                P631 = entity.P631,
                P632 = entity.P632,
                P633 = entity.P633,
                P634 = entity.P634,
                P637 = entity.P637,
                P638 = entity.P638,
                P639 = entity.P639,
                P640 = entity.P640,
                P641 = entity.P641,
                P644 = entity.P644,
                P645 = entity.P645,
                P646 = entity.P646,
                P647 = entity.P647,
                P648 = entity.P648,
                P651 = entity.P651,
                P652 = entity.P652,
                P653 = entity.P653,
                P654 = entity.P654,
                P655 = entity.P655,
                P658 = entity.P658,
                P659 = entity.P659,
                P660 = entity.P660,
                P661 = entity.P661,
                P662 = entity.P662,
                P665 = entity.P665,
                P666 = entity.P666,
                P667 = entity.P667,
                P668 = entity.P668,
                P669 = entity.P669,
                P672 = entity.P672,
                P673 = entity.P673,
                P674 = entity.P674,
                P675 = entity.P675,
                P676 = entity.P676,
                P679 = entity.P679,
                P680 = entity.P680,
                P681 = entity.P681,
                P682 = entity.P682,
                P683 = entity.P683,
                P686 = entity.P686,
                P687 = entity.P687,
                P688 = entity.P688,
                P689 = entity.P689,
                P690 = entity.P690,
                P693 = entity.P693,
                P694 = entity.P694,
                P695 = entity.P695,
                P696 = entity.P696,
                P697 = entity.P697,
                P700 = entity.P700,
                P701 = entity.P701,
                P702 = entity.P702,
                P703 = entity.P703,
                P704 = entity.P704,
                P707 = entity.P707,
                P708 = entity.P708,
                P709 = entity.P709,
                P710 = entity.P710,
                P711 = entity.P711,
                P714 = entity.P714,
                P715 = entity.P715,
                P716 = entity.P716,
                P717 = entity.P717,
                P718 = entity.P718,
                P721 = entity.P721,
                P722 = entity.P722,
                P723 = entity.P723,
                P724 = entity.P724,
                P725 = entity.P725,
                P728 = entity.P728,
                P729 = entity.P729,
                P730 = entity.P730,
                P731 = entity.P731,
                P732 = entity.P732,
                P735 = entity.P735,
                P736 = entity.P736,
                P737 = entity.P737,
                P738 = entity.P738,
                P739 = entity.P739,
                P742 = entity.P742,
                P743 = entity.P743,
                P744 = entity.P744,
                P745 = entity.P745,
                P746 = entity.P746,
                P749 = entity.P749,
                P750 = entity.P750,
                P751 = entity.P751,
                P752 = entity.P752,
                P753 = entity.P753,
                P756 = entity.P756,
                P757 = entity.P757,
                P758 = entity.P758,
                P759 = entity.P759,
                P760 = entity.P760,
                P763 = entity.P763,
                P764 = entity.P764,
                P765 = entity.P765,
                P766 = entity.P766,
                P767 = entity.P767,
                P770 = entity.P770,
                P771 = entity.P771,
                P772 = entity.P772,
                P773 = entity.P773,
                P774 = entity.P774,
                P777 = entity.P777,
                P778 = entity.P778,
                P779 = entity.P779,
                P780 = entity.P780,
                P781 = entity.P781,
                P784 = entity.P784,
                P785 = entity.P785,
                P786 = entity.P786,
                P787 = entity.P787,
                P788 = entity.P788,
                P791 = entity.P791,
                P792 = entity.P792,
                P793 = entity.P793,
                P794 = entity.P794,
                P795 = entity.P795,
                P798 = entity.P798,
                P799 = entity.P799,
                P800 = entity.P800,
                P801 = entity.P801,
                P802 = entity.P802,
                P805 = entity.P805,
                P806 = entity.P806,
                P807 = entity.P807,
                P808 = entity.P808,
                P809 = entity.P809,
                P812 = entity.P812,
                P813 = entity.P813,
                P814 = entity.P814,
                P815 = entity.P815,
                P816 = entity.P816,
                P819 = entity.P819,
                P820 = entity.P820,
                P821 = entity.P821,
                P822 = entity.P822,
                P823 = entity.P823,
                P826 = entity.P826,
                P827 = entity.P827,
                P828 = entity.P828,
                P829 = entity.P829,
                P830 = entity.P830,
                P833 = entity.P833,
                P834 = entity.P834,
                P835 = entity.P835,
                P836 = entity.P836,
                P837 = entity.P837,
                P840 = entity.P840,
                P841 = entity.P841,
                P842 = entity.P842,
                P843 = entity.P843,
                P844 = entity.P844,
                P847 = entity.P847,
                P848 = entity.P848,
                P849 = entity.P849,
                P850 = entity.P850,
                P851 = entity.P851,
                P854 = entity.P854,
                P855 = entity.P855,
                P856 = entity.P856,
                P857 = entity.P857,
                P858 = entity.P858,
                P861 = entity.P861,
                P862 = entity.P862,
                P863 = entity.P863,
                P864 = entity.P864,
                P865 = entity.P865,
                P868 = entity.P868,
                P869 = entity.P869,
                P870 = entity.P870,
                P871 = entity.P871,
                P872 = entity.P872,
                P875 = entity.P875,
                P876 = entity.P876,
                P877 = entity.P877,
                P878 = entity.P878,
                P879 = entity.P879,
                P882 = entity.P882,
                P883 = entity.P883,
                P884 = entity.P884,
                P885 = entity.P885,
                P886 = entity.P886,
                P889 = entity.P889,
                P890 = entity.P890,
                P891 = entity.P891,
                P892 = entity.P892,
                P893 = entity.P893,
                P896 = entity.P896,
                P897 = entity.P897,
                P898 = entity.P898,
                P899 = entity.P899,
                P900 = entity.P900,
                P903 = entity.P903,
                P904 = entity.P904,
                P905 = entity.P905,
                P906 = entity.P906,
                P907 = entity.P907,
                P910 = entity.P910,
                P911 = entity.P911,
                P912 = entity.P912,
                P913 = entity.P913,
                P914 = entity.P914,
                P917 = entity.P917,
                P918 = entity.P918,
                P919 = entity.P919,
                P920 = entity.P920,
                P921 = entity.P921,
                P924 = entity.P924,
                P925 = entity.P925,
                P926 = entity.P926,
                P927 = entity.P927,
                P928 = entity.P928,
                P931 = entity.P931,
                P932 = entity.P932,
                P933 = entity.P933,
                P934 = entity.P934,
                P935 = entity.P935,
                P938 = entity.P938,
                P939 = entity.P939,
                P940 = entity.P940,
                P941 = entity.P941,
                P942 = entity.P942,
                P945 = entity.P945,
                P946 = entity.P946,
                P947 = entity.P947,
                P948 = entity.P948,
                P949 = entity.P949,
                P952 = entity.P952,
                P953 = entity.P953,
                P954 = entity.P954,
                P955 = entity.P955,
                P956 = entity.P956,
                P959 = entity.P959,
                P960 = entity.P960,
                P961 = entity.P961,
                P962 = entity.P962,
                P963 = entity.P963,
                P966 = entity.P966,
                P967 = entity.P967,
                P968 = entity.P968,
                P969 = entity.P969,
                P970 = entity.P970,
                P973 = entity.P973,
                P974 = entity.P974,
                P975 = entity.P975,
                P976 = entity.P976,
                P977 = entity.P977,
                P980 = entity.P980,
                P981 = entity.P981,
                P982 = entity.P982,
                P983 = entity.P983,
                P984 = entity.P984,
                P987 = entity.P987,
                P988 = entity.P988,
                P989 = entity.P989,
                P990 = entity.P990,
                P991 = entity.P991,
                P994 = entity.P994,
                P995 = entity.P995,
                P996 = entity.P996,
                P997 = entity.P997,
                P998 = entity.P998,
            };
            if (entity.ListProp5 != null)
            {
                dto.ListProp5 = new List<Option>();
                for (int i = 0; i < entity.ListProp5.Count; i++)
                {
                    dto.ListProp5.Add(entity.ListProp5[i].Clone());
                }
                if (entity.ObjProp6 != null)
                {
                    dto.ObjProp6 = entity.ObjProp6.Clone();
                }
            }
            if (entity.ListProp12 != null)
            {
                dto.ListProp12 = new List<Option>();
                for (int i = 0; i < entity.ListProp12.Count; i++)
                {
                    dto.ListProp12.Add(entity.ListProp12[i].Clone());
                }
                if (entity.ObjProp13 != null)
                {
                    dto.ObjProp13 = entity.ObjProp13.Clone();
                }
            }
            if (entity.ListProp19 != null)
            {
                dto.ListProp19 = new List<Option>();
                for (int i = 0; i < entity.ListProp19.Count; i++)
                {
                    dto.ListProp19.Add(entity.ListProp19[i].Clone());
                }
                if (entity.ObjProp20 != null)
                {
                    dto.ObjProp20 = entity.ObjProp20.Clone();
                }
            }
            if (entity.ListProp26 != null)
            {
                dto.ListProp26 = new List<Option>();
                for (int i = 0; i < entity.ListProp26.Count; i++)
                {
                    dto.ListProp26.Add(entity.ListProp26[i].Clone());
                }
                if (entity.ObjProp27 != null)
                {
                    dto.ObjProp27 = entity.ObjProp27.Clone();
                }
            }
            if (entity.ListProp33 != null)
            {
                dto.ListProp33 = new List<Option>();
                for (int i = 0; i < entity.ListProp33.Count; i++)
                {
                    dto.ListProp33.Add(entity.ListProp33[i].Clone());
                }
                if (entity.ObjProp34 != null)
                {
                    dto.ObjProp34 = entity.ObjProp34.Clone();
                }
            }
            if (entity.ListProp40 != null)
            {
                dto.ListProp40 = new List<Option>();
                for (int i = 0; i < entity.ListProp40.Count; i++)
                {
                    dto.ListProp40.Add(entity.ListProp40[i].Clone());
                }
                if (entity.ObjProp41 != null)
                {
                    dto.ObjProp41 = entity.ObjProp41.Clone();
                }
            }
            if (entity.ListProp47 != null)
            {
                dto.ListProp47 = new List<Option>();
                for (int i = 0; i < entity.ListProp47.Count; i++)
                {
                    dto.ListProp47.Add(entity.ListProp47[i].Clone());
                }
                if (entity.ObjProp48 != null)
                {
                    dto.ObjProp48 = entity.ObjProp48.Clone();
                }
            }
            if (entity.ListProp54 != null)
            {
                dto.ListProp54 = new List<Option>();
                for (int i = 0; i < entity.ListProp54.Count; i++)
                {
                    dto.ListProp54.Add(entity.ListProp54[i].Clone());
                }
                if (entity.ObjProp55 != null)
                {
                    dto.ObjProp55 = entity.ObjProp55.Clone();
                }
            }
            if (entity.ListProp61 != null)
            {
                dto.ListProp61 = new List<Option>();
                for (int i = 0; i < entity.ListProp61.Count; i++)
                {
                    dto.ListProp61.Add(entity.ListProp61[i].Clone());
                }
                if (entity.ObjProp62 != null)
                {
                    dto.ObjProp62 = entity.ObjProp62.Clone();
                }
            }
            if (entity.ListProp68 != null)
            {
                dto.ListProp68 = new List<Option>();
                for (int i = 0; i < entity.ListProp68.Count; i++)
                {
                    dto.ListProp68.Add(entity.ListProp68[i].Clone());
                }
                if (entity.ObjProp69 != null)
                {
                    dto.ObjProp69 = entity.ObjProp69.Clone();
                }
            }
            if (entity.ListProp75 != null)
            {
                dto.ListProp75 = new List<Option>();
                for (int i = 0; i < entity.ListProp75.Count; i++)
                {
                    dto.ListProp75.Add(entity.ListProp75[i].Clone());
                }
                if (entity.ObjProp76 != null)
                {
                    dto.ObjProp76 = entity.ObjProp76.Clone();
                }
            }
            if (entity.ListProp82 != null)
            {
                dto.ListProp82 = new List<Option>();
                for (int i = 0; i < entity.ListProp82.Count; i++)
                {
                    dto.ListProp82.Add(entity.ListProp82[i].Clone());
                }
                if (entity.ObjProp83 != null)
                {
                    dto.ObjProp83 = entity.ObjProp83.Clone();
                }
            }
            if (entity.ListProp89 != null)
            {
                dto.ListProp89 = new List<Option>();
                for (int i = 0; i < entity.ListProp89.Count; i++)
                {
                    dto.ListProp89.Add(entity.ListProp89[i].Clone());
                }
                if (entity.ObjProp90 != null)
                {
                    dto.ObjProp90 = entity.ObjProp90.Clone();
                }
            }
            if (entity.ListProp96 != null)
            {
                dto.ListProp96 = new List<Option>();
                for (int i = 0; i < entity.ListProp96.Count; i++)
                {
                    dto.ListProp96.Add(entity.ListProp96[i].Clone());
                }
                if (entity.ObjProp97 != null)
                {
                    dto.ObjProp97 = entity.ObjProp97.Clone();
                }
            }
            if (entity.ListProp103 != null)
            {
                dto.ListProp103 = new List<Option>();
                for (int i = 0; i < entity.ListProp103.Count; i++)
                {
                    dto.ListProp103.Add(entity.ListProp103[i].Clone());
                }
                if (entity.ObjProp104 != null)
                {
                    dto.ObjProp104 = entity.ObjProp104.Clone();
                }
            }
            if (entity.ListProp110 != null)
            {
                dto.ListProp110 = new List<Option>();
                for (int i = 0; i < entity.ListProp110.Count; i++)
                {
                    dto.ListProp110.Add(entity.ListProp110[i].Clone());
                }
                if (entity.ObjProp111 != null)
                {
                    dto.ObjProp111 = entity.ObjProp111.Clone();
                }
            }
            if (entity.ListProp117 != null)
            {
                dto.ListProp117 = new List<Option>();
                for (int i = 0; i < entity.ListProp117.Count; i++)
                {
                    dto.ListProp117.Add(entity.ListProp117[i].Clone());
                }
                if (entity.ObjProp118 != null)
                {
                    dto.ObjProp118 = entity.ObjProp118.Clone();
                }
            }
            if (entity.ListProp124 != null)
            {
                dto.ListProp124 = new List<Option>();
                for (int i = 0; i < entity.ListProp124.Count; i++)
                {
                    dto.ListProp124.Add(entity.ListProp124[i].Clone());
                }
                if (entity.ObjProp125 != null)
                {
                    dto.ObjProp125 = entity.ObjProp125.Clone();
                }
            }
            if (entity.ListProp131 != null)
            {
                dto.ListProp131 = new List<Option>();
                for (int i = 0; i < entity.ListProp131.Count; i++)
                {
                    dto.ListProp131.Add(entity.ListProp131[i].Clone());
                }
                if (entity.ObjProp132 != null)
                {
                    dto.ObjProp132 = entity.ObjProp132.Clone();
                }
            }
            if (entity.ListProp138 != null)
            {
                dto.ListProp138 = new List<Option>();
                for (int i = 0; i < entity.ListProp138.Count; i++)
                {
                    dto.ListProp138.Add(entity.ListProp138[i].Clone());
                }
                if (entity.ObjProp139 != null)
                {
                    dto.ObjProp139 = entity.ObjProp139.Clone();
                }
            }
            if (entity.ListProp145 != null)
            {
                dto.ListProp145 = new List<Option>();
                for (int i = 0; i < entity.ListProp145.Count; i++)
                {
                    dto.ListProp145.Add(entity.ListProp145[i].Clone());
                }
                if (entity.ObjProp146 != null)
                {
                    dto.ObjProp146 = entity.ObjProp146.Clone();
                }
            }
            if (entity.ListProp152 != null)
            {
                dto.ListProp152 = new List<Option>();
                for (int i = 0; i < entity.ListProp152.Count; i++)
                {
                    dto.ListProp152.Add(entity.ListProp152[i].Clone());
                }
                if (entity.ObjProp153 != null)
                {
                    dto.ObjProp153 = entity.ObjProp153.Clone();
                }
            }
            if (entity.ListProp159 != null)
            {
                dto.ListProp159 = new List<Option>();
                for (int i = 0; i < entity.ListProp159.Count; i++)
                {
                    dto.ListProp159.Add(entity.ListProp159[i].Clone());
                }
                if (entity.ObjProp160 != null)
                {
                    dto.ObjProp160 = entity.ObjProp160.Clone();
                }
            }
            if (entity.ListProp166 != null)
            {
                dto.ListProp166 = new List<Option>();
                for (int i = 0; i < entity.ListProp166.Count; i++)
                {
                    dto.ListProp166.Add(entity.ListProp166[i].Clone());
                }
                if (entity.ObjProp167 != null)
                {
                    dto.ObjProp167 = entity.ObjProp167.Clone();
                }
            }
            if (entity.ListProp173 != null)
            {
                dto.ListProp173 = new List<Option>();
                for (int i = 0; i < entity.ListProp173.Count; i++)
                {
                    dto.ListProp173.Add(entity.ListProp173[i].Clone());
                }
                if (entity.ObjProp174 != null)
                {
                    dto.ObjProp174 = entity.ObjProp174.Clone();
                }
            }
            if (entity.ListProp180 != null)
            {
                dto.ListProp180 = new List<Option>();
                for (int i = 0; i < entity.ListProp180.Count; i++)
                {
                    dto.ListProp180.Add(entity.ListProp180[i].Clone());
                }
                if (entity.ObjProp181 != null)
                {
                    dto.ObjProp181 = entity.ObjProp181.Clone();
                }
            }
            if (entity.ListProp187 != null)
            {
                dto.ListProp187 = new List<Option>();
                for (int i = 0; i < entity.ListProp187.Count; i++)
                {
                    dto.ListProp187.Add(entity.ListProp187[i].Clone());
                }
                if (entity.ObjProp188 != null)
                {
                    dto.ObjProp188 = entity.ObjProp188.Clone();
                }
            }
            if (entity.ListProp194 != null)
            {
                dto.ListProp194 = new List<Option>();
                for (int i = 0; i < entity.ListProp194.Count; i++)
                {
                    dto.ListProp194.Add(entity.ListProp194[i].Clone());
                }
                if (entity.ObjProp195 != null)
                {
                    dto.ObjProp195 = entity.ObjProp195.Clone();
                }
            }
            if (entity.ListProp201 != null)
            {
                dto.ListProp201 = new List<Option>();
                for (int i = 0; i < entity.ListProp201.Count; i++)
                {
                    dto.ListProp201.Add(entity.ListProp201[i].Clone());
                }
                if (entity.ObjProp202 != null)
                {
                    dto.ObjProp202 = entity.ObjProp202.Clone();
                }
            }
            if (entity.ListProp208 != null)
            {
                dto.ListProp208 = new List<Option>();
                for (int i = 0; i < entity.ListProp208.Count; i++)
                {
                    dto.ListProp208.Add(entity.ListProp208[i].Clone());
                }
                if (entity.ObjProp209 != null)
                {
                    dto.ObjProp209 = entity.ObjProp209.Clone();
                }
            }
            if (entity.ListProp215 != null)
            {
                dto.ListProp215 = new List<Option>();
                for (int i = 0; i < entity.ListProp215.Count; i++)
                {
                    dto.ListProp215.Add(entity.ListProp215[i].Clone());
                }
                if (entity.ObjProp216 != null)
                {
                    dto.ObjProp216 = entity.ObjProp216.Clone();
                }
            }
            if (entity.ListProp222 != null)
            {
                dto.ListProp222 = new List<Option>();
                for (int i = 0; i < entity.ListProp222.Count; i++)
                {
                    dto.ListProp222.Add(entity.ListProp222[i].Clone());
                }
                if (entity.ObjProp223 != null)
                {
                    dto.ObjProp223 = entity.ObjProp223.Clone();
                }
            }
            if (entity.ListProp229 != null)
            {
                dto.ListProp229 = new List<Option>();
                for (int i = 0; i < entity.ListProp229.Count; i++)
                {
                    dto.ListProp229.Add(entity.ListProp229[i].Clone());
                }
                if (entity.ObjProp230 != null)
                {
                    dto.ObjProp230 = entity.ObjProp230.Clone();
                }
            }
            if (entity.ListProp236 != null)
            {
                dto.ListProp236 = new List<Option>();
                for (int i = 0; i < entity.ListProp236.Count; i++)
                {
                    dto.ListProp236.Add(entity.ListProp236[i].Clone());
                }
                if (entity.ObjProp237 != null)
                {
                    dto.ObjProp237 = entity.ObjProp237.Clone();
                }
            }
            if (entity.ListProp243 != null)
            {
                dto.ListProp243 = new List<Option>();
                for (int i = 0; i < entity.ListProp243.Count; i++)
                {
                    dto.ListProp243.Add(entity.ListProp243[i].Clone());
                }
                if (entity.ObjProp244 != null)
                {
                    dto.ObjProp244 = entity.ObjProp244.Clone();
                }
            }
            if (entity.ListProp250 != null)
            {
                dto.ListProp250 = new List<Option>();
                for (int i = 0; i < entity.ListProp250.Count; i++)
                {
                    dto.ListProp250.Add(entity.ListProp250[i].Clone());
                }
                if (entity.ObjProp251 != null)
                {
                    dto.ObjProp251 = entity.ObjProp251.Clone();
                }
            }
            if (entity.ListProp257 != null)
            {
                dto.ListProp257 = new List<Option>();
                for (int i = 0; i < entity.ListProp257.Count; i++)
                {
                    dto.ListProp257.Add(entity.ListProp257[i].Clone());
                }
                if (entity.ObjProp258 != null)
                {
                    dto.ObjProp258 = entity.ObjProp258.Clone();
                }
            }
            if (entity.ListProp264 != null)
            {
                dto.ListProp264 = new List<Option>();
                for (int i = 0; i < entity.ListProp264.Count; i++)
                {
                    dto.ListProp264.Add(entity.ListProp264[i].Clone());
                }
                if (entity.ObjProp265 != null)
                {
                    dto.ObjProp265 = entity.ObjProp265.Clone();
                }
            }
            if (entity.ListProp271 != null)
            {
                dto.ListProp271 = new List<Option>();
                for (int i = 0; i < entity.ListProp271.Count; i++)
                {
                    dto.ListProp271.Add(entity.ListProp271[i].Clone());
                }
                if (entity.ObjProp272 != null)
                {
                    dto.ObjProp272 = entity.ObjProp272.Clone();
                }
            }
            if (entity.ListProp278 != null)
            {
                dto.ListProp278 = new List<Option>();
                for (int i = 0; i < entity.ListProp278.Count; i++)
                {
                    dto.ListProp278.Add(entity.ListProp278[i].Clone());
                }
                if (entity.ObjProp279 != null)
                {
                    dto.ObjProp279 = entity.ObjProp279.Clone();
                }
            }
            if (entity.ListProp285 != null)
            {
                dto.ListProp285 = new List<Option>();
                for (int i = 0; i < entity.ListProp285.Count; i++)
                {
                    dto.ListProp285.Add(entity.ListProp285[i].Clone());
                }
                if (entity.ObjProp286 != null)
                {
                    dto.ObjProp286 = entity.ObjProp286.Clone();
                }
            }
            if (entity.ListProp292 != null)
            {
                dto.ListProp292 = new List<Option>();
                for (int i = 0; i < entity.ListProp292.Count; i++)
                {
                    dto.ListProp292.Add(entity.ListProp292[i].Clone());
                }
                if (entity.ObjProp293 != null)
                {
                    dto.ObjProp293 = entity.ObjProp293.Clone();
                }
            }
            if (entity.ListProp299 != null)
            {
                dto.ListProp299 = new List<Option>();
                for (int i = 0; i < entity.ListProp299.Count; i++)
                {
                    dto.ListProp299.Add(entity.ListProp299[i].Clone());
                }
                if (entity.ObjProp300 != null)
                {
                    dto.ObjProp300 = entity.ObjProp300.Clone();
                }
            }
            if (entity.ListProp306 != null)
            {
                dto.ListProp306 = new List<Option>();
                for (int i = 0; i < entity.ListProp306.Count; i++)
                {
                    dto.ListProp306.Add(entity.ListProp306[i].Clone());
                }
                if (entity.ObjProp307 != null)
                {
                    dto.ObjProp307 = entity.ObjProp307.Clone();
                }
            }
            if (entity.ListProp313 != null)
            {
                dto.ListProp313 = new List<Option>();
                for (int i = 0; i < entity.ListProp313.Count; i++)
                {
                    dto.ListProp313.Add(entity.ListProp313[i].Clone());
                }
                if (entity.ObjProp314 != null)
                {
                    dto.ObjProp314 = entity.ObjProp314.Clone();
                }
            }
            if (entity.ListProp320 != null)
            {
                dto.ListProp320 = new List<Option>();
                for (int i = 0; i < entity.ListProp320.Count; i++)
                {
                    dto.ListProp320.Add(entity.ListProp320[i].Clone());
                }
                if (entity.ObjProp321 != null)
                {
                    dto.ObjProp321 = entity.ObjProp321.Clone();
                }
            }
            if (entity.ListProp327 != null)
            {
                dto.ListProp327 = new List<Option>();
                for (int i = 0; i < entity.ListProp327.Count; i++)
                {
                    dto.ListProp327.Add(entity.ListProp327[i].Clone());
                }
                if (entity.ObjProp328 != null)
                {
                    dto.ObjProp328 = entity.ObjProp328.Clone();
                }
            }
            if (entity.ListProp334 != null)
            {
                dto.ListProp334 = new List<Option>();
                for (int i = 0; i < entity.ListProp334.Count; i++)
                {
                    dto.ListProp334.Add(entity.ListProp334[i].Clone());
                }
                if (entity.ObjProp335 != null)
                {
                    dto.ObjProp335 = entity.ObjProp335.Clone();
                }
            }
            if (entity.ListProp341 != null)
            {
                dto.ListProp341 = new List<Option>();
                for (int i = 0; i < entity.ListProp341.Count; i++)
                {
                    dto.ListProp341.Add(entity.ListProp341[i].Clone());
                }
                if (entity.ObjProp342 != null)
                {
                    dto.ObjProp342 = entity.ObjProp342.Clone();
                }
            }
            if (entity.ListProp348 != null)
            {
                dto.ListProp348 = new List<Option>();
                for (int i = 0; i < entity.ListProp348.Count; i++)
                {
                    dto.ListProp348.Add(entity.ListProp348[i].Clone());
                }
                if (entity.ObjProp349 != null)
                {
                    dto.ObjProp349 = entity.ObjProp349.Clone();
                }
            }
            if (entity.ListProp355 != null)
            {
                dto.ListProp355 = new List<Option>();
                for (int i = 0; i < entity.ListProp355.Count; i++)
                {
                    dto.ListProp355.Add(entity.ListProp355[i].Clone());
                }
                if (entity.ObjProp356 != null)
                {
                    dto.ObjProp356 = entity.ObjProp356.Clone();
                }
            }
            if (entity.ListProp362 != null)
            {
                dto.ListProp362 = new List<Option>();
                for (int i = 0; i < entity.ListProp362.Count; i++)
                {
                    dto.ListProp362.Add(entity.ListProp362[i].Clone());
                }
                if (entity.ObjProp363 != null)
                {
                    dto.ObjProp363 = entity.ObjProp363.Clone();
                }
            }
            if (entity.ListProp369 != null)
            {
                dto.ListProp369 = new List<Option>();
                for (int i = 0; i < entity.ListProp369.Count; i++)
                {
                    dto.ListProp369.Add(entity.ListProp369[i].Clone());
                }
                if (entity.ObjProp370 != null)
                {
                    dto.ObjProp370 = entity.ObjProp370.Clone();
                }
            }
            if (entity.ListProp376 != null)
            {
                dto.ListProp376 = new List<Option>();
                for (int i = 0; i < entity.ListProp376.Count; i++)
                {
                    dto.ListProp376.Add(entity.ListProp376[i].Clone());
                }
                if (entity.ObjProp377 != null)
                {
                    dto.ObjProp377 = entity.ObjProp377.Clone();
                }
            }
            if (entity.ListProp383 != null)
            {
                dto.ListProp383 = new List<Option>();
                for (int i = 0; i < entity.ListProp383.Count; i++)
                {
                    dto.ListProp383.Add(entity.ListProp383[i].Clone());
                }
                if (entity.ObjProp384 != null)
                {
                    dto.ObjProp384 = entity.ObjProp384.Clone();
                }
            }
            if (entity.ListProp390 != null)
            {
                dto.ListProp390 = new List<Option>();
                for (int i = 0; i < entity.ListProp390.Count; i++)
                {
                    dto.ListProp390.Add(entity.ListProp390[i].Clone());
                }
                if (entity.ObjProp391 != null)
                {
                    dto.ObjProp391 = entity.ObjProp391.Clone();
                }
            }
            if (entity.ListProp397 != null)
            {
                dto.ListProp397 = new List<Option>();
                for (int i = 0; i < entity.ListProp397.Count; i++)
                {
                    dto.ListProp397.Add(entity.ListProp397[i].Clone());
                }
                if (entity.ObjProp398 != null)
                {
                    dto.ObjProp398 = entity.ObjProp398.Clone();
                }
            }
            if (entity.ListProp404 != null)
            {
                dto.ListProp404 = new List<Option>();
                for (int i = 0; i < entity.ListProp404.Count; i++)
                {
                    dto.ListProp404.Add(entity.ListProp404[i].Clone());
                }
                if (entity.ObjProp405 != null)
                {
                    dto.ObjProp405 = entity.ObjProp405.Clone();
                }
            }
            if (entity.ListProp411 != null)
            {
                dto.ListProp411 = new List<Option>();
                for (int i = 0; i < entity.ListProp411.Count; i++)
                {
                    dto.ListProp411.Add(entity.ListProp411[i].Clone());
                }
                if (entity.ObjProp412 != null)
                {
                    dto.ObjProp412 = entity.ObjProp412.Clone();
                }
            }
            if (entity.ListProp418 != null)
            {
                dto.ListProp418 = new List<Option>();
                for (int i = 0; i < entity.ListProp418.Count; i++)
                {
                    dto.ListProp418.Add(entity.ListProp418[i].Clone());
                }
                if (entity.ObjProp419 != null)
                {
                    dto.ObjProp419 = entity.ObjProp419.Clone();
                }
            }
            if (entity.ListProp425 != null)
            {
                dto.ListProp425 = new List<Option>();
                for (int i = 0; i < entity.ListProp425.Count; i++)
                {
                    dto.ListProp425.Add(entity.ListProp425[i].Clone());
                }
                if (entity.ObjProp426 != null)
                {
                    dto.ObjProp426 = entity.ObjProp426.Clone();
                }
            }
            if (entity.ListProp432 != null)
            {
                dto.ListProp432 = new List<Option>();
                for (int i = 0; i < entity.ListProp432.Count; i++)
                {
                    dto.ListProp432.Add(entity.ListProp432[i].Clone());
                }
                if (entity.ObjProp433 != null)
                {
                    dto.ObjProp433 = entity.ObjProp433.Clone();
                }
            }
            if (entity.ListProp439 != null)
            {
                dto.ListProp439 = new List<Option>();
                for (int i = 0; i < entity.ListProp439.Count; i++)
                {
                    dto.ListProp439.Add(entity.ListProp439[i].Clone());
                }
                if (entity.ObjProp440 != null)
                {
                    dto.ObjProp440 = entity.ObjProp440.Clone();
                }
            }
            if (entity.ListProp446 != null)
            {
                dto.ListProp446 = new List<Option>();
                for (int i = 0; i < entity.ListProp446.Count; i++)
                {
                    dto.ListProp446.Add(entity.ListProp446[i].Clone());
                }
                if (entity.ObjProp447 != null)
                {
                    dto.ObjProp447 = entity.ObjProp447.Clone();
                }
            }
            if (entity.ListProp453 != null)
            {
                dto.ListProp453 = new List<Option>();
                for (int i = 0; i < entity.ListProp453.Count; i++)
                {
                    dto.ListProp453.Add(entity.ListProp453[i].Clone());
                }
                if (entity.ObjProp454 != null)
                {
                    dto.ObjProp454 = entity.ObjProp454.Clone();
                }
            }
            if (entity.ListProp460 != null)
            {
                dto.ListProp460 = new List<Option>();
                for (int i = 0; i < entity.ListProp460.Count; i++)
                {
                    dto.ListProp460.Add(entity.ListProp460[i].Clone());
                }
                if (entity.ObjProp461 != null)
                {
                    dto.ObjProp461 = entity.ObjProp461.Clone();
                }
            }
            if (entity.ListProp467 != null)
            {
                dto.ListProp467 = new List<Option>();
                for (int i = 0; i < entity.ListProp467.Count; i++)
                {
                    dto.ListProp467.Add(entity.ListProp467[i].Clone());
                }
                if (entity.ObjProp468 != null)
                {
                    dto.ObjProp468 = entity.ObjProp468.Clone();
                }
            }
            if (entity.ListProp474 != null)
            {
                dto.ListProp474 = new List<Option>();
                for (int i = 0; i < entity.ListProp474.Count; i++)
                {
                    dto.ListProp474.Add(entity.ListProp474[i].Clone());
                }
                if (entity.ObjProp475 != null)
                {
                    dto.ObjProp475 = entity.ObjProp475.Clone();
                }
            }
            if (entity.ListProp481 != null)
            {
                dto.ListProp481 = new List<Option>();
                for (int i = 0; i < entity.ListProp481.Count; i++)
                {
                    dto.ListProp481.Add(entity.ListProp481[i].Clone());
                }
                if (entity.ObjProp482 != null)
                {
                    dto.ObjProp482 = entity.ObjProp482.Clone();
                }
            }
            if (entity.ListProp488 != null)
            {
                dto.ListProp488 = new List<Option>();
                for (int i = 0; i < entity.ListProp488.Count; i++)
                {
                    dto.ListProp488.Add(entity.ListProp488[i].Clone());
                }
                if (entity.ObjProp489 != null)
                {
                    dto.ObjProp489 = entity.ObjProp489.Clone();
                }
            }
            if (entity.ListProp495 != null)
            {
                dto.ListProp495 = new List<Option>();
                for (int i = 0; i < entity.ListProp495.Count; i++)
                {
                    dto.ListProp495.Add(entity.ListProp495[i].Clone());
                }
                if (entity.ObjProp496 != null)
                {
                    dto.ObjProp496 = entity.ObjProp496.Clone();
                }
            }
            if (entity.ListProp502 != null)
            {
                dto.ListProp502 = new List<Option>();
                for (int i = 0; i < entity.ListProp502.Count; i++)
                {
                    dto.ListProp502.Add(entity.ListProp502[i].Clone());
                }
                if (entity.ObjProp503 != null)
                {
                    dto.ObjProp503 = entity.ObjProp503.Clone();
                }
            }
            if (entity.ListProp509 != null)
            {
                dto.ListProp509 = new List<Option>();
                for (int i = 0; i < entity.ListProp509.Count; i++)
                {
                    dto.ListProp509.Add(entity.ListProp509[i].Clone());
                }
                if (entity.ObjProp510 != null)
                {
                    dto.ObjProp510 = entity.ObjProp510.Clone();
                }
            }
            if (entity.ListProp516 != null)
            {
                dto.ListProp516 = new List<Option>();
                for (int i = 0; i < entity.ListProp516.Count; i++)
                {
                    dto.ListProp516.Add(entity.ListProp516[i].Clone());
                }
                if (entity.ObjProp517 != null)
                {
                    dto.ObjProp517 = entity.ObjProp517.Clone();
                }
            }
            if (entity.ListProp523 != null)
            {
                dto.ListProp523 = new List<Option>();
                for (int i = 0; i < entity.ListProp523.Count; i++)
                {
                    dto.ListProp523.Add(entity.ListProp523[i].Clone());
                }
                if (entity.ObjProp524 != null)
                {
                    dto.ObjProp524 = entity.ObjProp524.Clone();
                }
            }
            if (entity.ListProp530 != null)
            {
                dto.ListProp530 = new List<Option>();
                for (int i = 0; i < entity.ListProp530.Count; i++)
                {
                    dto.ListProp530.Add(entity.ListProp530[i].Clone());
                }
                if (entity.ObjProp531 != null)
                {
                    dto.ObjProp531 = entity.ObjProp531.Clone();
                }
            }
            if (entity.ListProp537 != null)
            {
                dto.ListProp537 = new List<Option>();
                for (int i = 0; i < entity.ListProp537.Count; i++)
                {
                    dto.ListProp537.Add(entity.ListProp537[i].Clone());
                }
                if (entity.ObjProp538 != null)
                {
                    dto.ObjProp538 = entity.ObjProp538.Clone();
                }
            }
            if (entity.ListProp544 != null)
            {
                dto.ListProp544 = new List<Option>();
                for (int i = 0; i < entity.ListProp544.Count; i++)
                {
                    dto.ListProp544.Add(entity.ListProp544[i].Clone());
                }
                if (entity.ObjProp545 != null)
                {
                    dto.ObjProp545 = entity.ObjProp545.Clone();
                }
            }
            if (entity.ListProp551 != null)
            {
                dto.ListProp551 = new List<Option>();
                for (int i = 0; i < entity.ListProp551.Count; i++)
                {
                    dto.ListProp551.Add(entity.ListProp551[i].Clone());
                }
                if (entity.ObjProp552 != null)
                {
                    dto.ObjProp552 = entity.ObjProp552.Clone();
                }
            }
            if (entity.ListProp558 != null)
            {
                dto.ListProp558 = new List<Option>();
                for (int i = 0; i < entity.ListProp558.Count; i++)
                {
                    dto.ListProp558.Add(entity.ListProp558[i].Clone());
                }
                if (entity.ObjProp559 != null)
                {
                    dto.ObjProp559 = entity.ObjProp559.Clone();
                }
            }
            if (entity.ListProp565 != null)
            {
                dto.ListProp565 = new List<Option>();
                for (int i = 0; i < entity.ListProp565.Count; i++)
                {
                    dto.ListProp565.Add(entity.ListProp565[i].Clone());
                }
                if (entity.ObjProp566 != null)
                {
                    dto.ObjProp566 = entity.ObjProp566.Clone();
                }
            }
            if (entity.ListProp572 != null)
            {
                dto.ListProp572 = new List<Option>();
                for (int i = 0; i < entity.ListProp572.Count; i++)
                {
                    dto.ListProp572.Add(entity.ListProp572[i].Clone());
                }
                if (entity.ObjProp573 != null)
                {
                    dto.ObjProp573 = entity.ObjProp573.Clone();
                }
            }
            if (entity.ListProp579 != null)
            {
                dto.ListProp579 = new List<Option>();
                for (int i = 0; i < entity.ListProp579.Count; i++)
                {
                    dto.ListProp579.Add(entity.ListProp579[i].Clone());
                }
                if (entity.ObjProp580 != null)
                {
                    dto.ObjProp580 = entity.ObjProp580.Clone();
                }
            }
            if (entity.ListProp586 != null)
            {
                dto.ListProp586 = new List<Option>();
                for (int i = 0; i < entity.ListProp586.Count; i++)
                {
                    dto.ListProp586.Add(entity.ListProp586[i].Clone());
                }
                if (entity.ObjProp587 != null)
                {
                    dto.ObjProp587 = entity.ObjProp587.Clone();
                }
            }
            if (entity.ListProp593 != null)
            {
                dto.ListProp593 = new List<Option>();
                for (int i = 0; i < entity.ListProp593.Count; i++)
                {
                    dto.ListProp593.Add(entity.ListProp593[i].Clone());
                }
                if (entity.ObjProp594 != null)
                {
                    dto.ObjProp594 = entity.ObjProp594.Clone();
                }
            }
            if (entity.ListProp600 != null)
            {
                dto.ListProp600 = new List<Option>();
                for (int i = 0; i < entity.ListProp600.Count; i++)
                {
                    dto.ListProp600.Add(entity.ListProp600[i].Clone());
                }
                if (entity.ObjProp601 != null)
                {
                    dto.ObjProp601 = entity.ObjProp601.Clone();
                }
            }
            if (entity.ListProp607 != null)
            {
                dto.ListProp607 = new List<Option>();
                for (int i = 0; i < entity.ListProp607.Count; i++)
                {
                    dto.ListProp607.Add(entity.ListProp607[i].Clone());
                }
                if (entity.ObjProp608 != null)
                {
                    dto.ObjProp608 = entity.ObjProp608.Clone();
                }
            }
            if (entity.ListProp614 != null)
            {
                dto.ListProp614 = new List<Option>();
                for (int i = 0; i < entity.ListProp614.Count; i++)
                {
                    dto.ListProp614.Add(entity.ListProp614[i].Clone());
                }
                if (entity.ObjProp615 != null)
                {
                    dto.ObjProp615 = entity.ObjProp615.Clone();
                }
            }
            if (entity.ListProp621 != null)
            {
                dto.ListProp621 = new List<Option>();
                for (int i = 0; i < entity.ListProp621.Count; i++)
                {
                    dto.ListProp621.Add(entity.ListProp621[i].Clone());
                }
                if (entity.ObjProp622 != null)
                {
                    dto.ObjProp622 = entity.ObjProp622.Clone();
                }
            }
            if (entity.ListProp628 != null)
            {
                dto.ListProp628 = new List<Option>();
                for (int i = 0; i < entity.ListProp628.Count; i++)
                {
                    dto.ListProp628.Add(entity.ListProp628[i].Clone());
                }
                if (entity.ObjProp629 != null)
                {
                    dto.ObjProp629 = entity.ObjProp629.Clone();
                }
            }
            if (entity.ListProp635 != null)
            {
                dto.ListProp635 = new List<Option>();
                for (int i = 0; i < entity.ListProp635.Count; i++)
                {
                    dto.ListProp635.Add(entity.ListProp635[i].Clone());
                }
                if (entity.ObjProp636 != null)
                {
                    dto.ObjProp636 = entity.ObjProp636.Clone();
                }
            }
            if (entity.ListProp642 != null)
            {
                dto.ListProp642 = new List<Option>();
                for (int i = 0; i < entity.ListProp642.Count; i++)
                {
                    dto.ListProp642.Add(entity.ListProp642[i].Clone());
                }
                if (entity.ObjProp643 != null)
                {
                    dto.ObjProp643 = entity.ObjProp643.Clone();
                }
            }
            if (entity.ListProp649 != null)
            {
                dto.ListProp649 = new List<Option>();
                for (int i = 0; i < entity.ListProp649.Count; i++)
                {
                    dto.ListProp649.Add(entity.ListProp649[i].Clone());
                }
                if (entity.ObjProp650 != null)
                {
                    dto.ObjProp650 = entity.ObjProp650.Clone();
                }
            }
            if (entity.ListProp656 != null)
            {
                dto.ListProp656 = new List<Option>();
                for (int i = 0; i < entity.ListProp656.Count; i++)
                {
                    dto.ListProp656.Add(entity.ListProp656[i].Clone());
                }
                if (entity.ObjProp657 != null)
                {
                    dto.ObjProp657 = entity.ObjProp657.Clone();
                }
            }
            if (entity.ListProp663 != null)
            {
                dto.ListProp663 = new List<Option>();
                for (int i = 0; i < entity.ListProp663.Count; i++)
                {
                    dto.ListProp663.Add(entity.ListProp663[i].Clone());
                }
                if (entity.ObjProp664 != null)
                {
                    dto.ObjProp664 = entity.ObjProp664.Clone();
                }
            }
            if (entity.ListProp670 != null)
            {
                dto.ListProp670 = new List<Option>();
                for (int i = 0; i < entity.ListProp670.Count; i++)
                {
                    dto.ListProp670.Add(entity.ListProp670[i].Clone());
                }
                if (entity.ObjProp671 != null)
                {
                    dto.ObjProp671 = entity.ObjProp671.Clone();
                }
            }
            if (entity.ListProp677 != null)
            {
                dto.ListProp677 = new List<Option>();
                for (int i = 0; i < entity.ListProp677.Count; i++)
                {
                    dto.ListProp677.Add(entity.ListProp677[i].Clone());
                }
                if (entity.ObjProp678 != null)
                {
                    dto.ObjProp678 = entity.ObjProp678.Clone();
                }
            }
            if (entity.ListProp684 != null)
            {
                dto.ListProp684 = new List<Option>();
                for (int i = 0; i < entity.ListProp684.Count; i++)
                {
                    dto.ListProp684.Add(entity.ListProp684[i].Clone());
                }
                if (entity.ObjProp685 != null)
                {
                    dto.ObjProp685 = entity.ObjProp685.Clone();
                }
            }
            if (entity.ListProp691 != null)
            {
                dto.ListProp691 = new List<Option>();
                for (int i = 0; i < entity.ListProp691.Count; i++)
                {
                    dto.ListProp691.Add(entity.ListProp691[i].Clone());
                }
                if (entity.ObjProp692 != null)
                {
                    dto.ObjProp692 = entity.ObjProp692.Clone();
                }
            }
            if (entity.ListProp698 != null)
            {
                dto.ListProp698 = new List<Option>();
                for (int i = 0; i < entity.ListProp698.Count; i++)
                {
                    dto.ListProp698.Add(entity.ListProp698[i].Clone());
                }
                if (entity.ObjProp699 != null)
                {
                    dto.ObjProp699 = entity.ObjProp699.Clone();
                }
            }
            if (entity.ListProp705 != null)
            {
                dto.ListProp705 = new List<Option>();
                for (int i = 0; i < entity.ListProp705.Count; i++)
                {
                    dto.ListProp705.Add(entity.ListProp705[i].Clone());
                }
                if (entity.ObjProp706 != null)
                {
                    dto.ObjProp706 = entity.ObjProp706.Clone();
                }
            }
            if (entity.ListProp712 != null)
            {
                dto.ListProp712 = new List<Option>();
                for (int i = 0; i < entity.ListProp712.Count; i++)
                {
                    dto.ListProp712.Add(entity.ListProp712[i].Clone());
                }
                if (entity.ObjProp713 != null)
                {
                    dto.ObjProp713 = entity.ObjProp713.Clone();
                }
            }
            if (entity.ListProp719 != null)
            {
                dto.ListProp719 = new List<Option>();
                for (int i = 0; i < entity.ListProp719.Count; i++)
                {
                    dto.ListProp719.Add(entity.ListProp719[i].Clone());
                }
                if (entity.ObjProp720 != null)
                {
                    dto.ObjProp720 = entity.ObjProp720.Clone();
                }
            }
            if (entity.ListProp726 != null)
            {
                dto.ListProp726 = new List<Option>();
                for (int i = 0; i < entity.ListProp726.Count; i++)
                {
                    dto.ListProp726.Add(entity.ListProp726[i].Clone());
                }
                if (entity.ObjProp727 != null)
                {
                    dto.ObjProp727 = entity.ObjProp727.Clone();
                }
            }
            if (entity.ListProp733 != null)
            {
                dto.ListProp733 = new List<Option>();
                for (int i = 0; i < entity.ListProp733.Count; i++)
                {
                    dto.ListProp733.Add(entity.ListProp733[i].Clone());
                }
                if (entity.ObjProp734 != null)
                {
                    dto.ObjProp734 = entity.ObjProp734.Clone();
                }
            }
            if (entity.ListProp740 != null)
            {
                dto.ListProp740 = new List<Option>();
                for (int i = 0; i < entity.ListProp740.Count; i++)
                {
                    dto.ListProp740.Add(entity.ListProp740[i].Clone());
                }
                if (entity.ObjProp741 != null)
                {
                    dto.ObjProp741 = entity.ObjProp741.Clone();
                }
            }
            if (entity.ListProp747 != null)
            {
                dto.ListProp747 = new List<Option>();
                for (int i = 0; i < entity.ListProp747.Count; i++)
                {
                    dto.ListProp747.Add(entity.ListProp747[i].Clone());
                }
                if (entity.ObjProp748 != null)
                {
                    dto.ObjProp748 = entity.ObjProp748.Clone();
                }
            }
            if (entity.ListProp754 != null)
            {
                dto.ListProp754 = new List<Option>();
                for (int i = 0; i < entity.ListProp754.Count; i++)
                {
                    dto.ListProp754.Add(entity.ListProp754[i].Clone());
                }
                if (entity.ObjProp755 != null)
                {
                    dto.ObjProp755 = entity.ObjProp755.Clone();
                }
            }
            if (entity.ListProp761 != null)
            {
                dto.ListProp761 = new List<Option>();
                for (int i = 0; i < entity.ListProp761.Count; i++)
                {
                    dto.ListProp761.Add(entity.ListProp761[i].Clone());
                }
                if (entity.ObjProp762 != null)
                {
                    dto.ObjProp762 = entity.ObjProp762.Clone();
                }
            }
            if (entity.ListProp768 != null)
            {
                dto.ListProp768 = new List<Option>();
                for (int i = 0; i < entity.ListProp768.Count; i++)
                {
                    dto.ListProp768.Add(entity.ListProp768[i].Clone());
                }
                if (entity.ObjProp769 != null)
                {
                    dto.ObjProp769 = entity.ObjProp769.Clone();
                }
            }
            if (entity.ListProp775 != null)
            {
                dto.ListProp775 = new List<Option>();
                for (int i = 0; i < entity.ListProp775.Count; i++)
                {
                    dto.ListProp775.Add(entity.ListProp775[i].Clone());
                }
                if (entity.ObjProp776 != null)
                {
                    dto.ObjProp776 = entity.ObjProp776.Clone();
                }
            }
            if (entity.ListProp782 != null)
            {
                dto.ListProp782 = new List<Option>();
                for (int i = 0; i < entity.ListProp782.Count; i++)
                {
                    dto.ListProp782.Add(entity.ListProp782[i].Clone());
                }
                if (entity.ObjProp783 != null)
                {
                    dto.ObjProp783 = entity.ObjProp783.Clone();
                }
            }
            if (entity.ListProp789 != null)
            {
                dto.ListProp789 = new List<Option>();
                for (int i = 0; i < entity.ListProp789.Count; i++)
                {
                    dto.ListProp789.Add(entity.ListProp789[i].Clone());
                }
                if (entity.ObjProp790 != null)
                {
                    dto.ObjProp790 = entity.ObjProp790.Clone();
                }
            }
            if (entity.ListProp796 != null)
            {
                dto.ListProp796 = new List<Option>();
                for (int i = 0; i < entity.ListProp796.Count; i++)
                {
                    dto.ListProp796.Add(entity.ListProp796[i].Clone());
                }
                if (entity.ObjProp797 != null)
                {
                    dto.ObjProp797 = entity.ObjProp797.Clone();
                }
            }
            if (entity.ListProp803 != null)
            {
                dto.ListProp803 = new List<Option>();
                for (int i = 0; i < entity.ListProp803.Count; i++)
                {
                    dto.ListProp803.Add(entity.ListProp803[i].Clone());
                }
                if (entity.ObjProp804 != null)
                {
                    dto.ObjProp804 = entity.ObjProp804.Clone();
                }
            }
            if (entity.ListProp810 != null)
            {
                dto.ListProp810 = new List<Option>();
                for (int i = 0; i < entity.ListProp810.Count; i++)
                {
                    dto.ListProp810.Add(entity.ListProp810[i].Clone());
                }
                if (entity.ObjProp811 != null)
                {
                    dto.ObjProp811 = entity.ObjProp811.Clone();
                }
            }
            if (entity.ListProp817 != null)
            {
                dto.ListProp817 = new List<Option>();
                for (int i = 0; i < entity.ListProp817.Count; i++)
                {
                    dto.ListProp817.Add(entity.ListProp817[i].Clone());
                }
                if (entity.ObjProp818 != null)
                {
                    dto.ObjProp818 = entity.ObjProp818.Clone();
                }
            }
            if (entity.ListProp824 != null)
            {
                dto.ListProp824 = new List<Option>();
                for (int i = 0; i < entity.ListProp824.Count; i++)
                {
                    dto.ListProp824.Add(entity.ListProp824[i].Clone());
                }
                if (entity.ObjProp825 != null)
                {
                    dto.ObjProp825 = entity.ObjProp825.Clone();
                }
            }
            if (entity.ListProp831 != null)
            {
                dto.ListProp831 = new List<Option>();
                for (int i = 0; i < entity.ListProp831.Count; i++)
                {
                    dto.ListProp831.Add(entity.ListProp831[i].Clone());
                }
                if (entity.ObjProp832 != null)
                {
                    dto.ObjProp832 = entity.ObjProp832.Clone();
                }
            }
            if (entity.ListProp838 != null)
            {
                dto.ListProp838 = new List<Option>();
                for (int i = 0; i < entity.ListProp838.Count; i++)
                {
                    dto.ListProp838.Add(entity.ListProp838[i].Clone());
                }
                if (entity.ObjProp839 != null)
                {
                    dto.ObjProp839 = entity.ObjProp839.Clone();
                }
            }
            if (entity.ListProp845 != null)
            {
                dto.ListProp845 = new List<Option>();
                for (int i = 0; i < entity.ListProp845.Count; i++)
                {
                    dto.ListProp845.Add(entity.ListProp845[i].Clone());
                }
                if (entity.ObjProp846 != null)
                {
                    dto.ObjProp846 = entity.ObjProp846.Clone();
                }
            }
            if (entity.ListProp852 != null)
            {
                dto.ListProp852 = new List<Option>();
                for (int i = 0; i < entity.ListProp852.Count; i++)
                {
                    dto.ListProp852.Add(entity.ListProp852[i].Clone());
                }
                if (entity.ObjProp853 != null)
                {
                    dto.ObjProp853 = entity.ObjProp853.Clone();
                }
            }
            if (entity.ListProp859 != null)
            {
                dto.ListProp859 = new List<Option>();
                for (int i = 0; i < entity.ListProp859.Count; i++)
                {
                    dto.ListProp859.Add(entity.ListProp859[i].Clone());
                }
                if (entity.ObjProp860 != null)
                {
                    dto.ObjProp860 = entity.ObjProp860.Clone();
                }
            }
            if (entity.ListProp866 != null)
            {
                dto.ListProp866 = new List<Option>();
                for (int i = 0; i < entity.ListProp866.Count; i++)
                {
                    dto.ListProp866.Add(entity.ListProp866[i].Clone());
                }
                if (entity.ObjProp867 != null)
                {
                    dto.ObjProp867 = entity.ObjProp867.Clone();
                }
            }
            if (entity.ListProp873 != null)
            {
                dto.ListProp873 = new List<Option>();
                for (int i = 0; i < entity.ListProp873.Count; i++)
                {
                    dto.ListProp873.Add(entity.ListProp873[i].Clone());
                }
                if (entity.ObjProp874 != null)
                {
                    dto.ObjProp874 = entity.ObjProp874.Clone();
                }
            }
            if (entity.ListProp880 != null)
            {
                dto.ListProp880 = new List<Option>();
                for (int i = 0; i < entity.ListProp880.Count; i++)
                {
                    dto.ListProp880.Add(entity.ListProp880[i].Clone());
                }
                if (entity.ObjProp881 != null)
                {
                    dto.ObjProp881 = entity.ObjProp881.Clone();
                }
            }
            if (entity.ListProp887 != null)
            {
                dto.ListProp887 = new List<Option>();
                for (int i = 0; i < entity.ListProp887.Count; i++)
                {
                    dto.ListProp887.Add(entity.ListProp887[i].Clone());
                }
                if (entity.ObjProp888 != null)
                {
                    dto.ObjProp888 = entity.ObjProp888.Clone();
                }
            }
            if (entity.ListProp894 != null)
            {
                dto.ListProp894 = new List<Option>();
                for (int i = 0; i < entity.ListProp894.Count; i++)
                {
                    dto.ListProp894.Add(entity.ListProp894[i].Clone());
                }
                if (entity.ObjProp895 != null)
                {
                    dto.ObjProp895 = entity.ObjProp895.Clone();
                }
            }
            if (entity.ListProp901 != null)
            {
                dto.ListProp901 = new List<Option>();
                for (int i = 0; i < entity.ListProp901.Count; i++)
                {
                    dto.ListProp901.Add(entity.ListProp901[i].Clone());
                }
                if (entity.ObjProp902 != null)
                {
                    dto.ObjProp902 = entity.ObjProp902.Clone();
                }
            }
            if (entity.ListProp908 != null)
            {
                dto.ListProp908 = new List<Option>();
                for (int i = 0; i < entity.ListProp908.Count; i++)
                {
                    dto.ListProp908.Add(entity.ListProp908[i].Clone());
                }
                if (entity.ObjProp909 != null)
                {
                    dto.ObjProp909 = entity.ObjProp909.Clone();
                }
            }
            if (entity.ListProp915 != null)
            {
                dto.ListProp915 = new List<Option>();
                for (int i = 0; i < entity.ListProp915.Count; i++)
                {
                    dto.ListProp915.Add(entity.ListProp915[i].Clone());
                }
                if (entity.ObjProp916 != null)
                {
                    dto.ObjProp916 = entity.ObjProp916.Clone();
                }
            }
            if (entity.ListProp922 != null)
            {
                dto.ListProp922 = new List<Option>();
                for (int i = 0; i < entity.ListProp922.Count; i++)
                {
                    dto.ListProp922.Add(entity.ListProp922[i].Clone());
                }
                if (entity.ObjProp923 != null)
                {
                    dto.ObjProp923 = entity.ObjProp923.Clone();
                }
            }
            if (entity.ListProp929 != null)
            {
                dto.ListProp929 = new List<Option>();
                for (int i = 0; i < entity.ListProp929.Count; i++)
                {
                    dto.ListProp929.Add(entity.ListProp929[i].Clone());
                }
                if (entity.ObjProp930 != null)
                {
                    dto.ObjProp930 = entity.ObjProp930.Clone();
                }
            }
            if (entity.ListProp936 != null)
            {
                dto.ListProp936 = new List<Option>();
                for (int i = 0; i < entity.ListProp936.Count; i++)
                {
                    dto.ListProp936.Add(entity.ListProp936[i].Clone());
                }
                if (entity.ObjProp937 != null)
                {
                    dto.ObjProp937 = entity.ObjProp937.Clone();
                }
            }
            if (entity.ListProp943 != null)
            {
                dto.ListProp943 = new List<Option>();
                for (int i = 0; i < entity.ListProp943.Count; i++)
                {
                    dto.ListProp943.Add(entity.ListProp943[i].Clone());
                }
                if (entity.ObjProp944 != null)
                {
                    dto.ObjProp944 = entity.ObjProp944.Clone();
                }
            }
            if (entity.ListProp950 != null)
            {
                dto.ListProp950 = new List<Option>();
                for (int i = 0; i < entity.ListProp950.Count; i++)
                {
                    dto.ListProp950.Add(entity.ListProp950[i].Clone());
                }
                if (entity.ObjProp951 != null)
                {
                    dto.ObjProp951 = entity.ObjProp951.Clone();
                }
            }
            if (entity.ListProp957 != null)
            {
                dto.ListProp957 = new List<Option>();
                for (int i = 0; i < entity.ListProp957.Count; i++)
                {
                    dto.ListProp957.Add(entity.ListProp957[i].Clone());
                }
                if (entity.ObjProp958 != null)
                {
                    dto.ObjProp958 = entity.ObjProp958.Clone();
                }
            }
            if (entity.ListProp964 != null)
            {
                dto.ListProp964 = new List<Option>();
                for (int i = 0; i < entity.ListProp964.Count; i++)
                {
                    dto.ListProp964.Add(entity.ListProp964[i].Clone());
                }
                if (entity.ObjProp965 != null)
                {
                    dto.ObjProp965 = entity.ObjProp965.Clone();
                }
            }
            if (entity.ListProp971 != null)
            {
                dto.ListProp971 = new List<Option>();
                for (int i = 0; i < entity.ListProp971.Count; i++)
                {
                    dto.ListProp971.Add(entity.ListProp971[i].Clone());
                }
                if (entity.ObjProp972 != null)
                {
                    dto.ObjProp972 = entity.ObjProp972.Clone();
                }
            }
            if (entity.ListProp978 != null)
            {
                dto.ListProp978 = new List<Option>();
                for (int i = 0; i < entity.ListProp978.Count; i++)
                {
                    dto.ListProp978.Add(entity.ListProp978[i].Clone());
                }
                if (entity.ObjProp979 != null)
                {
                    dto.ObjProp979 = entity.ObjProp979.Clone();
                }
            }
            if (entity.ListProp985 != null)
            {
                dto.ListProp985 = new List<Option>();
                for (int i = 0; i < entity.ListProp985.Count; i++)
                {
                    dto.ListProp985.Add(entity.ListProp985[i].Clone());
                }
                if (entity.ObjProp986 != null)
                {
                    dto.ObjProp986 = entity.ObjProp986.Clone();
                }
            }
            if (entity.ListProp992 != null)
            {
                dto.ListProp992 = new List<Option>();
                for (int i = 0; i < entity.ListProp992.Count; i++)
                {
                    dto.ListProp992.Add(entity.ListProp992[i].Clone());
                }
                if (entity.ObjProp993 != null)
                {
                    dto.ObjProp993 = entity.ObjProp993.Clone();
                }
            }
            if (entity.ListProp999 != null)
            {
                dto.ListProp999 = new List<Option>();
                for (int i = 0; i < entity.ListProp999.Count; i++)
                {
                    dto.ListProp999.Add(entity.ListProp999[i].Clone());
                }
                if (entity.ObjProp1000 != null)
                {
                    dto.ObjProp1000 = entity.ObjProp1000.Clone();
                }
            }

            return dto;
        }
    }
}
