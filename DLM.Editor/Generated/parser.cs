using System;
using System.Collections.Generic;
using DLM.Editor.Nodes;
using SablePP.Tools.Nodes;

namespace DLM.Editor.Parsing
{
    public class Parser : SablePP.Tools.Parsing.Parser<PRoot>
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
        
        private int getIndex(TInclude node)
        {
            return 0;
        }
        private int getIndex(TFile node)
        {
            return 1;
        }
        private int getIndex(TBool node)
        {
            return 2;
        }
        private int getIndex(TNumber node)
        {
            return 3;
        }
        private int getIndex(TWhile node)
        {
            return 4;
        }
        private int getIndex(TIf node)
        {
            return 5;
        }
        private int getIndex(TElse node)
        {
            return 6;
        }
        private int getIndex(TReturn node)
        {
            return 7;
        }
        private int getIndex(TActfor node)
        {
            return 8;
        }
        private int getIndex(TIdentifier node)
        {
            return 9;
        }
        private int getIndex(TRArrow node)
        {
            return 10;
        }
        private int getIndex(TLArrow node)
        {
            return 11;
        }
        private int getIndex(TCompare node)
        {
            return 12;
        }
        private int getIndex(TAssign node)
        {
            return 13;
        }
        private int getIndex(TPlus node)
        {
            return 14;
        }
        private int getIndex(TMinus node)
        {
            return 15;
        }
        private int getIndex(TAsterisk node)
        {
            return 16;
        }
        private int getIndex(TSlash node)
        {
            return 17;
        }
        private int getIndex(TPercent node)
        {
            return 18;
        }
        private int getIndex(TBang node)
        {
            return 19;
        }
        private int getIndex(TAnd node)
        {
            return 20;
        }
        private int getIndex(TOr node)
        {
            return 21;
        }
        private int getIndex(TPeriod node)
        {
            return 22;
        }
        private int getIndex(TComma node)
        {
            return 23;
        }
        private int getIndex(TColon node)
        {
            return 24;
        }
        private int getIndex(TSemicolon node)
        {
            return 25;
        }
        private int getIndex(TLabelStart node)
        {
            return 26;
        }
        private int getIndex(TLabelEnd node)
        {
            return 27;
        }
        private int getIndex(TLPar node)
        {
            return 28;
        }
        private int getIndex(TRPar node)
        {
            return 29;
        }
        private int getIndex(TLSqu node)
        {
            return 30;
        }
        private int getIndex(TRSqu node)
        {
            return 31;
        }
        private int getIndex(TLCur node)
        {
            return 32;
        }
        private int getIndex(TRCur node)
        {
            return 33;
        }
        
