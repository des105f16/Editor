using System;
using DLM.Editor.Nodes;

namespace DLM.Editor.Lexing
{
    public class Lexer : SablePP.Tools.Lexing.Lexer
    {
        public Lexer(System.IO.TextReader input)
            : base(input, 0, gotoTable, acceptTable)
        {
        }
        
        protected override SablePP.Tools.Nodes.Token getToken(int tokenIndex, string text, int line, int position)
        {
            switch (tokenIndex)
            {
                case 0: return new TBool(text, line, position);
                case 1: return new TNumber(text, line, position);
                case 2: return new TWhile(text, line, position);
                case 3: return new TIf(text, line, position);
                case 4: return new TElse(text, line, position);
                case 5: return new TReturn(text, line, position);
                case 6: return new TActfor(text, line, position);
                case 7: return new TIdentifier(text, line, position);
                case 8: return new TRArrow(text, line, position);
                case 9: return new TLArrow(text, line, position);
                case 10: return new TCompare(text, line, position);
                case 11: return new TAssign(text, line, position);
                case 12: return new TPlus(text, line, position);
                case 13: return new TMinus(text, line, position);
                case 14: return new TAsterisk(text, line, position);
                case 15: return new TSlash(text, line, position);
                case 16: return new TPercent(text, line, position);
                case 17: return new TBang(text, line, position);
                case 18: return new TAnd(text, line, position);
                case 19: return new TOr(text, line, position);
                case 20: return new TPeriod(text, line, position);
                case 21: return new TComma(text, line, position);
                case 22: return new TColon(text, line, position);
                case 23: return new TSemicolon(text, line, position);
                case 24: return new TLabelStart(text, line, position);
                case 25: return new TLabelEnd(text, line, position);
                case 26: return new TLPar(text, line, position);
                case 27: return new TRPar(text, line, position);
                case 28: return new TLSqu(text, line, position);
                case 29: return new TRSqu(text, line, position);
                case 30: return new TLCur(text, line, position);
                case 31: return new TRCur(text, line, position);
                case 32: return new TComment(text, line, position);
                case 33: return new TWhitespace(text, line, position);
                default:
                    throw new ArgumentException("Unknown token index.", "tokenIndex");
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
                    new int[] {45, 45, 39},
                    new int[] {61, 61, 40},
                },
                new int[][] {
                    new int[] {61, 61, 41},
                },
                new int[][] {
                    new int[] {61, 61, 42},
                },
                new int[][] {
                    new int[] {48, 57, 43},
                    new int[] {65, 90, 44},
                    new int[] {95, 95, 45},
                    new int[] {97, 122, 46},
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
                    new int[] {97, 107, 46},
                    new int[] {108, 108, 47},
                    new int[] {109, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 97, 48},
                    new int[] {98, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 101, 46},
                    new int[] {102, 102, 49},
                    new int[] {103, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 100, 46},
                    new int[] {101, 101, 50},
                    new int[] {102, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 113, 46},
                    new int[] {114, 114, 51},
                    new int[] {115, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 103, 46},
                    new int[] {104, 104, 52},
                    new int[] {105, 122, 46},
                },
                new int[][] {
                    new int[] {123, 123, 53},
                },
                new int[][] {
                    new int[] {124, 124, 54},
                },
                new int[][] {
                    new int[] {125, 125, 55},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 56},
                    new int[] {42, 42, 57},
                    new int[] {43, 65535, 56},
                },
                new int[][] {
                    new int[] {0, 9, 58},
                    new int[] {11, 12, 58},
                    new int[] {14, 65535, 58},
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
                    new int[] {97, 114, 46},
                    new int[] {115, 115, 59},
                    new int[] {116, 122, 46},
                },
                new int[][] {
                    new int[] {48, 107, -28},
                    new int[] {108, 108, 60},
                    new int[] {109, 122, 46},
                },
                new int[][] {
                    new int[] {48, 90, -24},
                    new int[] {95, 95, 61},
                    new int[] {97, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 115, 46},
                    new int[] {116, 116, 62},
                    new int[] {117, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 116, 46},
                    new int[] {117, 117, 63},
                    new int[] {118, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 104, 46},
                    new int[] {105, 105, 64},
                    new int[] {106, 122, 46},
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
                    new int[] {0, 41, 65},
                    new int[] {42, 42, 57},
                    new int[] {43, 46, 65},
                    new int[] {47, 47, 66},
                    new int[] {48, 65535, 65},
                },
                new int[][] {
                    new int[] {0, 65535, -40},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 67},
                    new int[] {102, 122, 46},
                },
                new int[][] {
                    new int[] {48, 114, -49},
                    new int[] {115, 115, 68},
                    new int[] {116, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 97, 69},
                    new int[] {98, 122, 46},
                },
                new int[][] {
                    new int[] {48, 116, -53},
                    new int[] {117, 117, 70},
                    new int[] {118, 122, 46},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 71},
                    new int[] {102, 122, 46},
                },
                new int[][] {
                    new int[] {48, 107, -28},
                    new int[] {108, 108, 72},
                    new int[] {109, 122, 46},
                },
                new int[][] {
                    new int[] {0, 41, 73},
                    new int[] {42, 42, 74},
                    new int[] {43, 65535, 73},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 75},
                    new int[] {102, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 98, 46},
                    new int[] {99, 99, 76},
                    new int[] {100, 122, 46},
                },
                new int[][] {
                    new int[] {48, 113, -32},
                    new int[] {114, 114, 77},
                    new int[] {115, 122, 46},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 100, -31},
                    new int[] {101, 101, 78},
                    new int[] {102, 122, 46},
                },
                new int[][] {
                    new int[] {0, 65535, -67},
                },
                new int[][] {
                    new int[] {0, 41, 65},
                    new int[] {42, 42, 74},
                    new int[] {43, 65535, -59},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 115, -52},
                    new int[] {116, 116, 79},
                    new int[] {117, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 109, 46},
                    new int[] {110, 110, 80},
                    new int[] {111, 122, 46},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 114, -49},
                    new int[] {115, 115, 81},
                    new int[] {116, 122, 46},
                },
                new int[][] {
                    new int[] {48, 122, -24},
                },
                new int[][] {
                    new int[] {48, 90, -24},
                    new int[] {95, 95, 82},
                    new int[] {97, 122, 46},
                },
                new int[][] {
                    new int[] {48, 101, -30},
                    new int[] {102, 102, 83},
                    new int[] {103, 122, 46},
                },
                new int[][] {
                    new int[] {48, 95, -24},
                    new int[] {97, 110, 46},
                    new int[] {111, 111, 84},
                    new int[] {112, 122, 46},
                },
                new int[][] {
                    new int[] {48, 113, -32},
                    new int[] {114, 114, 85},
                    new int[] {115, 122, 46},
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
                -1, 33, 33, 33, 33, 17, 16, -1, 26, 27, 14, 12, 21, 13, 20, 15,
                1, 22, 23, 10, 11, 10, 7, 28, 29, 7, 7, 7, 7, 7, 7, 7,
                30, -1, 31, 18, 8, -1, 32, 9, 10, 10, 10, 7, 7, 7, 7, 7,
                7, 3, 7, 7, 7, 24, 19, 25, -1, -1, 32, 7, 7, 7, 7, 7,
                7, -1, 32, 4, 7, 7, 7, 0, 7, -1, -1, 0, 7, 7, 2, 7,
                5, 7, 7, 7, 7, 6,
            },
        };
        
        
        #endregion
        
    }
}
