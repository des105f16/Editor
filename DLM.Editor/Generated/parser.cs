using System;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using SablePP.Tools.Nodes;

namespace DLM.Editor.Parsing
{
    public class Parser : SablePP.Tools.Parsing.Parser<PExpression>
    {
        #region Token Index
        
        protected override int getTokenIndex(Token token)
        {
            return getIndex((dynamic)token);
        }
        
        private int getIndex(Token node)
        {
            return -1;
        }
        
        private int getIndex(TBool node)
        {
            return 0;
        }
        private int getIndex(TNumber node)
        {
            return 1;
        }
        private int getIndex(TWhile node)
        {
            return 2;
        }
        private int getIndex(TIf node)
        {
            return 3;
        }
        private int getIndex(TElse node)
        {
            return 4;
        }
        private int getIndex(TReturn node)
        {
            return 5;
        }
        private int getIndex(TActfor node)
        {
            return 6;
        }
        private int getIndex(TIdentifier node)
        {
            return 7;
        }
        private int getIndex(TRArrow node)
        {
            return 8;
        }
        private int getIndex(TLArrow node)
        {
            return 9;
        }
        private int getIndex(TCompare node)
        {
            return 10;
        }
        private int getIndex(TPlus node)
        {
            return 11;
        }
        private int getIndex(TMinus node)
        {
            return 12;
        }
        private int getIndex(TAsterisk node)
        {
            return 13;
        }
        private int getIndex(TSlash node)
        {
            return 14;
        }
        private int getIndex(TPercent node)
        {
            return 15;
        }
        private int getIndex(TBang node)
        {
            return 16;
        }
        private int getIndex(TAnd node)
        {
            return 17;
        }
        private int getIndex(TOr node)
        {
            return 18;
        }
        private int getIndex(TPeriod node)
        {
            return 19;
        }
        private int getIndex(TComma node)
        {
            return 20;
        }
        private int getIndex(TLabelStart node)
        {
            return 21;
        }
        private int getIndex(TLabelEnd node)
        {
            return 22;
        }
        private int getIndex(TLPar node)
        {
            return 23;
        }
        private int getIndex(TRPar node)
        {
            return 24;
        }
        private int getIndex(TLSqu node)
        {
            return 25;
        }
        private int getIndex(TRSqu node)
        {
            return 26;
        }
        
        private int getIndex(EOF node)
        {
            return 27;
        }
        
        #endregion
        
