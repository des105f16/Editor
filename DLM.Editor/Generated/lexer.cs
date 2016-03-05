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
                case 4: return new TPrincipall(text, line, position);
                case 5: return new TTypedef(text, line, position);
                case 6: return new TStruct(text, line, position);
                case 7: return new TWhile(text, line, position);
                case 8: return new TIf(text, line, position);
                case 9: return new TElse(text, line, position);
                case 10: return new TReturn(text, line, position);
                case 11: return new TIdentifier(text, line, position);
                case 12: return new TActsFor(text, line, position);
                case 13: return new TDeclassifyStart(text, line, position);
                case 14: return new TDeclassifyEnd(text, line, position);
                case 15: return new TRArrow(text, line, position);
                case 16: return new TLArrow(text, line, position);
                case 17: return new TCompare(text, line, position);
                case 18: return new TAssign(text, line, position);
                case 19: return new TUnderscore(text, line, position);
                case 20: return new TPlus(text, line, position);
                case 21: return new TMinus(text, line, position);
                case 22: return new TAsterisk(text, line, position);
                case 23: return new TSlash(text, line, position);
                case 24: return new TPercent(text, line, position);
                case 25: return new TBang(text, line, position);
                case 26: return new TAnd(text, line, position);
                case 27: return new TOr(text, line, position);
                case 28: return new TPeriod(text, line, position);
                case 29: return new TComma(text, line, position);
                case 30: return new TColon(text, line, position);
                case 31: return new TSemicolon(text, line, position);
                case 32: return new TLabelStart(text, line, position);
                case 33: return new TLabelEnd(text, line, position);
                case 34: return new TLPar(text, line, position);
                case 35: return new TRPar(text, line, position);
                case 36: return new TLSqu(text, line, position);
                case 37: return new TRSqu(text, line, position);
                case 38: return new TLCur(text, line, position);
                case 39: return new TRCur(text, line, position);
                case 40: return new TJoin(text, line, position);
                case 41: return new TComment(text, line, position);
                case 42: return new TWhitespace(text, line, position);
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
                    new int[] {63, 63, 23},
                    new int[] {65, 90, 24},
                    new int[] {91, 91, 25},
                    new int[] {93, 93, 26},
                    new int[] {95, 95, 27},
                    new int[] {97, 100, 28},
                    new int[] {101, 101, 29},
                    new int[] {102, 102, 30},
                    new int[] {103, 104, 28},
                    new int[] {105, 105, 31},
                    new int[] {106, 111, 28},
                    new int[] {112, 112, 32},
                    new int[] {113, 113, 28},
                    new int[] {114, 114, 33},
                    new int[] {115, 115, 34},
                    new int[] {116, 116, 35},
                    new int[] {117, 118, 28},
                    new int[] {119, 119, 36},
                    new int[] {120, 122, 28},
                    new int[] {123, 123, 37},
                    new int[] {124, 124, 38},
                    new int[] {125, 125, 39},
                    new int[] {8852, 8852, 40},
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
                    new int[] {105, 105, 41},
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
                    new int[] {48, 57, 17},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 47},
                    new int[] {61, 61, 48},
                    new int[] {124, 124, 49},
                },
                new int[][] {
                    new int[] {61, 61, 50},
                },
                new int[][] {
                    new int[] {61, 61, 51},
                },
                new int[][] {
                    new int[] {62, 62, 52},
                },
                new int[][] {
                    new int[] {48, 57, 53},
                    new int[] {65, 90, 54},
                    new int[] {95, 95, 55},
                    new int[] {97, 122, 56},
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
                    new int[] {97, 107, 56},
                    new int[] {108, 108, 57},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 58},
                    new int[] {98, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 101, 56},
                    new int[] {102, 102, 59},
                    new int[] {103, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 113, 56},
                    new int[] {114, 114, 60},
                    new int[] {115, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 100, 56},
                    new int[] {101, 101, 61},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 115, 56},
                    new int[] {116, 116, 62},
                    new int[] {117, 122, 56},
                },
                new int[][] {
                    new int[] {48, 113, -34},
                    new int[] {114, 114, 63},
                    new int[] {115, 120, 56},
                    new int[] {121, 121, 64},
                    new int[] {122, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 103, 56},
                    new int[] {104, 104, 65},
                    new int[] {105, 122, 56},
                },
                new int[][] {
                    new int[] {123, 123, 66},
                },
                new int[][] {
                    new int[] {62, 62, 67},
                    new int[] {124, 124, 68},
                },
                new int[][] {
                    new int[] {125, 125, 69},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {110, 110, 70},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 71},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 72},
                    new int[] {42, 42, 73},
                    new int[] {43, 65535, 72},
                },
                new int[][] {
                    new int[] {0, 9, 74},
                    new int[] {11, 12, 74},
                    new int[] {14, 65535, 74},
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
                    new int[] {48, 95, -26},
                    new int[] {97, 114, 56},
                    new int[] {115, 115, 75},
                    new int[] {116, 122, 56},
                },
                new int[][] {
                    new int[] {48, 107, -31},
                    new int[] {108, 108, 76},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 104, 56},
                    new int[] {105, 105, 77},
                    new int[] {106, 122, 56},
                },
                new int[][] {
                    new int[] {48, 115, -36},
                    new int[] {116, 116, 78},
                    new int[] {117, 122, 56},
                },
                new int[][] {
                    new int[] {48, 113, -34},
                    new int[] {114, 114, 79},
                    new int[] {115, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 116, 56},
                    new int[] {117, 117, 80},
                    new int[] {118, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 111, 56},
                    new int[] {112, 112, 81},
                    new int[] {113, 122, 56},
                },
                new int[][] {
                    new int[] {48, 104, -62},
                    new int[] {105, 105, 82},
                    new int[] {106, 122, 56},
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
                    new int[] {99, 99, 83},
                },
                new int[][] {
                    new int[] {63, 63, 84},
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                    new int[] {0, 41, 85},
                    new int[] {42, 42, 73},
                    new int[] {43, 46, 85},
                    new int[] {47, 47, 86},
                    new int[] {48, 65535, 85},
                },
                new int[][] {
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                    new int[] {48, 100, -35},
                    new int[] {101, 101, 87},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 114, -59},
                    new int[] {115, 115, 88},
                    new int[] {116, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 109, 56},
                    new int[] {110, 110, 89},
                    new int[] {111, 122, 56},
                },
                new int[][] {
                    new int[] {48, 116, -65},
                    new int[] {117, 117, 90},
                    new int[] {118, 122, 56},
                },
                new int[][] {
                    new int[] {48, 116, -65},
                    new int[] {117, 117, 91},
                    new int[] {118, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -35},
                    new int[] {101, 101, 92},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -35},
                    new int[] {101, 101, 93},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 107, -31},
                    new int[] {108, 108, 94},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                    new int[] {108, 108, 95},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 96},
                    new int[] {42, 42, 97},
                    new int[] {43, 65535, 96},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 100, -35},
                    new int[] {101, 101, 98},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 98, 56},
                    new int[] {99, 99, 99},
                    new int[] {100, 122, 56},
                },
                new int[][] {
                    new int[] {48, 113, -34},
                    new int[] {114, 114, 100},
                    new int[] {115, 122, 56},
                },
                new int[][] {
                    new int[] {48, 98, -91},
                    new int[] {99, 99, 101},
                    new int[] {100, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 99, 56},
                    new int[] {100, 100, 102},
                    new int[] {101, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -35},
                    new int[] {101, 101, 103},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {117, 117, 104},
                },
                new int[][] {
                    new int[] {0, 65535, -87},
                },
                new int[][] {
                    new int[] {0, 41, 85},
                    new int[] {42, 42, 97},
                    new int[] {43, 65535, -75},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 104, -62},
                    new int[] {105, 105, 105},
                    new int[] {106, 122, 56},
                },
                new int[][] {
                    new int[] {48, 109, -79},
                    new int[] {110, 110, 106},
                    new int[] {111, 122, 56},
                },
                new int[][] {
                    new int[] {48, 115, -36},
                    new int[] {116, 116, 107},
                    new int[] {117, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -35},
                    new int[] {101, 101, 108},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {100, 100, 109},
                },
                new int[][] {
                    new int[] {48, 111, -66},
                    new int[] {112, 112, 110},
                    new int[] {113, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 101, -33},
                    new int[] {102, 102, 111},
                    new int[] {103, 122, 56},
                },
                new int[][] {
                    new int[] {101, 101, 112},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 113},
                    new int[] {98, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -31},
                    new int[] {108, 108, 114},
                    new int[] {109, 122, 56},
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
                    new int[] {95, 95, 26},
                    new int[] {97, 100, 27},
                    new int[] {101, 101, 28},
                    new int[] {102, 102, 29},
                    new int[] {103, 104, 27},
                    new int[] {105, 105, 30},
                    new int[] {106, 111, 27},
                    new int[] {112, 112, 31},
                    new int[] {113, 113, 27},
                    new int[] {114, 114, 32},
                    new int[] {115, 115, 33},
                    new int[] {116, 116, 34},
                    new int[] {117, 118, 27},
                    new int[] {119, 119, 35},
                    new int[] {120, 122, 27},
                    new int[] {123, 123, 36},
                    new int[] {124, 124, 37},
                    new int[] {125, 125, 38},
                    new int[] {8852, 8852, 39},
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
                    new int[] {38, 38, 40},
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
                    new int[] {45, 45, 41},
                    new int[] {62, 62, 42},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 43},
                    new int[] {47, 47, 44},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 45},
                    new int[] {45, 45, 46},
                    new int[] {46, 60, 45},
                    new int[] {61, 61, 47},
                    new int[] {62, 62, 48},
                    new int[] {63, 123, 45},
                    new int[] {124, 124, 49},
                    new int[] {125, 65535, 45},
                },
                new int[][] {
                    new int[] {61, 61, 50},
                },
                new int[][] {
                    new int[] {61, 61, 51},
                },
                new int[][] {
                    new int[] {62, 62, 52},
                },
                new int[][] {
                    new int[] {48, 57, 53},
                    new int[] {65, 90, 54},
                    new int[] {95, 95, 55},
                    new int[] {97, 122, 56},
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
                    new int[] {97, 107, 56},
                    new int[] {108, 108, 57},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 58},
                    new int[] {98, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 101, 56},
                    new int[] {102, 102, 59},
                    new int[] {103, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 113, 56},
                    new int[] {114, 114, 60},
                    new int[] {115, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 100, 56},
                    new int[] {101, 101, 61},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 115, 56},
                    new int[] {116, 116, 62},
                    new int[] {117, 122, 56},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 63},
                    new int[] {115, 120, 56},
                    new int[] {121, 121, 64},
                    new int[] {122, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 103, 56},
                    new int[] {104, 104, 65},
                    new int[] {105, 122, 56},
                },
                new int[][] {
                    new int[] {123, 123, 66},
                },
                new int[][] {
                    new int[] {62, 62, 67},
                    new int[] {124, 124, 68},
                },
                new int[][] {
                    new int[] {125, 125, 69},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 70},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 71},
                    new int[] {42, 42, 72},
                    new int[] {43, 65535, 71},
                },
                new int[][] {
                    new int[] {0, 9, 73},
                    new int[] {11, 12, 73},
                    new int[] {14, 65535, 73},
                },
                new int[][] {
                    new int[] {0, 61, 45},
                    new int[] {62, 62, 48},
                    new int[] {63, 65535, 45},
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -47},
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
                    new int[] {97, 114, 56},
                    new int[] {115, 115, 74},
                    new int[] {116, 122, 56},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 75},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 104, 56},
                    new int[] {105, 105, 76},
                    new int[] {106, 122, 56},
                },
                new int[][] {
                    new int[] {48, 115, -35},
                    new int[] {116, 116, 77},
                    new int[] {117, 122, 56},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 78},
                    new int[] {115, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 116, 56},
                    new int[] {117, 117, 79},
                    new int[] {118, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 111, 56},
                    new int[] {112, 112, 80},
                    new int[] {113, 122, 56},
                },
                new int[][] {
                    new int[] {48, 104, -62},
                    new int[] {105, 105, 81},
                    new int[] {106, 122, 56},
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
                    new int[] {63, 63, 82},
                },
                new int[][] {
                    new int[] {0, 65535, -45},
                },
                new int[][] {
                    new int[] {0, 41, 83},
                    new int[] {42, 42, 72},
                    new int[] {43, 46, 83},
                    new int[] {47, 47, 84},
                    new int[] {48, 65535, 83},
                },
                new int[][] {
                    new int[] {0, 65535, -46},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 85},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 114, -59},
                    new int[] {115, 115, 86},
                    new int[] {116, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 109, 56},
                    new int[] {110, 110, 87},
                    new int[] {111, 122, 56},
                },
                new int[][] {
                    new int[] {48, 116, -65},
                    new int[] {117, 117, 88},
                    new int[] {118, 122, 56},
                },
                new int[][] {
                    new int[] {48, 116, -65},
                    new int[] {117, 117, 89},
                    new int[] {118, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 90},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 91},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 92},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 93},
                    new int[] {42, 42, 94},
                    new int[] {43, 65535, 93},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 95},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 98, 56},
                    new int[] {99, 99, 96},
                    new int[] {100, 122, 56},
                },
                new int[][] {
                    new int[] {48, 113, -33},
                    new int[] {114, 114, 97},
                    new int[] {115, 122, 56},
                },
                new int[][] {
                    new int[] {48, 98, -89},
                    new int[] {99, 99, 98},
                    new int[] {100, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 99, 56},
                    new int[] {100, 100, 99},
                    new int[] {101, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 100},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {0, 65535, -85},
                },
                new int[][] {
                    new int[] {0, 41, 83},
                    new int[] {42, 42, 94},
                    new int[] {43, 65535, -74},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 104, -62},
                    new int[] {105, 105, 101},
                    new int[] {106, 122, 56},
                },
                new int[][] {
                    new int[] {48, 109, -78},
                    new int[] {110, 110, 102},
                    new int[] {111, 122, 56},
                },
                new int[][] {
                    new int[] {48, 115, -35},
                    new int[] {116, 116, 103},
                    new int[] {117, 122, 56},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 104},
                    new int[] {102, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 111, -66},
                    new int[] {112, 112, 105},
                    new int[] {113, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 101, -32},
                    new int[] {102, 102, 106},
                    new int[] {103, 122, 56},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 107},
                    new int[] {98, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 108},
                    new int[] {109, 122, 56},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
            },
        };
        
        
        #endregion
        
        
        
        #region Accept Table
        
        
        private static int[][] acceptTable = {
            new int[] {
                -1, 42, 42, 42, 42, 25, -1, 24, -1, 34, 35, 22, 20, 29, 21, 28,
                23, 3, 30, 31, 17, 18, 17, -1, 11, 36, 37, 19, 11, 11, 11, 11,
                11, 11, 11, 11, 11, 38, -1, 39, 40, -1, 26, -1, 15, -1, 41, 16,
                17, 13, 17, 17, 12, 11, 11, 11, 11, 11, 11, 8, 11, 11, 11, 11,
                11, 11, 32, 14, 27, 33, -1, -1, -1, -1, 41, 11, 11, 11, 11, 11,
                11, 11, 11, -1, 12, -1, 41, 9, 11, 11, 11, 11, 2, 11, 11, -1,
                -1, -1, 2, 11, 11, 11, 11, 7, -1, 11, 10, 6, 11, -1, 11, 5,
                0, 11, 4,
            },
            new int[] {
                -1, 42, 42, 42, 42, 25, 24, -1, 34, 35, 22, 20, 29, 21, 28, 23,
                3, 30, 31, 17, 18, 17, -1, 11, 36, 37, 19, 11, 11, 11, 11, 11,
                11, 11, 11, 11, 38, -1, 39, 40, 26, -1, 15, -1, 41, -1, 16, 17,
                1, 13, 17, 17, 12, 11, 11, 11, 11, 11, 11, 8, 11, 11, 11, 11,
                11, 11, 32, 14, 27, 33, -1, -1, -1, 41, 11, 11, 11, 11, 11, 11,
                11, 11, 12, -1, 41, 9, 11, 11, 11, 11, 2, 11, 11, -1, -1, 2,
                11, 11, 11, 11, 7, 11, 10, 6, 11, 11, 5, 11, 4,
            },
        };
        
        
        #endregion
        
    }
}
