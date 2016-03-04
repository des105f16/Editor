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
        private int getIndex(TTypedef node)
        {
            return 4;
        }
        private int getIndex(TStruct node)
        {
            return 5;
        }
        private int getIndex(TWhile node)
        {
            return 6;
        }
        private int getIndex(TIf node)
        {
            return 7;
        }
        private int getIndex(TElse node)
        {
            return 8;
        }
        private int getIndex(TReturn node)
        {
            return 9;
        }
        private int getIndex(TIdentifier node)
        {
            return 10;
        }
        private int getIndex(TActsFor node)
        {
            return 11;
        }
        private int getIndex(TDeclassifyStart node)
        {
            return 12;
        }
        private int getIndex(TDeclassifyEnd node)
        {
            return 13;
        }
        private int getIndex(TRArrow node)
        {
            return 14;
        }
        private int getIndex(TLArrow node)
        {
            return 15;
        }
        private int getIndex(TCompare node)
        {
            return 16;
        }
        private int getIndex(TAssign node)
        {
            return 17;
        }
        private int getIndex(TUnderscore node)
        {
            return 18;
        }
        private int getIndex(TPlus node)
        {
            return 19;
        }
        private int getIndex(TMinus node)
        {
            return 20;
        }
        private int getIndex(TAsterisk node)
        {
            return 21;
        }
        private int getIndex(TSlash node)
        {
            return 22;
        }
        private int getIndex(TPercent node)
        {
            return 23;
        }
        private int getIndex(TBang node)
        {
            return 24;
        }
        private int getIndex(TAnd node)
        {
            return 25;
        }
        private int getIndex(TOr node)
        {
            return 26;
        }
        private int getIndex(TPeriod node)
        {
            return 27;
        }
        private int getIndex(TComma node)
        {
            return 28;
        }
        private int getIndex(TColon node)
        {
            return 29;
        }
        private int getIndex(TSemicolon node)
        {
            return 30;
        }
        private int getIndex(TLabelStart node)
        {
            return 31;
        }
        private int getIndex(TLabelEnd node)
        {
            return 32;
        }
        private int getIndex(TLPar node)
        {
            return 33;
        }
        private int getIndex(TRPar node)
        {
            return 34;
        }
        private int getIndex(TLSqu node)
        {
            return 35;
        }
        private int getIndex(TRSqu node)
        {
            return 36;
        }
        private int getIndex(TLCur node)
        {
            return 37;
        }
        private int getIndex(TRCur node)
        {
            return 38;
        }
        private int getIndex(TJoin node)
        {
            return 39;
        }
        
        private int getIndex(EOF node)
        {
            return 40;
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
                case 4:
                case 5:
                case 6:
                case 7:
                    {
                        List<PStatement> pstatementlist = isOn(4, index - 0) ? Pop<List<PStatement>>() : new List<PStatement>();
                        List<PStruct> pstructlist = isOn(2, index - 0) ? Pop<List<PStruct>>() : new List<PStruct>();
                        List<PInclude> pincludelist = isOn(1, index - 0) ? Pop<List<PInclude>>() : new List<PInclude>();
                        List<PInclude> pincludelist2 = new List<PInclude>();
                        pincludelist2.AddRange(pincludelist);
                        List<PStruct> pstructlist2 = new List<PStruct>();
                        pstructlist2.AddRange(pstructlist);
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        ARoot aroot = new ARoot(
                            pincludelist2,
                            pstructlist2,
                            pstatementlist2
                        );
                        Push(0, aroot);
                    }
                    break;
                case 8:
                case 9:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TRCur trcur = Pop<TRCur>();
                        List<PField> pfieldlist = isOn(1, index - 8) ? Pop<List<PField>>() : new List<PField>();
                        TLCur tlcur = Pop<TLCur>();
                        TIdentifier tidentifier2 = Pop<TIdentifier>();
                        TStruct tstruct = Pop<TStruct>();
                        TTypedef ttypedef = Pop<TTypedef>();
                        List<PField> pfieldlist2 = new List<PField>();
                        pfieldlist2.AddRange(pfieldlist);
                        AStruct astruct = new AStruct(
                            tidentifier2,
                            pfieldlist2,
                            tidentifier
                        );
                        Push(1, astruct);
                    }
                    break;
                case 10:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AField afield = new AField(
                            ptype,
                            tidentifier
                        );
                        Push(2, afield);
                    }
                    break;
                case 11:
                    {
                        TFile tfile = Pop<TFile>();
                        TInclude tinclude = Pop<TInclude>();
                        AInclude ainclude = new AInclude(
                            tfile
                        );
                        Push(3, ainclude);
                    }
                    break;
                case 12:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(4, adeclarationstatement);
                    }
                    break;
                case 13:
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
                        Push(4, adeclarationstatement);
                    }
                    break;
                case 14:
                case 15:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 14) ? Pop<List<PStatement>>() : new List<PStatement>();
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
                        Push(4, afunctiondeclarationstatement);
                    }
                    break;
                case 16:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        AFunctionParameter afunctionparameter = new AFunctionParameter(
                            ptype,
                            tidentifier
                        );
                        List<PFunctionParameter> pfunctionparameterlist = new List<PFunctionParameter>();
                        pfunctionparameterlist.Add(afunctionparameter);
                        Push(5, pfunctionparameterlist);
                    }
                    break;
                case 17:
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
                        Push(5, pfunctionparameterlist2);
                    }
                    break;
                case 18:
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
                        Push(6, aifstatement);
                    }
                    break;
                case 19:
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
                        Push(6, aifelsestatement);
                    }
                    break;
                case 20:
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
                        Push(6, awhilestatement);
                    }
                    break;
                case 21:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(6, pstatement);
                    }
                    break;
                case 22:
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
                        Push(7, aifelsestatement);
                    }
                    break;
                case 23:
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
                        Push(7, awhilestatement);
                    }
                    break;
                case 24:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        Push(7, pstatement);
                    }
                    break;
                case 25:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        PType ptype = Pop<PType>();
                        ADeclarationStatement adeclarationstatement = new ADeclarationStatement(
                            ptype,
                            tidentifier,
                            null
                        );
                        Push(8, adeclarationstatement);
                    }
                    break;
                case 26:
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
                        Push(8, adeclarationstatement);
                    }
                    break;
                case 27:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = Pop<PExpression>();
                        TAssign tassign = Pop<TAssign>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AAssignmentStatement aassignmentstatement = new AAssignmentStatement(
                            tidentifier,
                            pexpression
                        );
                        Push(8, aassignmentstatement);
                    }
                    break;
                case 28:
                case 29:
                    {
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PExpression pexpression = isOn(1, index - 28) ? Pop<PExpression>() : null;
                        TReturn treturn = Pop<TReturn>();
                        AReturnStatement areturnstatement = new AReturnStatement(
                            pexpression
                        );
                        Push(8, areturnstatement);
                    }
                    break;
                case 30:
                case 31:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 30) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TActsFor tactsfor = Pop<TActsFor>();
                        TIdentifier tidentifier2 = Pop<TIdentifier>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        AActsForStatement aactsforstatement = new AActsForStatement(
                            tidentifier2,
                            tidentifier,
                            pstatementlist2
                        );
                        Push(8, aactsforstatement);
                    }
                    break;
                case 32:
                case 33:
                    {
                        PLabel plabel = isOn(1, index - 32) ? Pop<PLabel>() : null;
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AType atype = new AType(
                            tidentifier,
                            plabel
                        );
                        Push(9, atype);
                    }
                    break;
                case 34:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PType ptype = Pop<PType>();
                        APointerType apointertype = new APointerType(
                            ptype,
                            tasterisk
                        );
                        Push(9, apointertype);
                    }
                    break;
                case 35:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(10, pstatementlist);
                    }
                    break;
                case 36:
                case 37:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 36) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(10, pstatementlist2);
                    }
                    break;
                case 38:
                    {
                        PStatement pstatement = Pop<PStatement>();
                        List<PStatement> pstatementlist = new List<PStatement>();
                        pstatementlist.Add(pstatement);
                        Push(11, pstatementlist);
                    }
                    break;
                case 39:
                case 40:
                    {
                        TRCur trcur = Pop<TRCur>();
                        List<PStatement> pstatementlist = isOn(1, index - 39) ? Pop<List<PStatement>>() : new List<PStatement>();
                        TLCur tlcur = Pop<TLCur>();
                        List<PStatement> pstatementlist2 = new List<PStatement>();
                        pstatementlist2.AddRange(pstatementlist);
                        Push(11, pstatementlist2);
                    }
                    break;
                case 41:
                    {
                        TLabelEnd tlabelend = Pop<TLabelEnd>();
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TLabelStart tlabelstart = Pop<TLabelStart>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.AddRange(ppolicylist);
                        ALabel alabel = new ALabel(
                            ppolicylist2
                        );
                        Push(12, alabel);
                    }
                    break;
                case 42:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AVariablePolicy avariablepolicy = new AVariablePolicy(
                            tidentifier
                        );
                        Push(13, avariablepolicy);
                    }
                    break;
                case 43:
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
                        Push(13, aprincipalpolicy);
                    }
                    break;
                case 44:
                    {
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist = new List<PPolicy>();
                        ppolicylist.Add(ppolicy);
                        Push(14, ppolicylist);
                    }
                    break;
                case 45:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TSemicolon tsemicolon = Pop<TSemicolon>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(14, ppolicylist2);
                    }
                    break;
                case 46:
                    {
                        List<PPolicy> ppolicylist = Pop<List<PPolicy>>();
                        TJoin tjoin = Pop<TJoin>();
                        PPolicy ppolicy = Pop<PPolicy>();
                        List<PPolicy> ppolicylist2 = new List<PPolicy>();
                        ppolicylist2.Add(ppolicy);
                        ppolicylist2.AddRange(ppolicylist);
                        Push(14, ppolicylist2);
                    }
                    break;
                case 47:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        APrincipal aprincipal = new APrincipal(
                            tidentifier
                        );
                        Push(15, aprincipal);
                    }
                    break;
                case 48:
                    {
                        TUnderscore tunderscore = Pop<TUnderscore>();
                        ALowerPrincipal alowerprincipal = new ALowerPrincipal(
                            tunderscore
                        );
                        Push(15, alowerprincipal);
                    }
                    break;
                case 49:
                    {
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        AUpperPrincipal aupperprincipal = new AUpperPrincipal(
                            tasterisk
                        );
                        Push(15, aupperprincipal);
                    }
                    break;
                case 50:
                    {
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist = new List<PPrincipal>();
                        pprincipallist.Add(pprincipal);
                        Push(16, pprincipallist);
                    }
                    break;
                case 51:
                    {
                        List<PPrincipal> pprincipallist = Pop<List<PPrincipal>>();
                        TComma tcomma = Pop<TComma>();
                        PPrincipal pprincipal = Pop<PPrincipal>();
                        List<PPrincipal> pprincipallist2 = new List<PPrincipal>();
                        pprincipallist2.Add(pprincipal);
                        pprincipallist2.AddRange(pprincipallist);
                        Push(16, pprincipallist2);
                    }
                    break;
                case 52:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(17, pexpression);
                    }
                    break;
                case 53:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAnd tand = Pop<TAnd>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AAndExpression aandexpression = new AAndExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(18, aandexpression);
                    }
                    break;
                case 54:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TOr tor = Pop<TOr>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AOrExpression aorexpression = new AOrExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(18, aorexpression);
                    }
                    break;
                case 55:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(18, pexpression);
                    }
                    break;
                case 56:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TCompare tcompare = Pop<TCompare>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AComparisonExpression acomparisonexpression = new AComparisonExpression(
                            pexpression2,
                            tcompare,
                            pexpression
                        );
                        Push(19, acomparisonexpression);
                    }
                    break;
                case 57:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TBang tbang = Pop<TBang>();
                        ANotExpression anotexpression = new ANotExpression(
                            pexpression
                        );
                        Push(19, anotexpression);
                    }
                    break;
                case 58:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(19, pexpression);
                    }
                    break;
                case 59:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPlus tplus = Pop<TPlus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        APlusExpression aplusexpression = new APlusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(20, aplusexpression);
                    }
                    break;
                case 60:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMinusExpression aminusexpression = new AMinusExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(20, aminusexpression);
                    }
                    break;
                case 61:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TMinus tminus = Pop<TMinus>();
                        ANegateExpression anegateexpression = new ANegateExpression(
                            pexpression
                        );
                        Push(20, anegateexpression);
                    }
                    break;
                case 62:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(20, pexpression);
                    }
                    break;
                case 63:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TAsterisk tasterisk = Pop<TAsterisk>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AMultiplyExpression amultiplyexpression = new AMultiplyExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, amultiplyexpression);
                    }
                    break;
                case 64:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TSlash tslash = Pop<TSlash>();
                        PExpression pexpression2 = Pop<PExpression>();
                        ADivideExpression adivideexpression = new ADivideExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, adivideexpression);
                    }
                    break;
                case 65:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        TPercent tpercent = Pop<TPercent>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AModuloExpression amoduloexpression = new AModuloExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(21, amoduloexpression);
                    }
                    break;
                case 66:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(21, pexpression);
                    }
                    break;
                case 67:
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
                        Push(22, aelementexpression);
                    }
                    break;
                case 68:
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
                        Push(22, aelementexpression);
                    }
                    break;
                case 69:
                    {
                        TRSqu trsqu = Pop<TRSqu>();
                        PExpression pexpression = Pop<PExpression>();
                        TLSqu tlsqu = Pop<TLSqu>();
                        PExpression pexpression2 = Pop<PExpression>();
                        AIndexExpression aindexexpression = new AIndexExpression(
                            pexpression2,
                            pexpression
                        );
                        Push(22, aindexexpression);
                    }
                    break;
                case 70:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(22, pexpression);
                    }
                    break;
                case 71:
                    {
                        TRPar trpar = Pop<TRPar>();
                        PExpression pexpression = Pop<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        AParenthesisExpression aparenthesisexpression = new AParenthesisExpression(
                            pexpression
                        );
                        Push(23, aparenthesisexpression);
                    }
                    break;
                case 72:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        Push(23, pexpression);
                    }
                    break;
                case 73:
                    {
                        TNumber tnumber = Pop<TNumber>();
                        ANumberExpression anumberexpression = new ANumberExpression(
                            tnumber
                        );
                        Push(23, anumberexpression);
                    }
                    break;
                case 74:
                    {
                        TBool tbool = Pop<TBool>();
                        ABooleanExpression abooleanexpression = new ABooleanExpression(
                            tbool
                        );
                        Push(23, abooleanexpression);
                    }
                    break;
                case 75:
                    {
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        AIdentifierExpression aidentifierexpression = new AIdentifierExpression(
                            tidentifier
                        );
                        Push(23, aidentifierexpression);
                    }
                    break;
                case 76:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            tidentifier,
                            null
                        );
                        Push(23, adeclassifyexpression);
                    }
                    break;
                case 77:
                    {
                        TDeclassifyEnd tdeclassifyend = Pop<TDeclassifyEnd>();
                        PLabel plabel = Pop<PLabel>();
                        TComma tcomma = Pop<TComma>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        TDeclassifyStart tdeclassifystart = Pop<TDeclassifyStart>();
                        ADeclassifyExpression adeclassifyexpression = new ADeclassifyExpression(
                            tidentifier,
                            plabel
                        );
                        Push(23, adeclassifyexpression);
                    }
                    break;
                case 78:
                case 79:
                    {
                        TRPar trpar = Pop<TRPar>();
                        List<PExpression> pexpressionlist = isOn(1, index - 78) ? Pop<List<PExpression>>() : new List<PExpression>();
                        TLPar tlpar = Pop<TLPar>();
                        TIdentifier tidentifier = Pop<TIdentifier>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.AddRange(pexpressionlist);
                        AFunctionCallExpression afunctioncallexpression = new AFunctionCallExpression(
                            tidentifier,
                            pexpressionlist2
                        );
                        Push(24, afunctioncallexpression);
                    }
                    break;
                case 80:
                    {
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist = new List<PExpression>();
                        pexpressionlist.Add(pexpression);
                        Push(25, pexpressionlist);
                    }
                    break;
                case 81:
                    {
                        List<PExpression> pexpressionlist = Pop<List<PExpression>>();
                        TComma tcomma = Pop<TComma>();
                        PExpression pexpression = Pop<PExpression>();
                        List<PExpression> pexpressionlist2 = new List<PExpression>();
                        pexpressionlist2.Add(pexpression);
                        pexpressionlist2.AddRange(pexpressionlist);
                        Push(25, pexpressionlist2);
                    }
                    break;
                case 82:
                    Push(26, new List<PInclude>() { Pop<PInclude>() });
                    break;
                case 83:
                    {
                        PInclude item = Pop<PInclude>();
                        List<PInclude> list = Pop<List<PInclude>>();
                        list.Add(item);
                        Push(26, list);
                    }
                    break;
                case 84:
                    Push(27, new List<PStruct>() { Pop<PStruct>() });
                    break;
                case 85:
                    {
                        PStruct item = Pop<PStruct>();
                        List<PStruct> list = Pop<List<PStruct>>();
                        list.Add(item);
                        Push(27, list);
                    }
                    break;
                case 86:
                    Push(28, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 87:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(28, list);
                    }
                    break;
                case 88:
                    Push(29, new List<PField>() { Pop<PField>() });
                    break;
                case 89:
                    {
                        PField item = Pop<PField>();
                        List<PField> list = Pop<List<PField>>();
                        list.Add(item);
                        Push(29, list);
                    }
                    break;
                case 90:
                    Push(30, new List<PStatement>() { Pop<PStatement>() });
                    break;
                case 91:
                    {
                        PStatement item = Pop<PStatement>();
                        List<PStatement> list = Pop<List<PStatement>>();
                        list.Add(item);
                        Push(30, list);
                    }
                    break;
            }
        }
        
        #region actionTable
        private static int[][][] actionTable = {
            new int[][] {
                new int[] {-1, 1, 0},
                new int[] {0, 0, 1},
                new int[] {4, 0, 2},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 3, 1},
                new int[] {1, 0, 12},
            },
            new int[][] {
                new int[] {-1, 3, 2},
                new int[] {5, 0, 13},
            },
            new int[][] {
                new int[] {-1, 1, 32},
                new int[] {31, 0, 14},
            },
            new int[][] {
                new int[] {-1, 3, 4},
                new int[] {40, 2, -1},
            },
            new int[][] {
                new int[] {-1, 1, 84},
            },
            new int[][] {
                new int[] {-1, 1, 82},
            },
            new int[][] {
                new int[] {-1, 1, 86},
            },
            new int[][] {
                new int[] {-1, 3, 8},
                new int[] {10, 0, 16},
                new int[] {21, 0, 17},
            },
            new int[][] {
                new int[] {-1, 1, 1},
                new int[] {0, 0, 1},
                new int[] {4, 0, 2},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 2},
                new int[] {4, 0, 2},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 4},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 11},
            },
            new int[][] {
                new int[] {-1, 3, 13},
                new int[] {10, 0, 24},
            },
            new int[][] {
                new int[] {-1, 3, 14},
                new int[] {10, 0, 25},
                new int[] {18, 0, 26},
                new int[] {21, 0, 27},
            },
            new int[][] {
                new int[] {-1, 1, 33},
            },
            new int[][] {
                new int[] {-1, 3, 16},
                new int[] {17, 0, 31},
                new int[] {30, 0, 32},
                new int[] {33, 0, 33},
            },
            new int[][] {
                new int[] {-1, 1, 34},
            },
            new int[][] {
                new int[] {-1, 1, 83},
            },
            new int[][] {
                new int[] {-1, 1, 3},
                new int[] {4, 0, 2},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 5},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 85},
            },
            new int[][] {
                new int[] {-1, 1, 6},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 87},
            },
            new int[][] {
                new int[] {-1, 3, 24},
                new int[] {37, 0, 35},
            },
            new int[][] {
                new int[] {-1, 1, 42},
                new int[] {14, 1, 47},
            },
            new int[][] {
                new int[] {-1, 1, 48},
            },
            new int[][] {
                new int[] {-1, 1, 49},
            },
            new int[][] {
                new int[] {-1, 1, 44},
                new int[] {30, 0, 36},
                new int[] {39, 0, 37},
            },
            new int[][] {
                new int[] {-1, 3, 29},
                new int[] {32, 0, 38},
            },
            new int[][] {
                new int[] {-1, 3, 30},
                new int[] {14, 0, 39},
            },
            new int[][] {
                new int[] {-1, 3, 31},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 12},
            },
            new int[][] {
                new int[] {-1, 3, 33},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 7},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 3, 35},
                new int[] {10, 0, 3},
                new int[] {38, 0, 57},
            },
            new int[][] {
                new int[] {-1, 3, 36},
                new int[] {10, 0, 25},
                new int[] {18, 0, 26},
                new int[] {21, 0, 27},
            },
            new int[][] {
                new int[] {-1, 3, 37},
                new int[] {10, 0, 25},
                new int[] {18, 0, 26},
                new int[] {21, 0, 27},
            },
            new int[][] {
                new int[] {-1, 1, 41},
            },
            new int[][] {
                new int[] {-1, 3, 39},
                new int[] {10, 0, 63},
                new int[] {18, 0, 26},
                new int[] {21, 0, 27},
            },
            new int[][] {
                new int[] {-1, 1, 74},
            },
            new int[][] {
                new int[] {-1, 1, 73},
            },
            new int[][] {
                new int[] {-1, 1, 75},
                new int[] {33, 0, 66},
            },
            new int[][] {
                new int[] {-1, 3, 43},
                new int[] {10, 0, 67},
            },
            new int[][] {
                new int[] {-1, 3, 44},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 45},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 46},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 47},
                new int[] {30, 0, 71},
            },
            new int[][] {
                new int[] {-1, 1, 52},
            },
            new int[][] {
                new int[] {-1, 1, 55},
                new int[] {25, 0, 72},
                new int[] {26, 0, 73},
            },
            new int[][] {
                new int[] {-1, 1, 58},
                new int[] {16, 0, 74},
            },
            new int[][] {
                new int[] {-1, 1, 62},
                new int[] {19, 0, 75},
                new int[] {20, 0, 76},
            },
            new int[][] {
                new int[] {-1, 1, 66},
                new int[] {14, 0, 77},
                new int[] {21, 0, 78},
                new int[] {22, 0, 79},
                new int[] {23, 0, 80},
                new int[] {27, 0, 81},
                new int[] {35, 0, 82},
            },
            new int[][] {
                new int[] {-1, 1, 70},
            },
            new int[][] {
                new int[] {-1, 1, 72},
            },
            new int[][] {
                new int[] {-1, 3, 55},
                new int[] {34, 0, 83},
            },
            new int[][] {
                new int[] {-1, 3, 56},
                new int[] {10, 0, 84},
                new int[] {21, 0, 17},
            },
            new int[][] {
                new int[] {-1, 3, 57},
                new int[] {10, 0, 85},
            },
            new int[][] {
                new int[] {-1, 1, 88},
            },
            new int[][] {
                new int[] {-1, 3, 59},
                new int[] {10, 0, 86},
                new int[] {21, 0, 17},
            },
            new int[][] {
                new int[] {-1, 3, 60},
                new int[] {10, 0, 3},
                new int[] {38, 0, 87},
            },
            new int[][] {
                new int[] {-1, 1, 45},
            },
            new int[][] {
                new int[] {-1, 1, 46},
            },
            new int[][] {
                new int[] {-1, 1, 47},
            },
            new int[][] {
                new int[] {-1, 1, 50},
                new int[] {28, 0, 89},
            },
            new int[][] {
                new int[] {-1, 1, 43},
            },
            new int[][] {
                new int[] {-1, 3, 66},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
                new int[] {34, 0, 90},
            },
            new int[][] {
                new int[] {-1, 3, 67},
                new int[] {13, 0, 93},
                new int[] {28, 0, 94},
            },
            new int[][] {
                new int[] {-1, 1, 61},
            },
            new int[][] {
                new int[] {-1, 1, 57},
            },
            new int[][] {
                new int[] {-1, 3, 70},
                new int[] {34, 0, 95},
            },
            new int[][] {
                new int[] {-1, 1, 13},
            },
            new int[][] {
                new int[] {-1, 3, 72},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 73},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 74},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 75},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 76},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 77},
                new int[] {10, 0, 101},
            },
            new int[][] {
                new int[] {-1, 3, 78},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 79},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 80},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 81},
                new int[] {10, 0, 105},
            },
            new int[][] {
                new int[] {-1, 3, 82},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 83},
                new int[] {37, 0, 107},
            },
            new int[][] {
                new int[] {-1, 1, 16},
                new int[] {28, 0, 108},
            },
            new int[][] {
                new int[] {-1, 3, 85},
                new int[] {30, 0, 109},
            },
            new int[][] {
                new int[] {-1, 3, 86},
                new int[] {30, 0, 110},
            },
            new int[][] {
                new int[] {-1, 3, 87},
                new int[] {10, 0, 111},
            },
            new int[][] {
                new int[] {-1, 1, 89},
            },
            new int[][] {
                new int[] {-1, 3, 89},
                new int[] {10, 0, 63},
                new int[] {18, 0, 26},
                new int[] {21, 0, 27},
            },
            new int[][] {
                new int[] {-1, 1, 78},
            },
            new int[][] {
                new int[] {-1, 1, 80},
                new int[] {28, 0, 113},
            },
            new int[][] {
                new int[] {-1, 3, 92},
                new int[] {34, 0, 114},
            },
            new int[][] {
                new int[] {-1, 1, 76},
            },
            new int[][] {
                new int[] {-1, 3, 94},
                new int[] {31, 0, 14},
            },
            new int[][] {
                new int[] {-1, 1, 71},
            },
            new int[][] {
                new int[] {-1, 1, 53},
            },
            new int[][] {
                new int[] {-1, 1, 54},
            },
            new int[][] {
                new int[] {-1, 1, 56},
            },
            new int[][] {
                new int[] {-1, 1, 59},
            },
            new int[][] {
                new int[] {-1, 1, 60},
            },
            new int[][] {
                new int[] {-1, 1, 68},
            },
            new int[][] {
                new int[] {-1, 1, 63},
            },
            new int[][] {
                new int[] {-1, 1, 64},
            },
            new int[][] {
                new int[] {-1, 1, 65},
            },
            new int[][] {
                new int[] {-1, 1, 67},
            },
            new int[][] {
                new int[] {-1, 3, 106},
                new int[] {36, 0, 116},
            },
            new int[][] {
                new int[] {-1, 3, 107},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 121},
            },
            new int[][] {
                new int[] {-1, 3, 108},
                new int[] {10, 0, 3},
            },
            new int[][] {
                new int[] {-1, 1, 8},
            },
            new int[][] {
                new int[] {-1, 1, 10},
            },
            new int[][] {
                new int[] {-1, 3, 111},
                new int[] {30, 0, 127},
            },
            new int[][] {
                new int[] {-1, 1, 51},
            },
            new int[][] {
                new int[] {-1, 3, 113},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 79},
            },
            new int[][] {
                new int[] {-1, 3, 115},
                new int[] {13, 0, 129},
            },
            new int[][] {
                new int[] {-1, 1, 69},
            },
            new int[][] {
                new int[] {-1, 3, 117},
                new int[] {33, 0, 130},
            },
            new int[][] {
                new int[] {-1, 3, 118},
                new int[] {33, 0, 131},
            },
            new int[][] {
                new int[] {-1, 3, 119},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {30, 0, 132},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 32},
                new int[] {11, 0, 134},
                new int[] {17, 0, 135},
                new int[] {31, 0, 14},
            },
            new int[][] {
                new int[] {-1, 1, 14},
            },
            new int[][] {
                new int[] {-1, 1, 90},
            },
            new int[][] {
                new int[] {-1, 1, 21},
            },
            new int[][] {
                new int[] {-1, 3, 124},
                new int[] {10, 0, 136},
                new int[] {21, 0, 17},
            },
            new int[][] {
                new int[] {-1, 3, 125},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 137},
            },
            new int[][] {
                new int[] {-1, 1, 17},
            },
            new int[][] {
                new int[] {-1, 1, 9},
            },
            new int[][] {
                new int[] {-1, 1, 81},
            },
            new int[][] {
                new int[] {-1, 1, 77},
            },
            new int[][] {
                new int[] {-1, 3, 130},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 131},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 28},
            },
            new int[][] {
                new int[] {-1, 3, 133},
                new int[] {30, 0, 141},
            },
            new int[][] {
                new int[] {-1, 3, 134},
                new int[] {10, 0, 142},
            },
            new int[][] {
                new int[] {-1, 3, 135},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 136},
                new int[] {17, 0, 144},
                new int[] {30, 0, 145},
            },
            new int[][] {
                new int[] {-1, 1, 15},
            },
            new int[][] {
                new int[] {-1, 1, 91},
            },
            new int[][] {
                new int[] {-1, 3, 139},
                new int[] {34, 0, 146},
            },
            new int[][] {
                new int[] {-1, 3, 140},
                new int[] {34, 0, 147},
            },
            new int[][] {
                new int[] {-1, 1, 29},
            },
            new int[][] {
                new int[] {-1, 3, 142},
                new int[] {37, 0, 148},
            },
            new int[][] {
                new int[] {-1, 3, 143},
                new int[] {30, 0, 149},
            },
            new int[][] {
                new int[] {-1, 3, 144},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 25},
            },
            new int[][] {
                new int[] {-1, 3, 146},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 151},
            },
            new int[][] {
                new int[] {-1, 3, 147},
                new int[] {6, 0, 154},
                new int[] {7, 0, 155},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 156},
            },
            new int[][] {
                new int[] {-1, 3, 148},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 161},
            },
            new int[][] {
                new int[] {-1, 1, 27},
            },
            new int[][] {
                new int[] {-1, 3, 150},
                new int[] {30, 0, 163},
            },
            new int[][] {
                new int[] {-1, 3, 151},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 164},
            },
            new int[][] {
                new int[] {-1, 1, 35},
            },
            new int[][] {
                new int[] {-1, 1, 20},
            },
            new int[][] {
                new int[] {-1, 3, 154},
                new int[] {33, 0, 166},
            },
            new int[][] {
                new int[] {-1, 3, 155},
                new int[] {33, 0, 167},
            },
            new int[][] {
                new int[] {-1, 3, 156},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 168},
            },
            new int[][] {
                new int[] {-1, 1, 38},
            },
            new int[][] {
                new int[] {-1, 1, 21},
                new int[] {8, 1, 24},
            },
            new int[][] {
                new int[] {-1, 1, 18},
            },
            new int[][] {
                new int[] {-1, 3, 160},
                new int[] {8, 0, 170},
            },
            new int[][] {
                new int[] {-1, 1, 30},
            },
            new int[][] {
                new int[] {-1, 3, 162},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 171},
            },
            new int[][] {
                new int[] {-1, 1, 26},
            },
            new int[][] {
                new int[] {-1, 1, 36},
            },
            new int[][] {
                new int[] {-1, 3, 165},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 172},
            },
            new int[][] {
                new int[] {-1, 3, 166},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 167},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 36},
                new int[] {8, 1, 39},
            },
            new int[][] {
                new int[] {-1, 3, 169},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 175},
            },
            new int[][] {
                new int[] {-1, 3, 170},
                new int[] {6, 0, 176},
                new int[] {7, 0, 177},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 178},
            },
            new int[][] {
                new int[] {-1, 1, 31},
            },
            new int[][] {
                new int[] {-1, 1, 37},
            },
            new int[][] {
                new int[] {-1, 3, 173},
                new int[] {34, 0, 181},
            },
            new int[][] {
                new int[] {-1, 3, 174},
                new int[] {34, 0, 182},
            },
            new int[][] {
                new int[] {-1, 1, 37},
                new int[] {8, 1, 40},
            },
            new int[][] {
                new int[] {-1, 3, 176},
                new int[] {33, 0, 183},
            },
            new int[][] {
                new int[] {-1, 3, 177},
                new int[] {33, 0, 184},
            },
            new int[][] {
                new int[] {-1, 3, 178},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 185},
            },
            new int[][] {
                new int[] {-1, 1, 24},
            },
            new int[][] {
                new int[] {-1, 1, 19},
            },
            new int[][] {
                new int[] {-1, 3, 181},
                new int[] {6, 0, 154},
                new int[] {7, 0, 155},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 156},
            },
            new int[][] {
                new int[] {-1, 3, 182},
                new int[] {6, 0, 154},
                new int[] {7, 0, 155},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 156},
            },
            new int[][] {
                new int[] {-1, 3, 183},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 3, 184},
                new int[] {2, 0, 40},
                new int[] {3, 0, 41},
                new int[] {10, 0, 42},
                new int[] {12, 0, 43},
                new int[] {20, 0, 44},
                new int[] {24, 0, 45},
                new int[] {33, 0, 46},
            },
            new int[][] {
                new int[] {-1, 1, 39},
            },
            new int[][] {
                new int[] {-1, 3, 186},
                new int[] {6, 0, 117},
                new int[] {7, 0, 118},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {38, 0, 191},
            },
            new int[][] {
                new int[] {-1, 1, 23},
            },
            new int[][] {
                new int[] {-1, 3, 188},
                new int[] {8, 0, 192},
            },
            new int[][] {
                new int[] {-1, 3, 189},
                new int[] {34, 0, 193},
            },
            new int[][] {
                new int[] {-1, 3, 190},
                new int[] {34, 0, 194},
            },
            new int[][] {
                new int[] {-1, 1, 40},
            },
            new int[][] {
                new int[] {-1, 3, 192},
                new int[] {6, 0, 176},
                new int[] {7, 0, 177},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 178},
            },
            new int[][] {
                new int[] {-1, 3, 193},
                new int[] {6, 0, 176},
                new int[] {7, 0, 177},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 178},
            },
            new int[][] {
                new int[] {-1, 3, 194},
                new int[] {6, 0, 176},
                new int[] {7, 0, 177},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 178},
            },
            new int[][] {
                new int[] {-1, 1, 19},
                new int[] {8, 1, 22},
            },
            new int[][] {
                new int[] {-1, 3, 196},
                new int[] {8, 0, 197},
            },
            new int[][] {
                new int[] {-1, 3, 197},
                new int[] {6, 0, 176},
                new int[] {7, 0, 177},
                new int[] {9, 0, 119},
                new int[] {10, 0, 120},
                new int[] {37, 0, 178},
            },
            new int[][] {
                new int[] {-1, 1, 22},
            },
        };
        #endregion
        #region gotoTable
        private static int[][][] gotoTable = {
            new int[][] {
                new int[] {-1, 4},
            },
            new int[][] {
                new int[] {-1, 5},
                new int[] {10, 21},
                new int[] {19, 21},
            },
            new int[][] {
                new int[] {-1, 58},
                new int[] {60, 88},
            },
            new int[][] {
                new int[] {-1, 6},
                new int[] {9, 18},
            },
            new int[][] {
                new int[] {-1, 7},
                new int[] {11, 23},
                new int[] {20, 23},
                new int[] {22, 23},
                new int[] {34, 23},
            },
            new int[][] {
                new int[] {-1, 55},
                new int[] {108, 126},
            },
            new int[][] {
                new int[] {-1, 122},
                new int[] {125, 138},
                new int[] {146, 152},
                new int[] {147, 152},
                new int[] {162, 138},
                new int[] {165, 138},
                new int[] {169, 138},
                new int[] {181, 152},
                new int[] {182, 152},
                new int[] {186, 138},
            },
            new int[][] {
                new int[] {-1, 157},
            },
            new int[][] {
                new int[] {-1, 123},
                new int[] {147, 158},
                new int[] {170, 179},
                new int[] {181, 158},
                new int[] {182, 158},
                new int[] {192, 179},
                new int[] {193, 179},
                new int[] {194, 179},
                new int[] {197, 179},
            },
            new int[][] {
                new int[] {-1, 124},
                new int[] {0, 8},
                new int[] {9, 8},
                new int[] {10, 8},
                new int[] {11, 8},
                new int[] {19, 8},
                new int[] {20, 8},
                new int[] {22, 8},
                new int[] {33, 56},
                new int[] {34, 8},
                new int[] {35, 59},
                new int[] {60, 59},
                new int[] {108, 56},
            },
            new int[][] {
                new int[] {-1, 153},
                new int[] {147, 159},
                new int[] {182, 159},
            },
            new int[][] {
                new int[] {-1, 187},
                new int[] {147, 160},
                new int[] {170, 180},
                new int[] {182, 188},
                new int[] {192, 195},
                new int[] {194, 196},
                new int[] {197, 198},
            },
            new int[][] {
                new int[] {-1, 15},
                new int[] {94, 115},
            },
            new int[][] {
                new int[] {-1, 28},
            },
            new int[][] {
                new int[] {-1, 29},
                new int[] {36, 61},
                new int[] {37, 62},
            },
            new int[][] {
                new int[] {-1, 30},
                new int[] {39, 64},
                new int[] {89, 64},
            },
            new int[][] {
                new int[] {-1, 65},
                new int[] {89, 112},
            },
            new int[][] {
                new int[] {-1, 91},
                new int[] {31, 47},
                new int[] {46, 70},
                new int[] {82, 106},
                new int[] {119, 133},
                new int[] {130, 139},
                new int[] {131, 140},
                new int[] {135, 143},
                new int[] {144, 150},
                new int[] {166, 173},
                new int[] {167, 174},
                new int[] {183, 189},
                new int[] {184, 190},
            },
            new int[][] {
                new int[] {-1, 48},
                new int[] {72, 96},
                new int[] {73, 97},
            },
            new int[][] {
                new int[] {-1, 49},
                new int[] {74, 98},
            },
            new int[][] {
                new int[] {-1, 50},
                new int[] {45, 69},
                new int[] {75, 99},
                new int[] {76, 100},
            },
            new int[][] {
                new int[] {-1, 51},
                new int[] {44, 68},
                new int[] {78, 102},
                new int[] {79, 103},
                new int[] {80, 104},
            },
            new int[][] {
                new int[] {-1, 52},
            },
            new int[][] {
                new int[] {-1, 53},
            },
            new int[][] {
                new int[] {-1, 54},
            },
            new int[][] {
                new int[] {-1, 92},
                new int[] {113, 128},
            },
            new int[][] {
                new int[] {-1, 9},
            },
            new int[][] {
                new int[] {-1, 10},
                new int[] {9, 19},
            },
            new int[][] {
                new int[] {-1, 11},
                new int[] {9, 20},
                new int[] {10, 22},
                new int[] {19, 34},
            },
            new int[][] {
                new int[] {-1, 60},
            },
            new int[][] {
                new int[] {-1, 125},
                new int[] {148, 162},
                new int[] {151, 165},
                new int[] {156, 169},
                new int[] {178, 186},
            },
        };
        #endregion
        #region errorMessages
        private static string[] errorMessages = {
            "Expecting: '#include', 'typedef', TIdentifier or end of file",
            "Expecting: TFile",
            "Expecting: 'struct'",
            "Expecting: TIdentifier, '*' or '{{'",
            "Expecting: end of file",
            "Expecting: 'typedef', TIdentifier or end of file",
            "Expecting: TIdentifier or end of file",
            "Expecting: TIdentifier or '*'",
            "Expecting: TIdentifier",
            "Expecting: TIdentifier, '_' or '*'",
            "Expecting: '=', ';' or '('",
            "Expecting: '{'",
            "Expecting: '->', ';', '}}' or '⊔'",
            "Expecting: '->', ',', ';', '}}' or '⊔'",
            "Expecting: ';', '}}' or '⊔'",
            "Expecting: '}}'",
            "Expecting: '->'",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!' or '('",
            "Expecting: TIdentifier or '}'",
            "Expecting: TIdentifier, '|>' or '*'",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', ')', '[' or ']'",
            "Expecting: '->', TCompare, '+', '-', '*', '/', '%', '&&', '||', '.', ',', ';', '(', ')', '[' or ']'",
            "Expecting: TBool, TNumber, TIdentifier, '<|' or '('",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-' or '('",
            "Expecting: ';'",
            "Expecting: ',', ';', ')' or ']'",
            "Expecting: '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '&&', '||', ',', ';', ')' or ']'",
            "Expecting: TCompare, '+', '-', '&&', '||', ',', ';', ')' or ']'",
            "Expecting: ')'",
            "Expecting: ',', ';', '}}' or '⊔'",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!', '(' or ')'",
            "Expecting: '|>' or ','",
            "Expecting: ',' or ')'",
            "Expecting: '{{'",
            "Expecting: ']'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '}'",
            "Expecting: '|>'",
            "Expecting: '('",
            "Expecting: TBool, TNumber, TIdentifier, '<|', '-', '!', ';' or '('",
            "Expecting: TIdentifier, TActsFor, '=', '*' or '{{'",
            "Expecting: 'while', 'if', 'else', 'return', TIdentifier or '}'",
            "Expecting: '=' or ';'",
            "Expecting: 'while', 'if', 'return', TIdentifier or '{'",
            "Expecting: 'else'",
        };
        #endregion
        #region errors
        private static int[] errors = {
            0, 1, 2, 3, 4, 5, 0, 6, 7, 0, 5, 6, 0, 8, 9, 7,
            10, 7, 0, 5, 6, 5, 6, 6, 11, 12, 13, 13, 14, 15, 16, 17,
            6, 8, 6, 18, 9, 9, 19, 9, 20, 20, 21, 8, 22, 23, 17, 24,
            25, 26, 27, 28, 20, 20, 20, 29, 7, 8, 18, 7, 18, 15, 15, 30,
            30, 14, 31, 32, 27, 26, 29, 6, 17, 17, 17, 23, 23, 8, 22, 22,
            22, 8, 17, 11, 33, 24, 24, 8, 18, 9, 20, 33, 29, 20, 34, 20,
            25, 25, 26, 27, 27, 20, 28, 28, 28, 20, 35, 36, 8, 5, 18, 24,
            14, 17, 20, 37, 20, 38, 38, 39, 40, 6, 36, 36, 7, 36, 29, 5,
            29, 20, 17, 17, 41, 24, 8, 17, 42, 6, 36, 29, 29, 41, 11, 24,
            17, 41, 43, 43, 36, 41, 24, 36, 36, 36, 38, 38, 36, 41, 41, 36,
            44, 41, 36, 41, 36, 36, 17, 17, 41, 36, 43, 41, 36, 29, 29, 41,
            38, 38, 36, 41, 36, 43, 43, 17, 17, 41, 36, 41, 44, 29, 29, 41,
            43, 43, 43, 41, 44, 43, 41,
        };
        #endregion
    }
}
