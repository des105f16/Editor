using System;
using DLM.Editor.Nodes;

namespace DLM.Editor.Lexing
{
    public class Lexer : SablePP.Tools.Lexing.Lexer
    {
        private const int STATE1 = 0;
        private const int STATE2 = 1;
        
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
                case 2: return new TBool(text, line, position);
                case 3: return new TNumber(text, line, position);
                case 4: return new TWhile(text, line, position);
                case 5: return new TIf(text, line, position);
                case 6: return new TElse(text, line, position);
                case 7: return new TReturn(text, line, position);
                case 8: return new TActfor(text, line, position);
                case 9: return new TIdentifier(text, line, position);
                case 10: return new TRArrow(text, line, position);
                case 11: return new TLArrow(text, line, position);
                case 12: return new TCompare(text, line, position);
                case 13: return new TAssign(text, line, position);
                case 14: return new TUnderscore(text, line, position);
                case 15: return new TPlus(text, line, position);
                case 16: return new TMinus(text, line, position);
                case 17: return new TAsterisk(text, line, position);
                case 18: return new TSlash(text, line, position);
                case 19: return new TPercent(text, line, position);
                case 20: return new TBang(text, line, position);
                case 21: return new TAnd(text, line, position);
                case 22: return new TOr(text, line, position);
                case 23: return new TPeriod(text, line, position);
                case 24: return new TComma(text, line, position);
                case 25: return new TColon(text, line, position);
                case 26: return new TSemicolon(text, line, position);
                case 27: return new TLabelStart(text, line, position);
                case 28: return new TLabelEnd(text, line, position);
                case 29: return new TLPar(text, line, position);
                case 30: return new TRPar(text, line, position);
                case 31: return new TLSqu(text, line, position);
                case 32: return new TRSqu(text, line, position);
                case 33: return new TLCur(text, line, position);
                case 34: return new TRCur(text, line, position);
                case 35: return new TComment(text, line, position);
                case 36: return new TWhitespace(text, line, position);
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
                    new int[] {65, 90, 23},
                    new int[] {91, 91, 24},
                    new int[] {93, 93, 25},
                    new int[] {95, 95, 26},
                    new int[] {97, 100, 27},
                    new int[] {101, 101, 28},
                    new int[] {102, 102, 29},
                    new int[] {103, 104, 27},
                    new int[] {105, 105, 30},
                    new int[] {106, 113, 27},
                    new int[] {114, 114, 31},
                    new int[] {115, 115, 27},
                    new int[] {116, 116, 32},
                    new int[] {117, 118, 27},
                    new int[] {119, 119, 33},
                    new int[] {120, 122, 27},
                    new int[] {123, 123, 34},
                    new int[] {124, 124, 35},
                    new int[] {125, 125, 36},
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
                    new int[] {105, 105, 37},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 38},
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
                    new int[] {62, 62, 39},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 40},
                    new int[] {47, 47, 41},
                },
                new int[][] {
                    new int[] {48, 57, 17},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 42},
                    new int[] {61, 61, 43},
                },
                new int[][] {
                    new int[] {61, 61, 44},
                },
                new int[][] {
                    new int[] {61, 61, 45},
                },
                new int[][] {
                    new int[] {48, 57, 46},
                    new int[] {65, 90, 47},
                    new int[] {95, 95, 48},
                    new int[] {97, 122, 49},
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
                    new int[] {97, 107, 49},
                    new int[] {108, 108, 50},
                    new int[] {109, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 51},
                    new int[] {98, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 101, 49},
                    new int[] {102, 102, 52},
                    new int[] {103, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 100, 49},
                    new int[] {101, 101, 53},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 113, 49},
                    new int[] {114, 114, 54},
                    new int[] {115, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 103, 49},
                    new int[] {104, 104, 55},
                    new int[] {105, 122, 49},
                },
                new int[][] {
                    new int[] {123, 123, 56},
                },
                new int[][] {
                    new int[] {124, 124, 57},
                },
                new int[][] {
                    new int[] {125, 125, 58},
                },
                new int[][] {
                    new int[] {110, 110, 59},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 60},
                    new int[] {42, 42, 61},
                    new int[] {43, 65535, 60},
                },
                new int[][] {
                    new int[] {0, 9, 62},
                    new int[] {11, 12, 62},
                    new int[] {14, 65535, 62},
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
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 114, 49},
                    new int[] {115, 115, 63},
                    new int[] {116, 122, 49},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 64},
                    new int[] {109, 122, 49},
                },
                new int[][] {
                    new int[] {48, 90, -25},
                    new int[] {95, 95, 65},
                    new int[] {97, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 115, 49},
                    new int[] {116, 116, 66},
                    new int[] {117, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 116, 49},
                    new int[] {117, 117, 67},
                    new int[] {118, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 104, 49},
                    new int[] {105, 105, 68},
                    new int[] {106, 122, 49},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {99, 99, 69},
                },
                new int[][] {
                    new int[] {0, 65535, -42},
                },
                new int[][] {
                    new int[] {0, 41, 70},
                    new int[] {42, 42, 61},
                    new int[] {43, 46, 70},
                    new int[] {47, 47, 71},
                    new int[] {48, 65535, 70},
                },
                new int[][] {
                    new int[] {0, 65535, -43},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 72},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 114, -52},
                    new int[] {115, 115, 73},
                    new int[] {116, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 74},
                    new int[] {98, 122, 49},
                },
                new int[][] {
                    new int[] {48, 116, -56},
                    new int[] {117, 117, 75},
                    new int[] {118, 122, 49},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 76},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 77},
                    new int[] {109, 122, 49},
                },
                new int[][] {
                    new int[] {108, 108, 78},
                },
                new int[][] {
                    new int[] {0, 41, 79},
                    new int[] {42, 42, 80},
                    new int[] {43, 65535, 79},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 81},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 98, 49},
                    new int[] {99, 99, 82},
                    new int[] {100, 122, 49},
                },
                new int[][] {
                    new int[] {48, 113, -34},
                    new int[] {114, 114, 83},
                    new int[] {115, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 84},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {117, 117, 85},
                },
                new int[][] {
                    new int[] {0, 65535, -72},
                },
                new int[][] {
                    new int[] {0, 41, 70},
                    new int[] {42, 42, 80},
                    new int[] {43, 65535, -63},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 115, -55},
                    new int[] {116, 116, 86},
                    new int[] {117, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 109, 49},
                    new int[] {110, 110, 87},
                    new int[] {111, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {100, 100, 88},
                },
                new int[][] {
                    new int[] {48, 114, -52},
                    new int[] {115, 115, 89},
                    new int[] {116, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {101, 101, 90},
                },
                new int[][] {
                    new int[] {48, 90, -25},
                    new int[] {95, 95, 91},
                    new int[] {97, 122, 49},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 101, -32},
                    new int[] {102, 102, 92},
                    new int[] {103, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 110, 49},
                    new int[] {111, 111, 93},
                    new int[] {112, 122, 49},
                },
                new int[][] {
                    new int[] {48, 113, -34},
                    new int[] {114, 114, 94},
                    new int[] {115, 122, 49},
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
                    new int[] {65, 90, 22},
                    new int[] {91, 91, 23},
                    new int[] {93, 93, 24},
                    new int[] {95, 95, 25},
                    new int[] {97, 100, 26},
                    new int[] {101, 101, 27},
                    new int[] {102, 102, 28},
                    new int[] {103, 104, 26},
                    new int[] {105, 105, 29},
                    new int[] {106, 113, 26},
                    new int[] {114, 114, 30},
                    new int[] {115, 115, 26},
                    new int[] {116, 116, 31},
                    new int[] {117, 118, 26},
                    new int[] {119, 119, 32},
                    new int[] {120, 122, 26},
                    new int[] {123, 123, 33},
                    new int[] {124, 124, 34},
                    new int[] {125, 125, 35},
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
                    new int[] {38, 38, 36},
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
                    new int[] {62, 62, 37},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 38},
                    new int[] {47, 47, 39},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 40},
                    new int[] {45, 45, 41},
                    new int[] {46, 60, 40},
                    new int[] {61, 61, 42},
                    new int[] {62, 62, 43},
                    new int[] {63, 65535, 40},
                },
                new int[][] {
                    new int[] {61, 61, 44},
                },
                new int[][] {
                    new int[] {61, 61, 45},
                },
                new int[][] {
                    new int[] {48, 57, 46},
                    new int[] {65, 90, 47},
                    new int[] {95, 95, 48},
                    new int[] {97, 122, 49},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 107, 49},
                    new int[] {108, 108, 50},
                    new int[] {109, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 97, 51},
                    new int[] {98, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 101, 49},
                    new int[] {102, 102, 52},
                    new int[] {103, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 100, 49},
                    new int[] {101, 101, 53},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 113, 49},
                    new int[] {114, 114, 54},
                    new int[] {115, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 103, 49},
                    new int[] {104, 104, 55},
                    new int[] {105, 122, 49},
                },
                new int[][] {
                    new int[] {123, 123, 56},
                },
                new int[][] {
                    new int[] {124, 124, 57},
                },
                new int[][] {
                    new int[] {125, 125, 58},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 59},
                    new int[] {42, 42, 60},
                    new int[] {43, 65535, 59},
                },
                new int[][] {
                    new int[] {0, 9, 61},
                    new int[] {11, 12, 61},
                    new int[] {14, 65535, 61},
                },
                new int[][] {
                    new int[] {0, 61, 40},
                    new int[] {62, 65535, -21},
                },
                new int[][] {
                    new int[] {0, 65535, -42},
                },
                new int[][] {
                    new int[] {0, 65535, -42},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 114, 49},
                    new int[] {115, 115, 62},
                    new int[] {116, 122, 49},
                },
                new int[][] {
                    new int[] {48, 107, -29},
                    new int[] {108, 108, 63},
                    new int[] {109, 122, 49},
                },
                new int[][] {
                    new int[] {48, 90, -24},
                    new int[] {95, 95, 64},
                    new int[] {97, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 115, 49},
                    new int[] {116, 116, 65},
                    new int[] {117, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 116, 49},
                    new int[] {117, 117, 66},
                    new int[] {118, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 104, 49},
                    new int[] {105, 105, 67},
                    new int[] {106, 122, 49},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -40},
                },
                new int[][] {
                    new int[] {0, 41, 68},
                    new int[] {42, 42, 60},
                    new int[] {43, 46, 68},
                    new int[] {47, 47, 69},
                    new int[] {48, 65535, 68},
                },
                new int[][] {
                    new int[] {0, 65535, -41},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 70},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 114, -52},
                    new int[] {115, 115, 71},
                    new int[] {116, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 97, 72},
                    new int[] {98, 122, 49},
                },
                new int[][] {
                    new int[] {48, 116, -56},
                    new int[] {117, 117, 73},
                    new int[] {118, 122, 49},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 74},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 107, -29},
                    new int[] {108, 108, 75},
                    new int[] {109, 122, 49},
                },
                new int[][] {
                    new int[] {0, 41, 76},
                    new int[] {42, 42, 77},
                    new int[] {43, 65535, 76},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 78},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 98, 49},
                    new int[] {99, 99, 79},
                    new int[] {100, 122, 49},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 80},
                    new int[] {115, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 81},
                    new int[] {102, 122, 49},
                },
                new int[][] {
                    new int[] {0, 65535, -70},
                },
                new int[][] {
                    new int[] {0, 41, 68},
                    new int[] {42, 42, 77},
                    new int[] {43, 65535, -62},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 115, -55},
                    new int[] {116, 116, 82},
                    new int[] {117, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 109, 49},
                    new int[] {110, 110, 83},
                    new int[] {111, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 114, -52},
                    new int[] {115, 115, 84},
                    new int[] {116, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 90, -24},
                    new int[] {95, 95, 85},
                    new int[] {97, 122, 49},
                },
                new int[][] {
                    new int[] {48, 101, -31},
                    new int[] {102, 102, 86},
                    new int[] {103, 122, 49},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 110, 49},
                    new int[] {111, 111, 87},
                    new int[] {112, 122, 49},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 88},
                    new int[] {115, 122, 49},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
            },
        };
        
        
        #endregion
        
        
        
        #region Accept Table
        
        
        private static int[][] acceptTable = {
            new int[] {
                -1, 36, 36, 36, 36, 20, -1, 19, -1, 29, 30, 17, 15, 24, 16, 23,
                18, 3, 25, 26, 12, 13, 12, 9, 31, 32, 14, 9, 9, 9, 9, 9,
                9, 9, 33, -1, 34, -1, 21, 10, -1, 35, 11, 12, 12, 12, 9, 9,
                9, 9, 9, 9, 5, 9, 9, 9, 27, 22, 28, -1, -1, -1, 35, 9,
                9, 9, 9, 9, 9, -1, -1, 35, 6, 9, 9, 9, 2, 9, -1, -1,
                -1, 2, 9, 9, 4, -1, 9, 7, -1, 9, 0, 9, 9, 9, 8,
            },
            new int[] {
                -1, 36, 36, 36, 36, 20, 19, -1, 29, 30, 17, 15, 24, 16, 23, 18,
                3, 25, 26, 12, 13, 12, 9, 31, 32, 14, 9, 9, 9, 9, 9, 9,
                9, 33, -1, 34, 21, 10, -1, 35, -1, 11, 12, 1, 12, 12, 9, 9,
                9, 9, 9, 9, 5, 9, 9, 9, 27, 22, 28, -1, -1, 35, 9, 9,
                9, 9, 9, 9, -1, 35, 6, 9, 9, 9, 2, 9, -1, -1, 2, 9,
                9, 4, 9, 7, 9, 9, 9, 9, 8,
            },
        };
        
        
        #endregion
        
    }
}
