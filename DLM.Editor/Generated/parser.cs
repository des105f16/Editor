using System;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using SablePP.Tools.Nodes;

namespace DLM.Editor.Parsing
{
    public class Parser : SablePP.Tools.Parsing.Parser<PStatement>
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
        private int getIndex(TAssign node)
        {
            return 11;
        }
        private int getIndex(TPlus node)
        {
            return 12;
        }
        private int getIndex(TMinus node)
        {
            return 13;
        }
        private int getIndex(TAsterisk node)
        {
            return 14;
        }
        private int getIndex(TSlash node)
        {
            return 15;
        }
        private int getIndex(TPercent node)
        {
            return 16;
        }
        private int getIndex(TBang node)
        {
            return 17;
        }
        private int getIndex(TAnd node)
        {
            return 18;
        }
        private int getIndex(TOr node)
        {
            return 19;
        }
        private int getIndex(TPeriod node)
        {
            return 20;
        }
        private int getIndex(TComma node)
        {
            return 21;
        }
        private int getIndex(TColon node)
        {
            return 22;
        }
        private int getIndex(TSemicolon node)
        {
            return 23;
        }
        private int getIndex(TLabelStart node)
        {
            return 24;
        }
        private int getIndex(TLabelEnd node)
        {
            return 25;
        }
        private int getIndex(TLPar node)
        {
            return 26;
        }
        private int getIndex(TRPar node)
        {
            return 27;
        }
        private int getIndex(TLSqu node)
        {
            return 28;
        }
        private int getIndex(TRSqu node)
        {
            return 29;
        }
        private int getIndex(TLCur node)
        {
            return 30;
        }
        private int getIndex(TRCur node)
        {
            return 31;
        }
        
