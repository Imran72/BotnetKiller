﻿using System;
using System.Collections.Generic;

namespace PythonRunner
{
    public class Codes
    {
        public static Dictionary<string, string> codes = new Dictionary<string, string> {
            ["nop"] = "00",

            ["move"] = "01",

            ["move/from16"] = "02",

            ["move/16"] = "03",

            ["move-wide"] = "04",

            ["move-wide/from16"] = "05",

            ["move-wide/16"] = "06",

            ["move-object"] = "07",

            ["move-object/from16"] = "08",

            ["move-object/16"] = "09",

            ["move-result"] = "0A",

            ["move-result-wide"] = "0B",

            ["move-result-object"] = "0C",

            ["move-exception"] = "0D",

            ["return-void"] = "0E",

            ["return"] = "0F",

            ["return-wide"] = "10",

            ["return-object"] = "11",

            ["const/4"] = "12",

            ["const/16"] = "13",

            ["const"] = "14",

            ["const/high16"] = "15",

            ["const-wide/16"] = "16",

            ["const-wide/32"] = "17",

            ["const-wide"] = "18",

            ["const-wide/high16"] = "19",

            ["const-string"] = "1A",

            ["const-string-jumbo"] = "1B",

            ["const-class"] = "1C",

            ["monitor-enter"] = "1D",

            ["monitor-exit"] = "1E",

            ["check-cast"] = "1F",

            ["instance-of"] = "20",

            ["array-length"] = "21",

            ["new-instance"] = "22",

            ["new-array"] = "23",

            ["filled-new-array"] = "24",

            ["filled-new-array-range"] = "25",

            ["fill-array-data"] = "26",

            ["throw"] = "27",

            ["goto"] = "28",

            ["goto/16"] = "29",

            ["goto/32"] = "2A",

            ["packed-switch"] = "2B",

            ["sparse-switch"] = "2C",

            ["cmpl-float"] = "2D",

            ["cmpg-float"] = "2E",

            ["cmpl-double"] = "2F",

            ["cmpg-double"] = "30",

            ["cmp-long"] = "31",

            ["if-eq"] = "32",

            ["if-ne"] = "33",

            ["if-lt"] = "34",

            ["if-ge"] = "35",

            ["if-gt"] = "36",

            ["if-le"] = "37",

            ["if-eqz"] = "38",

            ["if-nez"] = "39",

            ["if-ltz"] = "3A",

            ["if-gez"] = "3B",

            ["if-gtz"] = "3C",

            ["if-lez"] = "3D",

            ["unused_3E"] = "3E",

            ["unused_3F"] = "3F",

            ["unused_40"] = "40",

            ["unused_41"] = "41",

            ["unused_42"] = "42",

            ["unused_43"] = "43",

            ["aget"] = "44",

            ["aget-wide"] = "45",

            ["aget-object"] = "46",

            ["aget-boolean"] = "47",

            ["aget-byte"] = "48",

            ["aget-char"] = "49",

            ["aget-short"] = "4A",

            ["aput"] = "4B",

            ["aput-wide"] = "4C",

            ["aput-object"] = "4D",

            ["aput-boolean"] = "4E",

            ["aput-byte"] = "4F",

            ["aput-char"] = "50",

            ["aput-short"] = "51",

            ["iget"] = "52",

            ["iget-wide"] = "53",

            ["iget-object"] = "54",

            ["iget-boolean"] = "55",

            ["iget-byte"] = "56",

            ["iget-char"] = "57",

            ["iget-short"] = "58",

            ["iput"] = "59",

            ["iput-wide"] = "5A",

            ["iput-object"] = "5B",

            ["iput-boolean"] = "5C",

            ["iput-byte"] = "5D",

            ["iput-char"] = "5E",

            ["iput-short"] = "5F",

            ["sget"] = "60",

            ["sget-wide"] = "61",

            ["sget-object"] = "62",

            ["sget-boolean"] = "63",

            ["sget-byte"] = "64",

            ["sget-char"] = "65",

            ["sget-short"] = "66",

            ["sput"] = "67",

            ["sput-wide"] = "68",

            ["sput-object"] = "69",

            ["sput-boolean"] = "6A",

            ["sput-byte"] = "6B",

            ["sput-char"] = "6C",

            ["sput-short"] = "6D",

            ["invoke-virtual"] = "6E",

            ["invoke-super"] = "6F",

            ["invoke-direct"] = "70",

            ["invoke-static"] = "71",

            ["invoke-interface"] = "72",

            ["unused_73"] = "73",

            ["invoke-virtual/range"] = "74",

            ["invoke-super/range"] = "75",

            ["invoke-direct/range"] = "76",

            ["invoke-static/range"] = "77",

            ["invoke-interfacerange"] = "78",

            ["unused_79"] = "79",

            ["unused_7A"] = "7A",

            ["neg-int"] = "7B",

            ["not-int"] = "7C",

            ["neg-long"] = "7D",

            ["not-long"] = "7E",

            ["neg-float"] = "7F",

            ["neg-double"] = "80",

            ["int-to-long"] = "81",

            ["int-to-float"] = "82",

            ["int-to-double"] = "83",

            ["long-to-int"] = "84",

            ["long-to-float"] = "85",

            ["long-to-double"] = "86",

            ["float-to-int"] = "87",

            ["float-to-long"] = "88",

            ["float-to-double"] = "89",

            ["double-to-int"] = "8A",

            ["double-to-long"] = "8B",

            ["double-to-float"] = "8C",

            ["int-to-byte"] = "8D",

            ["int-to-char"] = "8E",

            ["int-to-short"] = "8F",

            ["add-int"] = "90",

            ["sub-int"] = "91",

            ["mul-int"] = "92",

            ["div-int"] = "93",

            ["rem-int"] = "94",

            ["and-int"] = "95",

            ["or-int"] = "96",

            ["xor-int"] = "97",

            ["shl-int"] = "98",

            ["shr-int"] = "99",

            ["ushr-int"] = "9A",

            ["add-long"] = "9B",

            ["sub-long"] = "9C",

            ["mul-long"] = "9D",

            ["div-long"] = "9E",

            ["rem-long"] = "9F",

            ["and-long"] = "A0",

            ["or-long"] = "A1",

            ["xor-long"] = "A2",

            ["shl-long"] = "A3",

            ["shr-long"] = "A4",

            ["ushr-long"] = "A5",

            ["add-float"] = "A6",

            ["sub-float"] = "A7",

            ["mul-float"] = "A8",

            ["div-float"] = "A9",

            ["rem-float"] = "AA",

            ["add-double"] = "AB",

            ["sub-double"] = "AC",

            ["mul-double"] = "AD",

            ["div-double"] = "AE",

            ["rem-double"] = "AF",

            ["add-int/2addr"] = "B0",

            ["sub-int/2addr"] = "B1",

            ["mul-int/2addr"] = "B2",

            ["div-int/2addr"] = "B3",

            ["rem-int/2addr"] = "B4",

            ["and-int/2addr"] = "B5",

            ["or-int/2addr"] = "B6",

            ["xor-int/2addr"] = "B7",

            ["shl-int/2addr"] = "B8",

            ["shr-int/2addr"] = "B9",

            ["ushr-int/2addr"] = "BA",

            ["add-long/2addr"] = "BB",

            ["sub-long/2addr"] = "BC",

            ["mul-long/2addr"] = "BD",

            ["div-long/2addr"] = "BE",

            ["rem-long/2addr"] = "BF",

            ["and-long/2addr"] = "C0",

            ["or-long/2addr"] = "C1",

            ["xor-long/2addr"] = "C2",

            ["shl-long/2addr"] = "C3",

            ["shr-long/2addr"] = "C4",

            ["ushr-long/2addr"] = "C5",

            ["add-float/2addr"] = "C6",

            ["sub-float/2addr"] = "C7",

            ["mul-float/2addr"] = "C8",

            ["div-float/2addr"] = "C9",

            ["rem-float/2addr"] = "CA",

            ["add-double/2addr"] = "CB",

            ["sub-double/2addr"] = "CC",

            ["mul-double/2addr"] = "CD",

            ["div-double/2addr"] = "CE",

            ["rem-double/2addr"] = "CF",

            ["add-int/lit16"] = "D0",

            ["sub-int/lit16"] = "D1",

            ["mul-int/lit16"] = "D2",

            ["div-int/lit16"] = "D3",

            ["rem-int/lit16"] = "D4",

            ["and-int/lit16"] = "D5",

            ["or-int/lit16"] = "D6",

            ["xor-int/lit16"] = "D7",

            ["add-int/lit8"] = "D8",

            ["sub-int/lit8"] = "D9",

            ["mul-int/lit8"] = "DA",

            ["div-int/lit8"] = "DB",

            ["rem-int/lit8"] = "DC",

            ["and-int/lit8"] = "DD",

            ["or-int/lit8"] = "DE",

            ["xor-int/lit8"] = "DF",

            ["shl-int/lit8"] = "E0",

            ["shr-int/lit8"] = "E1",

            ["ushr-int/lit8"] = "E2",

            ["unused_E3"] = "E3",

            ["unused_E4"] = "E4",

            ["unused_E5"] = "E5",

            ["unused_E6"] = "E6",

            ["unused_E7"] = "E7",

            ["unused_E8"] = "E8",

            ["unused_E9"] = "E9",

            ["unused_EA"] = "EA",

            ["unused_EB"] = "EB",

            ["unused_EC"] = "EC",

            ["unused_ED"] = "ED",

            ["execute-inline"] = "EE",

            ["unused_EF"] = "EF",

            ["invoke-direct-empty"] = "F0",

            ["unused_F1"] = "F1",

            ["iget-quick"] = "F2",

            ["iget-wide-quick"] = "F3",

            ["iget-object-quick"] = "F4",

            ["iput-quick"] = "F5",

            ["iput-wide-quick"] = "F6",

            ["iput-object-quick"] = "F7",

            ["invoke-virtual-quick"] = "F8",

            ["invoke-virtual-quick/range"] = "F9",

            ["invoke-super-quick"] = "FA",

            ["invoke-super-quick/range"] = "FB",

            ["unused_FC"] = "FC",

            ["unused_FD"] = "FD",

            ["unused_FE"] = "FE",

            ["unused_FF"] = "FF"
        };

        public static Dictionary<string, int> classes = new Dictionary<string, int>
        {
            ["DroidDream"] = 1,
            ["Sandroid"] = 2,
            ["Rootsmart"] = 3,
            ["Wroba"] = 4,
            ["Nickyspy"] = 5,
            ["Bmaster"] = 6,
            ["NotCompatible"] = 7,
            ["Geinimi"] = 8,
            ["Anserverbot"] = 9,
            ["Zitmo"] = 10,
            ["Pletor"] = 11,
            ["MisoSMS"] = 12,
            ["TigerBot"] = 13,
            ["PJapps"] = 14

        };
    }
}
