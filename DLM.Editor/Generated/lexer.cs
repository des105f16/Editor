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
                case 14: return new TPlus(text, line, position);
                case 15: return new TMinus(text, line, position);
                case 16: return new TAsterisk(text, line, position);
                case 17: return new TSlash(text, line, position);
                case 18: return new TPercent(text, line, position);
                case 19: return new TBang(text, line, position);
                case 20: return new TAnd(text, line, position);
                case 21: return new TOr(text, line, position);
                case 22: return new TPeriod(text, line, position);
                case 23: return new TComma(text, line, position);
                case 24: return new TColon(text, line, position);
                case 25: return new TSemicolon(text, line, position);
                case 26: return new TLabelStart(text, line, position);
                case 27: return new TLabelEnd(text, line, position);
                case 28: return new TLPar(text, line, position);
                case 29: return new TRPar(text, line, position);
                case 30: return new TLSqu(text, line, position);
                case 31: return new TRSqu(text, line, position);
                case 32: return new TLCur(text, line, position);
                case 33: return new TRCur(text, line, position);
                case 34: return new TComment(text, line, position);
                case 35: return new TWhitespace(text, line, position);
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
                    new int[] {105, 105, 36},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {38, 38, 37},
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
                    new int[] {62, 62, 38},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 39},
                    new int[] {47, 47, 40},
                },
                new int[][] {
                    new int[] {48, 57, 17},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 41},
                    new int[] {61, 61, 42},
                },
                new int[][] {
                    new int[] {61, 61, 43},
                },
                new int[][] {
                    new int[] {61, 61, 44},
                },
                new int[][] {
                    new int[] {48, 57, 45},
                    new int[] {65, 90, 46},
                    new int[] {95, 95, 47},
                    new int[] {97, 122, 48},
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
                    new int[] {97, 107, 48},
                    new int[] {108, 108, 49},
                    new int[] {109, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 50},
                    new int[] {98, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 101, 48},
                    new int[] {102, 102, 51},
                    new int[] {103, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 100, 48},
                    new int[] {101, 101, 52},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 113, 48},
                    new int[] {114, 114, 53},
                    new int[] {115, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 103, 48},
                    new int[] {104, 104, 54},
                    new int[] {105, 122, 48},
                },
                new int[][] {
                    new int[] {123, 123, 55},
                },
                new int[][] {
                    new int[] {124, 124, 56},
                },
                new int[][] {
                    new int[] {125, 125, 57},
                },
                new int[][] {
                    new int[] {110, 110, 58},
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
                    new int[] {97, 114, 48},
                    new int[] {115, 115, 62},
                    new int[] {116, 122, 48},
                },
                new int[][] {
                    new int[] {48, 107, -29},
                    new int[] {108, 108, 63},
                    new int[] {109, 122, 48},
                },
                new int[][] {
                    new int[] {48, 90, -25},
                    new int[] {95, 95, 64},
                    new int[] {97, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 115, 48},
                    new int[] {116, 116, 65},
                    new int[] {117, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 116, 48},
                    new int[] {117, 117, 66},
                    new int[] {118, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 104, 48},
                    new int[] {105, 105, 67},
                    new int[] {106, 122, 48},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {99, 99, 68},
                },
                new int[][] {
                    new int[] {0, 65535, -41},
                },
                new int[][] {
                    new int[] {0, 41, 69},
                    new int[] {42, 42, 60},
                    new int[] {43, 46, 69},
                    new int[] {47, 47, 70},
                    new int[] {48, 65535, 69},
                },
                new int[][] {
                    new int[] {0, 65535, -42},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 71},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 114, -51},
                    new int[] {115, 115, 72},
                    new int[] {116, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 73},
                    new int[] {98, 122, 48},
                },
                new int[][] {
                    new int[] {48, 116, -55},
                    new int[] {117, 117, 74},
                    new int[] {118, 122, 48},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 75},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 107, -29},
                    new int[] {108, 108, 76},
                    new int[] {109, 122, 48},
                },
                new int[][] {
                    new int[] {108, 108, 77},
                },
                new int[][] {
                    new int[] {0, 41, 78},
                    new int[] {42, 42, 79},
                    new int[] {43, 65535, 78},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 80},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 98, 48},
                    new int[] {99, 99, 81},
                    new int[] {100, 122, 48},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 82},
                    new int[] {115, 122, 48},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -32},
                    new int[] {101, 101, 83},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {117, 117, 84},
                },
                new int[][] {
                    new int[] {0, 65535, -71},
                },
                new int[][] {
                    new int[] {0, 41, 69},
                    new int[] {42, 42, 79},
                    new int[] {43, 65535, -62},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 115, -54},
                    new int[] {116, 116, 85},
                    new int[] {117, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 109, 48},
                    new int[] {110, 110, 86},
                    new int[] {111, 122, 48},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {100, 100, 87},
                },
                new int[][] {
                    new int[] {48, 114, -51},
                    new int[] {115, 115, 88},
                    new int[] {116, 122, 48},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {101, 101, 89},
                },
                new int[][] {
                    new int[] {48, 90, -25},
                    new int[] {95, 95, 90},
                    new int[] {97, 122, 48},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 101, -31},
                    new int[] {102, 102, 91},
                    new int[] {103, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 110, 48},
                    new int[] {111, 111, 92},
                    new int[] {112, 122, 48},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 93},
                    new int[] {115, 122, 48},
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
                    new int[] {97, 100, 25},
                    new int[] {101, 101, 26},
                    new int[] {102, 102, 27},
                    new int[] {103, 104, 25},
                    new int[] {105, 105, 28},
                    new int[] {106, 113, 25},
                    new int[] {114, 114, 29},
                    new int[] {115, 115, 25},
                    new int[] {116, 116, 30},
                    new int[] {117, 118, 25},
                    new int[] {119, 119, 31},
                    new int[] {120, 122, 25},
                    new int[] {123, 123, 32},
                    new int[] {124, 124, 33},
                    new int[] {125, 125, 34},
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
                    new int[] {38, 38, 35},
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
                    new int[] {62, 62, 36},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 37},
                    new int[] {47, 47, 38},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 39},
                    new int[] {45, 45, 40},
                    new int[] {46, 60, 39},
                    new int[] {61, 61, 41},
                    new int[] {62, 62, 42},
                    new int[] {63, 65535, 39},
                },
                new int[][] {
                    new int[] {61, 61, 43},
                },
                new int[][] {
                    new int[] {61, 61, 44},
                },
                new int[][] {
                    new int[] {48, 57, 45},
                    new int[] {65, 90, 46},
                    new int[] {95, 95, 47},
                    new int[] {97, 122, 48},
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
                    new int[] {97, 107, 48},
                    new int[] {108, 108, 49},
                    new int[] {109, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 97, 50},
                    new int[] {98, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 101, 48},
                    new int[] {102, 102, 51},
                    new int[] {103, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 100, 48},
                    new int[] {101, 101, 52},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 113, 48},
                    new int[] {114, 114, 53},
                    new int[] {115, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 103, 48},
                    new int[] {104, 104, 54},
                    new int[] {105, 122, 48},
                },
                new int[][] {
                    new int[] {123, 123, 55},
                },
                new int[][] {
                    new int[] {124, 124, 56},
                },
                new int[][] {
                    new int[] {125, 125, 57},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 58},
                    new int[] {42, 42, 59},
                    new int[] {43, 65535, 58},
                },
                new int[][] {
                    new int[] {0, 9, 60},
                    new int[] {11, 12, 60},
                    new int[] {14, 65535, 60},
                },
                new int[][] {
                    new int[] {0, 61, 39},
                    new int[] {62, 65535, -21},
                },
                new int[][] {
                    new int[] {0, 65535, -41},
                },
                new int[][] {
                    new int[] {0, 65535, -41},
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
                    new int[] {97, 114, 48},
                    new int[] {115, 115, 61},
                    new int[] {116, 122, 48},
                },
                new int[][] {
                    new int[] {48, 107, -28},
                    new int[] {108, 108, 62},
                    new int[] {109, 122, 48},
                },
                new int[][] {
                    new int[] {48, 90, -24},
                    new int[] {95, 95, 63},
                    new int[] {97, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 115, 48},
                    new int[] {116, 116, 64},
                    new int[] {117, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 116, 48},
                    new int[] {117, 117, 65},
                    new int[] {118, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 104, 48},
                    new int[] {105, 105, 66},
                    new int[] {106, 122, 48},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -39},
                },
                new int[][] {
                    new int[] {0, 41, 67},
                    new int[] {42, 42, 59},
                    new int[] {43, 46, 67},
                    new int[] {47, 47, 68},
                    new int[] {48, 65535, 67},
                },
                new int[][] {
                    new int[] {0, 65535, -40},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 69},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 114, -51},
                    new int[] {115, 115, 70},
                    new int[] {116, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 97, 71},
                    new int[] {98, 122, 48},
                },
                new int[][] {
                    new int[] {48, 116, -55},
                    new int[] {117, 117, 72},
                    new int[] {118, 122, 48},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 73},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 107, -28},
                    new int[] {108, 108, 74},
                    new int[] {109, 122, 48},
                },
                new int[][] {
                    new int[] {0, 41, 75},
                    new int[] {42, 42, 76},
                    new int[] {43, 65535, 75},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 77},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 98, 48},
                    new int[] {99, 99, 78},
                    new int[] {100, 122, 48},
                },
                new int[][] {
                    new int[] {48, 113, -32},
                    new int[] {114, 114, 79},
                    new int[] {115, 122, 48},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 80},
                    new int[] {102, 122, 48},
                },
                new int[][] {
                    new int[] {0, 65535, -69},
                },
                new int[][] {
                    new int[] {0, 41, 67},
                    new int[] {42, 42, 76},
                    new int[] {43, 65535, -61},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 115, -54},
                    new int[] {116, 116, 81},
                    new int[] {117, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 109, 48},
                    new int[] {110, 110, 82},
                    new int[] {111, 122, 48},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 114, -51},
                    new int[] {115, 115, 83},
                    new int[] {116, 122, 48},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 90, -24},
                    new int[] {95, 95, 84},
                    new int[] {97, 122, 48},
                },
                new int[][] {
                    new int[] {48, 101, -30},
                    new int[] {102, 102, 85},
                    new int[] {103, 122, 48},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 110, 48},
                    new int[] {111, 111, 86},
                    new int[] {112, 122, 48},
                },
                new int[][] {
                    new int[] {48, 113, -32},
                    new int[] {114, 114, 87},
                    new int[] {115, 122, 48},
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
                -1, 35, 35, 35, 35, 19, -1, 18, -1, 28, 29, 16, 14, 23, 15, 22,
                17, 3, 24, 25, 12, 13, 12, 9, 30, 31, 9, 9, 9, 9, 9, 9,
                9, 32, -1, 33, -1, 20, 10, -1, 34, 11, 12, 12, 12, 9, 9, 9,
                9, 9, 9, 5, 9, 9, 9, 26, 21, 27, -1, -1, -1, 34, 9, 9,
                9, 9, 9, 9, -1, -1, 34, 6, 9, 9, 9, 2, 9, -1, -1, -1,
                2, 9, 9, 4, -1, 9, 7, -1, 9, 0, 9, 9, 9, 8,
            },
            new int[] {
                -1, 35, 35, 35, 35, 19, 18, -1, 28, 29, 16, 14, 23, 15, 22, 17,
                3, 24, 25, 12, 13, 12, 9, 30, 31, 9, 9, 9, 9, 9, 9, 9,
                32, -1, 33, 20, 10, -1, 34, -1, 11, 12, 1, 12, 12, 9, 9, 9,
                9, 9, 9, 5, 9, 9, 9, 26, 21, 27, -1, -1, 34, 9, 9, 9,
                9, 9, 9, -1, 34, 6, 9, 9, 9, 2, 9, -1, -1, 2, 9, 9,
                4, 9, 7, 9, 9, 9, 9, 8,
            },
        };
        
        
        #endregion
        
    }
}
