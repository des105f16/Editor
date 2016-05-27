using System;
using DLM.Compiler.Nodes;

namespace DLM.Compiler.Lexing
{
    public class Lexer : SablePP.Tools.Lexing.Lexer
    {
        private const int STATE1 = 0;
        private const int STATE2 = 1;
        private const int STATE3 = 2;
        
        public Lexer(System.IO.TextReader input)
            : base(input, STATE1, gotoTable, acceptTable)
        {
        }
        
        protected override SablePP.Tools.Nodes.Token getToken(int tokenIndex, string text, int line, int position)
        {
            switch (tokenIndex)
            {
                case 0: return new TDirective(text, line, position);
                case 1: return new TTime(text, line, position);
                case 2: return new TIntervalUnit(text, line, position);
                case 3: return new TBool(text, line, position);
                case 4: return new TNumber(text, line, position);
                case 5: return new TPrincipall(text, line, position);
                case 6: return new TTypedef(text, line, position);
                case 7: return new TStruct(text, line, position);
                case 8: return new TWhile(text, line, position);
                case 9: return new TIf(text, line, position);
                case 10: return new TElse(text, line, position);
                case 11: return new TReturn(text, line, position);
                case 12: return new TThis(text, line, position);
                case 13: return new TCaller(text, line, position);
                case 14: return new TNull(text, line, position);
                case 15: return new TChar(text, line, position);
                case 16: return new TCharErr(text, line, position);
                case 17: return new TString(text, line, position);
                case 18: return new TStringErr(text, line, position);
                case 19: return new TIdentifier(text, line, position);
                case 20: return new TActsFor(text, line, position);
                case 21: return new TIfActsFor(text, line, position);
                case 22: return new TDeclassifyStart(text, line, position);
                case 23: return new TDeclassifyEnd(text, line, position);
                case 24: return new TFuncAuthStart(text, line, position);
                case 25: return new TFuncAuthEnd(text, line, position);
                case 26: return new TRArrow(text, line, position);
                case 27: return new TLArrow(text, line, position);
                case 28: return new TCompare(text, line, position);
                case 29: return new TAssign(text, line, position);
                case 30: return new TUnderscore(text, line, position);
                case 31: return new THat(text, line, position);
                case 32: return new TPlus(text, line, position);
                case 33: return new TMinus(text, line, position);
                case 34: return new TAsterisk(text, line, position);
                case 35: return new TSlash(text, line, position);
                case 36: return new TPercent(text, line, position);
                case 37: return new TAmpersand(text, line, position);
                case 38: return new TBang(text, line, position);
                case 39: return new TAnd(text, line, position);
                case 40: return new TOr(text, line, position);
                case 41: return new TQuestion(text, line, position);
                case 42: return new TPeriod(text, line, position);
                case 43: return new TComma(text, line, position);
                case 44: return new TColon(text, line, position);
                case 45: return new TSemicolon(text, line, position);
                case 46: return new TLabelStart(text, line, position);
                case 47: return new TTimeStart(text, line, position);
                case 48: return new TLabelEnd(text, line, position);
                case 49: return new TTimeCall(text, line, position);
                case 50: return new TTimeCheck(text, line, position);
                case 51: return new TLPar(text, line, position);
                case 52: return new TRPar(text, line, position);
                case 53: return new TLSqu(text, line, position);
                case 54: return new TRSqu(text, line, position);
                case 55: return new TLCur(text, line, position);
                case 56: return new TRCur(text, line, position);
                case 57: return new TJoin(text, line, position);
                case 58: return new TComment(text, line, position);
                case 59: return new TWhitespace(text, line, position);
                default:
                    throw new ArgumentException("Unknown token index.", "tokenIndex");
            }
        }
        protected override int getNextState(int tokenIndex, int currentState)
        {
            switch (tokenIndex)
            {
                case 46:
                    switch (currentState)
                    {
                        case STATE1: return STATE2;
                        default: return -1;
                    }
                case 47:
                    switch (currentState)
                    {
                        case STATE2: return STATE3;
                        default: return -1;
                    }
                case 48:
                    switch (currentState)
                    {
                        case STATE3: return STATE1;
                        case STATE2: return STATE1;
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
                    new int[] {64, 64, 26},
                    new int[] {65, 77, 27},
                    new int[] {78, 78, 28},
                    new int[] {79, 90, 27},
                    new int[] {91, 91, 29},
                    new int[] {93, 93, 30},
                    new int[] {94, 94, 31},
                    new int[] {95, 95, 32},
                    new int[] {97, 98, 33},
                    new int[] {99, 99, 34},
                    new int[] {100, 100, 33},
                    new int[] {101, 101, 35},
                    new int[] {102, 102, 36},
                    new int[] {103, 104, 33},
                    new int[] {105, 105, 37},
                    new int[] {106, 111, 33},
                    new int[] {112, 112, 38},
                    new int[] {113, 113, 33},
                    new int[] {114, 114, 39},
                    new int[] {115, 115, 40},
                    new int[] {116, 116, 41},
                    new int[] {117, 118, 33},
                    new int[] {119, 119, 42},
                    new int[] {120, 122, 33},
                    new int[] {123, 123, 43},
                    new int[] {124, 124, 44},
                    new int[] {125, 125, 45},
                    new int[] {8852, 8852, 46},
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
                    new int[] {0, 9, 47},
                    new int[] {11, 12, 47},
                    new int[] {14, 33, 47},
                    new int[] {34, 34, 48},
                    new int[] {35, 91, 47},
                    new int[] {92, 92, 49},
                    new int[] {93, 65535, 47},
                },
                new int[][] {
                    new int[] {0, 9, 50},
                    new int[] {11, 12, 50},
                    new int[] {14, 65535, 50},
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
                    new int[] {48, 57, 19},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 59},
                    new int[] {60, 60, 60},
                    new int[] {61, 61, 61},
                    new int[] {124, 124, 62},
                },
                new int[][] {
                    new int[] {61, 61, 63},
                },
                new int[][] {
                    new int[] {61, 61, 64},
                    new int[] {62, 62, 65},
                },
                new int[][] {
                    new int[] {62, 62, 66},
                },
                new int[][] {
                    new int[] {63, 63, 67},
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
                    new int[] {95, 122, -29},
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
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 97, 73},
                    new int[] {98, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 107, 71},
                    new int[] {108, 108, 74},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 97, 75},
                    new int[] {98, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 101, 71},
                    new int[] {102, 102, 76},
                    new int[] {103, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 113, 71},
                    new int[] {114, 114, 77},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 100, 71},
                    new int[] {101, 101, 78},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 115, 71},
                    new int[] {116, 116, 79},
                    new int[] {117, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 103, 71},
                    new int[] {104, 104, 80},
                    new int[] {105, 113, 71},
                    new int[] {114, 114, 81},
                    new int[] {115, 120, 71},
                    new int[] {121, 121, 82},
                    new int[] {122, 122, 71},
                },
                new int[][] {
                    new int[] {48, 103, -43},
                    new int[] {104, 104, 83},
                    new int[] {105, 122, 71},
                },
                new int[][] {
                    new int[] {123, 123, 84},
                },
                new int[][] {
                    new int[] {62, 62, 85},
                    new int[] {124, 124, 86},
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
                    new int[] {0, 9, 87},
                    new int[] {11, 12, 87},
                    new int[] {14, 33, 87},
                    new int[] {34, 34, 88},
                    new int[] {35, 91, 87},
                    new int[] {92, 92, 89},
                    new int[] {93, 65535, 87},
                },
                new int[][] {
                    new int[] {0, 65535, -9},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 90},
                    new int[] {11, 12, 90},
                    new int[] {14, 38, 90},
                    new int[] {39, 39, 91},
                    new int[] {40, 91, 90},
                    new int[] {92, 92, 92},
                    new int[] {93, 65535, 90},
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
                },
                new int[][] {
                    new int[] {60, 60, 97},
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
                    new int[] {62, 62, 98},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 57, 68},
                    new int[] {65, 75, 69},
                    new int[] {76, 76, 99},
                    new int[] {77, 90, 69},
                    new int[] {95, 122, -29},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 100},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 114, 71},
                    new int[] {115, 115, 101},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 102},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 104, 71},
                    new int[] {105, 105, 103},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                    new int[] {48, 115, -42},
                    new int[] {116, 116, 104},
                    new int[] {117, 122, 71},
                },
                new int[][] {
                    new int[] {48, 113, -40},
                    new int[] {114, 114, 105},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 104, -79},
                    new int[] {105, 105, 106},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 116, 71},
                    new int[] {117, 117, 107},
                    new int[] {118, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 111, 71},
                    new int[] {112, 112, 108},
                    new int[] {113, 122, 71},
                },
                new int[][] {
                    new int[] {48, 104, -79},
                    new int[] {105, 105, 109},
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
                    new int[] {0, 65535, -51},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                    new int[] {63, 63, 110},
                },
                new int[][] {
                    new int[] {0, 65535, -59},
                },
                new int[][] {
                    new int[] {0, 41, 111},
                    new int[] {42, 42, 95},
                    new int[] {43, 46, 111},
                    new int[] {47, 47, 112},
                    new int[] {48, 65535, 111},
                },
                new int[][] {
                    new int[] {0, 65535, -60},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -74},
                    new int[] {76, 76, 113},
                    new int[] {77, 122, -74},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 114},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 115},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 114, -76},
                    new int[] {115, 115, 116},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 109, 71},
                    new int[] {110, 110, 117},
                    new int[] {111, 122, 71},
                },
                new int[][] {
                    new int[] {48, 116, -83},
                    new int[] {117, 117, 118},
                    new int[] {118, 122, 71},
                },
                new int[][] {
                    new int[] {48, 116, -83},
                    new int[] {117, 117, 119},
                    new int[] {118, 122, 71},
                },
                new int[][] {
                    new int[] {48, 114, -76},
                    new int[] {115, 115, 120},
                    new int[] {116, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 121},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 122},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 123},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 124},
                    new int[] {42, 42, 125},
                    new int[] {43, 65535, 124},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 126},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 127},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 98, 71},
                    new int[] {99, 99, 128},
                    new int[] {100, 122, 71},
                },
                new int[][] {
                    new int[] {48, 113, -40},
                    new int[] {114, 114, 129},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 98, -119},
                    new int[] {99, 99, 130},
                    new int[] {100, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 99, 71},
                    new int[] {100, 100, 131},
                    new int[] {101, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 132},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {0, 65535, -113},
                },
                new int[][] {
                    new int[] {0, 41, 111},
                    new int[] {42, 42, 125},
                    new int[] {43, 65535, -97},
                },
                new int[][] {
                    new int[] {48, 113, -40},
                    new int[] {114, 114, 133},
                    new int[] {115, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 104, -79},
                    new int[] {105, 105, 134},
                    new int[] {106, 122, 71},
                },
                new int[][] {
                    new int[] {48, 109, -105},
                    new int[] {110, 110, 135},
                    new int[] {111, 122, 71},
                },
                new int[][] {
                    new int[] {48, 115, -42},
                    new int[] {116, 116, 136},
                    new int[] {117, 122, 71},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 137},
                    new int[] {102, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 111, -84},
                    new int[] {112, 112, 138},
                    new int[] {113, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 101, -39},
                    new int[] {102, 102, 139},
                    new int[] {103, 122, 71},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 97, 140},
                    new int[] {98, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 141},
                    new int[] {109, 122, 71},
                },
                new int[][] {
                    new int[] {48, 122, -29},
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
                    new int[] {64, 64, 26},
                    new int[] {65, 77, 27},
                    new int[] {78, 78, 28},
                    new int[] {79, 90, 27},
                    new int[] {91, 91, 29},
                    new int[] {93, 93, 30},
                    new int[] {94, 94, 31},
                    new int[] {95, 95, 32},
                    new int[] {97, 98, 33},
                    new int[] {99, 99, 34},
                    new int[] {100, 100, 33},
                    new int[] {101, 101, 35},
                    new int[] {102, 102, 36},
                    new int[] {103, 104, 33},
                    new int[] {105, 105, 37},
                    new int[] {106, 111, 33},
                    new int[] {112, 112, 38},
                    new int[] {113, 113, 33},
                    new int[] {114, 114, 39},
                    new int[] {115, 115, 40},
                    new int[] {116, 116, 41},
                    new int[] {117, 118, 33},
                    new int[] {119, 119, 42},
                    new int[] {120, 122, 33},
                    new int[] {123, 123, 43},
                    new int[] {124, 124, 44},
                    new int[] {125, 125, 45},
                    new int[] {8852, 8852, 46},
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
                    new int[] {0, 9, 47},
                    new int[] {11, 12, 47},
                    new int[] {14, 33, 47},
                    new int[] {34, 34, 48},
                    new int[] {35, 91, 47},
                    new int[] {92, 92, 49},
                    new int[] {93, 65535, 47},
                },
                new int[][] {
                    new int[] {0, 9, 50},
                    new int[] {11, 12, 50},
                    new int[] {14, 65535, 50},
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
                    new int[] {48, 57, 19},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 59},
                    new int[] {60, 60, 60},
                    new int[] {61, 61, 61},
                    new int[] {124, 124, 62},
                },
                new int[][] {
                    new int[] {61, 61, 63},
                },
                new int[][] {
                    new int[] {61, 61, 64},
                    new int[] {62, 62, 65},
                },
                new int[][] {
                    new int[] {62, 62, 66},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 57, 67},
                    new int[] {65, 90, 68},
                    new int[] {95, 95, 69},
                    new int[] {97, 122, 70},
                },
                new int[][] {
                    new int[] {48, 57, 67},
                    new int[] {65, 84, 68},
                    new int[] {85, 85, 71},
                    new int[] {86, 90, 68},
                    new int[] {95, 122, -29},
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
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 97, 72},
                    new int[] {98, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 107, 70},
                    new int[] {108, 108, 73},
                    new int[] {109, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 97, 74},
                    new int[] {98, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 101, 70},
                    new int[] {102, 102, 75},
                    new int[] {103, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 113, 70},
                    new int[] {114, 114, 76},
                    new int[] {115, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 100, 70},
                    new int[] {101, 101, 77},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 115, 70},
                    new int[] {116, 116, 78},
                    new int[] {117, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 103, 70},
                    new int[] {104, 104, 79},
                    new int[] {105, 113, 70},
                    new int[] {114, 114, 80},
                    new int[] {115, 120, 70},
                    new int[] {121, 121, 81},
                    new int[] {122, 122, 70},
                },
                new int[][] {
                    new int[] {48, 103, -43},
                    new int[] {104, 104, 82},
                    new int[] {105, 122, 70},
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
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 86},
                    new int[] {11, 12, 86},
                    new int[] {14, 33, 86},
                    new int[] {34, 34, 87},
                    new int[] {35, 91, 86},
                    new int[] {92, 92, 88},
                    new int[] {93, 65535, 86},
                },
                new int[][] {
                    new int[] {0, 65535, -9},
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
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 57, 67},
                    new int[] {65, 75, 68},
                    new int[] {76, 76, 98},
                    new int[] {77, 90, 68},
                    new int[] {95, 122, -29},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 99},
                    new int[] {109, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 114, 70},
                    new int[] {115, 115, 100},
                    new int[] {116, 122, 70},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 101},
                    new int[] {109, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 104, 70},
                    new int[] {105, 105, 102},
                    new int[] {106, 122, 70},
                },
                new int[][] {
                    new int[] {48, 115, -42},
                    new int[] {116, 116, 103},
                    new int[] {117, 122, 70},
                },
                new int[][] {
                    new int[] {48, 113, -40},
                    new int[] {114, 114, 104},
                    new int[] {115, 122, 70},
                },
                new int[][] {
                    new int[] {48, 104, -78},
                    new int[] {105, 105, 105},
                    new int[] {106, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 116, 70},
                    new int[] {117, 117, 106},
                    new int[] {118, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 111, 70},
                    new int[] {112, 112, 107},
                    new int[] {113, 122, 70},
                },
                new int[][] {
                    new int[] {48, 104, -78},
                    new int[] {105, 105, 108},
                    new int[] {106, 122, 70},
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
                    new int[] {0, 65535, -51},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -56},
                },
                new int[][] {
                    new int[] {63, 63, 109},
                },
                new int[][] {
                    new int[] {0, 65535, -59},
                },
                new int[][] {
                    new int[] {0, 41, 110},
                    new int[] {42, 42, 94},
                    new int[] {43, 46, 110},
                    new int[] {47, 47, 111},
                    new int[] {48, 65535, 110},
                },
                new int[][] {
                    new int[] {0, 65535, -60},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -73},
                    new int[] {76, 76, 112},
                    new int[] {77, 122, -73},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 113},
                    new int[] {109, 122, 70},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 114},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 114, -75},
                    new int[] {115, 115, 115},
                    new int[] {116, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 109, 70},
                    new int[] {110, 110, 116},
                    new int[] {111, 122, 70},
                },
                new int[][] {
                    new int[] {48, 116, -82},
                    new int[] {117, 117, 117},
                    new int[] {118, 122, 70},
                },
                new int[][] {
                    new int[] {48, 116, -82},
                    new int[] {117, 117, 118},
                    new int[] {118, 122, 70},
                },
                new int[][] {
                    new int[] {48, 114, -75},
                    new int[] {115, 115, 119},
                    new int[] {116, 122, 70},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 120},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 121},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 122},
                    new int[] {109, 122, 70},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 123},
                    new int[] {42, 42, 124},
                    new int[] {43, 65535, 123},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 125},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 126},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 98, 70},
                    new int[] {99, 99, 127},
                    new int[] {100, 122, 70},
                },
                new int[][] {
                    new int[] {48, 113, -40},
                    new int[] {114, 114, 128},
                    new int[] {115, 122, 70},
                },
                new int[][] {
                    new int[] {48, 98, -118},
                    new int[] {99, 99, 129},
                    new int[] {100, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 99, 70},
                    new int[] {100, 100, 130},
                    new int[] {101, 122, 70},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 131},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {0, 65535, -112},
                },
                new int[][] {
                    new int[] {0, 41, 110},
                    new int[] {42, 42, 124},
                    new int[] {43, 65535, -96},
                },
                new int[][] {
                    new int[] {48, 113, -40},
                    new int[] {114, 114, 132},
                    new int[] {115, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 104, -78},
                    new int[] {105, 105, 133},
                    new int[] {106, 122, 70},
                },
                new int[][] {
                    new int[] {48, 109, -104},
                    new int[] {110, 110, 134},
                    new int[] {111, 122, 70},
                },
                new int[][] {
                    new int[] {48, 115, -42},
                    new int[] {116, 116, 135},
                    new int[] {117, 122, 70},
                },
                new int[][] {
                    new int[] {48, 100, -41},
                    new int[] {101, 101, 136},
                    new int[] {102, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 111, -83},
                    new int[] {112, 112, 137},
                    new int[] {113, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 101, -39},
                    new int[] {102, 102, 138},
                    new int[] {103, 122, 70},
                },
                new int[][] {
                    new int[] {48, 95, -29},
                    new int[] {97, 97, 139},
                    new int[] {98, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 140},
                    new int[] {109, 122, 70},
                },
                new int[][] {
                    new int[] {48, 122, -29},
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
                    new int[] {100, 100, 34},
                    new int[] {101, 101, 35},
                    new int[] {102, 102, 36},
                    new int[] {103, 103, 32},
                    new int[] {104, 104, 37},
                    new int[] {105, 105, 38},
                    new int[] {106, 108, 32},
                    new int[] {109, 109, 39},
                    new int[] {110, 111, 32},
                    new int[] {112, 112, 40},
                    new int[] {113, 113, 32},
                    new int[] {114, 114, 41},
                    new int[] {115, 115, 42},
                    new int[] {116, 116, 43},
                    new int[] {117, 118, 32},
                    new int[] {119, 119, 44},
                    new int[] {120, 122, 32},
                    new int[] {123, 123, 45},
                    new int[] {124, 124, 46},
                    new int[] {125, 125, 47},
                    new int[] {8852, 8852, 48},
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
                    new int[] {0, 9, 49},
                    new int[] {11, 12, 49},
                    new int[] {14, 33, 49},
                    new int[] {34, 34, 50},
                    new int[] {35, 91, 49},
                    new int[] {92, 92, 51},
                    new int[] {93, 65535, 49},
                },
                new int[][] {
                    new int[] {0, 9, 52},
                    new int[] {11, 12, 52},
                    new int[] {14, 65535, 52},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 53},
                },
                new int[][] {
                    new int[] {0, 9, 54},
                    new int[] {11, 12, 54},
                    new int[] {14, 38, 54},
                    new int[] {39, 39, 55},
                    new int[] {40, 91, 54},
                    new int[] {92, 92, 56},
                    new int[] {93, 65535, 54},
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
                    new int[] {45, 45, 57},
                    new int[] {62, 62, 58},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 59},
                    new int[] {47, 47, 60},
                },
                new int[][] {
                    new int[] {48, 57, 19},
                    new int[] {58, 58, 61},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 62},
                    new int[] {60, 60, 63},
                    new int[] {61, 61, 64},
                    new int[] {124, 124, 65},
                },
                new int[][] {
                    new int[] {61, 61, 66},
                },
                new int[][] {
                    new int[] {61, 61, 67},
                    new int[] {62, 62, 68},
                },
                new int[][] {
                    new int[] {62, 62, 69},
                },
                new int[][] {
                    new int[] {48, 57, 70},
                    new int[] {65, 90, 71},
                    new int[] {95, 95, 72},
                    new int[] {97, 122, 73},
                },
                new int[][] {
                    new int[] {48, 57, 70},
                    new int[] {65, 84, 71},
                    new int[] {85, 85, 74},
                    new int[] {86, 90, 71},
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
                    new int[] {97, 97, 75},
                    new int[] {98, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 107, 73},
                    new int[] {108, 108, 76},
                    new int[] {109, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 77},
                    new int[] {98, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 101, 73},
                    new int[] {102, 102, 78},
                    new int[] {103, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 114, 73},
                    new int[] {115, 115, 79},
                    new int[] {116, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 113, 73},
                    new int[] {114, 114, 80},
                    new int[] {115, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 100, 73},
                    new int[] {101, 101, 81},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 115, 73},
                    new int[] {116, 116, 82},
                    new int[] {117, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 103, 73},
                    new int[] {104, 104, 83},
                    new int[] {105, 113, 73},
                    new int[] {114, 114, 84},
                    new int[] {115, 120, 73},
                    new int[] {121, 121, 85},
                    new int[] {122, 122, 73},
                },
                new int[][] {
                    new int[] {48, 103, -45},
                    new int[] {104, 104, 86},
                    new int[] {105, 122, 73},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 87},
                    new int[] {124, 124, 88},
                },
                new int[][] {
                    new int[] {125, 125, 89},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -8},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 90},
                    new int[] {11, 12, 90},
                    new int[] {14, 33, 90},
                    new int[] {34, 34, 91},
                    new int[] {35, 91, 90},
                    new int[] {92, 92, 92},
                    new int[] {93, 65535, 90},
                },
                new int[][] {
                    new int[] {0, 65535, -9},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 9, 93},
                    new int[] {11, 12, 93},
                    new int[] {14, 38, 93},
                    new int[] {39, 39, 94},
                    new int[] {40, 91, 93},
                    new int[] {92, 92, 95},
                    new int[] {93, 65535, 93},
                },
                new int[][] {
                    new int[] {62, 62, 96},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 97},
                    new int[] {42, 42, 98},
                    new int[] {43, 65535, 97},
                },
                new int[][] {
                    new int[] {0, 9, 99},
                    new int[] {11, 12, 99},
                    new int[] {14, 65535, 99},
                },
                new int[][] {
                    new int[] {48, 57, 100},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 101},
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
                    new int[] {62, 62, 102},
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
                    new int[] {48, 57, 70},
                    new int[] {65, 75, 71},
                    new int[] {76, 76, 103},
                    new int[] {77, 90, 71},
                    new int[] {95, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 104},
                    new int[] {109, 122, 73},
                },
                new int[][] {
                    new int[] {48, 114, -41},
                    new int[] {115, 115, 105},
                    new int[] {116, 122, 73},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 106},
                    new int[] {109, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 104, 73},
                    new int[] {105, 105, 107},
                    new int[] {106, 122, 73},
                },
                new int[][] {
                    new int[] {48, 115, -44},
                    new int[] {116, 116, 108},
                    new int[] {117, 122, 73},
                },
                new int[][] {
                    new int[] {48, 113, -42},
                    new int[] {114, 114, 109},
                    new int[] {115, 122, 73},
                },
                new int[][] {
                    new int[] {48, 104, -82},
                    new int[] {105, 105, 110},
                    new int[] {106, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 116, 73},
                    new int[] {117, 117, 111},
                    new int[] {118, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 111, 73},
                    new int[] {112, 112, 112},
                    new int[] {113, 122, 73},
                },
                new int[][] {
                    new int[] {48, 104, -82},
                    new int[] {105, 105, 113},
                    new int[] {106, 122, 73},
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
                    new int[] {0, 65535, -53},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -12},
                },
                new int[][] {
                    new int[] {0, 65535, -58},
                },
                new int[][] {
                    new int[] {63, 63, 114},
                },
                new int[][] {
                    new int[] {0, 65535, -61},
                },
                new int[][] {
                    new int[] {0, 41, 115},
                    new int[] {42, 42, 98},
                    new int[] {43, 46, 115},
                    new int[] {47, 47, 116},
                    new int[] {48, 65535, 115},
                },
                new int[][] {
                    new int[] {0, 65535, -62},
                },
                new int[][] {
                    new int[] {48, 57, 100},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 75, -76},
                    new int[] {76, 76, 117},
                    new int[] {77, 122, -76},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 118},
                    new int[] {109, 122, 73},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 119},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 114, -41},
                    new int[] {115, 115, 120},
                    new int[] {116, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 109, 73},
                    new int[] {110, 110, 121},
                    new int[] {111, 122, 73},
                },
                new int[][] {
                    new int[] {48, 116, -86},
                    new int[] {117, 117, 122},
                    new int[] {118, 122, 73},
                },
                new int[][] {
                    new int[] {48, 116, -86},
                    new int[] {117, 117, 123},
                    new int[] {118, 122, 73},
                },
                new int[][] {
                    new int[] {48, 114, -41},
                    new int[] {115, 115, 124},
                    new int[] {116, 122, 73},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 125},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 126},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 127},
                    new int[] {109, 122, 73},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 128},
                    new int[] {42, 42, 129},
                    new int[] {43, 65535, 128},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 130},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 131},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 98, 73},
                    new int[] {99, 99, 132},
                    new int[] {100, 122, 73},
                },
                new int[][] {
                    new int[] {48, 113, -42},
                    new int[] {114, 114, 133},
                    new int[] {115, 122, 73},
                },
                new int[][] {
                    new int[] {48, 98, -123},
                    new int[] {99, 99, 134},
                    new int[] {100, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 99, 73},
                    new int[] {100, 100, 135},
                    new int[] {101, 122, 73},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 136},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {0, 65535, -117},
                },
                new int[][] {
                    new int[] {0, 41, 115},
                    new int[] {42, 42, 129},
                    new int[] {43, 65535, -100},
                },
                new int[][] {
                    new int[] {48, 113, -42},
                    new int[] {114, 114, 137},
                    new int[] {115, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 104, -82},
                    new int[] {105, 105, 138},
                    new int[] {106, 122, 73},
                },
                new int[][] {
                    new int[] {48, 109, -109},
                    new int[] {110, 110, 139},
                    new int[] {111, 122, 73},
                },
                new int[][] {
                    new int[] {48, 115, -44},
                    new int[] {116, 116, 140},
                    new int[] {117, 122, 73},
                },
                new int[][] {
                    new int[] {48, 100, -43},
                    new int[] {101, 101, 141},
                    new int[] {102, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 111, -87},
                    new int[] {112, 112, 142},
                    new int[] {113, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 101, -40},
                    new int[] {102, 102, 143},
                    new int[] {103, 122, 73},
                },
                new int[][] {
                    new int[] {48, 95, -28},
                    new int[] {97, 97, 144},
                    new int[] {98, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
                new int[][] {
                    new int[] {48, 107, -37},
                    new int[] {108, 108, 145},
                    new int[] {109, 122, 73},
                },
                new int[][] {
                    new int[] {48, 122, -28},
                },
            },
        };
        
        
        #endregion
        
        
        
        #region Accept Table
        
        
        private static int[][] acceptTable = {
            new int[] {
                -1, 59, 59, 59, 59, 38, 18, 0, 36, 37, 16, 51, 52, 34, 32, 43,
                33, 42, 35, 4, 44, 45, 28, 29, 28, 41, 49, 19, 19, 53, 54, 31,
                30, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 55, -1, 56, 57, 18,
                17, 18, 0, 39, 16, 15, 16, -1, 26, -1, 58, 27, -1, 28, 22, 28,
                28, -1, 21, 50, 19, 19, 19, 19, 19, 19, 19, 19, 9, 19, 19, 19,
                19, 19, 19, 19, 46, 23, 40, 18, 17, 18, 16, 15, 16, 20, -1, -1,
                58, 24, 25, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 21, -1,
                58, 14, 19, 10, 19, 19, 19, 19, 12, 3, 19, 19, -1, -1, 19, 3,
                19, 19, 19, 19, 8, 13, 19, 11, 7, 19, 19, 6, 19, 5,
            },
            new int[] {
                -1, 59, 59, 59, 59, 38, 18, 0, 36, 37, 16, 51, 52, 34, 32, 43,
                33, 42, 35, 4, 44, 45, 28, 29, 28, 41, 47, 19, 19, 53, 54, 31,
                30, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 55, -1, 56, 57, 18,
                17, 18, 0, 39, 16, 15, 16, -1, 26, -1, 58, 27, -1, 28, 22, 28,
                28, -1, 21, 19, 19, 19, 19, 19, 19, 19, 19, 9, 19, 19, 19, 19,
                19, 19, 19, 23, 40, 48, 18, 17, 18, 16, 15, 16, 20, -1, -1, 58,
                24, 25, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 19, 21, -1, 58,
                14, 19, 10, 19, 19, 19, 19, 12, 3, 19, 19, -1, -1, 19, 3, 19,
                19, 19, 19, 8, 13, 19, 11, 7, 19, 19, 6, 19, 5,
            },
            new int[] {
                -1, 59, 59, 59, 59, 38, 18, 0, 36, 37, 16, 51, 52, 34, 32, 43,
                33, 42, 35, 4, 44, 45, 28, 29, 28, 41, 19, 19, 53, 54, 31, 30,
                19, 19, 2, 19, 19, 2, 19, 2, 19, 19, 2, 19, 19, 55, -1, 56,
                57, 18, 17, 18, 0, 39, 16, 15, 16, -1, 26, -1, 58, -1, 27, -1,
                28, 22, 28, 28, -1, 21, 19, 19, 19, 19, 19, 19, 19, 19, 9, 2,
                19, 19, 19, 19, 19, 19, 19, 23, 40, 48, 18, 17, 18, 16, 15, 16,
                20, -1, -1, 58, 1, 24, 25, 19, 19, 19, 19, 19, 19, 19, 19, 19,
                19, 19, 21, -1, 58, 14, 19, 10, 19, 19, 19, 19, 12, 3, 19, 19,
                -1, -1, 19, 3, 19, 19, 19, 19, 8, 13, 19, 11, 7, 19, 19, 6,
                19, 5,
            },
        };
        
        
        #endregion
        
    }
}