        private int getIndex(EOF node)
        {
            return 32;
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
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(0, adeclarationstatement);
                    }
                    break;
                case 1:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            pexpression
                        );
                        Push(0, adeclarationstatement);
                    }
                    break;
                case 2:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier
                        );
                        Push(1, atype);
                    }
                    break;
                case 3:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PType ptype = Pop<PType>();
                        APointerType apointertype = new APointerType(
                            ptype,
                            tasterisk
                        );
                        Push(1, apointertype);
                    }
                    break;
                case 4:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(2, pstatementlist);
                    }
                    break;
                case 5:
                case 6:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 5) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(2, pstatementlist2);
                    }
                    break;
                case 7:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(3, pexpression);
                    }
                    break;
                case 8:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(4, aandexpression);
                    }
                    break;
                case 9:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(4, aorexpression);
                    }
                    break;
                case 10:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(4, pexpression);
                    }
                    break;
                case 11:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(5, acomparisonexpression);
                    }
                    break;
                case 12:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(5, anotexpression);
                    }
                    break;
                case 13:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(5, pexpression);
                    }
                    break;
                case 14:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(6, aplusexpression);
                    }
                    break;
                case 15:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(6, aminusexpression);
                    }
                    break;
                case 16:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(6, anegateexpression);
                    }
                    break;
                case 17:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(6, pexpression);
                    }
                    break;
                case 18:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(7, amultiplyexpression);
                    }
                    break;
                case 19:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(7, adivideexpression);
                    }
                    break;
                case 20:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(7, amoduloexpression);
                    }
                    break;
                case 21:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(7, pexpression);
                    }
                    break;
                case 22:
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
                        Push(8, aelementexpression);
                    }
                    break;
                case 23:
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
                        Push(8, aelementexpression);
                    }
                    break;
                case 24:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(8, aindexexpression);
                    }
                    break;
                case 25:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(8, pexpression);
                    }
                    break;
                case 26:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(9, aparenthesisexpression);
                    }
                    break;
                case 27:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(9, pexpression);
                    }
                    break;
                case 28:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(9, anumberexpression);
                    }
                    break;
                case 29:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(9, abooleanexpression);
                    }
                    break;
                case 30:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(9, aidentifierexpression);
                    }
                    break;
                case 31:
                case 32:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 31) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(10, afunctioncallexpression);
                    }
                    break;
                case 33:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(11, pexpressionlist);
                    }
                    break;
                case 34:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(11, pexpressionlist2);
                    }
                    break;
                case 35:
                    Push(12, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 36:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(12, list);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 3, 0},
                new int[] {7, 0, 1},
            },
            new int[][] {
                new int[] {-1, 1, 2},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {32, 2, -1},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {7, 0, 4},
                new int[] {14, 0, 5},
            },
            new int[][] {
                new int[] {-1, 3, 4},
                new int[] {11, 0, 6},
                new int[] {23, 0, 7},
            },
            new int[][] {
                new int[] {-1, 1, 3},
            },
            new int[][] {
                new int[] {-1, 3, 6},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 1, 0},
            },
            new int[][] {
                new int[] {-1, 1, 29},
            },
            new int[][] {
                new int[] {-1, 1, 28},
            },
            new int[][] {
                new int[] {-1, 1, 30},
                new int[] {26, 0, 22},
            },
            new int[][] {
                new int[] {-1, 3, 11},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 12},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 13},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 14},
                new int[] {23, 0, 26},
            },
            new int[][] {
                new int[] {-1, 1, 7},
            },
            new int[][] {
                new int[] {-1, 1, 10},
                new int[] {18, 0, 27},
                new int[] {19, 0, 28},
            },
            new int[][] {
                new int[] {-1, 1, 13},
                new int[] {10, 0, 29},
            },
            new int[][] {
                new int[] {-1, 1, 17},
                new int[] {12, 0, 30},
                new int[] {13, 0, 31},
            },
            new int[][] {
                new int[] {-1, 1, 21},
                new int[] {8, 0, 32},
                new int[] {14, 0, 33},
                new int[] {15, 0, 34},
                new int[] {16, 0, 35},
                new int[] {20, 0, 36},
                new int[] {28, 0, 37},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 1, 27},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
                new int[] {27, 0, 38},
            },
            new int[][] {
                new int[] {-1, 1, 16},
            },
            new int[][] {
                new int[] {-1, 1, 12},
            },
            new int[][] {
                new int[] {-1, 3, 25},
                new int[] {27, 0, 41},
            },
            new int[][] {
                new int[] {-1, 1, 1},
            },
            new int[][] {
                new int[] {-1, 3, 27},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 28},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 29},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 30},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 31},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 32},
                new int[] {7, 0, 47},
            },
            new int[][] {
                new int[] {-1, 3, 33},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 34},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 35},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 36},
                new int[] {7, 0, 51},
            },
            new int[][] {
                new int[] {-1, 3, 37},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 1, 31},
            },
            new int[][] {
                new int[] {-1, 1, 33},
                new int[] {21, 0, 53},
            },
            new int[][] {
                new int[] {-1, 3, 40},
                new int[] {27, 0, 54},
            },
            new int[][] {
                new int[] {-1, 1, 26},
            },
            new int[][] {
                new int[] {-1, 1, 8},
            },
            new int[][] {
                new int[] {-1, 1, 9},
            },
            new int[][] {
                new int[] {-1, 1, 11},
            },
            new int[][] {
                new int[] {-1, 1, 14},
            },
            new int[][] {
                new int[] {-1, 1, 15},
            },
            new int[][] {
                new int[] {-1, 1, 23},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
            new int[][] {
                new int[] {-1, 3, 52},
                new int[] {29, 0, 55},
            },
            new int[][] {
                new int[] {-1, 3, 53},
                new int[] {0, 0, 8},
                new int[] {1, 0, 9},
                new int[] {7, 0, 10},
                new int[] {13, 0, 11},
                new int[] {17, 0, 12},
                new int[] {26, 0, 13},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
        };
        #endregion
        #region gotoTable
        private static int[][][] gotoTable = {
            new int[][] {
                new int[] {-1, 2},
            },
            new int[][] {
                new int[] {-1, 3},
            },
            new int[][] {
                new int[] {-1, -1},
            },
            new int[][] {
                new int[] {-1, 39},
                new int[] {6, 14},
                new int[] {13, 25},
                new int[] {37, 52},
            },
            new int[][] {
                new int[] {-1, 15},
                new int[] {27, 42},
                new int[] {28, 43},
            },
            new int[][] {
                new int[] {-1, 16},
                new int[] {29, 44},
            },
            new int[][] {
                new int[] {-1, 17},
                new int[] {12, 24},
                new int[] {30, 45},
                new int[] {31, 46},
            },
            new int[][] {
                new int[] {-1, 18},
                new int[] {11, 23},
                new int[] {33, 48},
                new int[] {34, 49},
                new int[] {35, 50},
            },
            new int[][] {
                new int[] {-1, 19},
            },
            new int[][] {
                new int[] {-1, 20},
            },
            new int[][] {
                new int[] {-1, 21},
            },
            new int[][] {
                new int[] {-1, 40},
                new int[] {53, 56},
            },
            new int[][] {
                new int[] {-1, -1},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: TIdentifier",
            "Expecting: TIdentifier or '*'",
            "Expecting: end of file",
            "Expecting: '=' or ';'",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!' or '('",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', ')', '[' or ']'",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', '(', ')', '[' or ']'",
            "Expecting: TBool, TNumber, TIdentifier or '('",
            "Expecting: TBool, TNumber, TIdentifier, '-' or '('",
            "Expecting: ';'",
            "Expecting: ',', ';', ')' or ']'",
            "Expecting: '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '+', '-', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!', '(' or ')'",
            "Expecting: ')'",
            "Expecting: ',' or ')'",
            "Expecting: ']'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 2, 1, 3, 1, 4, 2, 5, 5, 6, 7, 8, 4, 9, 10,
            11, 12, 13, 5, 5, 5, 14, 12, 11, 15, 2, 4, 4, 4, 8, 8,
            0, 7, 7, 7, 0, 4, 5, 16, 15, 5, 10, 10, 11, 12, 12, 5,
            13, 13, 13, 5, 17, 4, 5, 5, 15,
        };
        #endregion
    }
}