        public Parser(SablePP.Tools.Lexing.ILexer lexer)
            : base(lexer, actionTable, gotoTable, errorMessages, errors)
        {
        }
        protected override void reduce(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(0, pexpression);
                    }
                    break;
                case 1:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(1, aandexpression);
                    }
                    break;
                case 2:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(1, aorexpression);
                    }
                    break;
                case 3:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(1, pexpression);
                    }
                    break;
                case 4:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(2, acomparisonexpression);
                    }
                    break;
                case 5:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(2, anotexpression);
                    }
                    break;
                case 6:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(2, pexpression);
                    }
                    break;
                case 7:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(3, aplusexpression);
                    }
                    break;
                case 8:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(3, aminusexpression);
                    }
                    break;
                case 9:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(3, anegateexpression);
                    }
                    break;
                case 10:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(3, pexpression);
                    }
                    break;
                case 11:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(4, amultiplyexpression);
                    }
                    break;
                case 12:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(4, adivideexpression);
                    }
                    break;
                case 13:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(4, amoduloexpression);
                    }
                    break;
                case 14:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(4, pexpression);
                    }
                    break;
                case 15:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TPeriod tperiod = Pop<TPeriod>();
                        PExpression pexpression = Pop<PExpression>();
                        AElement aelement = new AElement(
                            tidentifier
                        );
                        AElementExpression aelementexpression = new AElementExpression(
                            pexpression,
                            aelement
                        );
                        Push(5, aelementexpression);
                    }
                    break;
                case 16:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TRArrow trarrow = Pop<TRArrow>();
                        PExpression pexpression = Pop<PExpression>();
                        APointerElement apointerelement = new APointerElement(
                            tidentifier
                        );
                        AElementExpression aelementexpression = new AElementExpression(
                            pexpression,
                            apointerelement
                        );
                        Push(5, aelementexpression);
                    }
                    break;
                case 17:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(5, aindexexpression);
                    }
                    break;
                case 18:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(5, pexpression);
                    }
                    break;
                case 19:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(6, aparenthesisexpression);
                    }
                    break;
                case 20:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(6, pexpression);
                    }
                    break;
                case 21:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(6, anumberexpression);
                    }
                    break;
                case 22:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(6, abooleanexpression);
                    }
                    break;
                case 23:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(6, aidentifierexpression);
                    }
                    break;
                case 24:
                case 25:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 24) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(7, afunctioncallexpression);
                    }
                    break;
                case 26:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(8, pexpressionlist);
                    }
                    break;
                case 27:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(8, pexpressionlist2);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 3, 0},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
            new int[][] {
                new int[] {-1, 1, 21},
            },
            new int[][] {
                new int[] {-1, 1, 23},
                new int[] {23, 0, 15},
            },
            new int[][] {
                new int[] {-1, 3, 4},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 5},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 6},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 7},
                new int[] {27, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 0},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {17, 0, 19},
                new int[] {18, 0, 20},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {10, 0, 21},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {11, 0, 22},
                new int[] {12, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {8, 0, 24},
                new int[] {13, 0, 25},
                new int[] {14, 0, 26},
                new int[] {15, 0, 27},
                new int[] {19, 0, 28},
                new int[] {25, 0, 29},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 3, 15},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
                new int[] {24, 0, 30},
            },
            new int[][] {
                new int[] {-1, 1, 9},
            },
            new int[][] {
                new int[] {-1, 1, 5},
            },
            new int[][] {
                new int[] {-1, 3, 18},
                new int[] {24, 0, 33},
            },
            new int[][] {
                new int[] {-1, 3, 19},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 20},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 21},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 23},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 24},
                new int[] {7, 0, 39},
            },
            new int[][] {
                new int[] {-1, 3, 25},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 26},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 27},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 3, 28},
                new int[] {7, 0, 43},
            },
            new int[][] {
                new int[] {-1, 3, 29},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 1, 26},
                new int[] {20, 0, 45},
            },
            new int[][] {
                new int[] {-1, 3, 32},
                new int[] {24, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 1, 1},
            },
            new int[][] {
                new int[] {-1, 1, 2},
            },
            new int[][] {
                new int[] {-1, 1, 4},
            },
            new int[][] {
                new int[] {-1, 1, 7},
            },
            new int[][] {
                new int[] {-1, 1, 8},
            },
            new int[][] {
                new int[] {-1, 1, 16},
            },
            new int[][] {
                new int[] {-1, 1, 11},
            },
            new int[][] {
                new int[] {-1, 1, 12},
            },
            new int[][] {
                new int[] {-1, 1, 13},
            },
            new int[][] {
                new int[] {-1, 1, 15},
            },
            new int[][] {
                new int[] {-1, 3, 44},
                new int[] {26, 0, 47},
            },
            new int[][] {
                new int[] {-1, 3, 45},
                new int[] {0, 0, 1},
                new int[] {1, 0, 2},
                new int[] {7, 0, 3},
                new int[] {12, 0, 4},
                new int[] {16, 0, 5},
                new int[] {23, 0, 6},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 1, 17},
            },
            new int[][] {
                new int[] {-1, 1, 27},
            },
        };
        #endregion
        #region gotoTable
        private static int[][][] gotoTable = {
            new int[][] {
                new int[] {-1, 31},
                new int[] {0, 7},
                new int[] {6, 18},
                new int[] {29, 44},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {19, 34},
                new int[] {20, 35},
            },
            new int[][] {
                new int[] {-1, 9},
                new int[] {21, 36},
            },
            new int[][] {
                new int[] {-1, 10},
                new int[] {5, 17},
                new int[] {22, 37},
                new int[] {23, 38},
            },
            new int[][] {
                new int[] {-1, 11},
                new int[] {4, 16},
                new int[] {25, 40},
                new int[] {26, 41},
                new int[] {27, 42},
            },
            new int[][] {
                new int[] {-1, 12},
            },
            new int[][] {
                new int[] {-1, 13},
            },
            new int[][] {
                new int[] {-1, 14},
            },
            new int[][] {
                new int[] {-1, 32},
                new int[] {45, 48},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: TBool, TNumber, TIdentifier, '-', '!' or '('",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ')', '[', ']' or end of file",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', '(', ')', '[', ']' or end of file",
            "Expecting: TBool, TNumber, TIdentifier or '('",
            "Expecting: TBool, TNumber, TIdentifier, '-' or '('",
            "Expecting: end of file",
            "Expecting: ',', ')', ']' or end of file",
            "Expecting: '&&', '||', ',', ')', ']' or end of file",
            "Expecting: TCompare, '&&', '||', ',', ')', ']' or end of file",
            "Expecting: TCompare, '+', '-', '&&', '||', ',', ')', ']' or end of file",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!', '(' or ')'",
            "Expecting: ')'",
            "Expecting: TIdentifier",
            "Expecting: ',' or ')'",
            "Expecting: ']'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 1, 2, 3, 4, 0, 5, 6, 7, 8, 9, 1, 1, 1, 10,
            8, 7, 11, 0, 0, 0, 4, 4, 12, 3, 3, 3, 12, 0, 1, 13,
            11, 1, 6, 6, 7, 8, 8, 1, 9, 9, 9, 1, 14, 0, 1, 1,
            11,
        };
        #endregion
    }
}