        private int getIndex(EOF node)
        {
            return 34;
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
                case 1:
                case 2:
                case 3:
                    {
                        List<PStatement> pstatementlist = isOn(2, index - 0) ? Pop<List<PStatement>>() : new List<PStatement>();
                        List<PInclude> pincludelist = isOn(1, index - 0) ? Pop<List<PInclude>>() : new List<PInclude>();
                        List<PInclude> pincludelist2 = new List<PInclude>();
                        pincludelist2.AddRange(pincludelist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        ARoot aroot = new ARoot(
                            pincludelist2,
                            pstatementlist2
                        );
                        Push(0, aroot);
                    }
                    break;
                case 4:
                    {
                        TFile tfile = Pop<TFile>();
                        TInclude tinclude = Pop<TInclude>();
                        AInclude ainclude = new AInclude(
                            tfile
                        );
                        Push(1, ainclude);
                    }
                    break;
                case 5:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(2, adeclarationstatement);
                    }
                    break;
                case 6:
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
                        Push(2, adeclarationstatement);
                    }
                    break;
                case 7:
                case 8:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 7) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        TRPar trpar = Pop<TRPar>();
                        List<PFunctionParameter> pfunctionparameterlist = Pop<List<PFunctionParameter>>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        List<PFunctionParameter> pfunctionparameterlist2 = new List<PFunctionParameter>();
                        pfunctionparameterlist2.AddRange(pfunctionparameterlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AFunctionDeclarationStatement afunctiondeclarationstatement = new AFunctionDeclarationStatement(
                            ptype,
                            tidentifier,
                            pfunctionparameterlist2,
                            pstatementlist2
                        );
                        Push(2, afunctiondeclarationstatement);
                    }
                    break;
                case 9:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist = new List<PFunctionParameter>();
                        pfunctionparameterlist.Add(afunctionparameter);
                        Push(3, pfunctionparameterlist);
                    }
                    break;
                case 10:
                    {
                        List<PFunctionParameter> pfunctionparameterlist = Pop<List<PFunctionParameter>>();
                        TComma tcomma = Pop<TComma>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist2 = new List<PFunctionParameter>();
                        pfunctionparameterlist2.Add(afunctionparameter);
                        pfunctionparameterlist2.AddRange(pfunctionparameterlist);
                        Push(3, pfunctionparameterlist2);
                    }
                    break;
                case 11:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AIfStatement aifstatement = new AIfStatement(
                            pexpression,
                            pstatementlist2
                        );
                        Push(4, aifstatement);
                    }
                    break;
                case 12:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TElse telse = Pop<TElse>();
                        List<PStatement> pstatementlist2 = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist3 = new List<PStatement>();
                        pstatementlist3.AddRange(pstatementlist2);
                        List<PStatement> pstatementlist4 = new List<PStatement>();
                        pstatementlist4.AddRange(pstatementlist);
                        AIfElseStatement aifelsestatement = new AIfElseStatement(
                            pexpression,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(4, aifelsestatement);
                    }
                    break;
                case 13:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TWhile twhile = Pop<TWhile>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AWhileStatement awhilestatement = new AWhileStatement(
                            pexpression,
                            pstatementlist2
                        );
                        Push(4, awhilestatement);
                    }
                    break;
                case 14:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(4, pstatement);
                    }
                    break;
                case 15:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TElse telse = Pop<TElse>();
                        List<PStatement> pstatementlist2 = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIf tif = Pop<TIf>();
                        List<PStatement> pstatementlist3 = new List<PStatement>();
                        pstatementlist3.AddRange(pstatementlist2);
                        List<PStatement> pstatementlist4 = new List<PStatement>();
                        pstatementlist4.AddRange(pstatementlist);
                        AIfElseStatement aifelsestatement = new AIfElseStatement(
                            pexpression,
                            pstatementlist3,
                            pstatementlist4
                        );
                        Push(5, aifelsestatement);
                    }
                    break;
                case 16:
                    {
                        List<PStatement> pstatementlist = Pop<List<PStatement>>();
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TWhile twhile = Pop<TWhile>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AWhileStatement awhilestatement = new AWhileStatement(
                            pexpression,
                            pstatementlist2
                        );
                        Push(5, awhilestatement);
                    }
                    break;
                case 17:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(5, pstatement);
                    }
                    break;
                case 18:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(6, adeclarationstatement);
                    }
                    break;
                case 19:
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
                        Push(6, adeclarationstatement);
                    }
                    break;
                case 20:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AAssignmentStatement aassignmentstatement = new AAssignmentStatement(
                            tidentifier,
                            pexpression
                        );
                        Push(6, aassignmentstatement);
                    }
                    break;
                case 21:
                case 22:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 21) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            pexpression
                        );
                        Push(6, areturnstatement);
                    }
                    break;
                case 23:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier
                        );
                        Push(7, atype);
                    }
                    break;
                case 24:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PType ptype = Pop<PType>();
                        APointerType apointertype = new APointerType(
                            ptype,
                            tasterisk
                        );
                        Push(7, apointertype);
                    }
                    break;
                case 25:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(8, pstatementlist);
                    }
                    break;
                case 26:
                case 27:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 26) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(8, pstatementlist2);
                    }
                    break;
                case 28:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(9, pstatementlist);
                    }
                    break;
                case 29:
                case 30:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 29) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(9, pstatementlist2);
                    }
                    break;
                case 31:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(10, pexpression);
                    }
                    break;
                case 32:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(11, aandexpression);
                    }
                    break;
                case 33:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(11, aorexpression);
                    }
                    break;
                case 34:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(11, pexpression);
                    }
                    break;
                case 35:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(12, acomparisonexpression);
                    }
                    break;
                case 36:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(12, anotexpression);
                    }
                    break;
                case 37:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(12, pexpression);
                    }
                    break;
                case 38:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(13, aplusexpression);
                    }
                    break;
                case 39:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(13, aminusexpression);
                    }
                    break;
                case 40:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(13, anegateexpression);
                    }
                    break;
                case 41:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(13, pexpression);
                    }
                    break;
                case 42:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(14, amultiplyexpression);
                    }
                    break;
                case 43:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(14, adivideexpression);
                    }
                    break;
                case 44:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(14, amoduloexpression);
                    }
                    break;
                case 45:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(14, pexpression);
                    }
                    break;
                case 46:
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
                        Push(15, aelementexpression);
                    }
                    break;
                case 47:
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
                        Push(15, aelementexpression);
                    }
                    break;
                case 48:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(15, aindexexpression);
                    }
                    break;
                case 49:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(15, pexpression);
                    }
                    break;
                case 50:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(16, aparenthesisexpression);
                    }
                    break;
                case 51:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(16, pexpression);
                    }
                    break;
                case 52:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(16, anumberexpression);
                    }
                    break;
                case 53:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(16, abooleanexpression);
                    }
                    break;
                case 54:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(16, aidentifierexpression);
                    }
                    break;
                case 55:
                case 56:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 55) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(17, afunctioncallexpression);
                    }
                    break;
                case 57:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(18, pexpressionlist);
                    }
                    break;
                case 58:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(18, pexpressionlist2);
                    }
                    break;
                case 59:
                    Push(19, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 60:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(19, list);
                    }
                    break;
                case 61:
                    Push(20, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 62:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(20, list);
                    }
                    break;
                case 63:
                    Push(21, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 64:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(21, list);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 1, 0},
                new int[] {0, 0, 1},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 3, 1},
                new int[] {1, 0, 9},
            },
            new int[][] {
                new int[] {-1, 1, 23},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {34, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 59},
            },
            new int[][] {
                new int[] {-1, 1, 61},
            },
            new int[][] {
                new int[] {-1, 3, 6},
                new int[] {9, 0, 10},
                new int[] {16, 0, 11},
            },
            new int[][] {
                new int[] {-1, 1, 1},
                new int[] {0, 0, 1},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 1, 2},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 1, 4},
            },
            new int[][] {
                new int[] {-1, 3, 10},
                new int[] {13, 0, 15},
                new int[] {25, 0, 16},
                new int[] {28, 0, 17},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 3, 15},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 5},
            },
            new int[][] {
                new int[] {-1, 3, 17},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 1, 54},
                new int[] {28, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 21},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 23},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 24},
                new int[] {25, 0, 38},
            },
            new int[][] {
                new int[] {-1, 1, 31},
            },
            new int[][] {
                new int[] {-1, 1, 34},
                new int[] {20, 0, 39},
                new int[] {21, 0, 40},
            },
            new int[][] {
                new int[] {-1, 1, 37},
                new int[] {12, 0, 41},
            },
            new int[][] {
                new int[] {-1, 1, 41},
                new int[] {14, 0, 42},
                new int[] {15, 0, 43},
            },
            new int[][] {
                new int[] {-1, 1, 45},
                new int[] {10, 0, 44},
                new int[] {16, 0, 45},
                new int[] {17, 0, 46},
                new int[] {18, 0, 47},
                new int[] {22, 0, 48},
                new int[] {30, 0, 49},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 3, 32},
                new int[] {29, 0, 50},
            },
            new int[][] {
                new int[] {-1, 3, 33},
                new int[] {9, 0, 51},
                new int[] {16, 0, 11},
            },
            new int[][] {
                new int[] {-1, 3, 34},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
                new int[] {29, 0, 52},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 3, 37},
                new int[] {29, 0, 55},
            },
            new int[][] {
                new int[] {-1, 1, 6},
            },
            new int[][] {
                new int[] {-1, 3, 39},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 40},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 41},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 42},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 43},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 44},
                new int[] {9, 0, 61},
            },
            new int[][] {
                new int[] {-1, 3, 45},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 46},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 47},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 48},
                new int[] {9, 0, 65},
            },
            new int[][] {
                new int[] {-1, 3, 49},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 50},
                new int[] {32, 0, 67},
            },
            new int[][] {
                new int[] {-1, 1, 9},
                new int[] {23, 0, 68},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 1, 57},
                new int[] {23, 0, 69},
            },
            new int[][] {
                new int[] {-1, 3, 54},
                new int[] {29, 0, 70},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
            new int[][] {
                new int[] {-1, 1, 35},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 1, 44},
            },
            new int[][] {
                new int[] {-1, 1, 46},
            },
            new int[][] {
                new int[] {-1, 3, 66},
                new int[] {31, 0, 71},
            },
            new int[][] {
                new int[] {-1, 3, 67},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 76},
            },
            new int[][] {
                new int[] {-1, 3, 68},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 3, 69},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 56},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 3, 72},
                new int[] {28, 0, 83},
            },
            new int[][] {
                new int[] {-1, 3, 73},
                new int[] {28, 0, 84},
            },
            new int[][] {
                new int[] {-1, 3, 74},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {25, 0, 85},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 23},
                new int[] {13, 0, 87},
            },
            new int[][] {
                new int[] {-1, 1, 7},
            },
            new int[][] {
                new int[] {-1, 1, 63},
            },
            new int[][] {
                new int[] {-1, 1, 14},
            },
            new int[][] {
                new int[] {-1, 3, 79},
                new int[] {9, 0, 88},
                new int[] {16, 0, 11},
            },
            new int[][] {
                new int[] {-1, 3, 80},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 89},
            },
            new int[][] {
                new int[] {-1, 1, 10},
            },
            new int[][] {
                new int[] {-1, 1, 58},
            },
            new int[][] {
                new int[] {-1, 3, 83},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 84},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 21},
            },
            new int[][] {
                new int[] {-1, 3, 86},
                new int[] {25, 0, 93},
            },
            new int[][] {
                new int[] {-1, 3, 87},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 88},
                new int[] {13, 0, 95},
                new int[] {25, 0, 96},
            },
            new int[][] {
                new int[] {-1, 1, 8},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {29, 0, 97},
            },
            new int[][] {
                new int[] {-1, 3, 92},
                new int[] {29, 0, 98},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
            new int[][] {
                new int[] {-1, 3, 94},
                new int[] {25, 0, 99},
            },
            new int[][] {
                new int[] {-1, 3, 95},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 3, 97},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 101},
            },
            new int[][] {
                new int[] {-1, 3, 98},
                new int[] {4, 0, 104},
                new int[] {5, 0, 105},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 106},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 3, 100},
                new int[] {25, 0, 111},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 112},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 1, 13},
            },
            new int[][] {
                new int[] {-1, 3, 104},
                new int[] {28, 0, 114},
            },
            new int[][] {
                new int[] {-1, 3, 105},
                new int[] {28, 0, 115},
            },
            new int[][] {
                new int[] {-1, 3, 106},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 116},
            },
            new int[][] {
                new int[] {-1, 1, 28},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {6, 1, 17},
            },
            new int[][] {
                new int[] {-1, 1, 11},
            },
            new int[][] {
                new int[] {-1, 3, 110},
                new int[] {6, 0, 118},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 1, 26},
            },
            new int[][] {
                new int[] {-1, 3, 113},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 119},
            },
            new int[][] {
                new int[] {-1, 3, 114},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 115},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 26},
                new int[] {6, 1, 29},
            },
            new int[][] {
                new int[] {-1, 3, 117},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 122},
            },
            new int[][] {
                new int[] {-1, 3, 118},
                new int[] {4, 0, 123},
                new int[] {5, 0, 124},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 125},
            },
            new int[][] {
                new int[] {-1, 1, 27},
            },
            new int[][] {
                new int[] {-1, 3, 120},
                new int[] {29, 0, 128},
            },
            new int[][] {
                new int[] {-1, 3, 121},
                new int[] {29, 0, 129},
            },
            new int[][] {
                new int[] {-1, 1, 27},
                new int[] {6, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 123},
                new int[] {28, 0, 130},
            },
            new int[][] {
                new int[] {-1, 3, 124},
                new int[] {28, 0, 131},
            },
            new int[][] {
                new int[] {-1, 3, 125},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 132},
            },
            new int[][] {
                new int[] {-1, 1, 17},
            },
            new int[][] {
                new int[] {-1, 1, 12},
            },
            new int[][] {
                new int[] {-1, 3, 128},
                new int[] {4, 0, 104},
                new int[] {5, 0, 105},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 106},
            },
            new int[][] {
                new int[] {-1, 3, 129},
                new int[] {4, 0, 104},
                new int[] {5, 0, 105},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 106},
            },
            new int[][] {
                new int[] {-1, 3, 130},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 3, 131},
                new int[] {2, 0, 18},
                new int[] {3, 0, 19},
                new int[] {9, 0, 20},
                new int[] {15, 0, 21},
                new int[] {19, 0, 22},
                new int[] {28, 0, 23},
            },
            new int[][] {
                new int[] {-1, 1, 29},
            },
            new int[][] {
                new int[] {-1, 3, 133},
                new int[] {4, 0, 72},
                new int[] {5, 0, 73},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {33, 0, 138},
            },
            new int[][] {
                new int[] {-1, 1, 16},
            },
            new int[][] {
                new int[] {-1, 3, 135},
                new int[] {6, 0, 139},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {29, 0, 140},
            },
            new int[][] {
                new int[] {-1, 3, 137},
                new int[] {29, 0, 141},
            },
            new int[][] {
                new int[] {-1, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 139},
                new int[] {4, 0, 123},
                new int[] {5, 0, 124},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 125},
            },
            new int[][] {
                new int[] {-1, 3, 140},
                new int[] {4, 0, 123},
                new int[] {5, 0, 124},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 125},
            },
            new int[][] {
                new int[] {-1, 3, 141},
                new int[] {4, 0, 123},
                new int[] {5, 0, 124},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 125},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {6, 1, 15},
            },
            new int[][] {
                new int[] {-1, 3, 143},
                new int[] {6, 0, 144},
            },
            new int[][] {
                new int[] {-1, 3, 144},
                new int[] {4, 0, 123},
                new int[] {5, 0, 124},
                new int[] {7, 0, 74},
                new int[] {9, 0, 75},
                new int[] {32, 0, 125},
            },
            new int[][] {
                new int[] {-1, 1, 15},
            },
        };
        #endregion
        #region gotoTable
        private static int[][][] gotoTable = {
            new int[][] {
                new int[] {-1, 3},
            },
            new int[][] {
                new int[] {-1, 4},
                new int[] {7, 12},
            },
            new int[][] {
                new int[] {-1, 5},
                new int[] {8, 14},
                new int[] {13, 14},
            },
            new int[][] {
                new int[] {-1, 32},
                new int[] {68, 81},
            },
            new int[][] {
                new int[] {-1, 77},
                new int[] {80, 90},
                new int[] {97, 102},
                new int[] {98, 102},
                new int[] {113, 90},
                new int[] {117, 90},
                new int[] {128, 102},
                new int[] {129, 102},
                new int[] {133, 90},
            },
            new int[][] {
                new int[] {-1, 107},
            },
            new int[][] {
                new int[] {-1, 78},
                new int[] {98, 108},
                new int[] {118, 126},
                new int[] {128, 108},
                new int[] {129, 108},
                new int[] {139, 126},
                new int[] {140, 126},
                new int[] {141, 126},
                new int[] {144, 126},
            },
            new int[][] {
                new int[] {-1, 79},
                new int[] {0, 6},
                new int[] {7, 6},
                new int[] {8, 6},
                new int[] {13, 6},
                new int[] {17, 33},
                new int[] {68, 33},
            },
            new int[][] {
                new int[] {-1, 103},
                new int[] {98, 109},
                new int[] {129, 109},
            },
            new int[][] {
                new int[] {-1, 134},
                new int[] {98, 110},
                new int[] {118, 127},
                new int[] {129, 135},
                new int[] {139, 142},
                new int[] {141, 143},
                new int[] {144, 145},
            },
            new int[][] {
                new int[] {-1, 53},
                new int[] {15, 24},
                new int[] {23, 37},
                new int[] {49, 66},
                new int[] {74, 86},
                new int[] {83, 91},
                new int[] {84, 92},
                new int[] {87, 94},
                new int[] {95, 100},
                new int[] {114, 120},
                new int[] {115, 121},
                new int[] {130, 136},
                new int[] {131, 137},
            },
            new int[][] {
                new int[] {-1, 25},
                new int[] {39, 56},
                new int[] {40, 57},
            },
            new int[][] {
                new int[] {-1, 26},
                new int[] {41, 58},
            },
            new int[][] {
                new int[] {-1, 27},
                new int[] {22, 36},
                new int[] {42, 59},
                new int[] {43, 60},
            },
            new int[][] {
                new int[] {-1, 28},
                new int[] {21, 35},
                new int[] {45, 62},
                new int[] {46, 63},
                new int[] {47, 64},
            },
            new int[][] {
                new int[] {-1, 29},
            },
            new int[][] {
                new int[] {-1, 30},
            },
            new int[][] {
                new int[] {-1, 31},
            },
            new int[][] {
                new int[] {-1, 54},
                new int[] {69, 82},
            },
            new int[][] {
                new int[] {-1, 7},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {7, 13},
            },
            new int[][] {
                new int[] {-1, 80},
                new int[] {101, 113},
                new int[] {106, 117},
                new int[] {125, 133},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: '#include', TIdentifier or end of file",
            "Expecting: TFile",
            "Expecting: TIdentifier or '*'",
            "Expecting: end of file",
            "Expecting: TIdentifier or end of file",
            "Expecting: '=', ';' or '('",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!' or '('",
            "Expecting: TIdentifier",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', ')', '[' or ']'",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', '(', ')', '[' or ']'",
            "Expecting: TBool, TNumber, TIdentifier or '('",
            "Expecting: TBool, TNumber, TIdentifier, '-' or '('",
            "Expecting: ';'",
            "Expecting: ',', ';', ')' or ']'",
            "Expecting: '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '+', '-', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: ')'",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!', '(' or ')'",
            "Expecting: '{'",
            "Expecting: ',' or ')'",
            "Expecting: ']'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '}'",
            "Expecting: '('",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!', ';' or '('",
            "Expecting: TIdentifier, '=' or '*'",
            "Expecting: 'while', 'if', 'else', 'return', TIdentifier or '}'",
            "Expecting: '=' or ';'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '{'",
            "Expecting: 'else'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 2, 3, 0, 4, 2, 0, 4, 0, 5, 2, 0, 4, 4, 6,
            4, 7, 8, 8, 9, 10, 11, 6, 12, 13, 14, 15, 16, 8, 8, 8,
            17, 2, 18, 15, 14, 17, 4, 6, 6, 6, 11, 11, 7, 10, 10, 10,
            7, 6, 19, 20, 8, 20, 17, 8, 13, 13, 14, 15, 15, 8, 16, 16,
            16, 8, 21, 22, 7, 6, 8, 8, 23, 23, 24, 25, 4, 22, 22, 2,
            22, 17, 17, 6, 6, 26, 12, 6, 27, 4, 22, 17, 17, 26, 12, 6,
            26, 28, 28, 26, 12, 22, 22, 22, 23, 23, 22, 26, 26, 22, 29, 26,
            22, 22, 6, 6, 26, 22, 28, 22, 17, 17, 26, 23, 23, 22, 26, 22,
            28, 28, 6, 6, 26, 22, 26, 29, 17, 17, 26, 28, 28, 28, 26, 29,
            28, 26,
        };
        #endregion
    }
}
