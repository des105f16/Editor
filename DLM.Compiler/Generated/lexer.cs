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
                case 0: return new TInclude(text, line, position);
                case 1: return new TFile(text, line, position);
                case 2: return new TAt(text, line, position);
                case 3: return new TTime(text, line, position);
                case 4: return new TIntervalUnit(text, line, position);
                case 5: return new TBool(text, line, position);
                case 6: return new TNumber(text, line, position);
                case 7: return new TPrincipall(text, line, position);
                case 8: return new TTypedef(text, line, position);
                case 9: return new TStruct(text, line, position);
                case 10: return new TWhile(text, line, position);
                case 11: return new TIf(text, line, position);
                case 12: return new TElse(text, line, position);
                case 13: return new TReturn(text, line, position);
                case 14: return new TThis(text, line, position);
                case 15: return new TCaller(text, line, position);
                case 16: return new TIdentifier(text, line, position);
                case 17: return new TActsFor(text, line, position);
                case 18: return new TIfActsFor(text, line, position);
                case 19: return new TDeclassifyStart(text, line, position);
                case 20: return new TDeclassifyEnd(text, line, position);
                case 21: return new TFuncAuthStart(text, line, position);
                case 22: return new TFuncAuthEnd(text, line, position);
                case 23: return new TRArrow(text, line, position);
                case 24: return new TLArrow(text, line, position);
                case 25: return new TCompare(text, line, position);
                case 26: return new TAssign(text, line, position);
                case 27: return new TUnderscore(text, line, position);
                case 28: return new THat(text, line, position);
                case 29: return new TPlus(text, line, position);
                case 30: return new TMinus(text, line, position);
                case 31: return new TAsterisk(text, line, position);
                case 32: return new TSlash(text, line, position);
                case 33: return new TPercent(text, line, position);
                case 34: return new TBang(text, line, position);
                case 35: return new TAnd(text, line, position);
                case 36: return new TOr(text, line, position);
                case 37: return new TPeriod(text, line, position);
                case 38: return new TComma(text, line, position);
                case 39: return new TColon(text, line, position);
                case 40: return new TSemicolon(text, line, position);
                case 41: return new TLabelStart(text, line, position);
                case 42: return new TLabelEnd(text, line, position);
                case 43: return new TLPar(text, line, position);
                case 44: return new TRPar(text, line, position);
                case 45: return new TLSqu(text, line, position);
                case 46: return new TRSqu(text, line, position);
                case 47: return new TLCur(text, line, position);
                case 48: return new TRCur(text, line, position);
                case 49: return new TJoin(text, line, position);
                case 50: return new TComment(text, line, position);
                case 51: return new TWhitespace(text, line, position);
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
                case 41:
                    switch (currentState)
                    {
                        case STATE1: return STATE3;
                        default: return -1;
                    }
                case 42:
                    switch (currentState)
                    {
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
                    new int[] {35, 35, 6},
                    new int[] {37, 37, 7},
                    new int[] {38, 38, 8},
                    new int[] {40, 40, 9},
                    new int[] {41, 41, 10},
                    new int[] {42, 42, 11},
                    new int[] {43, 43, 12},
                    new int[] {44, 44, 13},
                    new int[] {45, 45, 14},
                    new int[] {46, 46, 15},
                    new int[] {47, 47, 16},
                    new int[] {48, 57, 17},
                    new int[] {58, 58, 18},
                    new int[] {59, 59, 19},
                    new int[] {60, 60, 20},
                    new int[] {61, 61, 21},
                    new int[] {62, 62, 22},
                    new int[] {63, 63, 23},
                    new int[] {65, 90, 24},
                    new int[] {91, 91, 25},
                    new int[] {93, 93, 26},
                    new int[] {94, 94, 27},
                    new int[] {95, 95, 28},
                    new int[] {97, 98, 29},
                    new int[] {99, 99, 30},
                    new int[] {100, 100, 29},
                    new int[] {101, 101, 31},
                    new int[] {102, 102, 32},
                    new int[] {103, 104, 29},
                    new int[] {105, 105, 33},
                    new int[] {106, 111, 29},
                    new int[] {112, 112, 34},
                    new int[] {113, 113, 29},
                    new int[] {114, 114, 35},
                    new int[] {115, 115, 36},
                    new int[] {116, 116, 37},
                    new int[] {117, 118, 29},
                    new int[] {119, 119, 38},
                    new int[] {120, 122, 29},
                    new int[] {123, 123, 39},
                    new int[] {124, 124, 40},
                    new int[] {125, 125, 41},
                    new int[] {8852, 8852, 42},
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
                    new int[] {105, 105, 43},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 44},
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
                    new int[] {45, 45, 45},
                    new int[] {62, 62, 46},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 47},
                    new int[] {47, 47, 48},
                },
                new int[][] {
                    new int[] {48, 57, 17},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 49},
                    new int[] {60, 60, 50},
                    new int[] {61, 61, 51},
                    new int[] {124, 124, 52},
                },
                new int[][] {
                    new int[] {61, 61, 53},
                },
                new int[][] {
                    new int[] {61, 61, 54},
                    new int[] {62, 62, 55},
                },
                new int[][] {
                    new int[] {62, 62, 56},
                },
                new int[][] {
                    new int[] {48, 57, 57},
                    new int[] {65, 90, 58},
                    new int[] {95, 95, 59},
                    new int[] {97, 122, 60},
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
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 61},
                    new int[] {98, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 107, 60},
                    new int[] {108, 108, 62},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 63},
                    new int[] {98, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 101, 60},
                    new int[] {102, 102, 64},
                    new int[] {103, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 113, 60},
                    new int[] {114, 114, 65},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 100, 60},
                    new int[] {101, 101, 66},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 115, 60},
                    new int[] {116, 116, 67},
                    new int[] {117, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 103, 60},
                    new int[] {104, 104, 68},
                    new int[] {105, 113, 60},
                    new int[] {114, 114, 69},
                    new int[] {115, 120, 60},
                    new int[] {121, 121, 70},
                    new int[] {122, 122, 60},
                },
                new int[][] {
                    new int[] {48, 103, -39},
                    new int[] {104, 104, 71},
                    new int[] {105, 122, 60},
                },
                new int[][] {
                    new int[] {123, 123, 72},
                },
                new int[][] {
                    new int[] {62, 62, 73},
                    new int[] {124, 124, 74},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {110, 110, 75},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 76},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 77},
                    new int[] {42, 42, 78},
                    new int[] {43, 65535, 77},
                },
                new int[][] {
                    new int[] {0, 9, 79},
                    new int[] {11, 12, 79},
                    new int[] {14, 65535, 79},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 80},
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
                    new int[] {62, 62, 81},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 82},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 114, 60},
                    new int[] {115, 115, 83},
                    new int[] {116, 122, 60},
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 84},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 104, 60},
                    new int[] {105, 105, 85},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                    new int[] {48, 115, -38},
                    new int[] {116, 116, 86},
                    new int[] {117, 122, 60},
                },
                new int[][] {
                    new int[] {48, 113, -36},
                    new int[] {114, 114, 87},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 104, -67},
                    new int[] {105, 105, 88},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 116, 60},
                    new int[] {117, 117, 89},
                    new int[] {118, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 111, 60},
                    new int[] {112, 112, 90},
                    new int[] {113, 122, 60},
                },
                new int[][] {
                    new int[] {48, 104, -67},
                    new int[] {105, 105, 91},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {99, 99, 92},
                },
                new int[][] {
                    new int[] {63, 63, 93},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                    new int[] {0, 41, 94},
                    new int[] {42, 42, 78},
                    new int[] {43, 46, 94},
                    new int[] {47, 47, 95},
                    new int[] {48, 65535, 94},
                },
                new int[][] {
                    new int[] {0, 65535, -50},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 96},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 97},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 114, -64},
                    new int[] {115, 115, 98},
                    new int[] {116, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 109, 60},
                    new int[] {110, 110, 99},
                    new int[] {111, 122, 60},
                },
                new int[][] {
                    new int[] {48, 116, -71},
                    new int[] {117, 117, 100},
                    new int[] {118, 122, 60},
                },
                new int[][] {
                    new int[] {48, 116, -71},
                    new int[] {117, 117, 101},
                    new int[] {118, 122, 60},
                },
                new int[][] {
                    new int[] {48, 114, -64},
                    new int[] {115, 115, 102},
                    new int[] {116, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 103},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 104},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 105},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {108, 108, 106},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 107},
                    new int[] {42, 42, 108},
                    new int[] {43, 65535, 107},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 109},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 110},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 98, 60},
                    new int[] {99, 99, 111},
                    new int[] {100, 122, 60},
                },
                new int[][] {
                    new int[] {48, 113, -36},
                    new int[] {114, 114, 112},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 98, -101},
                    new int[] {99, 99, 113},
                    new int[] {100, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 99, 60},
                    new int[] {100, 100, 114},
                    new int[] {101, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 115},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {117, 117, 116},
                },
                new int[][] {
                    new int[] {0, 65535, -96},
                },
                new int[][] {
                    new int[] {0, 41, 94},
                    new int[] {42, 42, 108},
                    new int[] {43, 65535, -80},
                },
                new int[][] {
                    new int[] {48, 113, -36},
                    new int[] {114, 114, 117},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 104, -67},
                    new int[] {105, 105, 118},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                    new int[] {48, 109, -87},
                    new int[] {110, 110, 119},
                    new int[] {111, 122, 60},
                },
                new int[][] {
                    new int[] {48, 115, -38},
                    new int[] {116, 116, 120},
                    new int[] {117, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 121},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {100, 100, 122},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 111, -72},
                    new int[] {112, 112, 123},
                    new int[] {113, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 101, -35},
                    new int[] {102, 102, 124},
                    new int[] {103, 122, 60},
                },
                new int[][] {
                    new int[] {101, 101, 125},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 126},
                    new int[] {98, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 127},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
            },
            new int[][][] {
                new int[][] {
                    new int[] {9, 9, 1},
                    new int[] {10, 10, 2},
                    new int[] {13, 13, 3},
                    new int[] {32, 32, 4},
                    new int[] {33, 33, 5},
                    new int[] {37, 37, 6},
                    new int[] {38, 38, 7},
                    new int[] {40, 40, 8},
                    new int[] {41, 41, 9},
                    new int[] {42, 42, 10},
                    new int[] {43, 43, 11},
                    new int[] {44, 44, 12},
                    new int[] {45, 45, 13},
                    new int[] {46, 46, 14},
                    new int[] {47, 47, 15},
                    new int[] {48, 57, 16},
                    new int[] {58, 58, 17},
                    new int[] {59, 59, 18},
                    new int[] {60, 60, 19},
                    new int[] {61, 61, 20},
                    new int[] {62, 62, 21},
                    new int[] {63, 63, 22},
                    new int[] {65, 90, 23},
                    new int[] {91, 91, 24},
                    new int[] {93, 93, 25},
                    new int[] {94, 94, 26},
                    new int[] {95, 95, 27},
                    new int[] {97, 98, 28},
                    new int[] {99, 99, 29},
                    new int[] {100, 100, 28},
                    new int[] {101, 101, 30},
                    new int[] {102, 102, 31},
                    new int[] {103, 104, 28},
                    new int[] {105, 105, 32},
                    new int[] {106, 111, 28},
                    new int[] {112, 112, 33},
                    new int[] {113, 113, 28},
                    new int[] {114, 114, 34},
                    new int[] {115, 115, 35},
                    new int[] {116, 116, 36},
                    new int[] {117, 118, 28},
                    new int[] {119, 119, 37},
                    new int[] {120, 122, 28},
                    new int[] {123, 123, 38},
                    new int[] {124, 124, 39},
                    new int[] {125, 125, 40},
                    new int[] {8852, 8852, 41},
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
                },
                new int[][] {
                    new int[] {38, 38, 42},
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
                    new int[] {45, 45, 43},
                    new int[] {62, 62, 44},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 45},
                    new int[] {47, 47, 46},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 47},
                    new int[] {45, 45, 48},
                    new int[] {46, 59, 47},
                    new int[] {60, 60, 49},
                    new int[] {61, 61, 50},
                    new int[] {62, 62, 51},
                    new int[] {63, 123, 47},
                    new int[] {124, 124, 52},
                    new int[] {125, 65535, 47},
                },
                new int[][] {
                    new int[] {61, 61, 53},
                },
                new int[][] {
                    new int[] {61, 61, 54},
                    new int[] {62, 62, 55},
                },
                new int[][] {
                    new int[] {62, 62, 56},
                },
                new int[][] {
                    new int[] {48, 57, 57},
                    new int[] {65, 90, 58},
                    new int[] {95, 95, 59},
                    new int[] {97, 122, 60},
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
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 61},
                    new int[] {98, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 107, 60},
                    new int[] {108, 108, 62},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 63},
                    new int[] {98, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 101, 60},
                    new int[] {102, 102, 64},
                    new int[] {103, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 113, 60},
                    new int[] {114, 114, 65},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 100, 60},
                    new int[] {101, 101, 66},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 115, 60},
                    new int[] {116, 116, 67},
                    new int[] {117, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 103, 60},
                    new int[] {104, 104, 68},
                    new int[] {105, 113, 60},
                    new int[] {114, 114, 69},
                    new int[] {115, 120, 60},
                    new int[] {121, 121, 70},
                    new int[] {122, 122, 60},
                },
                new int[][] {
                    new int[] {48, 103, -38},
                    new int[] {104, 104, 71},
                    new int[] {105, 122, 60},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 72},
                    new int[] {124, 124, 73},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 74},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 75},
                    new int[] {42, 42, 76},
                    new int[] {43, 65535, 75},
                },
                new int[][] {
                    new int[] {0, 9, 77},
                    new int[] {11, 12, 77},
                    new int[] {14, 65535, 77},
                },
                new int[][] {
                    new int[] {0, 61, 47},
                    new int[] {62, 62, 51},
                    new int[] {63, 65535, 47},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                    new int[] {0, 59, 47},
                    new int[] {60, 60, 78},
                    new int[] {61, 61, 47},
                    new int[] {62, 65535, -49},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 79},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 80},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 114, 60},
                    new int[] {115, 115, 81},
                    new int[] {116, 122, 60},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 82},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 104, 60},
                    new int[] {105, 105, 83},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                    new int[] {48, 115, -37},
                    new int[] {116, 116, 84},
                    new int[] {117, 122, 60},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 85},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 104, -67},
                    new int[] {105, 105, 86},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 116, 60},
                    new int[] {117, 117, 87},
                    new int[] {118, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 111, 60},
                    new int[] {112, 112, 88},
                    new int[] {113, 122, 60},
                },
                new int[][] {
                    new int[] {48, 104, -67},
                    new int[] {105, 105, 89},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {63, 63, 90},
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                    new int[] {0, 41, 91},
                    new int[] {42, 42, 76},
                    new int[] {43, 46, 91},
                    new int[] {47, 47, 92},
                    new int[] {48, 65535, 91},
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
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 93},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 94},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 114, -64},
                    new int[] {115, 115, 95},
                    new int[] {116, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 109, 60},
                    new int[] {110, 110, 96},
                    new int[] {111, 122, 60},
                },
                new int[][] {
                    new int[] {48, 116, -71},
                    new int[] {117, 117, 97},
                    new int[] {118, 122, 60},
                },
                new int[][] {
                    new int[] {48, 116, -71},
                    new int[] {117, 117, 98},
                    new int[] {118, 122, 60},
                },
                new int[][] {
                    new int[] {48, 114, -64},
                    new int[] {115, 115, 99},
                    new int[] {116, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 100},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 101},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 102},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 103},
                    new int[] {42, 42, 104},
                    new int[] {43, 65535, 103},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 105},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 106},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 98, 60},
                    new int[] {99, 99, 107},
                    new int[] {100, 122, 60},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 108},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 98, -98},
                    new int[] {99, 99, 109},
                    new int[] {100, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 99, 60},
                    new int[] {100, 100, 110},
                    new int[] {101, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 111},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {0, 65535, -93},
                },
                new int[][] {
                    new int[] {0, 41, 91},
                    new int[] {42, 42, 104},
                    new int[] {43, 65535, -78},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 112},
                    new int[] {115, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 104, -67},
                    new int[] {105, 105, 113},
                    new int[] {106, 122, 60},
                },
                new int[][] {
                    new int[] {48, 109, -85},
                    new int[] {110, 110, 114},
                    new int[] {111, 122, 60},
                },
                new int[][] {
                    new int[] {48, 115, -37},
                    new int[] {116, 116, 115},
                    new int[] {117, 122, 60},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 116},
                    new int[] {102, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 111, -72},
                    new int[] {112, 112, 117},
                    new int[] {113, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 101, -34},
                    new int[] {102, 102, 118},
                    new int[] {103, 122, 60},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 119},
                    new int[] {98, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 120},
                    new int[] {109, 122, 60},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
            },
            new int[][][] {
                new int[][] {
                    new int[] {9, 9, 1},
                    new int[] {10, 10, 2},
                    new int[] {13, 13, 3},
                    new int[] {32, 32, 4},
                    new int[] {33, 33, 5},
                    new int[] {37, 37, 6},
                    new int[] {38, 38, 7},
                    new int[] {40, 40, 8},
                    new int[] {41, 41, 9},
                    new int[] {42, 42, 10},
                    new int[] {43, 43, 11},
                    new int[] {44, 44, 12},
                    new int[] {45, 45, 13},
                    new int[] {46, 46, 14},
                    new int[] {47, 47, 15},
                    new int[] {48, 57, 16},
                    new int[] {58, 58, 17},
                    new int[] {59, 59, 18},
                    new int[] {60, 60, 19},
                    new int[] {61, 61, 20},
                    new int[] {62, 62, 21},
                    new int[] {63, 63, 22},
                    new int[] {64, 64, 23},
                    new int[] {65, 90, 24},
                    new int[] {91, 91, 25},
                    new int[] {93, 93, 26},
                    new int[] {94, 94, 27},
                    new int[] {95, 95, 28},
                    new int[] {97, 98, 29},
                    new int[] {99, 99, 30},
                    new int[] {100, 100, 31},
                    new int[] {101, 101, 32},
                    new int[] {102, 102, 33},
                    new int[] {103, 103, 29},
                    new int[] {104, 104, 34},
                    new int[] {105, 105, 35},
                    new int[] {106, 108, 29},
                    new int[] {109, 109, 36},
                    new int[] {110, 111, 29},
                    new int[] {112, 112, 37},
                    new int[] {113, 113, 29},
                    new int[] {114, 114, 38},
                    new int[] {115, 115, 39},
                    new int[] {116, 116, 40},
                    new int[] {117, 118, 29},
                    new int[] {119, 119, 41},
                    new int[] {120, 122, 29},
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
                },
                new int[][] {
                    new int[] {38, 38, 46},
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
                    new int[] {45, 45, 47},
                    new int[] {62, 62, 48},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 49},
                    new int[] {47, 47, 50},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                    new int[] {58, 58, 51},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 52},
                    new int[] {60, 60, 53},
                    new int[] {61, 61, 54},
                    new int[] {124, 124, 55},
                },
                new int[][] {
                    new int[] {61, 61, 56},
                },
                new int[][] {
                    new int[] {61, 61, 57},
                    new int[] {62, 62, 58},
                },
                new int[][] {
                    new int[] {62, 62, 59},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 57, 60},
                    new int[] {65, 90, 61},
                    new int[] {95, 95, 62},
                    new int[] {97, 122, 63},
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
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 64},
                    new int[] {98, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 107, 63},
                    new int[] {108, 108, 65},
                    new int[] {109, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 66},
                    new int[] {98, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 101, 63},
                    new int[] {102, 102, 67},
                    new int[] {103, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 114, 63},
                    new int[] {115, 115, 68},
                    new int[] {116, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 113, 63},
                    new int[] {114, 114, 69},
                    new int[] {115, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 100, 63},
                    new int[] {101, 101, 70},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 115, 63},
                    new int[] {116, 116, 71},
                    new int[] {117, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 103, 63},
                    new int[] {104, 104, 72},
                    new int[] {105, 113, 63},
                    new int[] {114, 114, 73},
                    new int[] {115, 120, 63},
                    new int[] {121, 121, 74},
                    new int[] {122, 122, 63},
                },
                new int[][] {
                    new int[] {48, 103, -42},
                    new int[] {104, 104, 75},
                    new int[] {105, 122, 63},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 76},
                    new int[] {124, 124, 77},
                },
                new int[][] {
                    new int[] {125, 125, 78},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 79},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 80},
                    new int[] {42, 42, 81},
                    new int[] {43, 65535, 80},
                },
                new int[][] {
                    new int[] {0, 9, 82},
                    new int[] {11, 12, 82},
                    new int[] {14, 65535, 82},
                },
                new int[][] {
                    new int[] {48, 57, 83},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {60, 60, 84},
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
                    new int[] {62, 62, 85},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 107, -34},
                    new int[] {108, 108, 86},
                    new int[] {109, 122, 63},
                },
                new int[][] {
                    new int[] {48, 114, -38},
                    new int[] {115, 115, 87},
                    new int[] {116, 122, 63},
                },
                new int[][] {
                    new int[] {48, 107, -34},
                    new int[] {108, 108, 88},
                    new int[] {109, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 104, 63},
                    new int[] {105, 105, 89},
                    new int[] {106, 122, 63},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 90},
                    new int[] {117, 122, 63},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 91},
                    new int[] {115, 122, 63},
                },
                new int[][] {
                    new int[] {48, 104, -71},
                    new int[] {105, 105, 92},
                    new int[] {106, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 116, 63},
                    new int[] {117, 117, 93},
                    new int[] {118, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 111, 63},
                    new int[] {112, 112, 94},
                    new int[] {113, 122, 63},
                },
                new int[][] {
                    new int[] {48, 104, -71},
                    new int[] {105, 105, 95},
                    new int[] {106, 122, 63},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {63, 63, 96},
                },
                new int[][] {
                    new int[] {0, 65535, -51},
                },
                new int[][] {
                    new int[] {0, 41, 97},
                    new int[] {42, 42, 81},
                    new int[] {43, 46, 97},
                    new int[] {47, 47, 98},
                    new int[] {48, 65535, 97},
                },
                new int[][] {
                    new int[] {0, 65535, -52},
                },
                new int[][] {
                    new int[] {48, 57, 83},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -34},
                    new int[] {108, 108, 99},
                    new int[] {109, 122, 63},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 100},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 114, -38},
                    new int[] {115, 115, 101},
                    new int[] {116, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 109, 63},
                    new int[] {110, 110, 102},
                    new int[] {111, 122, 63},
                },
                new int[][] {
                    new int[] {48, 116, -75},
                    new int[] {117, 117, 103},
                    new int[] {118, 122, 63},
                },
                new int[][] {
                    new int[] {48, 116, -75},
                    new int[] {117, 117, 104},
                    new int[] {118, 122, 63},
                },
                new int[][] {
                    new int[] {48, 114, -38},
                    new int[] {115, 115, 105},
                    new int[] {116, 122, 63},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 106},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 107},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 107, -34},
                    new int[] {108, 108, 108},
                    new int[] {109, 122, 63},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 109},
                    new int[] {42, 42, 110},
                    new int[] {43, 65535, 109},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 111},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 112},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 98, 63},
                    new int[] {99, 99, 113},
                    new int[] {100, 122, 63},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 114},
                    new int[] {115, 122, 63},
                },
                new int[][] {
                    new int[] {48, 98, -104},
                    new int[] {99, 99, 115},
                    new int[] {100, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 99, 63},
                    new int[] {100, 100, 116},
                    new int[] {101, 122, 63},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 117},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {0, 65535, -99},
                },
                new int[][] {
                    new int[] {0, 41, 97},
                    new int[] {42, 42, 110},
                    new int[] {43, 65535, -83},
                },
                new int[][] {
                    new int[] {48, 113, -39},
                    new int[] {114, 114, 118},
                    new int[] {115, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 104, -71},
                    new int[] {105, 105, 119},
                    new int[] {106, 122, 63},
                },
                new int[][] {
                    new int[] {48, 109, -91},
                    new int[] {110, 110, 120},
                    new int[] {111, 122, 63},
                },
                new int[][] {
                    new int[] {48, 115, -41},
                    new int[] {116, 116, 121},
                    new int[] {117, 122, 63},
                },
                new int[][] {
                    new int[] {48, 100, -40},
                    new int[] {101, 101, 122},
                    new int[] {102, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 111, -76},
                    new int[] {112, 112, 123},
                    new int[] {113, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 101, -37},
                    new int[] {102, 102, 124},
                    new int[] {103, 122, 63},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 125},
                    new int[] {98, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 107, -34},
                    new int[] {108, 108, 126},
                    new int[] {109, 122, 63},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
            },
        };
        
        
        #endregion
        
        
        
        #region Accept Table
        
        
        private static int[][] acceptTable = {
            new int[] {
                -1, 51, 51, 51, 51, 34, -1, 33, -1, 43, 44, 31, 29, 38, 30, 37,
                32, 6, 39, 40, 25, 26, 25, -1, 16, 45, 46, 28, 27, 16, 16, 16,
                16, 16, 16, 16, 16, 16, 16, 47, -1, 48, 49, -1, 35, -1, 23, -1,
                50, 24, -1, 25, 19, 25, 25, -1, 18, 16, 16, 16, 16, 16, 16, 16,
                11, 16, 16, 16, 16, 16, 16, 16, 41, 20, 36, -1, 17, -1, -1, 50,
                21, 22, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, -1, 18, -1, 50,
                16, 12, 16, 16, 16, 16, 14, 5, 16, 16, -1, -1, -1, 16, 5, 16,
                16, 16, 16, 10, -1, 15, 16, 13, 9, 16, -1, 16, 8, 0, 16, 7,
            },
            new int[] {
                -1, 51, 51, 51, 51, 34, 33, -1, 43, 44, 31, 29, 38, 30, 37, 32,
                6, 39, 40, 25, 26, 25, -1, 16, 45, 46, 28, 27, 16, 16, 16, 16,
                16, 16, 16, 16, 16, 16, 47, -1, 48, 49, 35, -1, 23, -1, 50, -1,
                24, -1, 25, 1, 19, 25, 25, -1, 18, 16, 16, 16, 16, 16, 16, 16,
                11, 16, 16, 16, 16, 16, 16, 16, 20, 36, 17, -1, -1, 50, 21, 22,
                16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 18, -1, 50, 16, 12, 16,
                16, 16, 16, 14, 5, 16, 16, -1, -1, 16, 5, 16, 16, 16, 16, 10,
                15, 16, 13, 9, 16, 16, 8, 16, 7,
            },
            new int[] {
                -1, 51, 51, 51, 51, 34, 33, -1, 43, 44, 31, 29, 38, 30, 37, 32,
                6, 39, 40, 25, 26, 25, -1, 2, 16, 45, 46, 28, 27, 16, 16, 4,
                16, 16, 4, 16, 4, 16, 16, 4, 16, 16, 47, -1, 48, 49, 35, -1,
                23, -1, 50, -1, 24, -1, 25, 19, 25, 25, -1, 18, 16, 16, 16, 16,
                16, 16, 16, 11, 4, 16, 16, 16, 16, 16, 16, 16, 20, 36, 42, 17,
                -1, -1, 50, 3, 21, 22, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16,
                18, -1, 50, 16, 12, 16, 16, 16, 16, 14, 5, 16, 16, -1, -1, 16,
                5, 16, 16, 16, 16, 10, 15, 16, 13, 9, 16, 16, 8, 16, 7,
            },
        };
        
        
        #endregion
        
    }
}
