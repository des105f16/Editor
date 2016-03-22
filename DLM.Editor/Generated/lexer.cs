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
                case 11: return new TThis(text, line, position);
                case 12: return new TCaller(text, line, position);
                case 13: return new TIdentifier(text, line, position);
                case 14: return new TActsFor(text, line, position);
                case 15: return new TIfActsFor(text, line, position);
                case 16: return new TDeclassifyStart(text, line, position);
                case 17: return new TDeclassifyEnd(text, line, position);
                case 18: return new TRArrow(text, line, position);
                case 19: return new TLArrow(text, line, position);
                case 20: return new TCompare(text, line, position);
                case 21: return new TAssign(text, line, position);
                case 22: return new TUnderscore(text, line, position);
                case 23: return new THat(text, line, position);
                case 24: return new TPlus(text, line, position);
                case 25: return new TMinus(text, line, position);
                case 26: return new TAsterisk(text, line, position);
                case 27: return new TSlash(text, line, position);
                case 28: return new TPercent(text, line, position);
                case 29: return new TBang(text, line, position);
                case 30: return new TAnd(text, line, position);
                case 31: return new TOr(text, line, position);
                case 32: return new TPeriod(text, line, position);
                case 33: return new TComma(text, line, position);
                case 34: return new TColon(text, line, position);
                case 35: return new TSemicolon(text, line, position);
                case 36: return new TLabelStart(text, line, position);
                case 37: return new TLabelEnd(text, line, position);
                case 38: return new TLPar(text, line, position);
                case 39: return new TRPar(text, line, position);
                case 40: return new TLSqu(text, line, position);
                case 41: return new TRSqu(text, line, position);
                case 42: return new TLCur(text, line, position);
                case 43: return new TRCur(text, line, position);
                case 44: return new TJoin(text, line, position);
                case 45: return new TComment(text, line, position);
                case 46: return new TWhitespace(text, line, position);
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
                    new int[] {61, 61, 50},
                    new int[] {124, 124, 51},
                },
                new int[][] {
                    new int[] {61, 61, 52},
                },
                new int[][] {
                    new int[] {61, 61, 53},
                },
                new int[][] {
                    new int[] {62, 62, 54},
                },
                new int[][] {
                    new int[] {48, 57, 55},
                    new int[] {65, 90, 56},
                    new int[] {95, 95, 57},
                    new int[] {97, 122, 58},
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
                    new int[] {97, 97, 59},
                    new int[] {98, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 107, 58},
                    new int[] {108, 108, 60},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 61},
                    new int[] {98, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 101, 58},
                    new int[] {102, 102, 62},
                    new int[] {103, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 113, 58},
                    new int[] {114, 114, 63},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 100, 58},
                    new int[] {101, 101, 64},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 115, 58},
                    new int[] {116, 116, 65},
                    new int[] {117, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 103, 58},
                    new int[] {104, 104, 66},
                    new int[] {105, 113, 58},
                    new int[] {114, 114, 67},
                    new int[] {115, 120, 58},
                    new int[] {121, 121, 68},
                    new int[] {122, 122, 58},
                },
                new int[][] {
                    new int[] {48, 103, -39},
                    new int[] {104, 104, 69},
                    new int[] {105, 122, 58},
                },
                new int[][] {
                    new int[] {123, 123, 70},
                },
                new int[][] {
                    new int[] {62, 62, 71},
                    new int[] {124, 124, 72},
                },
                new int[][] {
                    new int[] {125, 125, 73},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {110, 110, 74},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {62, 62, 75},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 76},
                    new int[] {42, 42, 77},
                    new int[] {43, 65535, 76},
                },
                new int[][] {
                    new int[] {0, 9, 78},
                    new int[] {11, 12, 78},
                    new int[] {14, 65535, 78},
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
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 79},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 114, 58},
                    new int[] {115, 115, 80},
                    new int[] {116, 122, 58},
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 81},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 104, 58},
                    new int[] {105, 105, 82},
                    new int[] {106, 122, 58},
                },
                new int[][] {
                    new int[] {48, 115, -38},
                    new int[] {116, 116, 83},
                    new int[] {117, 122, 58},
                },
                new int[][] {
                    new int[] {48, 113, -36},
                    new int[] {114, 114, 84},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 104, -65},
                    new int[] {105, 105, 85},
                    new int[] {106, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 116, 58},
                    new int[] {117, 117, 86},
                    new int[] {118, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 111, 58},
                    new int[] {112, 112, 87},
                    new int[] {113, 122, 58},
                },
                new int[][] {
                    new int[] {48, 104, -65},
                    new int[] {105, 105, 88},
                    new int[] {106, 122, 58},
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
                    new int[] {99, 99, 89},
                },
                new int[][] {
                    new int[] {63, 63, 90},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
                },
                new int[][] {
                    new int[] {0, 41, 91},
                    new int[] {42, 42, 77},
                    new int[] {43, 46, 91},
                    new int[] {47, 47, 92},
                    new int[] {48, 65535, 91},
                },
                new int[][] {
                    new int[] {0, 65535, -50},
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 93},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 94},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 114, -62},
                    new int[] {115, 115, 95},
                    new int[] {116, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 109, 58},
                    new int[] {110, 110, 96},
                    new int[] {111, 122, 58},
                },
                new int[][] {
                    new int[] {48, 116, -69},
                    new int[] {117, 117, 97},
                    new int[] {118, 122, 58},
                },
                new int[][] {
                    new int[] {48, 116, -69},
                    new int[] {117, 117, 98},
                    new int[] {118, 122, 58},
                },
                new int[][] {
                    new int[] {48, 114, -62},
                    new int[] {115, 115, 99},
                    new int[] {116, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 100},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 101},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 102},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {108, 108, 103},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 104},
                    new int[] {42, 42, 105},
                    new int[] {43, 65535, 104},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 106},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 107},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 98, 58},
                    new int[] {99, 99, 108},
                    new int[] {100, 122, 58},
                },
                new int[][] {
                    new int[] {48, 113, -36},
                    new int[] {114, 114, 109},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 98, -98},
                    new int[] {99, 99, 110},
                    new int[] {100, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 99, 58},
                    new int[] {100, 100, 111},
                    new int[] {101, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 112},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {117, 117, 113},
                },
                new int[][] {
                    new int[] {0, 65535, -93},
                },
                new int[][] {
                    new int[] {0, 41, 91},
                    new int[] {42, 42, 105},
                    new int[] {43, 65535, -79},
                },
                new int[][] {
                    new int[] {48, 113, -36},
                    new int[] {114, 114, 114},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 104, -65},
                    new int[] {105, 105, 115},
                    new int[] {106, 122, 58},
                },
                new int[][] {
                    new int[] {48, 109, -84},
                    new int[] {110, 110, 116},
                    new int[] {111, 122, 58},
                },
                new int[][] {
                    new int[] {48, 115, -38},
                    new int[] {116, 116, 117},
                    new int[] {117, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -37},
                    new int[] {101, 101, 118},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {100, 100, 119},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 111, -70},
                    new int[] {112, 112, 120},
                    new int[] {113, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                    new int[] {48, 101, -35},
                    new int[] {102, 102, 121},
                    new int[] {103, 122, 58},
                },
                new int[][] {
                    new int[] {101, 101, 122},
                },
                new int[][] {
                    new int[] {48, 95, -26},
                    new int[] {97, 97, 123},
                    new int[] {98, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -26},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 107, -33},
                    new int[] {108, 108, 124},
                    new int[] {109, 122, 58},
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
                    new int[] {46, 60, 47},
                    new int[] {61, 61, 49},
                    new int[] {62, 62, 50},
                    new int[] {63, 123, 47},
                    new int[] {124, 124, 51},
                    new int[] {125, 65535, 47},
                },
                new int[][] {
                    new int[] {61, 61, 52},
                },
                new int[][] {
                    new int[] {61, 61, 53},
                },
                new int[][] {
                    new int[] {62, 62, 54},
                },
                new int[][] {
                    new int[] {48, 57, 55},
                    new int[] {65, 90, 56},
                    new int[] {95, 95, 57},
                    new int[] {97, 122, 58},
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
                    new int[] {97, 97, 59},
                    new int[] {98, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 107, 58},
                    new int[] {108, 108, 60},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 61},
                    new int[] {98, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 101, 58},
                    new int[] {102, 102, 62},
                    new int[] {103, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 113, 58},
                    new int[] {114, 114, 63},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 100, 58},
                    new int[] {101, 101, 64},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 115, 58},
                    new int[] {116, 116, 65},
                    new int[] {117, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 103, 58},
                    new int[] {104, 104, 66},
                    new int[] {105, 113, 58},
                    new int[] {114, 114, 67},
                    new int[] {115, 120, 58},
                    new int[] {121, 121, 68},
                    new int[] {122, 122, 58},
                },
                new int[][] {
                    new int[] {48, 103, -38},
                    new int[] {104, 104, 69},
                    new int[] {105, 122, 58},
                },
                new int[][] {
                    new int[] {123, 123, 70},
                },
                new int[][] {
                    new int[] {62, 62, 71},
                    new int[] {124, 124, 72},
                },
                new int[][] {
                    new int[] {125, 125, 73},
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
                    new int[] {62, 62, 50},
                    new int[] {63, 65535, 47},
                },
                new int[][] {
                    new int[] {0, 65535, -49},
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
                    new int[] {108, 108, 78},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 114, 58},
                    new int[] {115, 115, 79},
                    new int[] {116, 122, 58},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 80},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 104, 58},
                    new int[] {105, 105, 81},
                    new int[] {106, 122, 58},
                },
                new int[][] {
                    new int[] {48, 115, -37},
                    new int[] {116, 116, 82},
                    new int[] {117, 122, 58},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 83},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 104, -65},
                    new int[] {105, 105, 84},
                    new int[] {106, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 116, 58},
                    new int[] {117, 117, 85},
                    new int[] {118, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 111, 58},
                    new int[] {112, 112, 86},
                    new int[] {113, 122, 58},
                },
                new int[][] {
                    new int[] {48, 104, -65},
                    new int[] {105, 105, 87},
                    new int[] {106, 122, 58},
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
                    new int[] {63, 63, 88},
                },
                new int[][] {
                    new int[] {0, 65535, -47},
                },
                new int[][] {
                    new int[] {0, 41, 89},
                    new int[] {42, 42, 76},
                    new int[] {43, 46, 89},
                    new int[] {47, 47, 90},
                    new int[] {48, 65535, 89},
                },
                new int[][] {
                    new int[] {0, 65535, -48},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 91},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 92},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 114, -62},
                    new int[] {115, 115, 93},
                    new int[] {116, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 109, 58},
                    new int[] {110, 110, 94},
                    new int[] {111, 122, 58},
                },
                new int[][] {
                    new int[] {48, 116, -69},
                    new int[] {117, 117, 95},
                    new int[] {118, 122, 58},
                },
                new int[][] {
                    new int[] {48, 116, -69},
                    new int[] {117, 117, 96},
                    new int[] {118, 122, 58},
                },
                new int[][] {
                    new int[] {48, 114, -62},
                    new int[] {115, 115, 97},
                    new int[] {116, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 98},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 99},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 100},
                    new int[] {109, 122, 58},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {0, 41, 101},
                    new int[] {42, 42, 102},
                    new int[] {43, 65535, 101},
                },
                new int[][] {
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 103},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 104},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 98, 58},
                    new int[] {99, 99, 105},
                    new int[] {100, 122, 58},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 106},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 98, -96},
                    new int[] {99, 99, 107},
                    new int[] {100, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 99, 58},
                    new int[] {100, 100, 108},
                    new int[] {101, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 109},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {0, 65535, -91},
                },
                new int[][] {
                    new int[] {0, 41, 89},
                    new int[] {42, 42, 102},
                    new int[] {43, 65535, -78},
                },
                new int[][] {
                    new int[] {48, 113, -35},
                    new int[] {114, 114, 110},
                    new int[] {115, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 104, -65},
                    new int[] {105, 105, 111},
                    new int[] {106, 122, 58},
                },
                new int[][] {
                    new int[] {48, 109, -83},
                    new int[] {110, 110, 112},
                    new int[] {111, 122, 58},
                },
                new int[][] {
                    new int[] {48, 115, -37},
                    new int[] {116, 116, 113},
                    new int[] {117, 122, 58},
                },
                new int[][] {
                    new int[] {48, 100, -36},
                    new int[] {101, 101, 114},
                    new int[] {102, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 111, -70},
                    new int[] {112, 112, 115},
                    new int[] {113, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 101, -34},
                    new int[] {102, 102, 116},
                    new int[] {103, 122, 58},
                },
                new int[][] {
                    new int[] {48, 95, -25},
                    new int[] {97, 97, 117},
                    new int[] {98, 122, 58},
                },
                new int[][] {
                    new int[] {48, 122, -25},
                },
                new int[][] {
                    new int[] {48, 107, -32},
                    new int[] {108, 108, 118},
                    new int[] {109, 122, 58},
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
                -1, 46, 46, 46, 46, 29, -1, 28, -1, 38, 39, 26, 24, 33, 25, 32,
                27, 3, 34, 35, 20, 21, 20, -1, 13, 40, 41, 23, 22, 13, 13, 13,
                13, 13, 13, 13, 13, 13, 13, 42, -1, 43, 44, -1, 30, -1, 18, -1,
                45, 19, 20, 16, 20, 20, 15, 13, 13, 13, 13, 13, 13, 13, 8, 13,
                13, 13, 13, 13, 13, 13, 36, 17, 31, 37, -1, 14, -1, -1, 45, 13,
                13, 13, 13, 13, 13, 13, 13, 13, 13, -1, 15, -1, 45, 13, 9, 13,
                13, 13, 13, 11, 2, 13, 13, -1, -1, -1, 13, 2, 13, 13, 13, 13,
                7, -1, 12, 13, 10, 6, 13, -1, 13, 5, 0, 13, 4,
            },
            new int[] {
                -1, 46, 46, 46, 46, 29, 28, -1, 38, 39, 26, 24, 33, 25, 32, 27,
                3, 34, 35, 20, 21, 20, -1, 13, 40, 41, 23, 22, 13, 13, 13, 13,
                13, 13, 13, 13, 13, 13, 42, -1, 43, 44, 30, -1, 18, -1, 45, -1,
                19, 20, 1, 16, 20, 20, 15, 13, 13, 13, 13, 13, 13, 13, 8, 13,
                13, 13, 13, 13, 13, 13, 36, 17, 31, 37, 14, -1, -1, 45, 13, 13,
                13, 13, 13, 13, 13, 13, 13, 13, 15, -1, 45, 13, 9, 13, 13, 13,
                13, 11, 2, 13, 13, -1, -1, 13, 2, 13, 13, 13, 13, 7, 12, 13,
                10, 6, 13, 13, 5, 13, 4,
            },
        };
        
        
        #endregion
        
    }
}
