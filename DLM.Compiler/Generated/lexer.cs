using System;
using DLM.Compiler.Nodes;

namespace DLM.Compiler.Lexing
{
    public class Lexer : SablePP.Tools.Lexing.Lexer
    {
        private const int STATE1 = 0;
        private const int STATE2 = 1;
        private const int STATE3 = 2;
        private const int STATE4 = 3;
        
        public Lexer(System.IO.TextReader input)
            : base(input, STATE1, gotoTable, acceptTable)
        {
        }
        
        protected override SablePP.Tools.Nodes.Token getToken(int tokenIndex, string text, int line, int position)
        {
            switch (tokenIndex)
            {
                case 0: return new TInclude(text, line, position);
                case 1: return new TFile(text, line, position);
                case 2: return new TTime(text, line, position);
                case 3: return new TIntervalUnit(text, line, position);
                case 4: return new TBool(text, line, position);
                case 5: return new TNumber(text, line, position);
                case 6: return new TPrincipall(text, line, position);
                case 7: return new TTypedef(text, line, position);
                case 8: return new TStruct(text, line, position);
                case 9: return new TWhile(text, line, position);
                case 10: return new TIf(text, line, position);
                case 11: return new TElse(text, line, position);
                case 12: return new TReturn(text, line, position);
                case 13: return new TThis(text, line, position);
                case 14: return new TCaller(text, line, position);
                case 15: return new TNull(text, line, position);
                case 16: return new TChar(text, line, position);
                case 17: return new TCharErr(text, line, position);
                case 18: return new TString(text, line, position);
                case 19: return new TStringErr(text, line, position);
                case 20: return new TIdentifier(text, line, position);
                case 21: return new TActsFor(text, line, position);
                case 22: return new TIfActsFor(text, line, position);
                case 23: return new TDeclassifyStart(text, line, position);
                case 24: return new TDeclassifyEnd(text, line, position);
                case 25: return new TFuncAuthStart(text, line, position);
                case 26: return new TFuncAuthEnd(text, line, position);
                case 27: return new TRArrow(text, line, position);
                case 28: return new TLArrow(text, line, position);
                case 29: return new TCompare(text, line, position);
                case 30: return new TAssign(text, line, position);
                case 31: return new TUnderscore(text, line, position);
                case 32: return new THat(text, line, position);
                case 33: return new TPlus(text, line, position);
                case 34: return new TMinus(text, line, position);
                case 35: return new TAsterisk(text, line, position);
                case 36: return new TSlash(text, line, position);
                case 37: return new TPercent(text, line, position);
                case 38: return new TBang(text, line, position);
                case 39: return new TAnd(text, line, position);
                case 40: return new TOr(text, line, position);
                case 41: return new TPeriod(text, line, position);
                case 42: return new TComma(text, line, position);
                case 43: return new TColon(text, line, position);
                case 44: return new TSemicolon(text, line, position);
                case 45: return new TLabelStart(text, line, position);
                case 46: return new TTimeStart(text, line, position);
                case 47: return new TLabelEnd(text, line, position);
                case 48: return new TLPar(text, line, position);
                case 49: return new TRPar(text, line, position);
                case 50: return new TLSqu(text, line, position);
                case 51: return new TRSqu(text, line, position);
                case 52: return new TLCur(text, line, position);
                case 53: return new TRCur(text, line, position);
                case 54: return new TJoin(text, line, position);
                case 55: return new TComment(text, line, position);
                case 56: return new TWhitespace(text, line, position);
                default:
                    throw new ArgumentException("Unknown token index.", "tokenIndex");
            }
        }
        protected override int getNextState(int tokenIndex, int currentState)
        {
            switch (tokenIndex)
            {
                case 0:
                    switch (currentState)
                    {
                        case STATE1: return STATE2;
                        default: return -1;
                    }
                case 1:
                    switch (currentState)
                    {
                        case STATE2: return STATE1;
                        default: return -1;
                    }
                case 45:
                    switch (currentState)
                    {
                        case STATE1: return STATE3;
                        default: return -1;
                    }
                case 46:
                    switch (currentState)
                    {
                        case STATE3: return STATE4;
                        default: return -1;
                    }
                case 47:
                    switch (currentState)
                    {
                        case STATE4: return STATE1;
                        case STATE3: return STATE1;
                        default: return -1;
                    }
                default: return -1;
            }
        }
        
        
        #region Goto Table
        
        
        private static int[][][][] gotoTable = {
            new int[][][] {
                new int[][] {
                    new int[] {9, 9, 1},
                    new int[] {10, 10, 2},
                    new int[] {13, 13, 3},
                    new int[] {32, 32, 4},
                    new int[] {33, 33, 5},
                    new int[] {34, 34, 6},
                    new int[] {35, 35, 7},
                    new int[] {37, 37, 8},
                    new int[] {38, 38, 9},
                    new int[] {39, 39, 10},
                    new int[] {40, 40, 11},
                    new int[] {41, 41, 12},
                    new int[] {42, 42, 13},
                    new int[] {43, 43, 14},
                    new int[] {44, 44, 15},
                    new int[] {45, 45, 16},
                    new int[] {46, 46, 17},
                    new int[] {47, 47, 18},
                    new int[] {48, 57, 19},
                    new int[] {58, 58, 20},
                    new int[] {59, 59, 21},
                    new int[] {60, 60, 22},
                    new int[] {61, 61, 23},
                    new int[] {62, 62, 24},
                    new int[] {63, 63, 25},
                    new int[] {65, 77, 26},
                    new int[] {78, 78, 27},
                    new int[] {79, 90, 26},
                    new int[] {91, 91, 28},
                    new int[] {93, 93, 29},
                    new int[] {94, 94, 30},
                    new int[] {95, 95, 31},
                    new int[] {97, 98, 32},
                    new int[] {99, 99, 33},
                    new int[] {100, 100, 32},
                    new int[] {101, 101, 34},
                    new int[] {102, 102, 35},
                    new int[] {103, 104, 32},
                    new int[] {105, 105, 36},
                    new int[] {106, 111, 32},
                    new int[] {112, 112, 37},
                    new int[] {113, 113, 32},
                    new int[] {114, 114, 38},
                    new int[] {115, 115, 39},
                    new int[] {116, 116, 40},
                    new int[] {117, 118, 32},
                    new int[] {119, 119, 41},
                    new int[] {120, 122, 32},
                    new int[] {123, 123, 42},
                    new int[] {124, 124, 43},
                    new int[] {125, 125, 44},
                    new int[] {8852, 8852, 45},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 46},
                    new int[] {11, 12, 46},
                    new int[] {14, 33, 46},
                    new int[] {34, 34, 47},
                    new int[] {35, 91, 46},
                    new int[] {92, 92, 48},
                    new int[] {93, 65535, 46},
                },
                new int[][] {
                    new int[] {105, 105, 49},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 50},
                },
                new int[][] {
                    new int[] {0, 9, 51},
                    new int[] {11, 12, 51},
                    new int[] {14, 38, 51},
                    new int[] {39, 39, 52},
                    new int[] {40, 91, 51},
                    new int[] {92, 92, 53},
                    new int[] {93, 65535, 51},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 54},
                    new int[] {62, 62, 55},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 56},
                    new int[] {47, 47, 57},
                },
                new int[][] {
                    new int[] {48, 57, 19},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 58},
                    new int[] {60, 60, 59},
                    new int[] {61, 61, 60},
                    new int[] {124, 124, 61},
                },
                new int[][] {
                    new int[] {61, 61, 62},
                },
                new int[][] {
                    new int[] {61, 61, 63},
                    new int[] {62, 62, 64},
                },
                new int[][] {
                    new int[] {62, 62, 65},
                },
                new int[][] {
                    new int[] {48, 57, 66},
                    new int[] {65, 90, 67},
                    new int[] {95, 95, 68},
                    new int[] {97, 122, 69},
                },
                new int[][] {
                    new int[] {48, 57, 66},
                    new int[] {65, 84, 67},
                    new int[] {85, 85, 70},
                    new int[] {86, 90, 67},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 71},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 107, 69},
                    new int[] {108, 108, 72},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 73},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 101, 69},
                    new int[] {102, 102, 74},
                    new int[] {103, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 113, 69},
                    new int[] {114, 114, 75},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 100, 69},
                    new int[] {101, 101, 76},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 115, 69},
                    new int[] {116, 116, 77},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 103, 69},
                    new int[] {104, 104, 78},
                    new int[] {105, 113, 69},
                    new int[] {114, 114, 79},
                    new int[] {115, 120, 69},
                    new int[] {121, 121, 80},
                    new int[] {122, 122, 69},
                },
                new int[][] {
                    new int[] {48, 103, -42},
                    new int[] {104, 104, 81},
                    new int[] {105, 122, 69},
                },
                new int[][] {
                    new int[] {123, 123, 82},
                },
                new int[][] {
                    new int[] {62, 62, 83},
                    new int[] {124, 124, 84},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 85},
                    new int[] {11, 12, 85},
                    new int[] {14, 33, 85},
                    new int[] {34, 34, 86},
                    new int[] {35, 91, 85},
                    new int[] {92, 92, 87},
                    new int[] {93, 65535, 85},
                },
                new int[][] {
                    new int[] {110, 110, 88},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 89},
                    new int[] {11, 12, 89},
                    new int[] {14, 38, 89},
                    new int[] {39, 39, 90},
                    new int[] {40, 91, 89},
                    new int[] {92, 92, 91},
                    new int[] {93, 65535, 89},
                },
                new int[][] {
                    new int[] {62, 62, 92},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 93},
                    new int[] {42, 42, 94},
                    new int[] {43, 65535, 93},
                },
                new int[][] {
                    new int[] {0, 9, 95},
                    new int[] {11, 12, 95},
                    new int[] {14, 65535, 95},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 96},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 97},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 57, 66},
                    new int[] {65, 75, 67},
                    new int[] {76, 76, 98},
                    new int[] {77, 90, 67},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 99},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 114, 69},
                    new int[] {115, 115, 100},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 101},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 104, 69},
                    new int[] {105, 105, 102},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 103},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 104},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 104, -77},
                    new int[] {105, 105, 105},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 116, 69},
                    new int[] {117, 117, 106},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 111, 69},
                    new int[] {112, 112, 107},
                    new int[] {113, 122, 69},
                },
                new int[][] {
                    new int[] {48, 104, -77},
                    new int[] {105, 105, 108},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -50},
                },
                new int[][] {
                    new int[] {99, 99, 109},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -55},
                },
                new int[][] {
                    new int[] {63, 63, 110},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                    new int[] {0, 41, 111},
                    new int[] {42, 42, 94},
                    new int[] {43, 46, 111},
                    new int[] {47, 47, 112},
                    new int[] {48, 65535, 111},
                },
                new int[][] {
                    new int[] {0, 65535, -59},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -72},
                    new int[] {76, 76, 113},
                    new int[] {77, 122, -72},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 114},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 115},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -74},
                    new int[] {115, 115, 116},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 109, 69},
                    new int[] {110, 110, 117},
                    new int[] {111, 122, 69},
                },
                new int[][] {
                    new int[] {48, 116, -81},
                    new int[] {117, 117, 118},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 116, -81},
                    new int[] {117, 117, 119},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -74},
                    new int[] {115, 115, 120},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 121},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 122},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 123},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {108, 108, 124},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 125},
                    new int[] {42, 42, 126},
                    new int[] {43, 65535, 125},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 127},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 128},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 98, 69},
                    new int[] {99, 99, 129},
                    new int[] {100, 122, 69},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 130},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 98, -119},
                    new int[] {99, 99, 131},
                    new int[] {100, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 99, 69},
                    new int[] {100, 100, 132},
                    new int[] {101, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 133},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {117, 117, 134},
                },
                new int[][] {
                    new int[] {0, 65535, -113},
                },
                new int[][] {
                    new int[] {0, 41, 111},
                    new int[] {42, 42, 126},
                    new int[] {43, 65535, -96},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 135},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 104, -77},
                    new int[] {105, 105, 136},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 109, -104},
                    new int[] {110, 110, 137},
                    new int[] {111, 122, 69},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 138},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 139},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {100, 100, 140},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 111, -82},
                    new int[] {112, 112, 141},
                    new int[] {113, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 101, -38},
                    new int[] {102, 102, 142},
                    new int[] {103, 122, 69},
                },
                new int[][] {
                    new int[] {101, 101, 143},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 144},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 145},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
            },
            new int[][][] {
                new int[][] {
                    new int[] {9, 9, 1},
                    new int[] {10, 10, 2},
                    new int[] {13, 13, 3},
                    new int[] {32, 32, 4},
                    new int[] {33, 33, 5},
                    new int[] {34, 34, 6},
                    new int[] {37, 37, 7},
                    new int[] {38, 38, 8},
                    new int[] {39, 39, 9},
                    new int[] {40, 40, 10},
                    new int[] {41, 41, 11},
                    new int[] {42, 42, 12},
                    new int[] {43, 43, 13},
                    new int[] {44, 44, 14},
                    new int[] {45, 45, 15},
                    new int[] {46, 46, 16},
                    new int[] {47, 47, 17},
                    new int[] {48, 57, 18},
                    new int[] {58, 58, 19},
                    new int[] {59, 59, 20},
                    new int[] {60, 60, 21},
                    new int[] {61, 61, 22},
                    new int[] {62, 62, 23},
                    new int[] {63, 63, 24},
                    new int[] {65, 77, 25},
                    new int[] {78, 78, 26},
                    new int[] {79, 90, 25},
                    new int[] {91, 91, 27},
                    new int[] {93, 93, 28},
                    new int[] {94, 94, 29},
                    new int[] {95, 95, 30},
                    new int[] {97, 98, 31},
                    new int[] {99, 99, 32},
                    new int[] {100, 100, 31},
                    new int[] {101, 101, 33},
                    new int[] {102, 102, 34},
                    new int[] {103, 104, 31},
                    new int[] {105, 105, 35},
                    new int[] {106, 111, 31},
                    new int[] {112, 112, 36},
                    new int[] {113, 113, 31},
                    new int[] {114, 114, 37},
                    new int[] {115, 115, 38},
                    new int[] {116, 116, 39},
                    new int[] {117, 118, 31},
                    new int[] {119, 119, 40},
                    new int[] {120, 122, 31},
                    new int[] {123, 123, 41},
                    new int[] {124, 124, 42},
                    new int[] {125, 125, 43},
                    new int[] {8852, 8852, 44},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 45},
                    new int[] {11, 12, 45},
                    new int[] {14, 33, 45},
                    new int[] {34, 34, 46},
                    new int[] {35, 91, 45},
                    new int[] {92, 92, 47},
                    new int[] {93, 65535, 45},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 48},
                },
                new int[][] {
                    new int[] {0, 9, 49},
                    new int[] {11, 12, 49},
                    new int[] {14, 38, 49},
                    new int[] {39, 39, 50},
                    new int[] {40, 91, 49},
                    new int[] {92, 92, 51},
                    new int[] {93, 65535, 49},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 52},
                    new int[] {62, 62, 53},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 54},
                    new int[] {47, 47, 55},
                },
                new int[][] {
                    new int[] {48, 57, 18},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 56},
                    new int[] {45, 45, 57},
                    new int[] {46, 59, 56},
                    new int[] {60, 60, 58},
                    new int[] {61, 61, 59},
                    new int[] {62, 62, 60},
                    new int[] {63, 123, 56},
                    new int[] {124, 124, 61},
                    new int[] {125, 65535, 56},
                },
                new int[][] {
                    new int[] {61, 61, 62},
                },
                new int[][] {
                    new int[] {61, 61, 63},
                    new int[] {62, 62, 64},
                },
                new int[][] {
                    new int[] {62, 62, 65},
                },
                new int[][] {
                    new int[] {48, 57, 66},
                    new int[] {65, 90, 67},
                    new int[] {95, 95, 68},
                    new int[] {97, 122, 69},
                },
                new int[][] {
                    new int[] {48, 57, 66},
                    new int[] {65, 84, 67},
                    new int[] {85, 85, 70},
                    new int[] {86, 90, 67},
                    new int[] {95, 122, -27},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 71},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 107, 69},
                    new int[] {108, 108, 72},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 73},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 101, 69},
                    new int[] {102, 102, 74},
                    new int[] {103, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 113, 69},
                    new int[] {114, 114, 75},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 100, 69},
                    new int[] {101, 101, 76},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 115, 69},
                    new int[] {116, 116, 77},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 103, 69},
                    new int[] {104, 104, 78},
                    new int[] {105, 113, 69},
                    new int[] {114, 114, 79},
                    new int[] {115, 120, 69},
                    new int[] {121, 121, 80},
                    new int[] {122, 122, 69},
                },
                new int[][] {
                    new int[] {48, 103, -41},
                    new int[] {104, 104, 81},
                    new int[] {105, 122, 69},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 82},
                    new int[] {124, 124, 83},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 84},
                    new int[] {11, 12, 84},
                    new int[] {14, 33, 84},
                    new int[] {34, 34, 85},
                    new int[] {35, 91, 84},
                    new int[] {92, 92, 86},
                    new int[] {93, 65535, 84},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 87},
                    new int[] {11, 12, 87},
                    new int[] {14, 38, 87},
                    new int[] {39, 39, 88},
                    new int[] {40, 91, 87},
                    new int[] {92, 92, 89},
                    new int[] {93, 65535, 87},
                },
                new int[][] {
                    new int[] {62, 62, 90},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 91},
                    new int[] {42, 42, 92},
                    new int[] {43, 65535, 91},
                },
                new int[][] {
                    new int[] {0, 9, 93},
                    new int[] {11, 12, 93},
                    new int[] {14, 65535, 93},
                },
                new int[][] {
                    new int[] {0, 61, 56},
                    new int[] {62, 62, 60},
                    new int[] {63, 65535, 56},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                    new int[] {0, 59, 56},
                    new int[] {60, 60, 94},
                    new int[] {61, 61, 56},
                    new int[] {62, 65535, -58},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 95},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 57, 66},
                    new int[] {65, 75, 67},
                    new int[] {76, 76, 96},
                    new int[] {77, 90, 67},
                    new int[] {95, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 97},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 114, 69},
                    new int[] {115, 115, 98},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 99},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 104, 69},
                    new int[] {105, 105, 100},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 115, -40},
                    new int[] {116, 116, 101},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 113, -38},
                    new int[] {114, 114, 102},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 104, -77},
                    new int[] {105, 105, 103},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 116, 69},
                    new int[] {117, 117, 104},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 111, 69},
                    new int[] {112, 112, 105},
                    new int[] {113, 122, 69},
                },
                new int[][] {
                    new int[] {48, 104, -77},
                    new int[] {105, 105, 106},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                    new int[] {0, 65535, -53},
                },
                new int[][] {
                    new int[] {63, 63, 107},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 92},
                    new int[] {43, 46, 108},
                    new int[] {47, 47, 109},
                    new int[] {48, 65535, 108},
                },
                new int[][] {
                    new int[] {0, 65535, -57},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -72},
                    new int[] {76, 76, 110},
                    new int[] {77, 122, -72},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 111},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 112},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -74},
                    new int[] {115, 115, 113},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 109, 69},
                    new int[] {110, 110, 114},
                    new int[] {111, 122, 69},
                },
                new int[][] {
                    new int[] {48, 116, -81},
                    new int[] {117, 117, 115},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 116, -81},
                    new int[] {117, 117, 116},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -74},
                    new int[] {115, 115, 117},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 118},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 119},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 120},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 121},
                    new int[] {42, 42, 122},
                    new int[] {43, 65535, 121},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 123},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 124},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 98, 69},
                    new int[] {99, 99, 125},
                    new int[] {100, 122, 69},
                },
                new int[][] {
                    new int[] {48, 113, -38},
                    new int[] {114, 114, 126},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 98, -116},
                    new int[] {99, 99, 127},
                    new int[] {100, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 99, 69},
                    new int[] {100, 100, 128},
                    new int[] {101, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 129},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {0, 65535, -110},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 122},
                    new int[] {43, 65535, -94},
                },
                new int[][] {
                    new int[] {48, 113, -38},
                    new int[] {114, 114, 130},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 104, -77},
                    new int[] {105, 105, 131},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 109, -102},
                    new int[] {110, 110, 132},
                    new int[] {111, 122, 69},
                },
                new int[][] {
                    new int[] {48, 115, -40},
                    new int[] {116, 116, 133},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 134},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 111, -82},
                    new int[] {112, 112, 135},
                    new int[] {113, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 101, -37},
                    new int[] {102, 102, 136},
                    new int[] {103, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 137},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 138},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
            },
            new int[][][] {
                new int[][] {
                    new int[] {9, 9, 1},
                    new int[] {10, 10, 2},
                    new int[] {13, 13, 3},
                    new int[] {32, 32, 4},
                    new int[] {33, 33, 5},
                    new int[] {34, 34, 6},
                    new int[] {37, 37, 7},
                    new int[] {38, 38, 8},
                    new int[] {39, 39, 9},
                    new int[] {40, 40, 10},
                    new int[] {41, 41, 11},
                    new int[] {42, 42, 12},
                    new int[] {43, 43, 13},
                    new int[] {44, 44, 14},
                    new int[] {45, 45, 15},
                    new int[] {46, 46, 16},
                    new int[] {47, 47, 17},
                    new int[] {48, 57, 18},
                    new int[] {58, 58, 19},
                    new int[] {59, 59, 20},
                    new int[] {60, 60, 21},
                    new int[] {61, 61, 22},
                    new int[] {62, 62, 23},
                    new int[] {63, 63, 24},
                    new int[] {64, 64, 25},
                    new int[] {65, 77, 26},
                    new int[] {78, 78, 27},
                    new int[] {79, 90, 26},
                    new int[] {91, 91, 28},
                    new int[] {93, 93, 29},
                    new int[] {94, 94, 30},
                    new int[] {95, 95, 31},
                    new int[] {97, 98, 32},
                    new int[] {99, 99, 33},
                    new int[] {100, 100, 32},
                    new int[] {101, 101, 34},
                    new int[] {102, 102, 35},
                    new int[] {103, 104, 32},
                    new int[] {105, 105, 36},
                    new int[] {106, 111, 32},
                    new int[] {112, 112, 37},
                    new int[] {113, 113, 32},
                    new int[] {114, 114, 38},
                    new int[] {115, 115, 39},
                    new int[] {116, 116, 40},
                    new int[] {117, 118, 32},
                    new int[] {119, 119, 41},
                    new int[] {120, 122, 32},
                    new int[] {123, 123, 42},
                    new int[] {124, 124, 43},
                    new int[] {125, 125, 44},
                    new int[] {8852, 8852, 45},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 46},
                    new int[] {11, 12, 46},
                    new int[] {14, 33, 46},
                    new int[] {34, 34, 47},
                    new int[] {35, 91, 46},
                    new int[] {92, 92, 48},
                    new int[] {93, 65535, 46},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 49},
                },
                new int[][] {
                    new int[] {0, 9, 50},
                    new int[] {11, 12, 50},
                    new int[] {14, 38, 50},
                    new int[] {39, 39, 51},
                    new int[] {40, 91, 50},
                    new int[] {92, 92, 52},
                    new int[] {93, 65535, 50},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 53},
                    new int[] {62, 62, 54},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 55},
                    new int[] {47, 47, 56},
                },
                new int[][] {
                    new int[] {48, 57, 18},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 57},
                    new int[] {60, 60, 58},
                    new int[] {61, 61, 59},
                    new int[] {124, 124, 60},
                },
                new int[][] {
                    new int[] {61, 61, 61},
                },
                new int[][] {
                    new int[] {61, 61, 62},
                    new int[] {62, 62, 63},
                },
                new int[][] {
                    new int[] {62, 62, 64},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 57, 65},
                    new int[] {65, 90, 66},
                    new int[] {95, 95, 67},
                    new int[] {97, 122, 68},
                },
                new int[][] {
                    new int[] {48, 57, 65},
                    new int[] {65, 84, 66},
                    new int[] {85, 85, 69},
                    new int[] {86, 90, 66},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 70},
                    new int[] {98, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 107, 68},
                    new int[] {108, 108, 71},
                    new int[] {109, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 72},
                    new int[] {98, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 101, 68},
                    new int[] {102, 102, 73},
                    new int[] {103, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 113, 68},
                    new int[] {114, 114, 74},
                    new int[] {115, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 100, 68},
                    new int[] {101, 101, 75},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 115, 68},
                    new int[] {116, 116, 76},
                    new int[] {117, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 103, 68},
                    new int[] {104, 104, 77},
                    new int[] {105, 113, 68},
                    new int[] {114, 114, 78},
                    new int[] {115, 120, 68},
                    new int[] {121, 121, 79},
                    new int[] {122, 122, 68},
                },
                new int[][] {
                    new int[] {48, 103, -42},
                    new int[] {104, 104, 80},
                    new int[] {105, 122, 68},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 81},
                    new int[] {124, 124, 82},
                },
                new int[][] {
                    new int[] {125, 125, 83},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 84},
                    new int[] {11, 12, 84},
                    new int[] {14, 33, 84},
                    new int[] {34, 34, 85},
                    new int[] {35, 91, 84},
                    new int[] {92, 92, 86},
                    new int[] {93, 65535, 84},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 87},
                    new int[] {11, 12, 87},
                    new int[] {14, 38, 87},
                    new int[] {39, 39, 88},
                    new int[] {40, 91, 87},
                    new int[] {92, 92, 89},
                    new int[] {93, 65535, 87},
                },
                new int[][] {
                    new int[] {62, 62, 90},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 91},
                    new int[] {42, 42, 92},
                    new int[] {43, 65535, 91},
                },
                new int[][] {
                    new int[] {0, 9, 93},
                    new int[] {11, 12, 93},
                    new int[] {14, 65535, 93},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 94},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 95},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 57, 65},
                    new int[] {65, 75, 66},
                    new int[] {76, 76, 96},
                    new int[] {77, 90, 66},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 97},
                    new int[] {109, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 114, 68},
                    new int[] {115, 115, 98},
                    new int[] {116, 122, 68},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 99},
                    new int[] {109, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 104, 68},
                    new int[] {105, 105, 100},
                    new int[] {106, 122, 68},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 101},
                    new int[] {117, 122, 68},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 102},
                    new int[] {115, 122, 68},
                },
                new int[][] {
                    new int[] {48, 104, -76},
                    new int[] {105, 105, 103},
                    new int[] {106, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 116, 68},
                    new int[] {117, 117, 104},
                    new int[] {118, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 111, 68},
                    new int[] {112, 112, 105},
                    new int[] {113, 122, 68},
                },
                new int[][] {
                    new int[] {48, 104, -76},
                    new int[] {105, 105, 106},
                    new int[] {106, 122, 68},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -50},
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                    new int[] {0, 65535, -54},
                },
                new int[][] {
                    new int[] {63, 63, 107},
                },
                new int[][] {
                    new int[] {0, 65535, -57},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 92},
                    new int[] {43, 46, 108},
                    new int[] {47, 47, 109},
                    new int[] {48, 65535, 108},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -71},
                    new int[] {76, 76, 110},
                    new int[] {77, 122, -71},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 111},
                    new int[] {109, 122, 68},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 112},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 114, -73},
                    new int[] {115, 115, 113},
                    new int[] {116, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 109, 68},
                    new int[] {110, 110, 114},
                    new int[] {111, 122, 68},
                },
                new int[][] {
                    new int[] {48, 116, -80},
                    new int[] {117, 117, 115},
                    new int[] {118, 122, 68},
                },
                new int[][] {
                    new int[] {48, 116, -80},
                    new int[] {117, 117, 116},
                    new int[] {118, 122, 68},
                },
                new int[][] {
                    new int[] {48, 114, -73},
                    new int[] {115, 115, 117},
                    new int[] {116, 122, 68},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 118},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 119},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 120},
                    new int[] {109, 122, 68},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 121},
                    new int[] {42, 42, 122},
                    new int[] {43, 65535, 121},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 123},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 124},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 98, 68},
                    new int[] {99, 99, 125},
                    new int[] {100, 122, 68},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 126},
                    new int[] {115, 122, 68},
                },
                new int[][] {
                    new int[] {48, 98, -116},
                    new int[] {99, 99, 127},
                    new int[] {100, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 99, 68},
                    new int[] {100, 100, 128},
                    new int[] {101, 122, 68},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 129},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {0, 65535, -110},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 122},
                    new int[] {43, 65535, -94},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 130},
                    new int[] {115, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 104, -76},
                    new int[] {105, 105, 131},
                    new int[] {106, 122, 68},
                },
                new int[][] {
                    new int[] {48, 109, -102},
                    new int[] {110, 110, 132},
                    new int[] {111, 122, 68},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 133},
                    new int[] {117, 122, 68},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 134},
                    new int[] {102, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 111, -81},
                    new int[] {112, 112, 135},
                    new int[] {113, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 101, -38},
                    new int[] {102, 102, 136},
                    new int[] {103, 122, 68},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 137},
                    new int[] {98, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 138},
                    new int[] {109, 122, 68},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
            },
            new int[][][] {
                new int[][] {
                    new int[] {9, 9, 1},
                    new int[] {10, 10, 2},
                    new int[] {13, 13, 3},
                    new int[] {32, 32, 4},
                    new int[] {33, 33, 5},
                    new int[] {34, 34, 6},
                    new int[] {37, 37, 7},
                    new int[] {38, 38, 8},
                    new int[] {39, 39, 9},
                    new int[] {40, 40, 10},
                    new int[] {41, 41, 11},
                    new int[] {42, 42, 12},
                    new int[] {43, 43, 13},
                    new int[] {44, 44, 14},
                    new int[] {45, 45, 15},
                    new int[] {46, 46, 16},
                    new int[] {47, 47, 17},
                    new int[] {48, 57, 18},
                    new int[] {58, 58, 19},
                    new int[] {59, 59, 20},
                    new int[] {60, 60, 21},
                    new int[] {61, 61, 22},
                    new int[] {62, 62, 23},
                    new int[] {63, 63, 24},
                    new int[] {65, 77, 25},
                    new int[] {78, 78, 26},
                    new int[] {79, 90, 25},
                    new int[] {91, 91, 27},
                    new int[] {93, 93, 28},
                    new int[] {94, 94, 29},
                    new int[] {95, 95, 30},
                    new int[] {97, 98, 31},
                    new int[] {99, 99, 32},
                    new int[] {100, 100, 33},
                    new int[] {101, 101, 34},
                    new int[] {102, 102, 35},
                    new int[] {103, 103, 31},
                    new int[] {104, 104, 36},
                    new int[] {105, 105, 37},
                    new int[] {106, 108, 31},
                    new int[] {109, 109, 38},
                    new int[] {110, 111, 31},
                    new int[] {112, 112, 39},
                    new int[] {113, 113, 31},
                    new int[] {114, 114, 40},
                    new int[] {115, 115, 41},
                    new int[] {116, 116, 42},
                    new int[] {117, 118, 31},
                    new int[] {119, 119, 43},
                    new int[] {120, 122, 31},
                    new int[] {123, 123, 44},
                    new int[] {124, 124, 45},
                    new int[] {125, 125, 46},
                    new int[] {8852, 8852, 47},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                    new int[] {9, 32, -2},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 48},
                    new int[] {11, 12, 48},
                    new int[] {14, 33, 48},
                    new int[] {34, 34, 49},
                    new int[] {35, 91, 48},
                    new int[] {92, 92, 50},
                    new int[] {93, 65535, 48},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 51},
                },
                new int[][] {
                    new int[] {0, 9, 52},
                    new int[] {11, 12, 52},
                    new int[] {14, 38, 52},
                    new int[] {39, 39, 53},
                    new int[] {40, 91, 52},
                    new int[] {92, 92, 54},
                    new int[] {93, 65535, 52},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 55},
                    new int[] {62, 62, 56},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 57},
                    new int[] {47, 47, 58},
                },
                new int[][] {
                    new int[] {48, 57, 18},
                    new int[] {58, 58, 59},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 60},
                    new int[] {60, 60, 61},
                    new int[] {61, 61, 62},
                    new int[] {124, 124, 63},
                },
                new int[][] {
                    new int[] {61, 61, 64},
                },
                new int[][] {
                    new int[] {61, 61, 65},
                    new int[] {62, 62, 66},
                },
                new int[][] {
                    new int[] {62, 62, 67},
                },
                new int[][] {
                    new int[] {48, 57, 68},
                    new int[] {65, 90, 69},
                    new int[] {95, 95, 70},
                    new int[] {97, 122, 71},
                },
                new int[][] {
                    new int[] {48, 57, 68},
                    new int[] {65, 84, 69},
                    new int[] {85, 85, 72},
                    new int[] {86, 90, 69},
                    new int[] {95, 122, -27},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 73},
                    new int[] {98, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 107, 71},
                    new int[] {108, 108, 74},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 75},
                    new int[] {98, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 101, 71},
                    new int[] {102, 102, 76},
                    new int[] {103, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 114, 71},
                    new int[] {115, 115, 77},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 113, 71},
                    new int[] {114, 114, 78},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 100, 71},
                    new int[] {101, 101, 79},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 115, 71},
                    new int[] {116, 116, 80},
                    new int[] {117, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 103, 71},
                    new int[] {104, 104, 81},
                    new int[] {105, 113, 71},
                    new int[] {114, 114, 82},
                    new int[] {115, 120, 71},
                    new int[] {121, 121, 83},
                    new int[] {122, 122, 71},
                },
                new int[][] {
                    new int[] {48, 103, -44},
                    new int[] {104, 104, 84},
                    new int[] {105, 122, 71},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 85},
                    new int[] {124, 124, 86},
                },
                new int[][] {
                    new int[] {125, 125, 87},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 88},
                    new int[] {11, 12, 88},
                    new int[] {14, 33, 88},
                    new int[] {34, 34, 89},
                    new int[] {35, 91, 88},
                    new int[] {92, 92, 90},
                    new int[] {93, 65535, 88},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 91},
                    new int[] {11, 12, 91},
                    new int[] {14, 38, 91},
                    new int[] {39, 39, 92},
                    new int[] {40, 91, 91},
                    new int[] {92, 92, 93},
                    new int[] {93, 65535, 91},
                },
                new int[][] {
                    new int[] {62, 62, 94},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 95},
                    new int[] {42, 42, 96},
                    new int[] {43, 65535, 95},
                },
                new int[][] {
                    new int[] {0, 9, 97},
                    new int[] {11, 12, 97},
                    new int[] {14, 65535, 97},
                },
                new int[][] {
                    new int[] {48, 57, 98},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 99},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 100},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 57, 68},
                    new int[] {65, 75, 69},
                    new int[] {76, 76, 101},
                    new int[] {77, 90, 69},
                    new int[] {95, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 102},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 114, -40},
                    new int[] {115, 115, 103},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 104},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 104, 71},
                    new int[] {105, 105, 105},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                    new int[] {48, 115, -43},
                    new int[] {116, 116, 106},
                    new int[] {117, 122, 71},
                },
                new int[][] {
                    new int[] {48, 113, -41},
                    new int[] {114, 114, 107},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 104, -80},
                    new int[] {105, 105, 108},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 116, 71},
                    new int[] {117, 117, 109},
                    new int[] {118, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 111, 71},
                    new int[] {112, 112, 110},
                    new int[] {113, 122, 71},
                },
                new int[][] {
                    new int[] {48, 104, -80},
                    new int[] {105, 105, 111},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 65535, -52},
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                    new int[] {0, 65535, -11},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                    new int[] {63, 63, 112},
                },
                new int[][] {
                    new int[] {0, 65535, -59},
                },
                new int[][] {
                    new int[] {0, 41, 113},
                    new int[] {42, 42, 96},
                    new int[] {43, 46, 113},
                    new int[] {47, 47, 114},
                    new int[] {48, 65535, 113},
                },
                new int[][] {
                    new int[] {0, 65535, -60},
                },
                new int[][] {
                    new int[] {48, 57, 98},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -74},
                    new int[] {76, 76, 115},
                    new int[] {77, 122, -74},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 116},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 117},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 114, -40},
                    new int[] {115, 115, 118},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 109, 71},
                    new int[] {110, 110, 119},
                    new int[] {111, 122, 71},
                },
                new int[][] {
                    new int[] {48, 116, -84},
                    new int[] {117, 117, 120},
                    new int[] {118, 122, 71},
                },
                new int[][] {
                    new int[] {48, 116, -84},
                    new int[] {117, 117, 121},
                    new int[] {118, 122, 71},
                },
                new int[][] {
                    new int[] {48, 114, -40},
                    new int[] {115, 115, 122},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 123},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 124},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 125},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 126},
                    new int[] {42, 42, 127},
                    new int[] {43, 65535, 126},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 128},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 129},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 98, 71},
                    new int[] {99, 99, 130},
                    new int[] {100, 122, 71},
                },
                new int[][] {
                    new int[] {48, 113, -41},
                    new int[] {114, 114, 131},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 98, -121},
                    new int[] {99, 99, 132},
                    new int[] {100, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 99, 71},
                    new int[] {100, 100, 133},
                    new int[] {101, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 134},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {0, 65535, -115},
                },
                new int[][] {
                    new int[] {0, 41, 113},
                    new int[] {42, 42, 127},
                    new int[] {43, 65535, -98},
                },
                new int[][] {
                    new int[] {48, 113, -41},
                    new int[] {114, 114, 135},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 104, -80},
                    new int[] {105, 105, 136},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                    new int[] {48, 109, -107},
                    new int[] {110, 110, 137},
                    new int[] {111, 122, 71},
                },
                new int[][] {
                    new int[] {48, 115, -43},
                    new int[] {116, 116, 138},
                    new int[] {117, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 139},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 111, -85},
                    new int[] {112, 112, 140},
                    new int[] {113, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 101, -39},
                    new int[] {102, 102, 141},
                    new int[] {103, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 142},
                    new int[] {98, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 143},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
            },
        };
        
        
        #endregion
        
        
        
        #region Accept Table
        
        
        private static int[][] acceptTable = {
            new int[] {
                -1, 56, 56, 56, 56, 38, 19, -1, 37, -1, 17, 48, 49, 35, 33, 42,
                34, 41, 36, 5, 43, 44, 29, 30, 29, -1, 20, 20, 50, 51, 32, 31,
                20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 52, -1, 53, 54, 19, 18,
                19, -1, 39, 17, 16, 17, -1, 27, -1, 55, 28, -1, 29, 23, 29, 29,
                -1, 22, 20, 20, 20, 20, 20, 20, 20, 20, 10, 20, 20, 20, 20, 20,
                20, 20, 45, 24, 40, 19, 18, 19, -1, 17, 16, 17, 21, -1, -1, 55,
                25, 26, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, -1, 22, -1,
                55, 15, 20, 11, 20, 20, 20, 20, 13, 4, 20, 20, -1, -1, -1, 20,
                4, 20, 20, 20, 20, 9, -1, 14, 20, 12, 8, 20, -1, 20, 7, 0,
                20, 6,
            },
            new int[] {
                -1, 56, 56, 56, 56, 38, 19, 37, -1, 17, 48, 49, 35, 33, 42, 34,
                41, 36, 5, 43, 44, 29, 30, 29, -1, 20, 20, 50, 51, 32, 31, 20,
                20, 20, 20, 20, 20, 20, 20, 20, 20, 52, -1, 53, 54, 19, 18, 19,
                39, 17, 16, 17, -1, 27, -1, 55, -1, 28, -1, 29, 1, 23, 29, 29,
                -1, 22, 20, 20, 20, 20, 20, 20, 20, 20, 10, 20, 20, 20, 20, 20,
                20, 20, 24, 40, 19, 18, 19, 17, 16, 17, 21, -1, -1, 55, 25, 26,
                20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 22, -1, 55, 15, 20,
                11, 20, 20, 20, 20, 13, 4, 20, 20, -1, -1, 20, 4, 20, 20, 20,
                20, 9, 14, 20, 12, 8, 20, 20, 7, 20, 6,
            },
            new int[] {
                -1, 56, 56, 56, 56, 38, 19, 37, -1, 17, 48, 49, 35, 33, 42, 34,
                41, 36, 5, 43, 44, 29, 30, 29, -1, 46, 20, 20, 50, 51, 32, 31,
                20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 52, -1, 53, 54, 19, 18,
                19, 39, 17, 16, 17, -1, 27, -1, 55, 28, -1, 29, 23, 29, 29, -1,
                22, 20, 20, 20, 20, 20, 20, 20, 20, 10, 20, 20, 20, 20, 20, 20,
                20, 24, 40, 47, 19, 18, 19, 17, 16, 17, 21, -1, -1, 55, 25, 26,
                20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 22, -1, 55, 15, 20,
                11, 20, 20, 20, 20, 13, 4, 20, 20, -1, -1, 20, 4, 20, 20, 20,
                20, 9, 14, 20, 12, 8, 20, 20, 7, 20, 6,
            },
            new int[] {
                -1, 56, 56, 56, 56, 38, 19, 37, -1, 17, 48, 49, 35, 33, 42, 34,
                41, 36, 5, 43, 44, 29, 30, 29, -1, 20, 20, 50, 51, 32, 31, 20,
                20, 3, 20, 20, 3, 20, 3, 20, 20, 3, 20, 20, 52, -1, 53, 54,
                19, 18, 19, 39, 17, 16, 17, -1, 27, -1, 55, -1, 28, -1, 29, 23,
                29, 29, -1, 22, 20, 20, 20, 20, 20, 20, 20, 20, 10, 3, 20, 20,
                20, 20, 20, 20, 20, 24, 40, 47, 19, 18, 19, 17, 16, 17, 21, -1,
                -1, 55, 2, 25, 26, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
                22, -1, 55, 15, 20, 11, 20, 20, 20, 20, 13, 4, 20, 20, -1, -1,
                20, 4, 20, 20, 20, 20, 9, 14, 20, 12, 8, 20, 20, 7, 20, 6,
            },
        };
        
        
        #endregion
        
    }
}
