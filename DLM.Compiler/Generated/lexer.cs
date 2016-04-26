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
                case 17: return new TString(text, line, position);
                case 18: return new TIdentifier(text, line, position);
                case 19: return new TActsFor(text, line, position);
                case 20: return new TIfActsFor(text, line, position);
                case 21: return new TDeclassifyStart(text, line, position);
                case 22: return new TDeclassifyEnd(text, line, position);
                case 23: return new TFuncAuthStart(text, line, position);
                case 24: return new TFuncAuthEnd(text, line, position);
                case 25: return new TRArrow(text, line, position);
                case 26: return new TLArrow(text, line, position);
                case 27: return new TCompare(text, line, position);
                case 28: return new TAssign(text, line, position);
                case 29: return new TUnderscore(text, line, position);
                case 30: return new THat(text, line, position);
                case 31: return new TPlus(text, line, position);
                case 32: return new TMinus(text, line, position);
                case 33: return new TAsterisk(text, line, position);
                case 34: return new TSlash(text, line, position);
                case 35: return new TPercent(text, line, position);
                case 36: return new TBang(text, line, position);
                case 37: return new TAnd(text, line, position);
                case 38: return new TOr(text, line, position);
                case 39: return new TPeriod(text, line, position);
                case 40: return new TComma(text, line, position);
                case 41: return new TColon(text, line, position);
                case 42: return new TSemicolon(text, line, position);
                case 43: return new TLabelStart(text, line, position);
                case 44: return new TTimeStart(text, line, position);
                case 45: return new TLabelEnd(text, line, position);
                case 46: return new TLPar(text, line, position);
                case 47: return new TRPar(text, line, position);
                case 48: return new TLSqu(text, line, position);
                case 49: return new TRSqu(text, line, position);
                case 50: return new TLCur(text, line, position);
                case 51: return new TRCur(text, line, position);
                case 52: return new TJoin(text, line, position);
                case 53: return new TComment(text, line, position);
                case 54: return new TWhitespace(text, line, position);
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
                case 43:
                    switch (currentState)
                    {
                        case STATE1: return STATE3;
                        default: return -1;
                    }
                case 44:
                    switch (currentState)
                    {
                        case STATE3: return STATE4;
                        default: return -1;
                    }
                case 45:
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
                    new int[] {0, 33, 46},
                    new int[] {35, 91, 46},
                    new int[] {92, 92, 47},
                    new int[] {93, 65535, 46},
                },
                new int[][] {
                    new int[] {105, 105, 48},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 49},
                },
                new int[][] {
                    new int[] {0, 38, 50},
                    new int[] {40, 91, 50},
                    new int[] {92, 92, 51},
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
                    new int[] {48, 57, 19},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 56},
                    new int[] {60, 60, 57},
                    new int[] {61, 61, 58},
                    new int[] {124, 124, 59},
                },
                new int[][] {
                    new int[] {61, 61, 60},
                },
                new int[][] {
                    new int[] {61, 61, 61},
                    new int[] {62, 62, 62},
                },
                new int[][] {
                    new int[] {62, 62, 63},
                },
                new int[][] {
                    new int[] {48, 57, 64},
                    new int[] {65, 90, 65},
                    new int[] {95, 95, 66},
                    new int[] {97, 122, 67},
                },
                new int[][] {
                    new int[] {48, 57, 64},
                    new int[] {65, 84, 65},
                    new int[] {85, 85, 68},
                    new int[] {86, 90, 65},
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
                    new int[] {97, 97, 69},
                    new int[] {98, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 107, 67},
                    new int[] {108, 108, 70},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 71},
                    new int[] {98, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 101, 67},
                    new int[] {102, 102, 72},
                    new int[] {103, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 113, 67},
                    new int[] {114, 114, 73},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 100, 67},
                    new int[] {101, 101, 74},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 115, 67},
                    new int[] {116, 116, 75},
                    new int[] {117, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 103, 67},
                    new int[] {104, 104, 76},
                    new int[] {105, 113, 67},
                    new int[] {114, 114, 77},
                    new int[] {115, 120, 67},
                    new int[] {121, 121, 78},
                    new int[] {122, 122, 67},
                },
                new int[][] {
                    new int[] {48, 103, -42},
                    new int[] {104, 104, 79},
                    new int[] {105, 122, 67},
                },
                new int[][] {
                    new int[] {123, 123, 80},
                },
                new int[][] {
                    new int[] {62, 62, 81},
                    new int[] {124, 124, 82},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 33, 46},
                    new int[] {34, 34, 83},
                    new int[] {35, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 33, 84},
                    new int[] {34, 34, 85},
                    new int[] {35, 91, 84},
                    new int[] {92, 92, 86},
                    new int[] {93, 65535, 84},
                },
                new int[][] {
                    new int[] {110, 110, 87},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 88},
                },
                new int[][] {
                    new int[] {0, 38, 89},
                    new int[] {39, 39, 90},
                    new int[] {40, 65535, 89},
                },
                new int[][] {
                    new int[] {62, 62, 91},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 92},
                    new int[] {42, 42, 93},
                    new int[] {43, 65535, 92},
                },
                new int[][] {
                    new int[] {0, 9, 94},
                    new int[] {11, 12, 94},
                    new int[] {14, 65535, 94},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 95},
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
                    new int[] {62, 62, 96},
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
                    new int[] {48, 57, 64},
                    new int[] {65, 75, 65},
                    new int[] {76, 76, 97},
                    new int[] {77, 90, 65},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 98},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 114, 67},
                    new int[] {115, 115, 99},
                    new int[] {116, 122, 67},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 100},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 104, 67},
                    new int[] {105, 105, 101},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 102},
                    new int[] {117, 122, 67},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 103},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 104, -75},
                    new int[] {105, 105, 104},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 116, 67},
                    new int[] {117, 117, 105},
                    new int[] {118, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 111, 67},
                    new int[] {112, 112, 106},
                    new int[] {113, 122, 67},
                },
                new int[][] {
                    new int[] {48, 104, -75},
                    new int[] {105, 105, 107},
                    new int[] {106, 122, 67},
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
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                    new int[] {99, 99, 108},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 109},
                },
                new int[][] {
                    new int[] {39, 39, 109},
                },
                new int[][] {
                    new int[] {63, 63, 110},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                    new int[] {0, 41, 111},
                    new int[] {42, 42, 93},
                    new int[] {43, 46, 111},
                    new int[] {47, 47, 112},
                    new int[] {48, 65535, 111},
                },
                new int[][] {
                    new int[] {0, 65535, -57},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -70},
                    new int[] {76, 76, 113},
                    new int[] {77, 122, -70},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 114},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 115},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 114, -72},
                    new int[] {115, 115, 116},
                    new int[] {116, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 109, 67},
                    new int[] {110, 110, 117},
                    new int[] {111, 122, 67},
                },
                new int[][] {
                    new int[] {48, 116, -79},
                    new int[] {117, 117, 118},
                    new int[] {118, 122, 67},
                },
                new int[][] {
                    new int[] {48, 116, -79},
                    new int[] {117, 117, 119},
                    new int[] {118, 122, 67},
                },
                new int[][] {
                    new int[] {48, 114, -72},
                    new int[] {115, 115, 120},
                    new int[] {116, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 121},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 122},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 123},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {108, 108, 124},
                },
                new int[][] {
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
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 128},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 98, 67},
                    new int[] {99, 99, 129},
                    new int[] {100, 122, 67},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 130},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 98, -119},
                    new int[] {99, 99, 131},
                    new int[] {100, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 99, 67},
                    new int[] {100, 100, 132},
                    new int[] {101, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 133},
                    new int[] {102, 122, 67},
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
                    new int[] {43, 65535, -95},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 135},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 104, -75},
                    new int[] {105, 105, 136},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                    new int[] {48, 109, -103},
                    new int[] {110, 110, 137},
                    new int[] {111, 122, 67},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 138},
                    new int[] {117, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 139},
                    new int[] {102, 122, 67},
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
                    new int[] {48, 111, -80},
                    new int[] {112, 112, 141},
                    new int[] {113, 122, 67},
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
                    new int[] {103, 122, 67},
                },
                new int[][] {
                    new int[] {101, 101, 143},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 144},
                    new int[] {98, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 145},
                    new int[] {109, 122, 67},
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
                    new int[] {0, 33, 45},
                    new int[] {35, 91, 45},
                    new int[] {92, 92, 46},
                    new int[] {93, 65535, 45},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 47},
                },
                new int[][] {
                    new int[] {0, 38, 48},
                    new int[] {40, 91, 48},
                    new int[] {92, 92, 49},
                    new int[] {93, 65535, 48},
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
                    new int[] {45, 45, 50},
                    new int[] {62, 62, 51},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 52},
                    new int[] {47, 47, 53},
                },
                new int[][] {
                    new int[] {48, 57, 18},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 54},
                    new int[] {45, 45, 55},
                    new int[] {46, 59, 54},
                    new int[] {60, 60, 56},
                    new int[] {61, 61, 57},
                    new int[] {62, 62, 58},
                    new int[] {63, 123, 54},
                    new int[] {124, 124, 59},
                    new int[] {125, 65535, 54},
                },
                new int[][] {
                    new int[] {61, 61, 60},
                },
                new int[][] {
                    new int[] {61, 61, 61},
                    new int[] {62, 62, 62},
                },
                new int[][] {
                    new int[] {62, 62, 63},
                },
                new int[][] {
                    new int[] {48, 57, 64},
                    new int[] {65, 90, 65},
                    new int[] {95, 95, 66},
                    new int[] {97, 122, 67},
                },
                new int[][] {
                    new int[] {48, 57, 64},
                    new int[] {65, 84, 65},
                    new int[] {85, 85, 68},
                    new int[] {86, 90, 65},
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
                    new int[] {97, 97, 69},
                    new int[] {98, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 107, 67},
                    new int[] {108, 108, 70},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 71},
                    new int[] {98, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 101, 67},
                    new int[] {102, 102, 72},
                    new int[] {103, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 113, 67},
                    new int[] {114, 114, 73},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 100, 67},
                    new int[] {101, 101, 74},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 115, 67},
                    new int[] {116, 116, 75},
                    new int[] {117, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 103, 67},
                    new int[] {104, 104, 76},
                    new int[] {105, 113, 67},
                    new int[] {114, 114, 77},
                    new int[] {115, 120, 67},
                    new int[] {121, 121, 78},
                    new int[] {122, 122, 67},
                },
                new int[][] {
                    new int[] {48, 103, -41},
                    new int[] {104, 104, 79},
                    new int[] {105, 122, 67},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 80},
                    new int[] {124, 124, 81},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 33, 45},
                    new int[] {34, 34, 82},
                    new int[] {35, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 33, 83},
                    new int[] {34, 34, 84},
                    new int[] {35, 91, 83},
                    new int[] {92, 92, 85},
                    new int[] {93, 65535, 83},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 86},
                },
                new int[][] {
                    new int[] {0, 38, 87},
                    new int[] {39, 39, 88},
                    new int[] {40, 65535, 87},
                },
                new int[][] {
                    new int[] {62, 62, 89},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 90},
                    new int[] {42, 42, 91},
                    new int[] {43, 65535, 90},
                },
                new int[][] {
                    new int[] {0, 9, 92},
                    new int[] {11, 12, 92},
                    new int[] {14, 65535, 92},
                },
                new int[][] {
                    new int[] {0, 61, 54},
                    new int[] {62, 62, 58},
                    new int[] {63, 65535, 54},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                    new int[] {0, 59, 54},
                    new int[] {60, 60, 93},
                    new int[] {61, 61, 54},
                    new int[] {62, 65535, -56},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 94},
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
                    new int[] {48, 57, 64},
                    new int[] {65, 75, 65},
                    new int[] {76, 76, 95},
                    new int[] {77, 90, 65},
                    new int[] {95, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 96},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 114, 67},
                    new int[] {115, 115, 97},
                    new int[] {116, 122, 67},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 98},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 104, 67},
                    new int[] {105, 105, 99},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                    new int[] {48, 115, -40},
                    new int[] {116, 116, 100},
                    new int[] {117, 122, 67},
                },
                new int[][] {
                    new int[] {48, 113, -38},
                    new int[] {114, 114, 101},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 104, -75},
                    new int[] {105, 105, 102},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 116, 67},
                    new int[] {117, 117, 103},
                    new int[] {118, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 111, 67},
                    new int[] {112, 112, 104},
                    new int[] {113, 122, 67},
                },
                new int[][] {
                    new int[] {48, 104, -75},
                    new int[] {105, 105, 105},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 106},
                },
                new int[][] {
                    new int[] {39, 39, 106},
                },
                new int[][] {
                    new int[] {63, 63, 107},
                },
                new int[][] {
                    new int[] {0, 65535, -54},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 91},
                    new int[] {43, 46, 108},
                    new int[] {47, 47, 109},
                    new int[] {48, 65535, 108},
                },
                new int[][] {
                    new int[] {0, 65535, -55},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -70},
                    new int[] {76, 76, 110},
                    new int[] {77, 122, -70},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 111},
                    new int[] {109, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 112},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 114, -72},
                    new int[] {115, 115, 113},
                    new int[] {116, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 109, 67},
                    new int[] {110, 110, 114},
                    new int[] {111, 122, 67},
                },
                new int[][] {
                    new int[] {48, 116, -79},
                    new int[] {117, 117, 115},
                    new int[] {118, 122, 67},
                },
                new int[][] {
                    new int[] {48, 116, -79},
                    new int[] {117, 117, 116},
                    new int[] {118, 122, 67},
                },
                new int[][] {
                    new int[] {48, 114, -72},
                    new int[] {115, 115, 117},
                    new int[] {116, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 118},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 119},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 120},
                    new int[] {109, 122, 67},
                },
                new int[][] {
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
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 124},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 98, 67},
                    new int[] {99, 99, 125},
                    new int[] {100, 122, 67},
                },
                new int[][] {
                    new int[] {48, 113, -38},
                    new int[] {114, 114, 126},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 98, -116},
                    new int[] {99, 99, 127},
                    new int[] {100, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 99, 67},
                    new int[] {100, 100, 128},
                    new int[] {101, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 129},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {0, 65535, -110},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 122},
                    new int[] {43, 65535, -93},
                },
                new int[][] {
                    new int[] {48, 113, -38},
                    new int[] {114, 114, 130},
                    new int[] {115, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 104, -75},
                    new int[] {105, 105, 131},
                    new int[] {106, 122, 67},
                },
                new int[][] {
                    new int[] {48, 109, -101},
                    new int[] {110, 110, 132},
                    new int[] {111, 122, 67},
                },
                new int[][] {
                    new int[] {48, 115, -40},
                    new int[] {116, 116, 133},
                    new int[] {117, 122, 67},
                },
                new int[][] {
                    new int[] {48, 100, -39},
                    new int[] {101, 101, 134},
                    new int[] {102, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 111, -80},
                    new int[] {112, 112, 135},
                    new int[] {113, 122, 67},
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
                    new int[] {103, 122, 67},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 137},
                    new int[] {98, 122, 67},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -35},
                    new int[] {108, 108, 138},
                    new int[] {109, 122, 67},
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
                    new int[] {0, 33, 46},
                    new int[] {35, 91, 46},
                    new int[] {92, 92, 47},
                    new int[] {93, 65535, 46},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 48},
                },
                new int[][] {
                    new int[] {0, 38, 49},
                    new int[] {40, 91, 49},
                    new int[] {92, 92, 50},
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
                    new int[] {45, 45, 51},
                    new int[] {62, 62, 52},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 53},
                    new int[] {47, 47, 54},
                },
                new int[][] {
                    new int[] {48, 57, 18},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 55},
                    new int[] {60, 60, 56},
                    new int[] {61, 61, 57},
                    new int[] {124, 124, 58},
                },
                new int[][] {
                    new int[] {61, 61, 59},
                },
                new int[][] {
                    new int[] {61, 61, 60},
                    new int[] {62, 62, 61},
                },
                new int[][] {
                    new int[] {62, 62, 62},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 57, 63},
                    new int[] {65, 90, 64},
                    new int[] {95, 95, 65},
                    new int[] {97, 122, 66},
                },
                new int[][] {
                    new int[] {48, 57, 63},
                    new int[] {65, 84, 64},
                    new int[] {85, 85, 67},
                    new int[] {86, 90, 64},
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
                    new int[] {97, 97, 68},
                    new int[] {98, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 107, 66},
                    new int[] {108, 108, 69},
                    new int[] {109, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 70},
                    new int[] {98, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 101, 66},
                    new int[] {102, 102, 71},
                    new int[] {103, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 113, 66},
                    new int[] {114, 114, 72},
                    new int[] {115, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 100, 66},
                    new int[] {101, 101, 73},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 115, 66},
                    new int[] {116, 116, 74},
                    new int[] {117, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 103, 66},
                    new int[] {104, 104, 75},
                    new int[] {105, 113, 66},
                    new int[] {114, 114, 76},
                    new int[] {115, 120, 66},
                    new int[] {121, 121, 77},
                    new int[] {122, 122, 66},
                },
                new int[][] {
                    new int[] {48, 103, -42},
                    new int[] {104, 104, 78},
                    new int[] {105, 122, 66},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 79},
                    new int[] {124, 124, 80},
                },
                new int[][] {
                    new int[] {125, 125, 81},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 33, 46},
                    new int[] {34, 34, 82},
                    new int[] {35, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 33, 83},
                    new int[] {34, 34, 84},
                    new int[] {35, 91, 83},
                    new int[] {92, 92, 85},
                    new int[] {93, 65535, 83},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 86},
                },
                new int[][] {
                    new int[] {0, 38, 87},
                    new int[] {39, 39, 88},
                    new int[] {40, 65535, 87},
                },
                new int[][] {
                    new int[] {62, 62, 89},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 90},
                    new int[] {42, 42, 91},
                    new int[] {43, 65535, 90},
                },
                new int[][] {
                    new int[] {0, 9, 92},
                    new int[] {11, 12, 92},
                    new int[] {14, 65535, 92},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 93},
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
                    new int[] {62, 62, 94},
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
                    new int[] {48, 57, 63},
                    new int[] {65, 75, 64},
                    new int[] {76, 76, 95},
                    new int[] {77, 90, 64},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 96},
                    new int[] {109, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 114, 66},
                    new int[] {115, 115, 97},
                    new int[] {116, 122, 66},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 98},
                    new int[] {109, 122, 66},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 104, 66},
                    new int[] {105, 105, 99},
                    new int[] {106, 122, 66},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 100},
                    new int[] {117, 122, 66},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 101},
                    new int[] {115, 122, 66},
                },
                new int[][] {
                    new int[] {48, 104, -74},
                    new int[] {105, 105, 102},
                    new int[] {106, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 116, 66},
                    new int[] {117, 117, 103},
                    new int[] {118, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 111, 66},
                    new int[] {112, 112, 104},
                    new int[] {113, 122, 66},
                },
                new int[][] {
                    new int[] {48, 104, -74},
                    new int[] {105, 105, 105},
                    new int[] {106, 122, 66},
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
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 106},
                },
                new int[][] {
                    new int[] {39, 39, 106},
                },
                new int[][] {
                    new int[] {63, 63, 107},
                },
                new int[][] {
                    new int[] {0, 65535, -55},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 91},
                    new int[] {43, 46, 108},
                    new int[] {47, 47, 109},
                    new int[] {48, 65535, 108},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -69},
                    new int[] {76, 76, 110},
                    new int[] {77, 122, -69},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 111},
                    new int[] {109, 122, 66},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 112},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 114, -71},
                    new int[] {115, 115, 113},
                    new int[] {116, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 109, 66},
                    new int[] {110, 110, 114},
                    new int[] {111, 122, 66},
                },
                new int[][] {
                    new int[] {48, 116, -78},
                    new int[] {117, 117, 115},
                    new int[] {118, 122, 66},
                },
                new int[][] {
                    new int[] {48, 116, -78},
                    new int[] {117, 117, 116},
                    new int[] {118, 122, 66},
                },
                new int[][] {
                    new int[] {48, 114, -71},
                    new int[] {115, 115, 117},
                    new int[] {116, 122, 66},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 118},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 119},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 120},
                    new int[] {109, 122, 66},
                },
                new int[][] {
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
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 124},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 98, 66},
                    new int[] {99, 99, 125},
                    new int[] {100, 122, 66},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 126},
                    new int[] {115, 122, 66},
                },
                new int[][] {
                    new int[] {48, 98, -116},
                    new int[] {99, 99, 127},
                    new int[] {100, 122, 66},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 99, 66},
                    new int[] {100, 100, 128},
                    new int[] {101, 122, 66},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 129},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {0, 65535, -110},
                },
                new int[][] {
                    new int[] {0, 41, 108},
                    new int[] {42, 42, 122},
                    new int[] {43, 65535, -93},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 130},
                    new int[] {115, 122, 66},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 104, -74},
                    new int[] {105, 105, 131},
                    new int[] {106, 122, 66},
                },
                new int[][] {
                    new int[] {48, 109, -101},
                    new int[] {110, 110, 132},
                    new int[] {111, 122, 66},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 133},
                    new int[] {117, 122, 66},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 134},
                    new int[] {102, 122, 66},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 111, -79},
                    new int[] {112, 112, 135},
                    new int[] {113, 122, 66},
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
                    new int[] {103, 122, 66},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 137},
                    new int[] {98, 122, 66},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 138},
                    new int[] {109, 122, 66},
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
                    new int[] {0, 33, 48},
                    new int[] {35, 91, 48},
                    new int[] {92, 92, 49},
                    new int[] {93, 65535, 48},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 50},
                },
                new int[][] {
                    new int[] {0, 38, 51},
                    new int[] {40, 91, 51},
                    new int[] {92, 92, 52},
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
                    new int[] {58, 58, 57},
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
                    new int[] {48, 122, -27},
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
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 101, 69},
                    new int[] {102, 102, 74},
                    new int[] {103, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 114, 69},
                    new int[] {115, 115, 75},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 113, 69},
                    new int[] {114, 114, 76},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 100, 69},
                    new int[] {101, 101, 77},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 115, 69},
                    new int[] {116, 116, 78},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 103, 69},
                    new int[] {104, 104, 79},
                    new int[] {105, 113, 69},
                    new int[] {114, 114, 80},
                    new int[] {115, 120, 69},
                    new int[] {121, 121, 81},
                    new int[] {122, 122, 69},
                },
                new int[][] {
                    new int[] {48, 103, -44},
                    new int[] {104, 104, 82},
                    new int[] {105, 122, 69},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 83},
                    new int[] {124, 124, 84},
                },
                new int[][] {
                    new int[] {125, 125, 85},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 33, 48},
                    new int[] {34, 34, 86},
                    new int[] {35, 65535, -8},
                },
                new int[][] {
                    new int[] {0, 33, 87},
                    new int[] {34, 34, 88},
                    new int[] {35, 91, 87},
                    new int[] {92, 92, 89},
                    new int[] {93, 65535, 87},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 90},
                },
                new int[][] {
                    new int[] {0, 38, 91},
                    new int[] {39, 39, 92},
                    new int[] {40, 65535, 91},
                },
                new int[][] {
                    new int[] {62, 62, 93},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 94},
                    new int[] {42, 42, 95},
                    new int[] {43, 65535, 94},
                },
                new int[][] {
                    new int[] {0, 9, 96},
                    new int[] {11, 12, 96},
                    new int[] {14, 65535, 96},
                },
                new int[][] {
                    new int[] {48, 57, 97},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 98},
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
                    new int[] {62, 62, 99},
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
                    new int[] {76, 76, 100},
                    new int[] {77, 90, 67},
                    new int[] {95, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 101},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -40},
                    new int[] {115, 115, 102},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 103},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 104, 69},
                    new int[] {105, 105, 104},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 115, -43},
                    new int[] {116, 116, 105},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 113, -41},
                    new int[] {114, 114, 106},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 104, -78},
                    new int[] {105, 105, 107},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 116, 69},
                    new int[] {117, 117, 108},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 111, 69},
                    new int[] {112, 112, 109},
                    new int[] {113, 122, 69},
                },
                new int[][] {
                    new int[] {48, 104, -78},
                    new int[] {105, 105, 110},
                    new int[] {106, 122, 69},
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
                    new int[] {0, 65535, -50},
                },
                new int[][] {
                    new int[] {0, 65535, -50},
                },
                new int[][] {
                    new int[] {0, 65535, -51},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {39, 39, 111},
                },
                new int[][] {
                    new int[] {39, 39, 111},
                },
                new int[][] {
                    new int[] {63, 63, 112},
                },
                new int[][] {
                    new int[] {0, 65535, -57},
                },
                new int[][] {
                    new int[] {0, 41, 113},
                    new int[] {42, 42, 95},
                    new int[] {43, 46, 113},
                    new int[] {47, 47, 114},
                    new int[] {48, 65535, 113},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                    new int[] {48, 57, 97},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -72},
                    new int[] {76, 76, 115},
                    new int[] {77, 122, -72},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 116},
                    new int[] {109, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 117},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -40},
                    new int[] {115, 115, 118},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 109, 69},
                    new int[] {110, 110, 119},
                    new int[] {111, 122, 69},
                },
                new int[][] {
                    new int[] {48, 116, -82},
                    new int[] {117, 117, 120},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 116, -82},
                    new int[] {117, 117, 121},
                    new int[] {118, 122, 69},
                },
                new int[][] {
                    new int[] {48, 114, -40},
                    new int[] {115, 115, 122},
                    new int[] {116, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 123},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 124},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 125},
                    new int[] {109, 122, 69},
                },
                new int[][] {
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
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 129},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 98, 69},
                    new int[] {99, 99, 130},
                    new int[] {100, 122, 69},
                },
                new int[][] {
                    new int[] {48, 113, -41},
                    new int[] {114, 114, 131},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 98, -121},
                    new int[] {99, 99, 132},
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
                    new int[] {100, 100, 133},
                    new int[] {101, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 134},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {0, 65535, -115},
                },
                new int[][] {
                    new int[] {0, 41, 113},
                    new int[] {42, 42, 127},
                    new int[] {43, 65535, -97},
                },
                new int[][] {
                    new int[] {48, 113, -41},
                    new int[] {114, 114, 135},
                    new int[] {115, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 104, -78},
                    new int[] {105, 105, 136},
                    new int[] {106, 122, 69},
                },
                new int[][] {
                    new int[] {48, 109, -106},
                    new int[] {110, 110, 137},
                    new int[] {111, 122, 69},
                },
                new int[][] {
                    new int[] {48, 115, -43},
                    new int[] {116, 116, 138},
                    new int[] {117, 122, 69},
                },
                new int[][] {
                    new int[] {48, 100, -42},
                    new int[] {101, 101, 139},
                    new int[] {102, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 111, -83},
                    new int[] {112, 112, 140},
                    new int[] {113, 122, 69},
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
                    new int[] {103, 122, 69},
                },
                new int[][] {
                    new int[] {48, 95, -27},
                    new int[] {97, 97, 142},
                    new int[] {98, 122, 69},
                },
                new int[][] {
                    new int[] {48, 122, -27},
                },
                new int[][] {
                    new int[] {48, 107, -36},
                    new int[] {108, 108, 143},
                    new int[] {109, 122, 69},
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
                -1, 54, 54, 54, 54, 36, -1, -1, 35, -1, -1, 46, 47, 33, 31, 40,
                32, 39, 34, 5, 41, 42, 27, 28, 27, -1, 18, 18, 48, 49, 30, 29,
                18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 50, -1, 51, 52, -1, -1,
                -1, 37, -1, -1, -1, 25, -1, 53, 26, -1, 27, 21, 27, 27, -1, 20,
                18, 18, 18, 18, 18, 18, 18, 18, 10, 18, 18, 18, 18, 18, 18, 18,
                43, 22, 38, 17, -1, 17, -1, -1, 16, -1, 16, 19, -1, -1, 53, 23,
                24, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, -1, 16, 20, -1,
                53, 15, 18, 11, 18, 18, 18, 18, 13, 4, 18, 18, -1, -1, -1, 18,
                4, 18, 18, 18, 18, 9, -1, 14, 18, 12, 8, 18, -1, 18, 7, 0,
                18, 6,
            },
            new int[] {
                -1, 54, 54, 54, 54, 36, -1, 35, -1, -1, 46, 47, 33, 31, 40, 32,
                39, 34, 5, 41, 42, 27, 28, 27, -1, 18, 18, 48, 49, 30, 29, 18,
                18, 18, 18, 18, 18, 18, 18, 18, 18, 50, -1, 51, 52, -1, -1, 37,
                -1, -1, -1, 25, -1, 53, -1, 26, -1, 27, 1, 21, 27, 27, -1, 20,
                18, 18, 18, 18, 18, 18, 18, 18, 10, 18, 18, 18, 18, 18, 18, 18,
                22, 38, 17, -1, 17, -1, 16, -1, 16, 19, -1, -1, 53, 23, 24, 18,
                18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 16, 20, -1, 53, 15, 18,
                11, 18, 18, 18, 18, 13, 4, 18, 18, -1, -1, 18, 4, 18, 18, 18,
                18, 9, 14, 18, 12, 8, 18, 18, 7, 18, 6,
            },
            new int[] {
                -1, 54, 54, 54, 54, 36, -1, 35, -1, -1, 46, 47, 33, 31, 40, 32,
                39, 34, 5, 41, 42, 27, 28, 27, -1, 44, 18, 18, 48, 49, 30, 29,
                18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 50, -1, 51, 52, -1, -1,
                37, -1, -1, -1, 25, -1, 53, 26, -1, 27, 21, 27, 27, -1, 20, 18,
                18, 18, 18, 18, 18, 18, 18, 10, 18, 18, 18, 18, 18, 18, 18, 22,
                38, 45, 17, -1, 17, -1, 16, -1, 16, 19, -1, -1, 53, 23, 24, 18,
                18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 16, 20, -1, 53, 15, 18,
                11, 18, 18, 18, 18, 13, 4, 18, 18, -1, -1, 18, 4, 18, 18, 18,
                18, 9, 14, 18, 12, 8, 18, 18, 7, 18, 6,
            },
            new int[] {
                -1, 54, 54, 54, 54, 36, -1, 35, -1, -1, 46, 47, 33, 31, 40, 32,
                39, 34, 5, 41, 42, 27, 28, 27, -1, 18, 18, 48, 49, 30, 29, 18,
                18, 3, 18, 18, 3, 18, 3, 18, 18, 3, 18, 18, 50, -1, 51, 52,
                -1, -1, 37, -1, -1, -1, 25, -1, 53, -1, 26, -1, 27, 21, 27, 27,
                -1, 20, 18, 18, 18, 18, 18, 18, 18, 18, 10, 3, 18, 18, 18, 18,
                18, 18, 18, 22, 38, 45, 17, -1, 17, -1, 16, -1, 16, 19, -1, -1,
                53, 2, 23, 24, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 16,
                20, -1, 53, 15, 18, 11, 18, 18, 18, 18, 13, 4, 18, 18, -1, -1,
                18, 4, 18, 18, 18, 18, 9, 14, 18, 12, 8, 18, 18, 7, 18, 6,
            },
        };
        
        
        #endregion
        
    }
}
