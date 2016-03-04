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
                case 8: return new TIdentifier(text, line, position);
                case 9: return new TActsFor(text, line, position);
                case 10: return new TDeclassifyStart(text, line, position);
                case 11: return new TDeclassifyEnd(text, line, position);
                case 12: return new TRArrow(text, line, position);
                case 13: return new TLArrow(text, line, position);
                case 14: return new TCompare(text, line, position);
                case 15: return new TAssign(text, line, position);
                case 16: return new TUnderscore(text, line, position);
                case 17: return new TPlus(text, line, position);
                case 18: return new TMinus(text, line, position);
                case 19: return new TAsterisk(text, line, position);
                case 20: return new TSlash(text, line, position);
                case 21: return new TPercent(text, line, position);
                case 22: return new TBang(text, line, position);
                case 23: return new TAnd(text, line, position);
                case 24: return new TOr(text, line, position);
                case 25: return new TPeriod(text, line, position);
                case 26: return new TComma(text, line, position);
                case 27: return new TColon(text, line, position);
                case 28: return new TSemicolon(text, line, position);
                case 29: return new TLabelStart(text, line, position);
                case 30: return new TLabelEnd(text, line, position);
                case 31: return new TLPar(text, line, position);
                case 32: return new TRPar(text, line, position);
                case 33: return new TLSqu(text, line, position);
                case 34: return new TRSqu(text, line, position);
                case 35: return new TLCur(text, line, position);
                case 36: return new TRCur(text, line, position);
                case 37: return new TJoin(text, line, position);
                case 38: return new TComment(text, line, position);
                case 39: return new TWhitespace(text, line, position);
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
                    new int[] {106, 113, 28},
                    new int[] {114, 114, 32},
                    new int[] {115, 115, 28},
                    new int[] {116, 116, 33},
                    new int[] {117, 118, 28},
                    new int[] {119, 119, 34},
                    new int[] {120, 122, 28},
                    new int[] {123, 123, 35},
                    new int[] {124, 124, 36},
                    new int[] {125, 125, 37},
                    new int[] {8852, 8852, 38},
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
                    new int[] {105, 105, 39},
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
                    new int[] {48, 57, 17},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {45, 45, 45},
                    new int[] {61, 61, 46},
                    new int[] {124, 124, 47},
                },
                new int[][] {
                    new int[] {61, 61, 48},
                },
                new int[][] {
                    new int[] {61, 61, 49},
                },
                new int[][] {
                    new int[] {62, 62, 50},
                },
                new int[][] {
                    new int[] {48, 57, 51},
                    new int[] {65, 90, 52},
                    new int[] {95, 95, 53},
                    new int[] {97, 122, 54},
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
                    new int[] {97, 107, 54},
                    new int[] {108, 108, 55},
                    new int[] {109, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 56},
                    new int[] {98, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 101, 54},
                    new int[] {102, 102, 57},
                    new int[] {103, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 100, 54},
                    new int[] {101, 101, 58},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 113, 54},
                    new int[] {114, 114, 59},
                    new int[] {115, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 103, 54},
                    new int[] {104, 104, 60},
                    new int[] {105, 122, 54},
                },
                new int[][] {
                    new int[] {123, 123, 61},
                },
                new int[][] {
                    new int[] {62, 62, 62},
                    new int[] {124, 124, 63},
                },
                new int[][] {
                    new int[] {125, 125, 64},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {110, 110, 65},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 66},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 67},
                    new int[] {42, 42, 68},
                    new int[] {43, 65535, 67},
                },
                new int[][] {
                    new int[] {0, 9, 69},
                    new int[] {11, 12, 69},
                    new int[] {14, 65535, 69},
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
                    new int[] {97, 114, 54},
                    new int[] {115, 115, 70},
                    new int[] {116, 122, 54},
                },
                new int[][] {
                    new int[] {48, 107, -31},
                    new int[] {108, 108, 71},
                    new int[] {109, 122, 54},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 115, 54},
                    new int[] {116, 116, 72},
                    new int[] {117, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 116, 54},
                    new int[] {117, 117, 73},
                    new int[] {118, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 104, 54},
                    new int[] {105, 105, 74},
                    new int[] {106, 122, 54},
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
                    new int[] {99, 99, 75},
                },
                new int[][] {
                    new int[] {63, 63, 76},
                },
                new int[][] {
                    new int[] {0, 65535, -45},
                },
                new int[][] {
                    new int[] {0, 41, 77},
                    new int[] {42, 42, 68},
                    new int[] {43, 46, 77},
                    new int[] {47, 47, 78},
                    new int[] {48, 65535, 77},
                },
                new int[][] {
                    new int[] {0, 65535, -46},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 79},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 114, -57},
                    new int[] {115, 115, 80},
                    new int[] {116, 122, 54},
                },
                new int[][] {
                    new int[] {48, 116, -61},
                    new int[] {117, 117, 81},
                    new int[] {118, 122, 54},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 82},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 107, -31},
                    new int[] {108, 108, 83},
                    new int[] {109, 122, 54},
                },
                new int[][] {
                    new int[] {108, 108, 84},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 85},
                    new int[] {42, 42, 86},
                    new int[] {43, 65535, 85},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 87},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 88},
                    new int[] {115, 122, 54},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 100, -34},
                    new int[] {101, 101, 89},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {117, 117, 90},
                },
                new int[][] {
                    new int[] {0, 65535, -79},
                },
                new int[][] {
                    new int[] {0, 41, 77},
                    new int[] {42, 42, 86},
                    new int[] {43, 65535, -70},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 109, 54},
                    new int[] {110, 110, 91},
                    new int[] {111, 122, 54},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {100, 100, 92},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {101, 101, 93},
                },
                new int[][] {
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
                    new int[] {8852, 8852, 37},
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
                    new int[] {45, 45, 39},
                    new int[] {62, 62, 40},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {42, 42, 41},
                    new int[] {47, 47, 42},
                },
                new int[][] {
                    new int[] {48, 57, 16},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 44, 43},
                    new int[] {45, 45, 44},
                    new int[] {46, 60, 43},
                    new int[] {61, 61, 45},
                    new int[] {62, 62, 46},
                    new int[] {63, 123, 43},
                    new int[] {124, 124, 47},
                    new int[] {125, 65535, 43},
                },
                new int[][] {
                    new int[] {61, 61, 48},
                },
                new int[][] {
                    new int[] {61, 61, 49},
                },
                new int[][] {
                    new int[] {62, 62, 50},
                },
                new int[][] {
                    new int[] {48, 57, 51},
                    new int[] {65, 90, 52},
                    new int[] {95, 95, 53},
                    new int[] {97, 122, 54},
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
                    new int[] {97, 107, 54},
                    new int[] {108, 108, 55},
                    new int[] {109, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 56},
                    new int[] {98, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 101, 54},
                    new int[] {102, 102, 57},
                    new int[] {103, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 100, 54},
                    new int[] {101, 101, 58},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 113, 54},
                    new int[] {114, 114, 59},
                    new int[] {115, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 103, 54},
                    new int[] {104, 104, 60},
                    new int[] {105, 122, 54},
                },
                new int[][] {
                    new int[] {123, 123, 61},
                },
                new int[][] {
                    new int[] {62, 62, 62},
                    new int[] {124, 124, 63},
                },
                new int[][] {
                    new int[] {125, 125, 64},
                },
                new int[][] {
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 65},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 66},
                    new int[] {42, 42, 67},
                    new int[] {43, 65535, 66},
                },
                new int[][] {
                    new int[] {0, 9, 68},
                    new int[] {11, 12, 68},
                    new int[] {14, 65535, 68},
                },
                new int[][] {
                    new int[] {0, 61, 43},
                    new int[] {62, 62, 46},
                    new int[] {63, 65535, 43},
                },
                new int[][] {
                    new int[] {0, 65535, -45},
                },
                new int[][] {
                    new int[] {0, 65535, -45},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 65535, -45},
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
                    new int[] {97, 114, 54},
                    new int[] {115, 115, 69},
                    new int[] {116, 122, 54},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 70},
                    new int[] {109, 122, 54},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 115, 54},
                    new int[] {116, 116, 71},
                    new int[] {117, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 116, 54},
                    new int[] {117, 117, 72},
                    new int[] {118, 122, 54},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 104, 54},
                    new int[] {105, 105, 73},
                    new int[] {106, 122, 54},
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
                    new int[] {63, 63, 74},
                },
                new int[][] {
                    new int[] {0, 65535, -43},
                },
                new int[][] {
                    new int[] {0, 41, 75},
                    new int[] {42, 42, 67},
                    new int[] {43, 46, 75},
                    new int[] {47, 47, 76},
                    new int[] {48, 65535, 75},
                },
                new int[][] {
                    new int[] {0, 65535, -44},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 77},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 114, -57},
                    new int[] {115, 115, 78},
                    new int[] {116, 122, 54},
                },
                new int[][] {
                    new int[] {48, 116, -61},
                    new int[] {117, 117, 79},
                    new int[] {118, 122, 54},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 80},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 107, -30},
                    new int[] {108, 108, 81},
                    new int[] {109, 122, 54},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 82},
                    new int[] {42, 42, 83},
                    new int[] {43, 65535, 82},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 84},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {48, 113, -34},
                    new int[] {114, 114, 85},
                    new int[] {115, 122, 54},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -33},
                    new int[] {101, 101, 86},
                    new int[] {102, 122, 54},
                },
                new int[][] {
                    new int[] {0, 65535, -77},
                },
                new int[][] {
                    new int[] {0, 41, 75},
                    new int[] {42, 42, 83},
                    new int[] {43, 65535, -69},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 109, 54},
                    new int[] {110, 110, 87},
                    new int[] {111, 122, 54},
                },
                new int[][] {
                    new int[] {48, 122, -25},
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
                -1, 39, 39, 39, 39, 22, -1, 21, -1, 31, 32, 19, 17, 26, 18, 25,
                20, 3, 27, 28, 14, 15, 14, -1, 8, 33, 34, 16, 8, 8, 8, 8,
                8, 8, 8, 35, -1, 36, 37, -1, 23, -1, 12, -1, 38, 13, 14, 10,
                14, 14, 9, 8, 8, 8, 8, 8, 8, 5, 8, 8, 8, 29, 11, 24,
                30, -1, -1, -1, -1, 38, 8, 8, 8, 8, 8, -1, 9, -1, 38, 6,
                8, 8, 2, 8, -1, -1, -1, 2, 8, 4, -1, 7, -1, 0,
            },
            new int[] {
                -1, 39, 39, 39, 39, 22, 21, -1, 31, 32, 19, 17, 26, 18, 25, 20,
                3, 27, 28, 14, 15, 14, -1, 8, 33, 34, 16, 8, 8, 8, 8, 8,
                8, 8, 35, -1, 36, 37, 23, -1, 12, -1, 38, -1, 13, 14, 1, 10,
                14, 14, 9, 8, 8, 8, 8, 8, 8, 5, 8, 8, 8, 29, 11, 24,
                30, -1, -1, -1, 38, 8, 8, 8, 8, 8, 9, -1, 38, 6, 8, 8,
                2, 8, -1, -1, 2, 8, 4, 7,
            },
        };
        
        
        #endregion
        
    }
}
