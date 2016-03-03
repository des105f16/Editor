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
                case 11: return new TPlus(text, line, position);
                case 12: return new TMinus(text, line, position);
                case 13: return new TAsterisk(text, line, position);
                case 14: return new TSlash(text, line, position);
                case 15: return new TPercent(text, line, position);
                case 16: return new TBang(text, line, position);
                case 17: return new TAnd(text, line, position);
                case 18: return new TOr(text, line, position);
                case 19: return new TPeriod(text, line, position);
                case 20: return new TComma(text, line, position);
                case 21: return new TLabelStart(text, line, position);
                case 22: return new TLabelEnd(text, line, position);
                case 23: return new TLPar(text, line, position);
                case 24: return new TRPar(text, line, position);
                case 25: return new TLSqu(text, line, position);
                case 26: return new TRSqu(text, line, position);
                case 27: return new TComment(text, line, position);
                case 28: return new TWhitespace(text, line, position);
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
                    new int[] {60, 60, 17},
                    new int[] {61, 61, 18},
                    new int[] {62, 62, 19},
                    new int[] {65, 90, 20},
                    new int[] {91, 91, 21},
                    new int[] {93, 93, 22},
                    new int[] {97, 100, 23},
                    new int[] {101, 101, 24},
                    new int[] {102, 102, 25},
                    new int[] {103, 104, 23},
                    new int[] {105, 105, 26},
                    new int[] {106, 113, 23},
                    new int[] {114, 114, 27},
                    new int[] {115, 115, 23},
                    new int[] {116, 116, 28},
                    new int[] {117, 118, 23},
                    new int[] {119, 119, 29},
                    new int[] {120, 122, 23},
                    new int[] {123, 123, 30},
                    new int[] {124, 124, 31},
                    new int[] {125, 125, 32},
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
                    new int[] {38, 38, 33},
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
                    new int[] {62, 62, 34},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 35},
                    new int[] {47, 47, 36},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                },
                new int[][] {
                    new int[] {45, 45, 37},
                    new int[] {61, 61, 38},
                },
                new int[][] {
                    new int[] {61, 61, 39},
                },
                new int[][] {
                    new int[] {61, 61, 40},
                },
                new int[][] {
                    new int[] {48, 57, 41},
                    new int[] {65, 90, 42},
                    new int[] {95, 95, 43},
                    new int[] {97, 122, 44},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 107, 44},
                    new int[] {108, 108, 45},
                    new int[] {109, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 97, 46},
                    new int[] {98, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 101, 44},
                    new int[] {102, 102, 47},
                    new int[] {103, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 100, 44},
                    new int[] {101, 101, 48},
                    new int[] {102, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 113, 44},
                    new int[] {114, 114, 49},
                    new int[] {115, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 103, 44},
                    new int[] {104, 104, 50},
                    new int[] {105, 122, 44},
                },
                new int[][] {
                    new int[] {123, 123, 51},
                },
                new int[][] {
                    new int[] {124, 124, 52},
                },
                new int[][] {
                    new int[] {125, 125, 53},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 54},
                    new int[] {42, 42, 55},
                    new int[] {43, 65535, 54},
                },
                new int[][] {
                    new int[] {0, 9, 56},
                    new int[] {11, 12, 56},
                    new int[] {14, 65535, 56},
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
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 114, 44},
                    new int[] {115, 115, 57},
                    new int[] {116, 122, 44},
                },
                new int[][] {
                    new int[] {48, 107, -26},
                    new int[] {108, 108, 58},
                    new int[] {109, 122, 44},
                },
                new int[][] {
                    new int[] {48, 90, -22},
                    new int[] {95, 95, 59},
                    new int[] {97, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 115, 44},
                    new int[] {116, 116, 60},
                    new int[] {117, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 116, 44},
                    new int[] {117, 117, 61},
                    new int[] {118, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 104, 44},
                    new int[] {105, 105, 62},
                    new int[] {106, 122, 44},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -37},
                },
                new int[][] {
                    new int[] {0, 41, 63},
                    new int[] {42, 42, 55},
                    new int[] {43, 46, 63},
                    new int[] {47, 47, 64},
                    new int[] {48, 65535, 63},
                },
                new int[][] {
                    new int[] {0, 65535, -38},
                },
                new int[][] {
                    new int[] {48, 100, -29},
                    new int[] {101, 101, 65},
                    new int[] {102, 122, 44},
                },
                new int[][] {
                    new int[] {48, 114, -47},
                    new int[] {115, 115, 66},
                    new int[] {116, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 97, 67},
                    new int[] {98, 122, 44},
                },
                new int[][] {
                    new int[] {48, 116, -51},
                    new int[] {117, 117, 68},
                    new int[] {118, 122, 44},
                },
                new int[][] {
                    new int[] {48, 100, -29},
                    new int[] {101, 101, 69},
                    new int[] {102, 122, 44},
                },
                new int[][] {
                    new int[] {48, 107, -26},
                    new int[] {108, 108, 70},
                    new int[] {109, 122, 44},
                },
                new int[][] {
                    new int[] {0, 41, 71},
                    new int[] {42, 42, 72},
                    new int[] {43, 65535, 71},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 100, -29},
                    new int[] {101, 101, 73},
                    new int[] {102, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 98, 44},
                    new int[] {99, 99, 74},
                    new int[] {100, 122, 44},
                },
                new int[][] {
                    new int[] {48, 113, -30},
                    new int[] {114, 114, 75},
                    new int[] {115, 122, 44},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 100, -29},
                    new int[] {101, 101, 76},
                    new int[] {102, 122, 44},
                },
                new int[][] {
                    new int[] {0, 65535, -65},
                },
                new int[][] {
                    new int[] {0, 41, 63},
                    new int[] {42, 42, 72},
                    new int[] {43, 65535, -57},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 115, -50},
                    new int[] {116, 116, 77},
                    new int[] {117, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 109, 44},
                    new int[] {110, 110, 78},
                    new int[] {111, 122, 44},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 114, -47},
                    new int[] {115, 115, 79},
                    new int[] {116, 122, 44},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
                new int[][] {
                    new int[] {48, 90, -22},
                    new int[] {95, 95, 80},
                    new int[] {97, 122, 44},
                },
                new int[][] {
                    new int[] {48, 101, -28},
                    new int[] {102, 102, 81},
                    new int[] {103, 122, 44},
                },
                new int[][] {
                    new int[] {48, 95, -22},
                    new int[] {97, 110, 44},
                    new int[] {111, 111, 82},
                    new int[] {112, 122, 44},
                },
                new int[][] {
                    new int[] {48, 113, -30},
                    new int[] {114, 114, 83},
                    new int[] {115, 122, 44},
                },
                new int[][] {
                    new int[] {48, 122, -22},
                },
            },
        };
        
        
        #endregion
        
        
        
        #region Accept Table
        
        
        private static int[][] acceptTable = {
            new int[] {
                -1, 28, 28, 28, 28, 16, 15, -1, 23, 24, 13, 11, 20, 12, 19, 14,
                1, 10, -1, 10, 7, 25, 26, 7, 7, 7, 7, 7, 7, 7, -1, -1,
                -1, 17, 8, -1, 27, 9, 10, 10, 10, 7, 7, 7, 7, 7, 7, 3,
                7, 7, 7, 21, 18, 22, -1, -1, 27, 7, 7, 7, 7, 7, 7, -1,
                27, 4, 7, 7, 7, 0, 7, -1, -1, 0, 7, 7, 2, 7, 5, 7,
                7, 7, 7, 6,
            },
        };
        
        
        #endregion
        
    }
}
