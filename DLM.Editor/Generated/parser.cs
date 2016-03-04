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
        private int getIndex(TUnderscore node)
        {
            return 14;
        }
        private int getIndex(TPlus node)
        {
            return 15;
        }
        private int getIndex(TMinus node)
        {
            return 16;
        }
        private int getIndex(TAsterisk node)
        {
            return 17;
        }
        private int getIndex(TSlash node)
        {
            return 18;
        }
        private int getIndex(TPercent node)
        {
            return 19;
        }
        private int getIndex(TBang node)
        {
            return 20;
        }
        private int getIndex(TAnd node)
        {
            return 21;
        }
        private int getIndex(TOr node)
        {
            return 22;
        }
        private int getIndex(TPeriod node)
        {
            return 23;
        }
        private int getIndex(TComma node)
        {
            return 24;
        }
        private int getIndex(TColon node)
        {
            return 25;
        }
        private int getIndex(TSemicolon node)
        {
            return 26;
        }
        private int getIndex(TLabelStart node)
        {
            return 27;
        }
        private int getIndex(TLabelEnd node)
        {
            return 28;
        }
        private int getIndex(TLPar node)
        {
            return 29;
        }
        private int getIndex(TRPar node)
        {
            return 30;
        }
        private int getIndex(TLSqu node)
        {
            return 31;
        }
        private int getIndex(TRSqu node)
        {
            return 32;
        }
        private int getIndex(TLCur node)
        {
            return 33;
        }
        private int getIndex(TRCur node)
        {
            return 34;
        }
        
        private int getIndex(EOF node)
        {
            return 35;
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
                case 24:
                    {
                        PLabel plabel = isOn(1, index - 23) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(7, atype);
                    }
                    break;
                case 25:
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
                case 26:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(8, pstatementlist);
                    }
                    break;
                case 27:
                case 28:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 27) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(8, pstatementlist2);
                    }
                    break;
                case 29:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(9, pstatementlist);
                    }
                    break;
                case 30:
                case 31:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 30) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(9, pstatementlist2);
                    }
                    break;
                case 32:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2
                        );
                        Push(10, alabel);
                    }
                    break;
                case 33:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(11, avariablepolicy);
                    }
                    break;
                case 34:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TRArrow trarrow = Pop<TRArrow>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.AddRange(pprincipallist);
                        APrincipalPolicy aprincipalpolicy = new APrincipalPolicy(
                            pprincipal,
                            pprincipallist2
                        );
                        Push(11, aprincipalpolicy);
                    }
                    break;
                case 35:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(12, ppolicylist);
                    }
                    break;
                case 36:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(12, ppolicylist2);
                    }
                    break;
                case 37:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier
                        );
                        Push(13, aprincipal);
                    }
                    break;
                case 38:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPrincipal alowerprincipal = new ALowerPrincipal(
                            tunderscore
                        );
                        Push(13, alowerprincipal);
                    }
                    break;
                case 39:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        AUpperPrincipal aupperprincipal = new AUpperPrincipal(
                            tasterisk
                        );
                        Push(13, aupperprincipal);
                    }
                    break;
                case 40:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(14, pprincipallist);
                    }
                    break;
                case 41:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TComma tcomma = Pop<TComma>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.Add(pprincipal);
                        pprincipallist2.AddRange(pprincipallist);
                        Push(14, pprincipallist2);
                    }
                    break;
                case 42:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(15, pexpression);
                    }
                    break;
                case 43:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(16, aandexpression);
                    }
                    break;
                case 44:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(16, aorexpression);
                    }
                    break;
                case 45:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(16, pexpression);
                    }
                    break;
                case 46:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(17, acomparisonexpression);
                    }
                    break;
                case 47:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(17, anotexpression);
                    }
                    break;
                case 48:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(17, pexpression);
                    }
                    break;
                case 49:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(18, aplusexpression);
                    }
                    break;
                case 50:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(18, aminusexpression);
                    }
                    break;
                case 51:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(18, anegateexpression);
                    }
                    break;
                case 52:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(18, pexpression);
                    }
                    break;
                case 53:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(19, amultiplyexpression);
                    }
                    break;
                case 54:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(19, adivideexpression);
                    }
                    break;
                case 55:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(19, amoduloexpression);
                    }
                    break;
                case 56:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(19, pexpression);
                    }
                    break;
                case 57:
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
                        Push(20, aelementexpression);
                    }
                    break;
                case 58:
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
                        Push(20, aelementexpression);
                    }
                    break;
                case 59:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(20, aindexexpression);
                    }
                    break;
                case 60:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(20, pexpression);
                    }
                    break;
                case 61:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(21, aparenthesisexpression);
                    }
                    break;
                case 62:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(21, pexpression);
                    }
                    break;
                case 63:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(21, anumberexpression);
                    }
                    break;
                case 64:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(21, abooleanexpression);
                    }
                    break;
                case 65:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(21, aidentifierexpression);
                    }
                    break;
                case 66:
                case 67:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 66) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(22, afunctioncallexpression);
                    }
                    break;
                case 68:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(23, pexpressionlist);
                    }
                    break;
                case 69:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(23, pexpressionlist2);
                    }
                    break;
                case 70:
                    Push(24, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 71:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(24, list);
                    }
                    break;
                case 72:
                    Push(25, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 73:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(25, list);
                    }
                    break;
                case 74:
                    Push(26, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 75:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(26, list);
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
                new int[] {27, 0, 10},
            },
            new int[][] {
                new int[] {-1, 3, 3},
                new int[] {35, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 70},
            },
            new int[][] {
                new int[] {-1, 1, 72},
            },
            new int[][] {
                new int[] {-1, 3, 6},
                new int[] {9, 0, 12},
                new int[] {17, 0, 13},
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
                new int[] {9, 0, 17},
                new int[] {14, 0, 18},
                new int[] {17, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 3, 12},
                new int[] {13, 0, 23},
                new int[] {26, 0, 24},
                new int[] {29, 0, 25},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 1, 71},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 1, 33},
                new int[] {10, 1, 37},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 1, 35},
                new int[] {26, 0, 26},
            },
            new int[][] {
                new int[] {-1, 3, 21},
                new int[] {28, 0, 27},
            },
            new int[][] {
                new int[] {-1, 3, 22},
                new int[] {10, 0, 28},
            },
            new int[][] {
                new int[] {-1, 3, 23},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 5},
            },
            new int[][] {
                new int[] {-1, 3, 25},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 3, 26},
                new int[] {9, 0, 17},
                new int[] {14, 0, 18},
                new int[] {17, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 32},
            },
            new int[][] {
                new int[] {-1, 3, 28},
                new int[] {9, 0, 46},
                new int[] {14, 0, 18},
                new int[] {17, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 1, 63},
            },
            new int[][] {
                new int[] {-1, 1, 65},
                new int[] {29, 0, 49},
            },
            new int[][] {
                new int[] {-1, 3, 32},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 33},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 34},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 35},
                new int[] {26, 0, 53},
            },
            new int[][] {
                new int[] {-1, 1, 42},
            },
            new int[][] {
                new int[] {-1, 1, 45},
                new int[] {21, 0, 54},
                new int[] {22, 0, 55},
            },
            new int[][] {
                new int[] {-1, 1, 48},
                new int[] {12, 0, 56},
            },
            new int[][] {
                new int[] {-1, 1, 52},
                new int[] {15, 0, 57},
                new int[] {16, 0, 58},
            },
            new int[][] {
                new int[] {-1, 1, 56},
                new int[] {10, 0, 59},
                new int[] {17, 0, 60},
                new int[] {18, 0, 61},
                new int[] {19, 0, 62},
                new int[] {23, 0, 63},
                new int[] {31, 0, 64},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 1, 62},
            },
            new int[][] {
                new int[] {-1, 3, 43},
                new int[] {30, 0, 65},
            },
            new int[][] {
                new int[] {-1, 3, 44},
                new int[] {9, 0, 66},
                new int[] {17, 0, 13},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 1, 37},
            },
            new int[][] {
                new int[] {-1, 1, 40},
                new int[] {24, 0, 67},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 3, 49},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
                new int[] {30, 0, 68},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 3, 52},
                new int[] {30, 0, 71},
            },
            new int[][] {
                new int[] {-1, 1, 6},
            },
            new int[][] {
                new int[] {-1, 3, 54},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 55},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 56},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 57},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 58},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 59},
                new int[] {9, 0, 77},
            },
            new int[][] {
                new int[] {-1, 3, 60},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 61},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 62},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 63},
                new int[] {9, 0, 81},
            },
            new int[][] {
                new int[] {-1, 3, 64},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 65},
                new int[] {33, 0, 83},
            },
            new int[][] {
                new int[] {-1, 1, 9},
                new int[] {24, 0, 84},
            },
            new int[][] {
                new int[] {-1, 3, 67},
                new int[] {9, 0, 46},
                new int[] {14, 0, 18},
                new int[] {17, 0, 19},
            },
            new int[][] {
                new int[] {-1, 1, 66},
            },
            new int[][] {
                new int[] {-1, 1, 68},
                new int[] {24, 0, 86},
            },
            new int[][] {
                new int[] {-1, 3, 70},
                new int[] {30, 0, 87},
            },
            new int[][] {
                new int[] {-1, 1, 61},
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
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 1, 50},
            },
            new int[][] {
                new int[] {-1, 1, 58},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 1, 54},
            },
            new int[][] {
                new int[] {-1, 1, 55},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 3, 82},
                new int[] {32, 0, 88},
            },
            new int[][] {
                new int[] {-1, 3, 83},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 93},
            },
            new int[][] {
                new int[] {-1, 3, 84},
                new int[] {9, 0, 2},
            },
            new int[][] {
                new int[] {-1, 1, 41},
            },
            new int[][] {
                new int[] {-1, 3, 86},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 1, 59},
            },
            new int[][] {
                new int[] {-1, 3, 89},
                new int[] {29, 0, 100},
            },
            new int[][] {
                new int[] {-1, 3, 90},
                new int[] {29, 0, 101},
            },
            new int[][] {
                new int[] {-1, 3, 91},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {26, 0, 102},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 23},
                new int[] {13, 0, 104},
                new int[] {27, 0, 10},
            },
            new int[][] {
                new int[] {-1, 1, 7},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 1, 14},
            },
            new int[][] {
                new int[] {-1, 3, 96},
                new int[] {9, 0, 105},
                new int[] {17, 0, 13},
            },
            new int[][] {
                new int[] {-1, 3, 97},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 106},
            },
            new int[][] {
                new int[] {-1, 1, 10},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 3, 100},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 101},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 21},
            },
            new int[][] {
                new int[] {-1, 3, 103},
                new int[] {26, 0, 110},
            },
            new int[][] {
                new int[] {-1, 3, 104},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 105},
                new int[] {13, 0, 112},
                new int[] {26, 0, 113},
            },
            new int[][] {
                new int[] {-1, 1, 8},
            },
            new int[][] {
                new int[] {-1, 1, 75},
            },
            new int[][] {
                new int[] {-1, 3, 108},
                new int[] {30, 0, 114},
            },
            new int[][] {
                new int[] {-1, 3, 109},
                new int[] {30, 0, 115},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
            new int[][] {
                new int[] {-1, 3, 111},
                new int[] {26, 0, 116},
            },
            new int[][] {
                new int[] {-1, 3, 112},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 3, 114},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 118},
            },
            new int[][] {
                new int[] {-1, 3, 115},
                new int[] {4, 0, 121},
                new int[] {5, 0, 122},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 123},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 3, 117},
                new int[] {26, 0, 128},
            },
            new int[][] {
                new int[] {-1, 3, 118},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 129},
            },
            new int[][] {
                new int[] {-1, 1, 26},
            },
            new int[][] {
                new int[] {-1, 1, 13},
            },
            new int[][] {
                new int[] {-1, 3, 121},
                new int[] {29, 0, 131},
            },
            new int[][] {
                new int[] {-1, 3, 122},
                new int[] {29, 0, 132},
            },
            new int[][] {
                new int[] {-1, 3, 123},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 133},
            },
            new int[][] {
                new int[] {-1, 1, 29},
            },
            new int[][] {
                new int[] {-1, 1, 14},
                new int[] {6, 1, 17},
            },
            new int[][] {
                new int[] {-1, 1, 11},
            },
            new int[][] {
                new int[] {-1, 3, 127},
                new int[] {6, 0, 135},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 1, 27},
            },
            new int[][] {
                new int[] {-1, 3, 130},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 136},
            },
            new int[][] {
                new int[] {-1, 3, 131},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 132},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 27},
                new int[] {6, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 134},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 139},
            },
            new int[][] {
                new int[] {-1, 3, 135},
                new int[] {4, 0, 140},
                new int[] {5, 0, 141},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 142},
            },
            new int[][] {
                new int[] {-1, 1, 28},
            },
            new int[][] {
                new int[] {-1, 3, 137},
                new int[] {30, 0, 145},
            },
            new int[][] {
                new int[] {-1, 3, 138},
                new int[] {30, 0, 146},
            },
            new int[][] {
                new int[] {-1, 1, 28},
                new int[] {6, 1, 31},
            },
            new int[][] {
                new int[] {-1, 3, 140},
                new int[] {29, 0, 147},
            },
            new int[][] {
                new int[] {-1, 3, 141},
                new int[] {29, 0, 148},
            },
            new int[][] {
                new int[] {-1, 3, 142},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 149},
            },
            new int[][] {
                new int[] {-1, 1, 17},
            },
            new int[][] {
                new int[] {-1, 1, 12},
            },
            new int[][] {
                new int[] {-1, 3, 145},
                new int[] {4, 0, 121},
                new int[] {5, 0, 122},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 123},
            },
            new int[][] {
                new int[] {-1, 3, 146},
                new int[] {4, 0, 121},
                new int[] {5, 0, 122},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 123},
            },
            new int[][] {
                new int[] {-1, 3, 147},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 3, 148},
                new int[] {2, 0, 29},
                new int[] {3, 0, 30},
                new int[] {9, 0, 31},
                new int[] {16, 0, 32},
                new int[] {20, 0, 33},
                new int[] {29, 0, 34},
            },
            new int[][] {
                new int[] {-1, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 150},
                new int[] {4, 0, 89},
                new int[] {5, 0, 90},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {34, 0, 155},
            },
            new int[][] {
                new int[] {-1, 1, 16},
            },
            new int[][] {
                new int[] {-1, 3, 152},
                new int[] {6, 0, 156},
            },
            new int[][] {
                new int[] {-1, 3, 153},
                new int[] {30, 0, 157},
            },
            new int[][] {
                new int[] {-1, 3, 154},
                new int[] {30, 0, 158},
            },
            new int[][] {
                new int[] {-1, 1, 31},
            },
            new int[][] {
                new int[] {-1, 3, 156},
                new int[] {4, 0, 140},
                new int[] {5, 0, 141},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 142},
            },
            new int[][] {
                new int[] {-1, 3, 157},
                new int[] {4, 0, 140},
                new int[] {5, 0, 141},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 142},
            },
            new int[][] {
                new int[] {-1, 3, 158},
                new int[] {4, 0, 140},
                new int[] {5, 0, 141},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 142},
            },
            new int[][] {
                new int[] {-1, 1, 12},
                new int[] {6, 1, 15},
            },
            new int[][] {
                new int[] {-1, 3, 160},
                new int[] {6, 0, 161},
            },
            new int[][] {
                new int[] {-1, 3, 161},
                new int[] {4, 0, 140},
                new int[] {5, 0, 141},
                new int[] {7, 0, 91},
                new int[] {9, 0, 92},
                new int[] {33, 0, 142},
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
                new int[] {7, 14},
            },
            new int[][] {
                new int[] {-1, 5},
                new int[] {8, 16},
                new int[] {15, 16},
            },
            new int[][] {
                new int[] {-1, 43},
                new int[] {84, 98},
            },
            new int[][] {
                new int[] {-1, 94},
                new int[] {97, 107},
                new int[] {114, 119},
                new int[] {115, 119},
                new int[] {130, 107},
                new int[] {134, 107},
                new int[] {145, 119},
                new int[] {146, 119},
                new int[] {150, 107},
            },
            new int[][] {
                new int[] {-1, 124},
            },
            new int[][] {
                new int[] {-1, 95},
                new int[] {115, 125},
                new int[] {135, 143},
                new int[] {145, 125},
                new int[] {146, 125},
                new int[] {156, 143},
                new int[] {157, 143},
                new int[] {158, 143},
                new int[] {161, 143},
            },
            new int[][] {
                new int[] {-1, 96},
                new int[] {0, 6},
                new int[] {7, 6},
                new int[] {8, 6},
                new int[] {15, 6},
                new int[] {25, 44},
                new int[] {84, 44},
            },
            new int[][] {
                new int[] {-1, 120},
                new int[] {115, 126},
                new int[] {146, 126},
            },
            new int[][] {
                new int[] {-1, 151},
                new int[] {115, 127},
                new int[] {135, 144},
                new int[] {146, 152},
                new int[] {156, 159},
                new int[] {158, 160},
                new int[] {161, 162},
            },
            new int[][] {
                new int[] {-1, 11},
            },
            new int[][] {
                new int[] {-1, 20},
            },
            new int[][] {
                new int[] {-1, 21},
                new int[] {26, 45},
            },
            new int[][] {
                new int[] {-1, 22},
                new int[] {28, 47},
                new int[] {67, 47},
            },
            new int[][] {
                new int[] {-1, 48},
                new int[] {67, 85},
            },
            new int[][] {
                new int[] {-1, 69},
                new int[] {23, 35},
                new int[] {34, 52},
                new int[] {64, 82},
                new int[] {91, 103},
                new int[] {100, 108},
                new int[] {101, 109},
                new int[] {104, 111},
                new int[] {112, 117},
                new int[] {131, 137},
                new int[] {132, 138},
                new int[] {147, 153},
                new int[] {148, 154},
            },
            new int[][] {
                new int[] {-1, 36},
                new int[] {54, 72},
                new int[] {55, 73},
            },
            new int[][] {
                new int[] {-1, 37},
                new int[] {56, 74},
            },
            new int[][] {
                new int[] {-1, 38},
                new int[] {33, 51},
                new int[] {57, 75},
                new int[] {58, 76},
            },
            new int[][] {
                new int[] {-1, 39},
                new int[] {32, 50},
                new int[] {60, 78},
                new int[] {61, 79},
                new int[] {62, 80},
            },
            new int[][] {
                new int[] {-1, 40},
            },
            new int[][] {
                new int[] {-1, 41},
            },
            new int[][] {
                new int[] {-1, 42},
            },
            new int[][] {
                new int[] {-1, 70},
                new int[] {86, 99},
            },
            new int[][] {
                new int[] {-1, 7},
            },
            new int[][] {
                new int[] {-1, 8},
                new int[] {7, 15},
            },
            new int[][] {
                new int[] {-1, 97},
                new int[] {118, 130},
                new int[] {123, 134},
                new int[] {142, 150},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: '#include', TIdentifier or end of file",
            "Expecting: TFile",
            "Expecting: TIdentifier, '*' or '{{'",
            "Expecting: end of file",
            "Expecting: TIdentifier or end of file",
            "Expecting: TIdentifier or '*'",
            "Expecting: TIdentifier, '_' or '*'",
            "Expecting: '=', ';' or '('",
            "Expecting: '->', ';' or '}}'",
            "Expecting: '->', ',', ';' or '}}'",
            "Expecting: ';' or '}}'",
            "Expecting: '}}'",
            "Expecting: '->'",
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
            "Expecting: ',', ';' or '}}'",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!', '(' or ')'",
            "Expecting: '{'",
            "Expecting: ',' or ')'",
            "Expecting: ']'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '}'",
            "Expecting: '('",
            "Expecting: TBool, TNumber, TIdentifier, '-', '!', ';' or '('",
            "Expecting: TIdentifier, '=', '*' or '{{'",
            "Expecting: 'while', 'if', 'else', 'return', TIdentifier or '}'",
            "Expecting: '=' or ';'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '{'",
            "Expecting: 'else'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 2, 3, 0, 4, 5, 0, 4, 0, 6, 5, 7, 5, 0, 4,
            4, 8, 9, 9, 10, 11, 12, 13, 4, 14, 6, 5, 6, 15, 15, 16,
            17, 18, 13, 19, 20, 21, 22, 23, 15, 15, 15, 24, 5, 11, 25, 25,
            10, 26, 22, 21, 24, 4, 13, 13, 13, 18, 18, 14, 17, 17, 17, 14,
            13, 27, 28, 6, 15, 28, 24, 15, 20, 20, 21, 22, 22, 15, 23, 23,
            23, 15, 29, 30, 14, 10, 13, 15, 15, 31, 31, 32, 33, 4, 30, 30,
            5, 30, 24, 24, 13, 13, 34, 19, 13, 35, 4, 30, 24, 24, 34, 19,
            13, 34, 36, 36, 34, 19, 30, 30, 30, 31, 31, 30, 34, 34, 30, 37,
            34, 30, 30, 13, 13, 34, 30, 36, 30, 24, 24, 34, 31, 31, 30, 34,
            30, 36, 36, 13, 13, 34, 30, 34, 37, 24, 24, 34, 36, 36, 36, 34,
            37, 36, 34,
        };
        #endregion
    }
}
